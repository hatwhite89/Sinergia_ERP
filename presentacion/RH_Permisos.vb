Public Class RH_Permisos
    Dim objPerm As New ClsPermisos
    Dim objEmp As New ClsEmpleados
    Dim objTipoTerm As New ClsTipoPermiso
    Private Sub txtjefeInmediato_TextChanged(sender As Object, e As EventArgs) Handles txtjefeInmediato.Click
        If dtpFechaInicial.Enabled Then
            RH_ListadoEmpleados.lblform.Text = "M_Permisos_JefeInmediato"
            RH_ListadoEmpleados.Show()
        End If
    End Sub
    Private Sub txtTalentoHumano_TextChanged(sender As Object, e As EventArgs) Handles txtDepto.Click
        'If dtpFecha.Enabled Then
        '    M_ListadoEmpleados.lblform.Text = "M_Permisos_TalentoHumano"
        '    M_ListadoEmpleados.show()
        'End If
    End Sub
    Private Sub txtEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtEmpleado.Click
        If dtpFechaInicial.Enabled Then
            RH_ListadoEmpleados.lblform.Text = "M_Permisos_Empleado"
            RH_ListadoEmpleados.Show()
        End If
    End Sub
    Private Sub limpiar()

        txtcodigo.Text = ""
        dtpEntradaTarde.ResetText()
        dtpFechaInicial.ResetText()
        dtpFechaFinal.ResetText()
        dtpSalidaTemprano.ResetText()
        rtxtObservaciones.Text = ""
        txtjefeInmediato.Text = ""
        txtDepto.Text = ""
        lblcodigoEmpleado.Text = ""
        lblcodeJefeInme.Text = ""
        lblcodeDepto.Text = ""
        txtEmpleado.Text = ""
        llenarTipoPermiso()

        txtEmpleado.Enabled = False
        txtDepto.Enabled = False
        txtjefeInmediato.Enabled = False
        dtpEntradaTarde.Enabled = True
        dtpFechaInicial.Enabled = True
        dtpFechaFinal.Enabled = True
        dtpSalidaTemprano.Enabled = True
        rtxtObservaciones.Enabled = True

        btnTipoPermiso.Enabled = True
        cmbxTipoPermiso.Enabled = True

        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnnuevo.Enabled = True

        dtpEntradaTarde.Format = DateTimePickerFormat.Custom
        dtpEntradaTarde.CustomFormat = " "

        'dtpFechaFinal.Format = DateTimePickerFormat.Custom
        'dtpFechaFinal.CustomFormat = " "

        dtpSalidaTemprano.Format = DateTimePickerFormat.Custom
        dtpSalidaTemprano.CustomFormat = " "
    End Sub
    Private Sub dtpEntradaTarde_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpEntradaTarde.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpEntradaTarde.Format = DateTimePickerFormat.Time
                dtpEntradaTarde.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpEntradaTarde.Format = DateTimePickerFormat.Custom
                dtpEntradaTarde.CustomFormat = " "
        End Select

    End Sub
    Private Sub dtpSalidaTarde_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpFechaFinal.MouseDown

        'Select Case e.Button
        '    Case Windows.Forms.MouseButtons.Left
        '        dtpFechaFinal.Format = DateTimePickerFormat.Time
        '        dtpFechaFinal.Value = Date.Today

        '    Case Windows.Forms.MouseButtons.Right
        '        dtpFechaFinal.Format = DateTimePickerFormat.Custom
        '        dtpFechaFinal.CustomFormat = " "
        'End Select

    End Sub
    Private Sub dtpfechaBaja_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpSalidaTemprano.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpSalidaTemprano.Format = DateTimePickerFormat.Time
                dtpSalidaTemprano.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpSalidaTemprano.Format = DateTimePickerFormat.Custom
                dtpSalidaTemprano.CustomFormat = " "
        End Select

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Sub deshabilitar()
        'Deshabilitar
        dtpEntradaTarde.Enabled = False
        dtpFechaInicial.Enabled = False
        dtpFechaFinal.Enabled = False
        dtpSalidaTemprano.Enabled = False
        rtxtObservaciones.Enabled = False
        cmbxTipoPermiso.Enabled = False
        btnTipoPermiso.Enabled = False

        btnModificar.Enabled = False
        btnGuardar.Enabled = False
        btnnuevo.Enabled = True
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
            If txtEmpleado.Text = "" Then
                txtEmpleado.BackColor = Color.Red
            Else
                txtEmpleado.BackColor = Color.White
            End If
            If txtjefeInmediato.Text = "" Then
                txtjefeInmediato.BackColor = Color.Red
            Else
                txtjefeInmediato.BackColor = Color.White
            End If
            If txtDepto.Text = "" Then
                txtDepto.BackColor = Color.Red
            Else
                txtDepto.BackColor = Color.White
            End If
            'If Trim(rtxtObservaciones.Text) = "" Then
            '    rtxtObservaciones.BackColor = Color.Red
            'Else
            '    sinDobleEspacio(rtxtObservaciones.Text)
            '    rtxtObservaciones.BackColor = Color.White
            'End If
            If (txtEmpleado.BackColor = Color.White And txtjefeInmediato.BackColor = Color.White And txtDepto.BackColor = Color.White) Then

                With objPerm
                    .codigoEmpleado_ = lblcodigoEmpleado.Text
                    .codigoJefeInmediato_ = lblcodeJefeInme.Text
                    .fechaInicial_ = dtpFechaInicial.Value
                    .fechaFinal_ = dtpFechaFinal.Value
                    .codigoTipoPermiso_ = cmbxTipoPermiso.SelectedValue
                    .totalDias_ = txtTotalDias.Text
                    If Trim(dtpEntradaTarde.Text) <> "" Then
                        .entradaTarde_ = dtpEntradaTarde.Value
                    Else
                        .entradaTarde_ = Nothing
                    End If
                    If Trim(dtpSalidaTemprano.Text) <> "" Then
                        .salidaTemprano_ = dtpSalidaTemprano.Value
                    Else
                        .salidaTemprano_ = Nothing
                    End If
                    .observaciones_ = rtxtObservaciones.Text
                    '.goseSueldo_ = rbtnSi.Checked
                End With
                If objPerm.RegistrarNuevoPermiso() = 1 Then
                    MsgBox("Registrado el permiso especial correctamente.", MsgBoxStyle.Information)
                    seleccionarPermisos()
                    deshabilitar()
                Else
                    MsgBox("Error al querer registrar el permiso especial.", MsgBoxStyle.Information)
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
            If txtEmpleado.Text = "" Then
                txtEmpleado.BackColor = Color.Red
            Else
                txtEmpleado.BackColor = Color.White
            End If
            If txtjefeInmediato.Text = "" Then
                txtjefeInmediato.BackColor = Color.Red
            Else
                txtjefeInmediato.BackColor = Color.White
            End If
            If txtDepto.Text = "" Then
                txtDepto.BackColor = Color.Red
            Else
                txtDepto.BackColor = Color.White
            End If
            'If Trim(rtxtObservaciones.Text) = "" Then
            '    rtxtObservaciones.BackColor = Color.Red
            'Else
            '    sinDobleEspacio(rtxtObservaciones.Text)
            '    rtxtObservaciones.BackColor = Color.White
            'End If
            If (txtEmpleado.BackColor = Color.White And txtjefeInmediato.BackColor = Color.White And txtDepto.BackColor = Color.White) Then
                'Dim objPerm As New ClsPermisos
                With objPerm
                    .codigo_ = txtcodigo.Text
                    .codigoEmpleado_ = lblcodigoEmpleado.Text
                    .codigoJefeInmediato_ = lblcodeJefeInme.Text
                    .fechaInicial_ = dtpFechaInicial.Value
                    .fechaFinal_ = dtpFechaFinal.Value
                    .codigoTipoPermiso_ = cmbxTipoPermiso.SelectedValue
                    .totalDias_ = txtTotalDias.Text
                    If Trim(dtpEntradaTarde.Text) <> "" Then
                        .entradaTarde_ = dtpEntradaTarde.Value
                    Else
                        .entradaTarde_ = Nothing
                    End If
                    If Trim(dtpSalidaTemprano.Text) <> "" Then
                        .salidaTemprano_ = dtpSalidaTemprano.Value
                    Else
                        .salidaTemprano_ = Nothing
                    End If
                    .observaciones_ = rtxtObservaciones.Text
                    '.goseSueldo_ = rbtnSi.Checked
                End With

                If objPerm.ModificarPermisos() = 1 Then
                    MsgBox("Actualizado el permiso especial correctamente.", MsgBoxStyle.Information)
                    seleccionarPermisos()
                    deshabilitar()
                Else
                    MsgBox("Error al querer actualizar el permiso especial.", MsgBoxStyle.Information)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Information, "Validación")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btncancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            If e.RowIndex >= 0 Then
                limpiar()

                txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                lblcodigoEmpleado.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                lblcodeJefeInme.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
                dtpFechaInicial.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()
                dtpFechaFinal.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
                cmbxTipoPermiso.SelectedValue = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value()
                txtTotalDias.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value()
                'valida que no sea nulo para poner la hora ingresada.
                If Trim(Me.dgbtabla.Rows(e.RowIndex).Cells(8).Value().ToString) <> "" Then
                    dtpEntradaTarde.Format = DateTimePickerFormat.Time
                    dtpEntradaTarde.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(8).Value().ToString
                End If
                If Trim(Me.dgbtabla.Rows(e.RowIndex).Cells(9).Value().ToString) <> "" Then
                    dtpSalidaTemprano.Format = DateTimePickerFormat.Time
                    dtpSalidaTemprano.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(9).Value().ToString
                End If
                rtxtObservaciones.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(10).Value()

                btnModificar.Enabled = True
                btnGuardar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub llenarTipoPermiso()
        Try
            'llenar el combobox tipo permiso
            Dim dt As New DataTable
            dt = objTipoTerm.SeleccionarTipoPermiso()
            'cmbxTipoPermiso.DataSource = New BindingSource(dt, Nothing)
            cmbxTipoPermiso.DataSource = dt
            cmbxTipoPermiso.DisplayMember = "nombre"
            cmbxTipoPermiso.ValueMember = "codigo"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "factura") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el permiso especial?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_Factura.txtcodigoMedico.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    'M_Factura.txtcodigoSede.Text = txtcodigo.Text
                    'M_Factura.txtnombreSede.Text = txtnombre.Text
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub M_Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTUALIZAR LISTADO
        seleccionarPermisos()

        'AGREGARLE COLOR AL DATAGRIDVIEW
        alternarColoFilasDatagridview(dgbtabla)

        'OCULTAR COLUMNAS
        Me.dgbtabla.Columns("codigoEmpleado").Visible = False
        Me.dgbtabla.Columns("codigoJefeInmediato").Visible = False
        Me.dgbtabla.Columns("codigoTipoPermiso").Visible = False
        Me.dgbtabla.Columns("entradaTarde").Visible = False
        Me.dgbtabla.Columns("salidaTemprano").Visible = False
        'Me.dgbtabla.Columns("observacion").Visible = False

        'CAMBIAS NOMBRE COLUMNAS
        dgbtabla.Columns("codigo").HeaderText = "Código"
        dgbtabla.Columns("fechaInicial").HeaderText = "Fecha Inicial"
        dgbtabla.Columns("fechaFinal").HeaderText = "Fecha Final"
        dgbtabla.Columns("totalDias").HeaderText = "Total de Días"
        dgbtabla.Columns("observaciones").HeaderText = "Observaciones"

        'LLENAR COMBO BOX TIPO PERMISO
        llenarTipoPermiso()
    End Sub
    Private Sub seleccionarPermisos()
        Try
            Dim dv As DataView = objPerm.SeleccionarPermisos.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            deshabilitar()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        'Try
        '    Dim objPerm As New ClsPermisos
        '    With objPerm
        '        .observaciones_ = txtnombreB.Text
        '    End With
        '    Dim dv As DataView = objPerm.BuscarPermisosNombre.DefaultView
        '    dgbtabla.DataSource = dv
        '    lblcantidad.Text = dv.Count
        '    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        'Catch ex As Exception

        'End Try
        Try
            Dim dv As DataView = dgbtabla.DataSource
            dv.RowFilter = String.Format("Empleado Like '%{0}%'", txtnombreB.Text)
            lblcantidad.Text = dv.Count
            dgbtabla.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub lblcodeJefeInme_TextChanged(sender As Object, e As EventArgs) Handles lblcodeJefeInme.TextChanged
        Try
            With objEmp
                .codigo_ = lblcodeJefeInme.Text
            End With
            Dim dt As New DataTable
            dt = objEmp.BuscarEmpleadosPorCodigo()
            Dim row As DataRow = dt.Rows(0)
            txtjefeInmediato.Text = CStr(row("nombreCompleto"))
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblcodeTalentoHumano_TextChanged(sender As Object, e As EventArgs) Handles lblcodeDepto.TextChanged
        'Try
        '    Dim objEmp As New ClsEmpleados
        '    With objEmp
        '        .codigo_ = lblcodeDepto.Text
        '    End With
        '    Dim dt As New DataTable
        '    dt = objEmp.BuscarEmpleadosPorCodigo()
        '    Dim row As DataRow = dt.Rows(0)
        '    txtDepto.Text = CStr(row("nombreCompleto"))
        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub lblcodigoEmpleado_TextChanged(sender As Object, e As EventArgs) Handles lblcodigoEmpleado.TextChanged
        Try
            With objEmp
                .codigo_ = lblcodigoEmpleado.Text
            End With
            Dim dt As New DataTable
            dt = objEmp.BuscarEmpleadosPorCodigo()
            Dim row As DataRow = dt.Rows(0)
            txtEmpleado.Text = CStr(row("nombreCompleto"))
            lblcodeDepto.Text = CStr(row("codigoDepto"))
            txtDepto.Text = CStr(row("Departamento"))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtjefeInmediato_TextChanged_1(sender As Object, e As EventArgs) Handles txtjefeInmediato.TextChanged
        If txtjefeInmediato.Text <> "" Then
            txtjefeInmediato.BackColor = Color.White
        End If

    End Sub

    Private Sub txtTalentoHumano_TextChanged_1(sender As Object, e As EventArgs) Handles txtDepto.TextChanged
        If txtDepto.Text <> "" Then
            txtDepto.BackColor = Color.White
        End If
    End Sub

    Private Sub txtEmpleado_TextChanged_1(sender As Object, e As EventArgs) Handles txtEmpleado.TextChanged
        If txtEmpleado.Text <> "" Then
            txtEmpleado.BackColor = Color.White
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        RH_TipoPermiso.Show()
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicial.TextChanged
        'txtTotalDias.Text = DateDiff(DateInterval.Day, dtpFechaInicial.Value, dtpFechaFinal.Value)
        Dim difference As TimeSpan = dtpFechaFinal.Value.Subtract(dtpFechaInicial.Value)
        txtTotalDias.Text = Math.Round(difference.TotalDays, 0)
    End Sub

    Private Sub btnTipoPermiso_Click(sender As Object, e As EventArgs) Handles btnTipoPermiso.Click
        RH_TipoPermiso.lblform.Text = "M_Permisos"
        RH_TipoPermiso.Show()
    End Sub

    Private Sub dtpFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFinal.TextChanged
        'txtTotalDias.Text = DateDiff(DateInterval.Day, dtpFechaFinal.Value, dtpFechaInicial.Value)
        Dim difference As TimeSpan = dtpFechaFinal.Value.Subtract(dtpFechaInicial.Value)
        txtTotalDias.Text = Math.Round(difference.TotalDays, 0)
    End Sub



End Class