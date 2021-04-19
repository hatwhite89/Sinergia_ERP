Public Class RH_Vacaciones

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicial.TextChanged
        'txtTotalDias.Text = DateDiff(DateInterval.Day, dtpFechaInicial.Value, dtpFechaFinal.Value)
        Dim difference As TimeSpan = dtpFechaFinal.Value.Subtract(dtpFechaInicial.Value)
        txtTotalDias.Text = Math.Round(difference.TotalDays, 0)
    End Sub
    Private Sub dtpFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFinal.TextChanged
        'txtTotalDias.Text = DateDiff(DateInterval.Day, dtpFechaFinal.Value, dtpFechaInicial.Value)
        Dim difference As TimeSpan = dtpFechaFinal.Value.Subtract(dtpFechaInicial.Value)
        txtTotalDias.Text = Math.Round(difference.TotalDays, 0)
    End Sub
    Private Sub txtJefeDepto_Click(sender As Object, e As EventArgs)
        If lblEstado.Text <> "Deshabilitado" Then
            RH_ListadoEmpleados.lblform.Text = "M_Vacaciones_Depto"
            RH_ListadoEmpleados.Show()
        End If
    End Sub
    Private Sub txtTalentoHumano_Click(sender As Object, e As EventArgs)
        If lblEstado.Text <> "Deshabilitado" Then
            RH_ListadoEmpleados.lblform.Text = "M_Vacaciones_Humano"
            RH_ListadoEmpleados.Show()
        End If
    End Sub
    Private Sub txtSupervisor_Click(sender As Object, e As EventArgs)
        If lblEstado.Text <> "Deshabilitado" Then
            RH_ListadoEmpleados.lblform.Text = "M_Vacaciones_Supervisor"
            RH_ListadoEmpleados.Show()
        End If
    End Sub
    Private Sub txtEmpleado_Click(sender As Object, e As EventArgs) Handles txtEmpleado.Click
        If lblEstado.Text <> "Deshabilitado" Then
            RH_ListadoEmpleados.lblform.Text = "M_Vacaciones_Empleado"
            RH_ListadoEmpleados.Show()
        End If
    End Sub
    Private Sub limpiar()
        lblEstado.Text = ""
        txtcodigo.Text = ""
        txtEmpleado.Text = ""
        dtpFechaInicial.ResetText()
        dtpFechaFinal.ResetText()
        rbtnNo.Checked = True
        'rtxtMotivoInasistencia.Text = ""
        rtxtcubrira.Text = ""
        rtxtObservaciones.Text = ""
        txtTotalDias.Text = "0"
        'txtFirmaEmpleado.Text = ""
        'txtSupervisor.Text = ""
        'txtJefeDepto.Text = ""
        'txtTalentoHumano.Text = ""
        lblcodeEmpleado.Text = ""
        'lblcodeSupervisor.Text = ""
        'lblcodeJefeDepto.Text = ""
        'lblcodeSupervisor.Text = ""

        txtnombreB.Text = ""

        dtpFechaInicial.Enabled = True
        dtpFechaFinal.Enabled = True
        dtpfecha.Enabled = True
        rbtnNo.Enabled = True
        rbtnSi.Enabled = True
        'rtxtMotivoInasistencia.ReadOnly = False
        rtxtcubrira.Enabled = True
        rtxtObservaciones.Enabled = True

        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnnuevo.Enabled = True

        dtpfecha.Format = DateTimePickerFormat.Custom
        dtpfecha.CustomFormat = " "
    End Sub
    Private Sub dtpEntradaTarde_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpfecha.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpfecha.Format = DateTimePickerFormat.Short
                dtpfecha.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpfecha.Format = DateTimePickerFormat.Custom
                dtpfecha.CustomFormat = " "
        End Select

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Me.Close()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
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
            If (Trim(txtEmpleado.Text) <> "" And Trim(dtpFechaInicial.Text) <> "" And Trim(dtpFechaFinal.Text) <> "" And Trim(txtTotalDias.Text) <> "") Then
                Dim objVac As New ClsVacaciones
                With objVac
                    .codigoEmpleado_ = lblcodeEmpleado.Text
                    .fechaInicial_ = dtpFechaInicial.Value
                    .fechaFinal_ = dtpFechaFinal.Value
                    .totalDias_ = Integer.Parse(txtTotalDias.Text)
                    .notifico_ = rbtnSi.Checked
                    'validacion fecha nula 
                    If Trim(dtpfecha.Text) <> "" Then
                        .fecha_ = dtpfecha.Value
                    Else
                        .fecha_ = Nothing
                    End If
                    .cubrira_ = rtxtcubrira.Text
                    .observaciones_ = rtxtObservaciones.Text
                End With
                If objVac.RegistrarNuevoVacaciones() = 1 Then
                    MsgBox("Registrado correctamente.", MsgBoxStyle.Information)
                    seleccionarVacaciones()
                    deshabilitar()
                Else
                    MsgBox("Error al querer registrar la solicitud.", MsgBoxStyle.Information)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Information, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            If (txtcodigo.Text <> "" And Trim(txtEmpleado.Text) <> "" And Trim(dtpFechaInicial.Text) <> "" And Trim(dtpFechaFinal.Text) <> "" And Trim(txtTotalDias.Text) <> "") Then
                Dim objVac As New ClsVacaciones
                With objVac
                    .codigo_ = txtcodigo.Text
                    .codigoEmpleado_ = lblcodeEmpleado.Text
                    .fechaInicial_ = dtpFechaInicial.Value
                    .fechaFinal_ = dtpFechaFinal.Value
                    .totalDias_ = Integer.Parse(txtTotalDias.Text)
                    .notifico_ = rbtnSi.Checked
                    'validacion fecha nula 
                    If Trim(dtpfecha.Text) <> "" Then
                        .fecha_ = dtpfecha.Value
                    Else
                        .fecha_ = Nothing
                    End If
                    .cubrira_ = rtxtcubrira.Text
                    .observaciones_ = rtxtObservaciones.Text
                End With
                If objVac.ModificarVacaciones() = 1 Then
                    MsgBox("Actualizado correctamente.", MsgBoxStyle.Information)
                    seleccionarVacaciones()
                    deshabilitar()
                Else
                    MsgBox("Error al querer registrar la solicitud.", MsgBoxStyle.Information)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Information, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub seleccionarVacaciones()
        Try
            Dim objVac As New ClsVacaciones
            Dim dv As DataView = objVac.SeleccionarVacaciones.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Try
            Dim objVac As New ClsVacaciones
            With objVac
                .nombre_ = txtnombreB.Text
            End With
            Dim dv As DataView = objVac.BuscarVacacionesNombre.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub
    Private Sub deshabilitar()

        lblEstado.Text = "Deshabilitado"
        dtpFechaInicial.Enabled = False
        dtpFechaFinal.Enabled = False
        dtpfecha.Enabled = False
        rbtnNo.Enabled = False
        rbtnSi.Enabled = False
        rtxtcubrira.Enabled = False
        rtxtObservaciones.Enabled = False

        btnModificar.Enabled = False
        btnGuardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub

    Private Sub M_Vacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarVacaciones()
        alternarColoFilasDatagridview(dgbtabla)
        'Me.dgbtabla.Columns("codigoSupervisor").Visible = False
        'Me.dgbtabla.Columns("codigoJefeDepto").Visible = False
        'Me.dgbtabla.Columns("codigoTalentoHumano").Visible = False
    End Sub
    Private Sub lblcodeEmpleado_TextChanged(sender As Object, e As EventArgs) Handles lblcodeEmpleado.TextChanged
        Try
            Dim objEmp As New ClsEmpleados
            With objEmp
                .codigo_ = lblcodeEmpleado.Text
            End With
            Dim dt As New DataTable
            dt = objEmp.BuscarEmpleadosPorCodigo()
            Dim row As DataRow = dt.Rows(0)
            txtEmpleado.Text = CStr(row("nombreCompleto"))
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtTotalDias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalDias.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            If e.RowIndex >= 0 Then
                limpiar()

                txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                lblcodeEmpleado.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                dtpFechaInicial.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
                dtpFechaFinal.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
                txtTotalDias.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()
                If Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value() Then
                    rbtnSi.Checked = True
                Else
                    rbtnNo.Checked = True
                End If
                'valida que no sea nulo para poner la hora ingresada.
                If Trim(Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value().ToString) <> "" Then
                    dtpfecha.Format = DateTimePickerFormat.Short
                    dtpfecha.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value().ToString
                End If
                'If IsDBNull(Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()) = False Then
                '    dtpfecha.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
                'Else
                '    dtpfecha.Format = DateTimePickerFormat.Custom
                '    dtpfecha.CustomFormat = " "
                'End If
                rtxtcubrira.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value()
                rtxtObservaciones.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(8).Value()

                btnModificar.Enabled = True
                btnGuardar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



End Class