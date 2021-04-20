Public Class CT_Clientes

    Public FormularioDeLlamada As String = "default"
    Private Sub CT_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CARGARDATA()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub CARGARDATA()


        Dim objCliente As New ClsCliente
        Dim dt As New DataTable

        dt = objCliente.ListarClientes

        dgbtabla.DataSource = dt

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        CT_AgregarCliente.Show()
        CT_AgregarCliente.BringToFront()
        CT_AgregarCliente.WindowState = WindowState.Normal

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub dgbtabla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellDoubleClick
        Try
            Select Case FormularioDeLlamada
                Case "Cobro"
                    CT_CuentaPorCobrar.txtId.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value
                    CT_CuentaPorCobrar.txtNombre.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value
                Case "default"
                    With CT_AgregarCliente

                        .txtID.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value
                        .txtNombre.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value
                        .txtRTN.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value
                        .txtDireccion.Text = dgbtabla.Rows(e.RowIndex).Cells(3).Value
                        .txtEMAIL.Text = dgbtabla.Rows(e.RowIndex).Cells(4).Value
                        .txtTEL.Text = dgbtabla.Rows(e.RowIndex).Cells(5).Value
                        .txtCelular.Text = dgbtabla.Rows(e.RowIndex).Cells(6).Value
                        .Show()
                        .BringToFront()
                        .WindowState = WindowState.Normal
                    End With
            End Select


        Catch ex As Exception

        End Try
    End Sub
End Class