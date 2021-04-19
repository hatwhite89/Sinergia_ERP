Public Class RH_ListadoEmpleados
    Private Sub M_ListadoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeleccionarEmpleados()
        Me.dgbtabla.Columns("codigoDepto").Visible = False
        lblform.Visible = False
        lblfila.Visible = False
        alternarColoFilasDatagridview(dgbtabla)
    End Sub
    Public Sub SeleccionarEmpleados()
        Dim objEmp As New ClsEmpleados
        Dim dv As DataView = objEmp.SeleccionarEmpleados.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            If lblform.Text = "M_Permisos_JefeInmediato" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    RH_Permisos.lblcodeJefeInme.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    RH_Permisos.txtjefeInmediato.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            ElseIf lblform.Text = "M_Permisos_TalentoHumano" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    RH_Permisos.lblcodeDepto.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    RH_Permisos.txtDepto.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            ElseIf lblform.Text = "M_Permisos_Empleado" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'EMPLEADO
                    RH_Permisos.lblcodigoEmpleado.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    RH_Permisos.txtEmpleado.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()

                    'DEPARTAMENTO
                    RH_Permisos.lblcodeDepto.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value()
                    RH_Permisos.txtDepto.Text = dgbtabla.Rows(e.RowIndex).Cells(4).Value()

                    'buscar el jefe inmediato del empleado
                    Dim objEmp As New ClsPermisos
                    With objEmp
                        '.codigoDepto_ = Convert.ToInt64(dgbtabla.Rows(e.RowIndex).Cells(2).Value())
                    End With
                    Dim dt As New DataTable
                    'dt = objEmp.BuscarPermisoJefeInmediato()
                    dt = objEmp.BuscarPermisoJefeInmediato(Convert.ToInt64(dgbtabla.Rows(e.RowIndex).Cells(2).Value()))
                    Dim row As DataRow = dt.Rows(0)
                    RH_Permisos.lblcodeJefeInme.Text = CStr(row("codigo"))
                    RH_Permisos.txtjefeInmediato.Text = CStr(row("nombreCompleto"))

                    'buscar el jefe de talento humano
                    'dt = objEmp.BuscarJefeTalentoHumano()
                    'row = dt.Rows(0)
                    'M_Permisos.lblcodeDepto.Text = CStr(row("codigo"))
                    'M_Permisos.txtDepto.Text = CStr(row("nombreCompleto"))
                    Me.Close()
                End If
            ElseIf lblform.Text = "M_Vacaciones_Depto" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_Vacaciones.lblcodeJefeDepto.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    'M_Vacaciones.txtJefeDepto.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            ElseIf lblform.Text = "M_Vacaciones_Humano" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_Vacaciones.lblcodeTalHum.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    'M_Vacaciones.txtTalentoHumano.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            ElseIf lblform.Text = "M_Vacaciones_Supervisor" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_Vacaciones.lblcodeSupervisor.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    'M_Vacaciones.txtSupervisor.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            ElseIf lblform.Text = "M_Vacaciones_Empleado" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    RH_Vacaciones.lblcodeEmpleado.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    RH_Vacaciones.txtEmpleado.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    'M_Vacaciones.txtFirmaEmpleado.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()

                    ''buscar el jefe inmediato del empleado
                    'Dim objEmp As New ClsPermisos
                    'With objEmp
                    '    '.codigoDepto_ = Convert.ToInt64(dgbtabla.Rows(e.RowIndex).Cells(2).Value())
                    'End With
                    'Dim dt As New DataTable
                    'dt = objEmp.BuscarPermisoJefeInmediato(Convert.ToInt64(dgbtabla.Rows(e.RowIndex).Cells(2).Value()))
                    ''dt = objEmp.BuscarPermisoJefeInmediato()
                    'Dim row As DataRow = dt.Rows(0)
                    'M_Vacaciones.lblcodeJefeDepto.Text = CStr(row("codigo"))
                    'M_Vacaciones.txtJefeDepto.Text = CStr(row("nombreCompleto"))

                    ''buscar el jefe de talento humano
                    'dt = objEmp.BuscarJefeTalentoHumano()
                    'row = dt.Rows(0)
                    'M_Vacaciones.lblcodeTalHum.Text = CStr(row("codigo"))
                    'M_Vacaciones.txtTalentoHumano.Text = CStr(row("nombreCompleto"))
                    Me.Close()
                End If
            ElseIf lblform.Text = "A_Planilla" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then

                    'If A_Planilla.validarEmpleados(dgbtabla.Rows(e.RowIndex).Cells(0).Value()) Then

                    '    Dim objEmp As New ClsEmpleados
                    '    objEmp.codigo_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()

                    '    Dim dt As New DataTable
                    '    dt = objEmp.BuscarDatosEmpleadoPorCodigo()
                    '    Dim row As DataRow = dt.Rows(0)
                    '    Dim porcentaje As Single

                    '    porcentaje = Single.Parse(row("salario")) * 0.3



                    '    'A_Planilla.dgvEmpleados.Rows.Insert(lblfila.Text.ToString, New String() {"", CStr(row("codigo")), row("nIdentidad"), row("cuentaBancaria"), row("nombreCompleto"), row("salario"), porcentaje})

                    '    'A_Planilla.dgvEmpleados.Rows.Insert(lblfila.Text.ToString, New String() {"", dgbtabla.Rows(e.RowIndex).Cells(0).Value(), dgbtabla.Rows(e.RowIndex).Cells(1).Value(), dgbtabla.Rows(e.RowIndex).Cells(3).Value(), dgbtabla.Rows(e.RowIndex).Cells(4).Value()})
                    '    'A_Planilla.lblcantidad.Text = A_Planilla.dgvEmpleados.Rows.Count - 1
                    '    'MsgBox("El empleado a sido agregado en la capacitación con éxito.", MsgBoxStyle.Information)
                    '    'Me.Close()
                    'Else
                    '    MsgBox("El empleado ya a sido agregado en la planilla.", MsgBoxStyle.Information)
                    'End If
                End If

                'Capturar nombre y codigo para form usuarios
            ElseIf lblform.Text = "M_Capacitaciones" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    If RH_Capacitaciones.validarBeneficiarios(dgbtabla.Rows(e.RowIndex).Cells(0).Value()) Then
                        RH_Capacitaciones.dgvBeneficiarios.Rows.Insert(lblfila.Text.ToString, New String() {"", dgbtabla.Rows(e.RowIndex).Cells(0).Value(), dgbtabla.Rows(e.RowIndex).Cells(1).Value(), dgbtabla.Rows(e.RowIndex).Cells(3).Value(), dgbtabla.Rows(e.RowIndex).Cells(4).Value()})
                        'MsgBox("El empleado a sido agregado en la capacitación con éxito.", MsgBoxStyle.Information)
                        'Me.Close()
                    Else
                        MsgBox("El empleado ya a sido agregado en la capacitación.", MsgBoxStyle.Information)
                    End If
                End If

                'Capturar nombre y codigo para form usuarios
            ElseIf lblform.Text = "E_Usuarios" Then

                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'E_Usuarios.lblCodEmpleado.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    'E_Usuarios.txtNombreEmpleado.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            ElseIf lblform.Text = "M_ReporteriaTalentoHumano" Then
                'Capturar nombre y codigo para Formulario Reporteria Talento Humano

                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_ReporteriaTalentoHumano.lblcodeEmpleado.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    'M_ReporteriaTalentoHumano.txtnombreEmpleado.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            ElseIf lblform.Text = "MM_Conserje" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'MM_Conserje.txtCodEmpleado.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    'MM_Conserje.txtNombreEmpleado.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcodigoB_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoB.TextChanged
        If (txtCodigoB.Text <> "") Then
            Try
                Dim objEmp As New ClsEmpleados
                objEmp.codigo_ = txtCodigoB.Text
                Dim dv As DataView = objEmp.BuscarEmpleadosPorCodigo.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe el empleados con el respectivo código.", MsgBoxStyle.Information, "Validación")
            End Try
        Else
            SeleccionarEmpleados()
        End If
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
        If (txtNombreB.Text <> "") Then
            Try
                Dim objEmp As New ClsEmpleados
                objEmp.NombreCompleto_ = txtNombreB.Text
                Dim dv As DataView = objEmp.BuscarEmpleadosPorNombre.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la empleado con ese nombre.", MsgBoxStyle.Information, "Validación")
            End Try
        Else
            SeleccionarEmpleados()
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        RH_Empleados.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class