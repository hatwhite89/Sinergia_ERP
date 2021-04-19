Public Class RH_PuestoTrabajo
    Private Sub M_PuestoTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'ACTUALIZAR LISTADO
            Dim objPuesto As New ClsPuestoTrabajo
            Dim dv As DataView = objPuesto.SeleccionarPuestoTrabajo.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

            'AGREGARLE COLOR AL DATAGRIDVIEW
            alternarColoFilasDatagridview(dgbtabla)

            'OCULTAR COLUMNAS
            Me.dgbtabla.Columns("codigoDepto").Visible = False
            Me.dgbtabla.Columns("codigoArea").Visible = False

            'CAMBIAS NOMBRE COLUMNAS
            dgbtabla.Columns("codigo").HeaderText = "Código"
            dgbtabla.Columns("descripcion").HeaderText = "Descripción"


            'DESHABILITAR 
            rtxtdescripcion.Enabled = False
            txtcodigo.Enabled = False
            txtcodigoDepto.Enabled = False
            btnBuscar.Enabled = False
            btnModificar.Enabled = False
            btnGuardar.Enabled = False
            btnnuevo.Enabled = True

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            rtxtdescripcion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txtcodigoDepto.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()

            rtxtdescripcion.Enabled = True
            txtcodigoDepto.Enabled = True

            btnBuscar.Enabled = True

            btnModificar.Enabled = True
            btnGuardar.Enabled = False

            rtxtdescripcion.Enabled = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "Empleados") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el puesto de trabajo en el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_Factura.txtcodigoMedico.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    'RH_Empleados.lblcodePuesto.Text = txtcodigo.Text
                    'RH_Empleados.txtPuestoTrabajo.Text = rtxtdescripcion.Text
                    MsgBox(txtcodigo.Text)
                    Me.Close()
                End If
            ElseIf (lblform.Text = "Candidatos") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el puesto de trabajo en el candidato?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'RH_Candidatos.lblcodCargo.Text = txtcodigo.Text
                    'RH_Candidatos.txtCargo.Text = rtxtdescripcion.Text

                    Me.Close()
                End If

            ElseIf (lblform.Text = "CandidatosInforme") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el puesto de trabajo en el informe?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'RH_Candidatos.lblcodCargo.Text = txtcodigo.Text
                    'RH_Candidatos.txtCargoI.Text = rtxtdescripcion.Text

                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        rtxtdescripcion.Text() = ""
        txtdescrip.Text() = ""
        txtnombreDepto.Text = ""
        txtcodigoDepto.Text = ""

        rtxtdescripcion.Enabled = True
        txtcodigoDepto.Enabled = True

        btnBuscar.Enabled = True
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnnuevo.Enabled = True
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Function sinDobleEspacio(ByVal cadena As String) As String
        Dim texto As String = ""
        Dim testArray() As String = Split(cadena)
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                texto += testArray(i) + " "
            End If
        Next
        Return RTrim(texto)
    End Function
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If rtxtdescripcion.Text = "" Then
                rtxtdescripcion.BackColor = Color.Red
            Else
                rtxtdescripcion.BackColor = Color.White
            End If
            If (Trim(rtxtdescripcion.Text) <> "" And Trim(txtnombreDepto.Text) <> "") Then
                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
                Dim objPuesto As New ClsPuestoTrabajo
                With objPuesto
                    .Descripcion_ = rtxtdescripcion.Text
                    .codigoDepto_ = txtcodigoDepto.Text
                End With

                If objPuesto.RegistrarNuevoPuestoTrabajo() = 1 Then
                    MsgBox("Registrado correctamente.", MsgBoxStyle.Information, "Validación.")

                    Dim dv As DataView = objPuesto.SeleccionarPuestoTrabajo.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.Enabled = False
                    rtxtdescripcion.Enabled = False
                    txtcodigoDepto.Enabled = False

                    btnBuscar.Enabled = False

                    btnModificar.Enabled = False
                    btnGuardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el puesto de trabajo.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            If (txtcodigo.Text <> "" And Trim(rtxtdescripcion.Text) <> "" And Trim(txtnombreDepto.Text) <> "") Then
                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
                Dim objPuesto As New ClsPuestoTrabajo
                With objPuesto
                    .Codigo_ = txtcodigo.Text
                    .Descripcion_ = rtxtdescripcion.Text
                    .codigoDepto_ = txtcodigoDepto.Text
                End With

                If objPuesto.ModificarPuestoTrabajo() = 1 Then
                    MsgBox("Modificado correctamente.", MsgBoxStyle.Information, "Validación.")

                    Dim dv As DataView = objPuesto.SeleccionarPuestoTrabajo.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.Enabled = False
                    rtxtdescripcion.Enabled = False
                    txtcodigoDepto.Enabled = False

                    btnBuscar.Enabled = False

                    btnModificar.Enabled = False
                    btnGuardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el puesto de trabajo.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btncancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Me.Close()
    End Sub
    Private Sub txtdescripcionB_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcionB.TextChanged
        'Try

        '    'Dim objPuesto As New ClsPuestoTrabajo
        '    'With objPuesto
        '    '    .Descripcion_ = txtdescripcionB.Text
        '    'End With

        '    'If (Trim(txtdescripcionB.Text) <> "") Then
        '    '    Dim dv As DataView = objPuesto.BuscarPuestoTrabajo.DefaultView
        '    '    dgbtabla.DataSource = dv
        '    '    lblcantidad.Text = dv.Count
        '    '    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        '    'Else
        '    '    Dim dv As DataView = objPuesto.SeleccionarPuestoTrabajo.DefaultView
        '    '    dgbtabla.DataSource = dv
        '    '    lblcantidad.Text = dv.Count
        '    '    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        '    'End If
        'Catch ex As Exception

        'End Try

        Try
            Dim dv As DataView = dgbtabla.DataSource
            dv.RowFilter = String.Format("descripcion Like '%{0}%'", txtdescripcionB.Text)
            lblcantidad.Text = dv.Count
            dgbtabla.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub rtxtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles rtxtdescripcion.TextChanged
        If rtxtdescripcion.Text = "" Then
            rtxtdescripcion.BackColor = Color.Red
        Else
            rtxtdescripcion.BackColor = Color.White
        End If
    End Sub

    Private Sub btnDepto_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        RH_Departamentos.lblform.Text = "M_PuestoTrabajo"
        RH_Departamentos.Show()
    End Sub

    Private Sub txtcodigoDepto_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoDepto.TextChanged
        If (txtcodigoDepto.Text <> "") Then
            Try
                Dim objDepto As New ClsDepartamento
                With objDepto
                    .codigo_ = txtcodigoDepto.Text
                End With
                Dim dt As New DataTable
                dt = objDepto.BuscarDepartamento()
                Dim row As DataRow = dt.Rows(0)
                txtnombreDepto.Text = CStr(row("nombre"))
                txtcodigoDepto.BackColor = Color.White
            Catch ex As Exception
                txtcodigoDepto.BackColor = Color.Red
                txtnombreDepto.Text = ""
            End Try
        Else
            txtcodigoDepto.Text = ""
            txtnombreDepto.Text = ""
            txtcodigoDepto.BackColor = Color.White
        End If
    End Sub



End Class