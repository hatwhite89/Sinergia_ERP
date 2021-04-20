Public Class CT_CuentasPorPagar
    Dim objTerm As New ClsTerminoPago
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            dgvDetalleProveedor.Rows.Add("0", cmbxTipoMovimiento.Text, txtDescripcion.Text, txtDebito.Text, txtCredito.Text, cmbxTerminoPago.Text)
            lblmsj.Text = "Se agrego el registro exitosamente."


        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDetalleCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleProveedor.CellClick
        Try
            If e.ColumnIndex = 6 Then
                dgvDetalleProveedor.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
                dgvDetalleProveedor.Rows(e.RowIndex).Cells(4).Value = dgvDetalleProveedor.Rows(e.RowIndex).Cells(3).Value
                dgvDetalleProveedor.Rows(e.RowIndex).Cells(3).Value = ""
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class