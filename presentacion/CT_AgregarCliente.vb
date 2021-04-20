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
        dgvProveedores.Rows.Clear()

    End Sub

    Private Sub GUARDAR()

        Dim objCliente As New ClsCliente
        Dim objDetalle As New ClsDetalleCliente_Proveedores
        Dim codigoCliente As String

        If txtRTN.Text <> "" And txtNombre.Text <> "" Then

            With objCliente

                .NOMBRE_ = Trim(txtNombre.Text)
                .RTN_ = txtRTN.Text
                .DIRECCION_ = txtDireccion.Text
                .E_MAIL = txtEMAIL.Text
                .TEL_ = txtTEL.Text
                .CEL_ = txtCelular.Text
                codigoCliente = .RegistrarNuevoCliente
                MsgBox(codigoCliente)

                If codigoCliente <> "" Then

                    For i = 0 To dgvProveedores.Rows.Count - 2
                        With objDetalle

                            .ID_Cliente = Integer.Parse(codigoCliente)
                            .ID_Proveedor = Integer.Parse(dgvProveedores.Rows(i).Cells(1).Value)
                            .PORCENTAJE_ = Integer.Parse(dgvProveedores.Rows(i).Cells(3).Value)
                            .RegistrarNuevoDetalle()
                        End With
                    Next

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

    Private Sub CT_AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If txtID.Text <> "" Then

                Dim objDetalle As New ClsDetalleCliente_Proveedores
                Dim dt As New DataTable
                Dim row As DataRow

                With objDetalle

                    .ID_Cliente = Integer.Parse(txtID.Text)
                    dt = .ListarProveedoresXCliente

                    For i = 0 To dt.Rows.Count - 1

                        row = dt.Rows(i)

                        dgvProveedores.Rows.Add(CStr(row("id")), CStr(row("id_proveedor")), CStr(row("nombre")), CStr(row("porcentaje")))

                    Next

                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class