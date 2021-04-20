Public Class CT_AgregarCliente
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            GUARDAR()
            Limpiar()

            CT_Clientes.Show()
            CT_Clientes.CARGARDATA()
            CT_Clientes.BringToFront()
            CT_Clientes.WindowState = WindowState.Normal

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Sub Limpiar()

        txtID.Text = ""
        txtRTN.Text = ""
        txtTEL.Text = ""
        txtNombre.Text = ""
        txtCelular.Text = ""
        txtEMAIL.Text = ""
        txtDireccion.Text = ""

    End Sub

    Private Sub GUARDAR()

        Dim objCliente As New ClsCliente

        If txtRTN.Text <> "" And txtNombre.Text <> "" Then

            With objCliente

                .NOMBRE_ = Trim(txtNombre.Text)
                .RTN_ = txtRTN.Text
                .DIRECCION_ = txtDireccion.Text
                .E_MAIL = txtEMAIL.Text
                .TEL_ = txtTEL.Text
                .CEL_ = txtCelular.Text

                If .RegistrarNuevoCliente = 1 Then
                    lblEstado.Text = "Se guardo el cliente exitosamente."
                Else
                    lblEstado.Text = "Ocurrio un error al guardar."

                End If

            End With
        ElseIf txtRTN.Text = "" Then
            lblEstado.Text = "Existen campos vacíos. Debe registrar RTN de cliente"
        ElseIf txtNombre.Text = "" Then
            lblEstado.Text = "Existen campos vacíos. Debe registrar NOMBRE de cliente"
        End If

    End Sub
End Class