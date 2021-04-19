Public Class RH_Candidatos
    Private Sub A_Candidatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            alternarColoFilasDatagridview(dtCandidatos)
            cargardata()


        Catch ex As Exception

        End Try

    End Sub

    Sub cargardata()
        Dim candidatos As New ClsCandidatos
        dtCandidatos.DataSource = candidatos.SeleccionarCandidatos
    End Sub

    Sub limpiar()

        txtNombre.Text = ""
        txtContacto.Text = ""
        txtDescripcion.Text = ""
        txtProfesion.Text = ""
        txtArea.Text = ""
        txtCargo.Text = ""
        dtpFecha.Value = Date.Now

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click

        limpiar()
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnnuevo.Enabled = False
        ' btnEliminar.Enabled = False

    End Sub

    Private Sub btnBuscarPro_Click(sender As Object, e As EventArgs) Handles btnBuscarPro.Click
        Try

            RH_Profesion.Show()
            RH_Profesion.lblform.Text = "Candidatos"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscarCargo_Click(sender As Object, e As EventArgs) Handles btnBuscarCargo.Click
        Try

            RH_PuestoTrabajo.Show()
            RH_PuestoTrabajo.lblform.Text = "Candidatos"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            RH_Area.Show()
            RH_Area.lblform.Text = "Candidatos"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            Dim n As String = MsgBox("¿Desea guardar el nuevo candidato?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then

                Dim candidato As New ClsCandidatos

                With candidato

                    .codigoArea_ = Convert.ToInt32(lblcodArea.Text)
                    .codigoPuestoTrabajo_ = Convert.ToInt32(lblcodCargo.Text)
                    .codigoProfesion_ = Convert.ToInt32(lblcodProfesion.Text)
                    .Nombre_ = txtNombre.Text
                    .descripcionExperiencia_ = txtDescripcion.Text
                    .telContacto_ = txtContacto.Text
                    .fechaAplicacion_ = dtpFecha.Value

                    If .RegistrarNuevoCandidato = 1 Then
                        MsgBox("Se registro un nuevo candidato.")
                        cargardata()
                        limpiar()
                    End If
                End With
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dtCandidatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCandidatos.CellDoubleClick

        Try
            Dim area As New ClsArea
            Dim profesion As New ClsProfesion
            Dim cargo As New ClsPuestoTrabajo

            Dim dt As New DataTable
            Dim row As DataRow

            dt = dtCandidatos.DataSource
            row = dt.Rows(e.RowIndex)

            lblCandidato.Text = row("codigo")
            lblcodArea.Text = row("codigoArea")
            lblcodCargo.Text = row("codigoPuestoTrabajo")
            txtDescripcion.Text = row("descripcionExperiencia")
            txtContacto.Text = row("telContacto")
            lblcodProfesion.Text = row("codigoProfesion")
            dtpFecha.Value = row("fechaAplicacion")
            txtNombre.Text = row("nombre")

            'buscar area
            area.codigo_ = Convert.ToInt32(lblcodArea.Text)
            dt = area.BuscarArea
            row = dt.Rows(0)
            txtArea.Text = row("nombre")

            'buscar profesion
            profesion.Codigo_ = Convert.ToInt32(lblcodProfesion.Text)
            dt = profesion.BuscarProfesionCode
            row = dt.Rows(0)
            txtProfesion.Text = row("descripcion")

            'buscar cargo
            cargo.Codigo_ = Convert.ToInt32(lblcodCargo.Text)
            dt = cargo.BuscarPuestoTrabajoCode
            row = dt.Rows(0)
            txtCargo.Text = row("descripcion")

            btnnuevo.Enabled = True
            btnModificar.Enabled = True
            'btnEliminar.Enabled = True
            btnGuardar.Enabled = False

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            Dim n As String = MsgBox("¿Desea modificar el registro de candidato?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then

                Dim candidato As New ClsCandidatos

                With candidato

                    .codigo_ = Convert.ToInt32(lblCandidato.Text)
                    .codigoArea_ = Convert.ToInt32(lblcodArea.Text)
                    .codigoPuestoTrabajo_ = Convert.ToInt32(lblcodCargo.Text)
                    .codigoProfesion_ = Convert.ToInt32(lblcodProfesion.Text)
                    .Nombre_ = txtNombre.Text
                    .descripcionExperiencia_ = txtDescripcion.Text
                    .telContacto_ = txtContacto.Text
                    .fechaAplicacion_ = dtpFecha.Value

                    If .ModificarCandidatos = 1 Then
                        MsgBox("Se modifico el registro.")
                        cargardata()
                        limpiar()
                    End If
                End With
            End If
        Catch ex As Exception

        End Try

    End Sub



    'Impresión de informes::::::::::::::::::::::::::::::::::::::::::::::::::::::::

    'Sub Informe()

    '    Try
    '        Dim codProfesion, codCargo As Integer
    '        Dim fechaDesde, fechaHasta As DateTime
    '        Dim objInformeProfesion As New InformeCandidatos

    '        If lblcodCargo.Text = "" Then
    '            codCargo = Nothing
    '        Else
    '            codCargo = Convert.ToInt32(lblcodCargo.Text)
    '        End If

    '        If lblcodProfesion.Text = "" Then
    '            codProfesion = Nothing
    '        Else

    '            codProfesion = Convert.ToInt32(lblcodProfesion.Text)

    '        End If

    '        fechaDesde = dtpFechaDesde.Value
    '        fechaHasta = dtpFechaHasta.Value

    '        objInformeProfesion.SetParameterValue("@codigoProfesion", codProfesion)
    '        objInformeProfesion.SetParameterValue("@codigoPuestoTrabajo", codCargo)
    '        objInformeProfesion.SetParameterValue("@fechaDesde", fechaDesde)
    '        objInformeProfesion.SetParameterValue("@fechaHasta", fechaHasta)

    '        objInformeProfesion.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
    '        A_PrintInforme.crvInformeOrdenesTrabajo.ReportSource = objInformeProfesion
    '        A_PrintInforme.lblform.Text = "InformePro"
    '        A_PrintInforme.Show()

    '    Catch ex As Exception
    '        MsgBox("Error en impresión de informe: " + ex.Message)
    '    End Try

    'End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::





    Private Sub dtCandidatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCandidatos.CellClick
        Try
            Dim area As New ClsArea
            Dim profesion As New ClsProfesion
            Dim cargo As New ClsPuestoTrabajo

            Dim dt As New DataTable
            Dim row As DataRow

            dt = dtCandidatos.DataSource
            row = dt.Rows(e.RowIndex)

            lblCandidato.Text = row("codigo")
            lblcodArea.Text = row("codigoArea")
            lblcodCargo.Text = row("codigoPuestoTrabajo")
            txtDescripcion.Text = row("descripcionExperiencia")
            txtContacto.Text = row("telContacto")
            lblcodProfesion.Text = row("codigoProfesion")
            dtpFecha.Value = row("fechaAplicacion")
            txtNombre.Text = row("nombre")

            'buscar area
            area.codigo_ = Convert.ToInt32(lblcodArea.Text)
            dt = area.BuscarArea
            row = dt.Rows(0)
            txtArea.Text = row("nombre")

            'buscar profesion
            profesion.Codigo_ = Convert.ToInt32(lblcodProfesion.Text)
            dt = profesion.BuscarProfesionCode
            row = dt.Rows(0)
            txtProfesion.Text = row("descripcion")

            'buscar cargo
            cargo.Codigo_ = Convert.ToInt32(lblcodCargo.Text)
            dt = cargo.BuscarPuestoTrabajoCode
            row = dt.Rows(0)
            txtCargo.Text = row("descripcion")

            btnnuevo.Enabled = True
            btnModificar.Enabled = True
            ' btnEliminar.Enabled = True
            btnGuardar.Enabled = False

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            'limpiar()
            Me.Close()
        End If
    End Sub

End Class