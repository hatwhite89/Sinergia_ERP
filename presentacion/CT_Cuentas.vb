Public Class CT_Cuentas
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Try
            CT_AgregarCuenta.Show()


        Catch ex As Exception

        End Try
    End Sub
End Class