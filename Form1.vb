Public Class Form1

    Private Sub UI_ButtonMaterial1_Click(sender As Object, e As EventArgs) Handles UI_ButtonMaterial1.Click
        End
    End Sub

    Private Sub UI_ButtonMaterial2_Click(sender As Object, e As EventArgs) Handles UI_ButtonMaterial2.Click
        Try

            MenuPrincipal.Show()
            Me.Hide()



        Catch ex As Exception

        End Try
    End Sub
End Class
