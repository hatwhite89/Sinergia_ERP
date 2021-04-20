Public Class CT_TipoMovimiento
    Private Sub CT_TipoMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CARGARDATA()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub LIMPIAR()

        txtID.Text = ""
        txtNombre.Text = ""

    End Sub

    Private Sub CARGARDATA()

        Dim objtipomov As New ClsTipoMovimiento
        Dim dt As New DataTable

        dt = objtipomov.ListarTipoMov
        dgvData.DataSource = dt

    End Sub


    Private Sub GUARDAR()

        Dim objtipomov As New ClsTipoMovimiento

        If txtNombre.Text <> "" Then

            With objtipomov

                .NOMBRE_ = Trim(txtNombre.Text)

                If .RegistrarNuevoTipoMov = 1 Then
                    lblEstado.Text = "Se guardo el Tipo de Mov. exitosamente."
                Else
                    lblEstado.Text = "Hubo un error al guardar."
                End If

            End With

        End If

    End Sub

    Private Sub MODIFICAR()
        Dim objtipomov As New ClsTipoMovimiento

        If txtNombre.Text <> "" Then

            With objtipomov

                .NOMBRE_ = Trim(txtNombre.Text)
                .ID = Integer.Parse(txtID.Text)
                If .ActualizarTipoMov = 1 Then
                    lblEstado.Text = "Se actualizo el Tipo de Mov. exitosamente."
                Else
                    lblEstado.Text = "Hubo un error al actualizar."
                End If

            End With

        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            GUARDAR()
            LIMPIAR()
            CARGARDATA()
        Catch ex As Exception

        End Try

    End Sub

End Class