Public Class CT_Clientes
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
End Class