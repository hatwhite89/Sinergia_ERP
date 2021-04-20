Public Class CT_AgregarTerminoPago
    Dim objTerm As New ClsTerminoPago
    Private Sub M_Contratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''ACTUALIZAR LISTADO
        'seleccionarContratos()

        ''AGREGARLE COLOR AL DATAGRIDVIEW
        'alternarColoFilasDatagridview(dgbtabla)

        ''CAMBIAS NOMBRE COLUMNAS
        'dgbtabla.Columns("codigo").HeaderText = "Código"
        'dgbtabla.Columns("descripcion").HeaderText = "Descripción"

        'HABILITAR
        txtDescripcion.Enabled = True
        txtId.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnnuevo.Enabled = True
    End Sub

    Private Sub seleccionarTerminoPago()
        'Try
        '    Dim dv As DataView = objTerm.SeleccionarTerminoPago.DefaultView
        '    dgbtabla.DataSource = dv
        '    lblcantidad.Text = dv.Count
        '    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    'Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
    '    Try
    '        txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
    '        txtDescripcion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()

    '        txtcodigo.Enabled = False
    '        btnModificar.Enabled = True
    '        btnGuardar.Enabled = False

    '        txtDescripcion.Enabled = True
    '    Catch ex As Exception
    '        'MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub
    Private Sub limpiar()
        txtId.Text() = ""
        txtDescripcion.Text() = ""
        'txtdescripcionB.Text() = ""

        txtDescripcion.Enabled = True

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
            If txtDescripcion.Text = "" Then
                txtDescripcion.BackColor = Color.Red
            Else
                txtDescripcion.BackColor = Color.White
            End If
            If (Trim(txtDescripcion.Text) <> "") Then
                sinDobleEspacio(txtDescripcion.Text)
                With objTerm
                    .descripcion_ = txtDescripcion.Text
                End With

                id = objTerm.RegistrarNuevoTerminoPago()
                MsgBox("Registrado correctamente.", MsgBoxStyle.Information)

                txtId.Text = id
                'Dim dv As DataView = objContratos.SeleccionarContratos.DefaultView
                'dgbtabla.DataSource = dv
                'lblcantidad.Text = dv.Count
                'dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
                CT_TerminoPago.seleccionarTerminos()

                txtId.Enabled = False
                    txtDescripcion.Enabled = True

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

            If (txtId.Text <> "" And Trim(txtDescripcion.Text) <> "") Then
                sinDobleEspacio(txtDescripcion.Text)
                With objTerm
                    .id_ = Integer.Parse(txtId.Text)
                    .descripcion_ = txtDescripcion.Text
                End With

                If objTerm.ModificarTerminoPago() = 1 Then
                    MsgBox("Modificado correctamente.", MsgBoxStyle.Information)

                    'Dim dv As DataView = objContratos.SeleccionarContratos.DefaultView
                    'dgbtabla.DataSource = dv
                    'lblcantidad.Text = dv.Count
                    'dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    CT_TerminoPago.seleccionarTerminos()

                    txtId.Enabled = False
                    txtDescripcion.Enabled = True

                    btnModificar.Enabled = True
                    btnGuardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el término de pago.", MsgBoxStyle.Critical)
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
    'Private Sub txtdescripcionB_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcionB.TextChanged
    '    'Try

    '    '    With objContratos
    '    '        .Descripcion_ = txtdescripcionB.Text
    '    '    End With

    '    '    If (Trim(txtdescripcionB.Text) <> "") Then
    '    '        Dim dv As DataView = objContratos.BuscarContratos.DefaultView
    '    '        dgbtabla.DataSource = dv
    '    '        lblcantidad.Text = dv.Count
    '    '        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    '    '    Else
    '    '        Dim dv As DataView = objContratos.SeleccionarContratos.DefaultView
    '    '        dgbtabla.DataSource = dv
    '    '        lblcantidad.Text = dv.Count
    '    '        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    '    '    End If

    '    'Catch ex As Exception

    '    'End Try
    '    Try
    '        Dim dv As DataView = dgbtabla.DataSource
    '        dv.RowFilter = String.Format("descripcion Like '%{0}%'", txtdescripcionB.Text)
    '        lblcantidad.Text = dv.Count
    '        dgbtabla.DataSource = dv
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        If txtDescripcion.Text = "" Then
            txtDescripcion.BackColor = Color.Red
        Else
            txtDescripcion.BackColor = Color.White
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class