Public Class RH_BuscarEmpleados
    Private Sub M_BuscarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeleccionarEmpleados()
        alternarColoFilasDatagridview(dgbtabla)
        'OCULTAR COLUMNAS
        Me.dgbtabla.Columns("codigoDepto").Visible = False

        'CAMBIO DE NOMBRE COLUMNAS
        dgbtabla.Columns("codigo").HeaderText = "Código"
        dgbtabla.Columns("nombreCompleto").HeaderText = "Nombre Empleado"
        dgbtabla.Columns("PuestoTrabajo").HeaderText = "Puesto de Trabajo"
    End Sub
    Public Sub SeleccionarEmpleados()
        Dim objEmp As New ClsEmpleados
        Dim dv As DataView = objEmp.SeleccionarEmpleados.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea ver los datos del empleado?", MsgBoxStyle.YesNo)
            End If
            If n = vbYes Then
                RH_Empleados.limpiar()
                Dim objEmp As New ClsEmpleados
                objEmp.codigo_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()

                Dim dt As New DataTable
                dt = objEmp.BuscarDatosEmpleadoPorCodigo()
                Dim row As DataRow = dt.Rows(0)

                RH_Empleados.txtcodigo.Text = CStr(row("codigo"))

                RH_Empleados.txtnombre1.Text = CStr(row("nombre1"))
                RH_Empleados.txtnombre2.Text = CStr(row("nombre2"))
                RH_Empleados.txtapellido1.Text = CStr(row("apellido1"))
                RH_Empleados.txtapellido2.Text = CStr(row("apellido2"))
                RH_Empleados.txtnombreCompleto.Text = CStr(row("nombreCompleto"))
                RH_Empleados.lblcodigoArea.Text = CStr(row("codigoArea"))
                'RH_Empleados.txtcodigoArea.Text = CStr(row("numero"))
                RH_Empleados.dtpfechaAlta.Text = CStr(row("fechaAlta"))
                RH_Empleados.mtxtidentidad.Text = CStr(row("nIdentidad"))


                RH_Empleados.txtseguroSocial.Text = CStr(row("nSeguroSocial"))
                'RH_Empleados.txtseguroVida.Text = CStr(row("nSeguroVida"))
                RH_Empleados.txtcodigoHorario.Text = CStr(row("codigoHorario"))
                RH_Empleados.txtbanco.Text = CStr(row("banco"))
                RH_Empleados.txtcuentaBancaria.Text = CStr(row("cuentaBancaria"))
                'RH_Empleados.txtcodigoFormaPago.Text = CStr(row("codigoFormaPago"))

                If IsDBNull(row("fechaBaja")) = False Then
                    RH_Empleados.dtpfechaBaja.Format = DateTimePickerFormat.Short
                    RH_Empleados.dtpfechaBaja.Text = CStr(row("fechaBaja"))
                Else
                    RH_Empleados.dtpfechaBaja.Format = DateTimePickerFormat.Custom
                    RH_Empleados.dtpfechaBaja.CustomFormat = " "
                End If

                If IsDBNull(row("fechaAvisoBaja")) = False Then
                    RH_Empleados.dtpFechaAvisoBaja.Format = DateTimePickerFormat.Short
                    RH_Empleados.dtpFechaAvisoBaja.Value = Date.Parse(row("fechaAvisoBaja"))
                Else
                    RH_Empleados.dtpFechaAvisoBaja.Format = DateTimePickerFormat.Custom
                    RH_Empleados.dtpFechaAvisoBaja.CustomFormat = " "
                End If

                RH_Empleados.rtxtmotivoBaja.Text = CStr(row("motivoBaja"))
                RH_Empleados.lblcodeDepto.Text = CStr(row("codigoDepto"))
                RH_Empleados.lblcodePuesto.Text = CStr(row("codigoPuestoTrab"))
                RH_Empleados.txtsalario.Text = Convert.ToDecimal(CStr(row("salario"))).ToString("N2")
                'RH_Empleados.cmbxtipoCuenta.SelectedItem = CStr(row("tipoCuenta"))

                RH_Empleados.llenarContratos()
                RH_Empleados.cmbxcodigoContrato.SelectedValue = CStr(row("codigoContrato"))
                RH_Empleados.cmbxestadoLaboral.SelectedItem = CStr(row("estadoLaboral"))
                RH_Empleados.rtxtdireccion.Text = CStr(row("direccion1"))
                RH_Empleados.rtxtdireccion2.Text = CStr(row("direccion2"))
                RH_Empleados.txtcorreo.Text = CStr(row("correo1"))
                RH_Empleados.txtcorreo2.Text = CStr(row("correo2"))
                RH_Empleados.txttelefono.Text = CStr(row("telefono"))
                RH_Empleados.txtcelular.Text = CStr(row("celular"))
                RH_Empleados.txtRTN.Text = CStr(row("rtn"))
                RH_Empleados.dtpfechaNacimiento.Text = CStr(row("fechaNacimiento"))
                RH_Empleados.rtxtlugarNacimiento.Text = CStr(row("lugarNacimiento"))
                RH_Empleados.txtcodigoProfesion.Text = CStr(row("codigoProfesion"))

                RH_Empleados.txtgrupoSanguineo.Text = CStr(row("grupoSanguineo"))
                RH_Empleados.txtcontactoUrgencias.Text = CStr(row("contactoUrgencias"))
                RH_Empleados.txttelUrgencias.Text = CStr(row("telUrgencias"))
                RH_Empleados.txtcelularUrgencias.Text = CStr(row("celUrgencias"))
                RH_Empleados.txtnombreConyugue.Text = CStr(row("nombreConyugue"))
                RH_Empleados.txtParentesco1.Text = CStr(row("parentesco1"))
                RH_Empleados.txtParentesco2.Text = CStr(row("parentesco2"))

                RH_Empleados.txtnombrePadre.Text = CStr(row("nombrePadre"))

                RH_Empleados.txtnombreMadre.Text = CStr(row("nombreMadre"))
                If CStr(row("genero")) = "Masculino" Then
                    RH_Empleados.rbtnmasculino.Checked = True
                Else
                    RH_Empleados.rbtnfemenino.Checked = True
                End If

                'contacto urgencias 2
                RH_Empleados.txtcontactoUrgencias2.Text = CStr(row("contactoUrgencias2"))
                RH_Empleados.txttelUrgencias2.Text = CStr(row("telUrgencias2"))
                RH_Empleados.txtcelularUrgencias2.Text = CStr(row("celUrgencias2"))

                'radio boton 
                RH_Empleados.lblEstadoCvl2.Text = CStr(row("estadoCivil"))

                ''imagen 
                'If IsDBNull(row("imagen")) = False Or Trim(row("imagen").ToString) <> "" Then
                If Trim(row("imagen").ToString) <> "" Then
                    RH_Empleados.txtRuta.Text = CStr(row("imagen"))
                    RH_Empleados.pbxEmpleado.LoadAsync(row("imagen"))
                End If

                'datos medicos
                RH_Empleados.rtxtAAlimentos.Text = CStr(row("alergiaAli"))
                RH_Empleados.rtxtAMedicamentos.Text = CStr(row("alergiaMed"))
                RH_Empleados.rtxtCondicionesE.Text = CStr(row("condicionesEspe"))

                'boton de actualizar
                RH_Empleados.btnGuardar.Enabled = False
                RH_Empleados.btnModificar.Enabled = True
                RH_Empleados.lblform.Text = "M_BuscarEmpleados"
                RH_Empleados.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcodigoB_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoB.TextChanged
        If (txtcodigoB.Text <> "") Then
            Try
                Dim objEmp As New ClsEmpleados
                objEmp.codigo_ = txtcodigoB.Text
                Dim dv As DataView = objEmp.BuscarEmpleadosPorCodigo.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            Catch ex As Exception
                MsgBox("No existe el empleados con el respectivo código.", MsgBoxStyle.Information, "Validación")
            End Try
        Else
            SeleccionarEmpleados()
        End If
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        If (txtnombreB.Text <> "") Then
            Try
                Dim objEmp As New ClsEmpleados
                objEmp.NombreCompleto_ = txtnombreB.Text
                Dim dv As DataView = objEmp.BuscarEmpleadosPorNombre.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            Catch ex As Exception
                MsgBox("No existe la empleado con ese nombre.", MsgBoxStyle.Information, "Validación")
            End Try
        Else
            SeleccionarEmpleados()
        End If
    End Sub
    Private Sub btnnueva_Click(sender As Object, e As EventArgs)
        'Me.Close()
        RH_Empleados.llenarContratos()
        RH_Empleados.limpiar()
        RH_Empleados.lblform.Text = "M_BuscarEmpleados"
        RH_Empleados.Show()
    End Sub


End Class