Public Class RH_Capacitaciones
    Dim codigoDetalleCapacitacion As New ArrayList
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Public Sub limpiar()
        Try
            txtCodigo.ResetText()
            txtNombre.ResetText()
            txtProveedor.ResetText()
            dtpFecha.ResetText()
            txtCantidadHoras.ResetText()
            dgvBeneficiarios.Rows.Clear()

            btnGuardar.Enabled = True
            btnModificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub M_Capacitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dgvBeneficiarios)
        'agrgear el boton para eliminar un empleado de la capacitacion
        If dgvBeneficiarios.Columns.Contains("btnEliminar") = False Then
            Dim btn As New DataGridViewButtonColumn()
            dgvBeneficiarios.Columns.Add(btn)
            btn.HeaderText = "Eliminar"
            btn.Text = "Eliminar"
            btn.Name = "btnEliminar"
            btn.UseColumnTextForButtonValue = True
        End If
    End Sub
    Private Sub dgvBeneficiarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBeneficiarios.CellClick
        Try
            Dim n As String
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = 2 Then
                    RH_ListadoEmpleados.lblform.Text = "M_Capacitaciones"
                    RH_ListadoEmpleados.lblfila.Text = e.RowIndex
                    RH_ListadoEmpleados.Show()
                ElseIf e.ColumnIndex = 5 And Me.dgvBeneficiarios.Rows(e.RowIndex).Cells(0).Value() = "" Then
                    n = MsgBox("¿Desea eliminar el empleado de la capacitación?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        dgvBeneficiarios.Rows.Remove(dgvBeneficiarios.Rows(e.RowIndex.ToString))
                    End If
                ElseIf e.ColumnIndex = 5 And Me.dgvBeneficiarios.Rows(e.RowIndex).Cells(0).Value() <> "" Then
                    n = MsgBox("¿Desea eliminar el empleado de la capacitación?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        codigoDetalleCapacitacion.Add(Me.dgvBeneficiarios.Rows(e.RowIndex).Cells(0).Value())
                        dgvBeneficiarios.Rows.Remove(dgvBeneficiarios.Rows(e.RowIndex.ToString))
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("dtResultados  " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub sinDobleEspacio(ByRef cadena As String)
        Dim texto As String = ""
        Dim testArray() As String = Split(cadena)
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                texto += testArray(i) + " "
            End If
        Next
        cadena = RTrim(texto)
    End Sub
    Public Function validarBeneficiarios(ByVal codigoEmpleado As Integer) As Boolean
        For index As Integer = 0 To dgvBeneficiarios.Rows.Count - 2
            If (dgvBeneficiarios.Rows(index).Cells(1).Value() = codigoEmpleado) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            sinDobleEspacio(txtNombre.Text)
            sinDobleEspacio(txtProveedor.Text)
            If (Trim(txtNombre.Text) <> "" And Trim(txtCantidadHoras.Text) <> "" And dgvBeneficiarios.Rows.Count > 1 And Trim(txtProveedor.Text) <> "") Then

                Dim objCap As New ClsCapacitaciones

                With objCap
                    .fecha_ = dtpFecha.Value
                    .Nombre_ = txtNombre.Text
                    .cantidadHoras_ = txtCantidadHoras.Text
                    .proveedor_ = txtProveedor.Text
                End With

                If objCap.RegistrarNuevaCapacitacion() = 1 Then
                    'deshabilitar()
                    btnGuardar.Enabled = False
                    Dim dt As New DataTable
                    dt = objCap.CapturarCapacitacion()
                    Dim row As DataRow = dt.Rows(0)

                    txtCodigo.Text = CStr(row("codigo"))
                    Dim objDetCap As New ClsDetalleCapacitaciones
                    For index As Integer = 0 To dgvBeneficiarios.Rows.Count - 2
                        With objDetCap
                            .codigoCapacitacion_ = txtCodigo.Text
                            .codigoEmpleado_ = dgvBeneficiarios.Rows(index).Cells(1).Value()
                        End With
                        If objDetCap.RegistrarNuevoDetalleCapacitacion() = 0 Then
                            MsgBox("Error al querer insertar el detalle de capacitación.", MsgBoxStyle.Critical)
                        End If
                    Next
                    MsgBox("Registrada la capacitacion con éxito.", MsgBoxStyle.Information)
                Else
                    MsgBox("Error al querer ingresar la capacitación.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            sinDobleEspacio(txtNombre.Text)
            sinDobleEspacio(txtProveedor.Text)
            If (Trim(txtCodigo.Text) <> "" And Trim(txtNombre.Text) <> "" And Trim(txtCantidadHoras.Text) <> "" And dgvBeneficiarios.Rows.Count > 1 And Trim(txtProveedor.Text) <> "") Then

                Dim objCap As New ClsCapacitaciones
                Dim objDetCap As New ClsDetalleCapacitaciones

                With objCap
                    .codigo_ = Convert.ToInt64(txtCodigo.Text)
                    .fecha_ = dtpFecha.Value
                    .Nombre_ = txtNombre.Text
                    .cantidadHoras_ = txtCantidadHoras.Text
                    .proveedor_ = txtProveedor.Text
                End With

                If objCap.ModificarCapacitaciones() = 1 Then
                    For index As Integer = 0 To codigoDetalleCapacitacion.Count - 1
                        'ELIMINA LOS DETALLE DE CAPACITACIONES
                        objDetCap.codigo_ = Convert.ToInt64(codigoDetalleCapacitacion(index))
                        If objDetCap.EliminarDetalleCapacitacion() <> 1 Then
                            MsgBox("Error al querer modificar el detalle de capacitación.", MsgBoxStyle.Critical)
                        End If
                    Next
                    codigoDetalleCapacitacion.Clear()
                    For index As Integer = 0 To dgvBeneficiarios.Rows.Count - 2
                        If dgvBeneficiarios.Rows(index).Cells(0).Value() = "" Then
                            'agrega
                            With objDetCap
                                .codigoCapacitacion_ = Convert.ToInt64(txtCodigo.Text)
                                .codigoEmpleado_ = dgvBeneficiarios.Rows(index).Cells(1).Value()
                            End With
                            If objDetCap.RegistrarNuevoDetalleCapacitacion() = 0 Then
                                MsgBox("Error al querer modificar el detalle de capacitación.", MsgBoxStyle.Critical)
                            End If
                        Else
                            'actualiza 
                            With objDetCap
                                .codigo_ = dgvBeneficiarios.Rows(index).Cells(0).Value()
                                .codigoCapacitacion_ = Convert.ToInt64(txtCodigo.Text)
                                .codigoEmpleado_ = dgvBeneficiarios.Rows(index).Cells(1).Value()
                            End With
                            If objDetCap.ModificarDetalleCapacitacion() = 0 Then
                                MsgBox("Error al querer modificar el detalle de capacitación.", MsgBoxStyle.Critical)
                            End If
                        End If
                    Next
                    MsgBox("Actualizada la capacitación con éxito.", MsgBoxStyle.Information)
                    btnGuardar.Enabled = False
                    btnModificar.Enabled = True
                End If
                'ACTUALIZAR LISTADO DE CAPACITACIONES
                RH_BuscarCapacitaciones.SeleccionarCapacitaciones()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Me.Close()
    End Sub

End Class