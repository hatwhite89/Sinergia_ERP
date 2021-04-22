Public Class CT_CuentasPorPagar
    Dim objTerm As New ClsTerminoPago
    Dim objDetMov As New ClsDetalleMovimientos_Proveedor

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        CT_Proveedores.lblForm.Text = "CT_CuentasPorPagar"
        CT_Proveedores.Show()
    End Sub
    Public Sub llenarTerminoPago()
        Try
            'llenar el combobox tipo permiso
            Dim dt As New DataTable
            dt = objTerm.SeleccionarTerminoPago()
            cmbxTerminoPago.DataSource = dt
            cmbxTerminoPago.DisplayMember = "descripcion"
            cmbxTerminoPago.ValueMember = "id"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CT_TerminoPago.Show()
    End Sub
    Private Sub CerrarForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub CT_CuentasPorPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenar combo box termino de pago
        llenarTerminoPago()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Trim(txtDescripcion.Text) <> "" And Trim(txtId.Text) <> "" Then
                Dim id As String
                sinDobleEspacio(txtNombre.Text)
                With objDetMov
                    .id_Proveedor_ = Integer.Parse(txtId.Text)
                    .id_TipoMovimiento_ = 1
                    .descripcion_ = txtDescripcion.Text
                    If txtDebito.Text = "" Then
                        .debito_ = 0
                    Else
                        .debito_ = Double.Parse(txtDebito.Text)
                    End If
                    If txtCredito.Text = "" Then
                        .credito_ = 0
                    Else
                        .credito_ = Double.Parse(txtCredito.Text)
                    End If
                    .credito_ = Double.Parse(txtCredito.Text)
                    .id_terminoPago_ = cmbxTerminoPago.SelectedValue
                    .fecha_ = dtpFecha.Value
                    .pagado_ = 0
                    .anulado_ = 0
                End With

                id = objDetMov.RegistrarNuevoDetalleMovimientos_Proveedor()
                'MsgBox("Registrado correctamente.", MsgBoxStyle.Information)

                'dgvDetalleProveedor.Rows.Add(id, cmbxTipoMovimiento.Text, txtDescripcion.Text, txtDebito.Text, txtCredito.Text, cmbxTerminoPago.Text, dtpFecha.Value)
                dgvDetalleProveedor.Rows.Insert(0, New String() {id, cmbxTipoMovimiento.Text, txtDescripcion.Text, txtDebito.Text, txtCredito.Text, cmbxTerminoPago.SelectedValue, cmbxTerminoPago.Text, dtpFecha.Value, "", False})
                lblmsj.Text = "Se agrego el registro exitosamente."

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDetalleCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleProveedor.CellClick
        Try
            If e.ColumnIndex = 8 Then
                With objDetMov
                    .id_ = dgvDetalleProveedor.Rows(e.RowIndex).Cells(0).Value
                    .id_Proveedor_ = Integer.Parse(txtId.Text)
                    .id_TipoMovimiento_ = 1
                    .descripcion_ = dgvDetalleProveedor.Rows(e.RowIndex).Cells(2).Value
                    .debito_ = 0
                    .credito_ = Double.Parse(dgvDetalleProveedor.Rows(e.RowIndex).Cells(3).Value)
                    .id_terminoPago_ = Integer.Parse(dgvDetalleProveedor.Rows(e.RowIndex).Cells(5).Value)
                    .fecha_ = dgvDetalleProveedor.Rows(e.RowIndex).Cells(7).Value
                    .pagado_ = True
                    .anulado_ = dgvDetalleProveedor.Rows(e.RowIndex).Cells(9).Value
                    MsgBox(dgvDetalleProveedor.Rows(e.RowIndex).Cells(9).Value)
                    If .ModificarDetalleMovimientos_Proveedor = 1 Then
                        dgvDetalleProveedor.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
                        dgvDetalleProveedor.Rows(e.RowIndex).Cells(4).Value = dgvDetalleProveedor.Rows(e.RowIndex).Cells(3).Value
                        dgvDetalleProveedor.Rows(e.RowIndex).Cells(3).Value = "0"
                    End If
                End With
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Try
            If Trim(txtId.Text) <> "" Then
                MsgBox("Entra")
                objDetMov.id_Proveedor_ = Integer.Parse(txtId.Text)
                Dim dt As DataTable = objDetMov.BuscarDetalleMovimientos_Proveedor
                Dim row As DataRow
                For index = 0 To dt.Rows.Count - 1
                    row = dt.Rows(index)
                    dgvDetalleProveedor.Rows.Insert(0, New String() {CStr(row("id")), CStr(row("id_TipoMovimiento")), CStr(row("descripcion")), CStr(row("debito")), CStr(row("credito")), CStr(row("id_TerminoPago")), "", CStr(row("fecha")), "", CStr(row("anulado"))})

                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class