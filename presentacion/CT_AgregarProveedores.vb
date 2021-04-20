Public Class CT_AgregarProveedores
    Dim objProv As New ClsProveedor
    Private Sub M_Contratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''ACTUALIZAR LISTADO
        'seleccionarContratos()

        ''AGREGARLE COLOR AL DATAGRIDVIEW
        'alternarColoFilasDatagridview(dgbtabla)

        ''CAMBIAS NOMBRE COLUMNAS
        'dgbtabla.Columns("codigo").HeaderText = "Código"
        'dgbtabla.Columns("descripcion").HeaderText = "Descripción"

        'HABILITAR
        'limpiar()
    End Sub


    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub limpiar()
        txtId.Text() = ""
        txtNombre.Text() = ""
        txtRTN.Text() = ""
        txtDireccion.Text() = ""
        txtCorreo.Text() = ""
        txtTelefono.Text() = ""
        txtCelular.Text() = ""

        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnnuevo.Enabled = True
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
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
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim id As String
            If (Trim(txtNombre.Text) <> "") Then
                sinDobleEspacio(txtNombre.Text)
                With objProv
                    .nombre_ = txtNombre.Text
                    .RTN_ = txtRTN.Text
                    .direccion_ = txtDireccion.Text
                    .correo_ = txtCorreo.Text
                    .telefono_ = txtTelefono.Text
                    .celular_ = txtCelular.Text
                End With

                id = objProv.RegistrarNuevoProveedor()
                MsgBox("Registrado correctamente.", MsgBoxStyle.Information)

                txtId.Text = id
                CT_Proveedores.seleccionarProveedores()

                btnModificar.Enabled = True
                btnGuardar.Enabled = False
                btnnuevo.Enabled = True

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            If (txtId.Text <> "" And Trim(txtNombre.Text) <> "") Then
                sinDobleEspacio(txtNombre.Text)
                With objProv
                    .id_ = Integer.Parse(txtId.Text)
                    .nombre_ = txtNombre.Text
                    .RTN_ = txtRTN.Text
                    .direccion_ = txtDireccion.Text
                    .correo_ = txtCorreo.Text
                    .telefono_ = txtTelefono.Text
                    .celular_ = txtCelular.Text
                End With

                If objProv.ModificarProveedor() = 1 Then
                    MsgBox("Modificado correctamente.", MsgBoxStyle.Information)

                    'Dim dv As DataView = objContratos.SeleccionarContratos.DefaultView
                    'dgbtabla.DataSource = dv
                    'lblcantidad.Text = dv.Count
                    'dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    CT_Proveedores.seleccionarProveedores()

                    btnModificar.Enabled = True
                    btnGuardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el proveedor.", MsgBoxStyle.Critical)
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class