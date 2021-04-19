Public Class RH_Empleados
    Dim Imagen As String
    Private strAcentos As String = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç"
    'Dim img As Image
    'Dim datos As Byte()
    Private Sub btnProfesion_Click(sender As Object, e As EventArgs) Handles btnProfesion.Click
        RH_Profesion.lblform.Text = "Empleados"
        RH_Profesion.Show()
    End Sub
    Public Sub limpiar()
        Try
            txtcodigo.Text = ""
            txtnombre1.Text = ""
            txtnombre2.Text = ""
            txtapellido1.Text = ""
            txtapellido2.Text = ""
            txtnombreCompleto.Text = ""
            lblcodigoArea.Text = ""
            txtArea.Text = ""
            dtpfechaAlta.Value = Date.Now
            mtxtidentidad.Text = ""

            txtseguroSocial.Text = ""
            'txtseguroVida.Text = ""
            txtcodigoHorario.Text = ""
            txtbanco.Text = ""
            txtcuentaBancaria.Text = ""
            txtcodigoFormaPago.Text = ""

            rtxtmotivoBaja.Text = ""
            lblcodePuesto.Text = ""
            txtPuestoTrabajo.Text = ""
            lblcodeDepto.Text = ""
            txtdepartamento.Text = ""
            txtsalario.Text = ""
            'cmbxtipoCuenta.SelectedItem = ""
            cmbxcodigoContrato.SelectedValue = "1"
            cmbxestadoLaboral.SelectedItem = ""
            rtxtdireccion.Text = ""
            rtxtdireccion2.Text = ""
            txtcorreo.Text = ""
            txtcorreo2.Text = ""
            txttelefono.Text = ""
            txtcelular.Text = ""
            txtRTN.Text = ""
            dtpfechaNacimiento.Value = Date.Now
            rtxtlugarNacimiento.Text = ""
            txtcodigoProfesion.Text = ""

            'caso de emergencias
            txtgrupoSanguineo.Text = ""
            txtcontactoUrgencias.Text = ""
            txtParentesco1.ResetText()
            txttelUrgencias.Text = ""
            txtcelularUrgencias.Text = ""

            txtcontactoUrgencias2.Text = ""
            txtParentesco2.ResetText()
            txttelUrgencias2.Text = ""
            txtcelularUrgencias2.Text = ""


            txtnombreConyugue.Text = ""
            txtnombrePadre.Text = ""
            txtnombreMadre.Text = ""

            rbtnmasculino.Checked = True
            lblEstadoCvl.Text = "Soltero"
            rbtnsoltero.Checked = True

            dtpfechaBaja.Format = DateTimePickerFormat.Custom
            dtpfechaBaja.CustomFormat = " "

            dtpFechaAvisoBaja.Format = DateTimePickerFormat.Custom
            dtpFechaAvisoBaja.CustomFormat = " "

            btnModificar.Enabled = False
            btnGuardar.Enabled = True

            lblform.Text = ""


            'picture box
            pbxEmpleado.Image = Nothing
            txtRuta.Text = ""

            btnImprimirCarnet.Enabled = True
            'habilitar el boton para imprimir el carnet en caso que sea permanente
            'If cmbxcodigoContrato.SelectedValue.ToString = "1" Then
            '    btnImprimirCarnet.Enabled = True
            'Else
            '    btnImprimirCarnet.Enabled = False
            'End If

        Catch ex As Exception
            MsgBox("En la limpieza: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcodigoProfesion_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoProfesion.TextChanged
        If (txtcodigoProfesion.Text <> "") Then
            Try
                Dim objProf As New ClsProfesion
                With objProf
                    .Codigo_ = txtcodigoProfesion.Text
                End With
                Dim dt As New DataTable
                dt = objProf.BuscarProfesionCode()
                Dim row As DataRow = dt.Rows(0)
                txtdescripcionProfesion.Text = CStr(row("descripcion"))
                txtcodigoProfesion.BackColor = Color.White
            Catch ex As Exception
                txtcodigoProfesion.BackColor = Color.Red
                txtdescripcionProfesion.Text = ""
            End Try
        Else
            txtcodigoProfesion.Text = ""
            txtdescripcionProfesion.Text = ""
            txtcodigoProfesion.BackColor = Color.White
        End If
    End Sub

    Private Sub lblcodePuesto_TextChanged(sender As Object, e As EventArgs) Handles lblcodePuesto.TextChanged
        If (lblcodePuesto.Text <> "") Then
            Try
                Dim objPuesto As New ClsPuestoTrabajo
                With objPuesto
                    .Codigo_ = lblcodePuesto.Text
                End With
                Dim dt As New DataTable
                dt = objPuesto.BuscarPuestoTrabajoCode()
                Dim row As DataRow = dt.Rows(0)
                txtPuestoTrabajo.Text = CStr(row("descripcion"))
                txtPuestoTrabajo.BackColor = Color.White
            Catch ex As Exception
                txtPuestoTrabajo.BackColor = Color.Red
                txtPuestoTrabajo.Text = ""
                lblcodePuesto.Text = ""
            End Try
        Else
            lblcodePuesto.Text = ""
            txtPuestoTrabajo.Text = ""
            txtPuestoTrabajo.BackColor = Color.White
        End If
    End Sub

    Private Sub lblcodigoArea_TextChanged(sender As Object, e As EventArgs) Handles lblcodigoArea.TextChanged
        If (lblcodigoArea.Text <> "") Then
            Try
                Dim objArea As New ClsArea
                With objArea
                    .codigo_ = lblcodigoArea.Text
                End With
                Dim dt As New DataTable
                dt = objArea.BuscarArea()
                Dim row As DataRow = dt.Rows(0)
                txtArea.Text = CStr(row("nombre"))
                txtArea.BackColor = Color.White
            Catch ex As Exception
                txtArea.BackColor = Color.Red
                txtArea.Text = ""
                lblcodigoArea.Text = ""
            End Try
        End If
    End Sub
    Private Sub lblcodeDepto_TextChanged(sender As Object, e As EventArgs) Handles lblcodeDepto.TextChanged
        If (lblcodeDepto.Text <> "") Then
            Try
                Dim objDepto As New ClsDepartamento
                With objDepto
                    .codigo_ = lblcodeDepto.Text
                End With
                Dim dt As New DataTable
                dt = objDepto.BuscarDepartamento()
                Dim row As DataRow = dt.Rows(0)
                txtdepartamento.Text = CStr(row("nombre"))
                txtdepartamento.BackColor = Color.White
            Catch ex As Exception
                txtdepartamento.BackColor = Color.Red
                lblcodeDepto.Text = ""
            End Try
        Else
            txtdepartamento.Text = ""
            lblcodeDepto.Text = ""
            txtdepartamento.BackColor = Color.White
        End If
    End Sub

    Private Sub dtpfechaBaja_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpfechaBaja.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpfechaBaja.Format = DateTimePickerFormat.Short
                dtpfechaBaja.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpfechaBaja.Format = DateTimePickerFormat.Custom
                dtpfechaBaja.CustomFormat = " "
        End Select

    End Sub
    Private Sub dtpFechaAvisoBaja_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpFechaAvisoBaja.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpFechaAvisoBaja.Format = DateTimePickerFormat.Short
                dtpFechaAvisoBaja.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpFechaAvisoBaja.Format = DateTimePickerFormat.Custom
                dtpFechaAvisoBaja.CustomFormat = " "
        End Select

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
    Private Sub lblEstadoOrden_TextChanged(sender As Object, e As EventArgs) Handles lblEstadoCvl2.TextChanged
        Try
            Select Case lblEstadoCvl2.Text
                Case "Soltero"
                    rbtnsoltero.Checked = True
                Case "Casado"
                    rbtncasado.Checked = True
                Case "Viudo"
                    rbtnviudo.Checked = True
                Case "Divorciado"
                    rbtndivorciado.Checked = True
                Case "Separado"
                    rbtnseparado.Checked = True
                Case "Concuvinado"
                    rbtnconcuvinato.Checked = True
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub RadioButtonX_CheckedChanged(sender As Object, e As EventArgs) Handles rbtncasado.CheckedChanged, rbtnconcuvinato.CheckedChanged,
                                                rbtndivorciado.CheckedChanged, rbtnseparado.CheckedChanged, rbtnsoltero.CheckedChanged,
                                                rbtnviudo.CheckedChanged
        Try
            Select Case sender.name
                Case "rbtnsoltero"
                    lblEstadoCvl.Text = "Soltero"
                Case "rbtncasado"
                    lblEstadoCvl.Text = "Casado"
                Case "rbtnviudo"
                    lblEstadoCvl.Text = "Viudo"
                Case "rbtndivorciado"
                    lblEstadoCvl.Text = "Divorciado"
                Case "rbtnseparado"
                    lblEstadoCvl.Text = "Separado"
                Case "rbtnconcuvinato"
                    lblEstadoCvl.Text = "Concuvinado"
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Public Sub SaveRecord()
        For Each item As Control In GroupBox1.Controls
            If String.IsNullOrEmpty(item.Text) Then
                ''inform the user that all fields should have a value
                MsgBox("Please fill up all fields............." & item.Name)
                item.Focus()
                Exit Sub
            End If
        Next
        If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            ''save the record
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If Trim(txtnombreCompleto.Text) = "" Then
                MsgBox("Debe llenar los campos faltantes.", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Trim(txtnombre1.Text) <> "" Then
                sinDobleEspacio(txtnombre1.Text)
            End If
            If Trim(txtnombre2.Text) <> "" Then
                sinDobleEspacio(txtnombre2.Text)
            End If
            If Trim(txtapellido1.Text) <> "" Then
                sinDobleEspacio(txtapellido1.Text)
            End If
            If Trim(txtapellido2.Text) <> "" Then
                sinDobleEspacio(txtapellido2.Text)
            End If
            'If Trim(txtpagoPaciente.Text) = "" Then
            '    txtpagoPaciente.Text = "0"
            'End If
            Dim genero As String = ""
            If (rbtnmasculino.Checked) Then
                genero = "Masculino"
            ElseIf (rbtnfemenino.Checked) Then
                genero = "Femenino"
            Else
                genero = ""
                MsgBox("Debe seleccionar el genero del empleado.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim dt As New DataTable
            'Dim row As DataRow
            Dim band As Boolean = False
            If Trim(txttelefono.Text) <> "" Or Trim(txtcelular.Text) <> "" Then
                band = True
            End If

            Dim band2 As Boolean = False
            If Trim(txtcelularUrgencias.Text) <> "" Or Trim(txttelUrgencias.Text) <> "" Then
                band2 = True
            End If

            If (mtxtidentidad.MaskCompleted And Trim(txtcodigoHorario.Text) <> "" And Trim(txtapellido1.Text) <> "" And Trim(txtnombre1.Text) <> "" And
                Trim(txtbanco.Text) <> "" And Trim(lblcodigoArea.Text) <> "" And
                Trim(lblcodeDepto.Text) <> "" And Trim(lblcodePuesto.Text) <> "" And Trim(txtsalario.Text) <> "" And txtnombreCompleto.Text <> "" And
                Trim(rtxtdireccion.Text) <> "" And Trim(txtcodigoProfesion.Text) <> "" And band And Trim(txtgrupoSanguineo.Text) <> "" And
                Trim(txtcontactoUrgencias.Text) <> "" And band2) Then

                Dim objEmp As New ClsEmpleados
                With objEmp
                    .Nombre1_ = txtnombre1.Text
                    .Nombre2_ = txtnombre2.Text
                    .Apellido1_ = txtapellido1.Text
                    .Apellido2_ = txtapellido2.Text
                    .NombreCompleto_ = txtnombreCompleto.Text
                    .codigoArea_ = Convert.ToInt64(lblcodigoArea.Text)
                    .fechaAlta_ = dtpfechaAlta.Value
                    .nIdentidad_ = mtxtidentidad.Text

                    .nSeguroSocial_ = txtseguroSocial.Text
                    '.nSeguroVida_ = txtseguroVida.Text
                    .codigoHorario_ = Convert.ToInt64(txtcodigoHorario.Text)
                    .banco_ = txtbanco.Text
                    .cuentaBancaria_ = txtcuentaBancaria.Text
                    '.codigoFormaPago_ = Convert.ToInt64(txtcodigoFormaPago.Text)
                    'MsgBox("antes de la valicacion fecha baja")
                    If Trim(dtpfechaBaja.Text) <> "" Then
                        .fechaBaja_ = dtpfechaBaja.Value
                    Else
                        .fechaBaja_ = Nothing
                    End If
                    If Trim(dtpFechaAvisoBaja.Text) <> "" Then
                        .fechaAvisoBaja_ = dtpFechaAvisoBaja.Value
                    Else
                        .fechaAvisoBaja_ = Nothing
                    End If
                    '.fechaBaja_ = dtpfechaBaja.Text
                    '.fechaAvisoBaja_ = dtpFechaAvisoBaja.Text
                    'MsgBox("paso")
                    .motivoBaja_ = rtxtmotivoBaja.Text
                    .codigoPuestoTrab_ = Convert.ToInt64(lblcodePuesto.Text)
                    .codigoDepto_ = Convert.ToInt64(lblcodeDepto.Text)
                    .salario_ = Convert.ToDouble(txtsalario.Text)
                    '.tipoCuenta_ = cmbxtipoCuenta.SelectedItem.ToString

                    '.codigoContrato_ = Convert.ToInt64("1")
                    .codigoContrato_ = Integer.Parse(cmbxcodigoContrato.SelectedValue)
                    .estadoLaboral_ = cmbxestadoLaboral.SelectedItem.ToString
                    .direccion1_ = rtxtdireccion.Text
                    .direccion2_ = rtxtdireccion2.Text
                    .correo1_ = txtcorreo.Text
                    .correo2_ = txtcorreo2.Text
                    .telefono_ = txttelefono.Text
                    .celular_ = txtcelular.Text
                    .rtn_ = txtRTN.Text
                    .fechaNacimiento_ = dtpfechaNacimiento.Value
                    .lugarNacimiento_ = rtxtlugarNacimiento.Text
                    .codigoProfesion_ = txtcodigoProfesion.Text

                    .grupoSangineo_ = txtgrupoSanguineo.Text
                    .contactoUrgencias_ = txtcontactoUrgencias.Text
                    .telUrgencias_ = txttelUrgencias.Text
                    .celUrgencias_ = txtcelularUrgencias.Text
                    .nombreConyugue_ = txtnombreConyugue.Text
                    .nombrePadre_ = txtnombrePadre.Text
                    .nombreMadre_ = txtnombreMadre.Text
                    .genero_ = genero
                    .estadoCivil_ = lblEstadoCvl.Text
                    'imagen
                    .imagen_ = txtRuta.Text
                    .contactoUrgencias2_ = txtcontactoUrgencias2.Text
                    .telUrgencias2_ = txttelUrgencias2.Text
                    .celUrgencias2_ = txtcelularUrgencias2.Text
                    'Datos Medicos
                    .alergiaAli_ = rtxtAAlimentos.Text
                    .alergiaMed_ = rtxtAMedicamentos.Text
                    .condicionesEspe_ = rtxtCondicionesE.Text
                    .Parentesco1_ = txtParentesco1.Text
                    .Parentesco2_ = txtParentesco2.Text
                End With

                If objEmp.RegistrarNuevoEmpleados() = 1 Then

                    MsgBox("Registrado el empleado correctamente.", MsgBoxStyle.Information)

                    dt = objEmp.CapturarEmpleados()
                    Dim row As DataRow = dt.Rows(0)
                    txtcodigo.Text = CStr(row("codigo"))

                    btnGuardar.Enabled = False
                    btnModificar.Enabled = True

                    'actualizar la tabla
                    RH_BuscarEmpleados.SeleccionarEmpleados()
                    '::::::::::::::::::::::::::::::::::::::::::::: INSERTAR BITACORA ::::::::::::::::::::::
                    'Dim Bitacora As New ClsBitacora

                    'With Bitacora
                    '    .usuario_ = "1"
                    '    .accion_ = "Creación de un empleado."
                    '    .fecha_ = Date.Now
                    '    .registrarBitacora()
                    'End With
                    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                Else
                    MsgBox("Error al querer registrar el empleado.", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtnombre1_TextChanged(sender As Object, e As EventArgs) Handles txtnombre1.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub

    Private Sub txtnombre1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre1.KeyPress

        If strAcentos.IndexOf(e.KeyChar) > 0 Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        'txtnombre1.Select(txtnombre1.Text.Length, 0)
    End Sub
    Private Sub txtnombre2_TextChanged_1(sender As Object, e As EventArgs) Handles txtnombre2.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub
    Private Sub txtnombre2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre2.KeyPress

        If strAcentos.IndexOf(e.KeyChar) > 0 Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        'txtnombre2.Select(txtnombre2.Text.Length, 0)
    End Sub
    Private Sub txtapellido1_TextChanged_1(sender As Object, e As EventArgs) Handles txtapellido1.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub

    Private Sub txtapellido1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido1.KeyPress

        If strAcentos.IndexOf(e.KeyChar) > 0 Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        'txtapellido1.Select(txtapellido1.Text.Length, 0)
    End Sub
    Private Sub txtapellido2_TextChanged(sender As Object, e As EventArgs) Handles txtapellido2.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub
    Private Sub txtapellido2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido2.KeyPress

        If strAcentos.IndexOf(e.KeyChar) > 0 Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        'txtapellido2.Select(txtapellido2.Text.Length, 0)
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            If Trim(txtnombreCompleto.Text) = "" Then
                MsgBox("Debe llenar los campos faltantes.", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Trim(txtnombre1.Text) <> "" Then
                sinDobleEspacio(txtnombre1.Text)
            End If
            If Trim(txtnombre2.Text) <> "" Then
                sinDobleEspacio(txtnombre2.Text)
            End If
            If Trim(txtapellido1.Text) <> "" Then
                sinDobleEspacio(txtapellido1.Text)
            End If
            If Trim(txtapellido2.Text) <> "" Then
                sinDobleEspacio(txtapellido2.Text)
            End If
            'If Trim(txtpagoPaciente.Text) = "" Then
            '    txtpagoPaciente.Text = "0"
            'End If
            Dim genero As String = ""
            If (rbtnmasculino.Checked) Then
                genero = "Masculino"
            ElseIf (rbtnfemenino.Checked) Then
                genero = "Femenino"
            Else
                genero = ""
                MsgBox("Debe seleccionar el genero del empleado.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim dt As New DataTable
            'Dim row As DataRow

            Dim band As Boolean = False
            If Trim(txttelefono.Text) <> "" Or Trim(txtcelular.Text) <> "" Then
                band = True
            End If

            Dim band2 As Boolean = False
            If Trim(txtcelularUrgencias.Text) <> "" Or Trim(txttelUrgencias.Text) <> "" Then
                band2 = True
            End If

            If (txtcodigo.Text <> "" And mtxtidentidad.MaskCompleted And Trim(txtcodigoHorario.Text) <> "" And Trim(txtapellido1.Text) <> "" And Trim(txtnombre1.Text) <> "" And
                Trim(txtbanco.Text) <> "" And Trim(lblcodigoArea.Text) <> "" And
                Trim(lblcodeDepto.Text) <> "" And Trim(lblcodePuesto.Text) <> "" And Trim(txtsalario.Text) <> "" And txtnombreCompleto.Text <> "" And
                Trim(rtxtdireccion.Text) <> "" And Trim(txtcodigoProfesion.Text) <> "" And band And Trim(txtgrupoSanguineo.Text) <> "" And
                Trim(txtcontactoUrgencias.Text) <> "" And band2) Then

                Dim objEmp As New ClsEmpleados
                With objEmp
                    .codigo_ = txtcodigo.Text
                    .Nombre1_ = txtnombre1.Text
                    .Nombre2_ = txtnombre2.Text
                    .Apellido1_ = txtapellido1.Text
                    .Apellido2_ = txtapellido2.Text
                    .NombreCompleto_ = txtnombreCompleto.Text
                    .codigoArea_ = Convert.ToInt64(lblcodigoArea.Text)
                    .fechaAlta_ = dtpfechaAlta.Value
                    .nIdentidad_ = mtxtidentidad.Text

                    .nSeguroSocial_ = txtseguroSocial.Text
                    '.nSeguroVida_ = txtseguroVida.Text
                    .codigoHorario_ = Convert.ToInt64(txtcodigoHorario.Text)
                    .banco_ = txtbanco.Text
                    .cuentaBancaria_ = txtcuentaBancaria.Text
                    '.codigoFormaPago_ = Convert.ToInt64(txtcodigoFormaPago.Text)
                    'MsgBox("antes de la valicacion fecha baja")
                    If Trim(dtpfechaBaja.Text) <> "" Then
                        .fechaBaja_ = dtpfechaBaja.Value
                    Else
                        .fechaBaja_ = Nothing
                    End If
                    If Trim(dtpFechaAvisoBaja.Text) <> "" Then
                        .fechaAvisoBaja_ = dtpFechaAvisoBaja.Value
                    Else
                        .fechaAvisoBaja_ = Nothing
                    End If
                    '.fechaBaja_ = dtpfechaBaja.Text
                    '.fechaAvisoBaja_ = dtpFechaAvisoBaja.Text
                    .motivoBaja_ = rtxtmotivoBaja.Text
                    .codigoPuestoTrab_ = Convert.ToInt64(lblcodePuesto.Text)
                    .codigoDepto_ = Convert.ToInt64(lblcodeDepto.Text)
                    .salario_ = Convert.ToDouble(txtsalario.Text)
                    '.tipoCuenta_ = cmbxtipoCuenta.SelectedItem.ToString

                    '.codigoContrato_ = Convert.ToInt64("1")
                    .codigoContrato_ = Integer.Parse(cmbxcodigoContrato.SelectedValue)
                    .estadoLaboral_ = cmbxestadoLaboral.SelectedItem.ToString
                    .direccion1_ = rtxtdireccion.Text
                    .direccion2_ = rtxtdireccion2.Text
                    .correo1_ = txtcorreo.Text
                    .correo2_ = txtcorreo2.Text
                    .telefono_ = txttelefono.Text
                    .celular_ = txtcelular.Text
                    .rtn_ = txtRTN.Text
                    .fechaNacimiento_ = dtpfechaNacimiento.Value
                    .lugarNacimiento_ = rtxtlugarNacimiento.Text
                    .codigoProfesion_ = txtcodigoProfesion.Text

                    .grupoSangineo_ = txtgrupoSanguineo.Text
                    .contactoUrgencias_ = txtcontactoUrgencias.Text
                    .telUrgencias_ = txttelUrgencias.Text
                    .celUrgencias_ = txtcelularUrgencias.Text
                    .nombreConyugue_ = txtnombreConyugue.Text
                    .nombrePadre_ = txtnombrePadre.Text
                    .nombreMadre_ = txtnombreMadre.Text
                    .genero_ = genero
                    .estadoCivil_ = lblEstadoCvl.Text
                    'imagen
                    .imagen_ = txtRuta.Text
                    .contactoUrgencias2_ = txtcontactoUrgencias2.Text
                    .telUrgencias2_ = txttelUrgencias2.Text
                    .celUrgencias2_ = txtcelularUrgencias2.Text
                    'Datos Medicos
                    .alergiaAli_ = rtxtAAlimentos.Text
                    .alergiaMed_ = rtxtAMedicamentos.Text
                    .condicionesEspe_ = rtxtCondicionesE.Text
                    .Parentesco1_ = txtParentesco1.Text
                    .Parentesco2_ = txtParentesco2.Text
                End With

                If objEmp.ModificarEmpleados() = 1 Then
                    MsgBox("Actualizado los datos del empleado correctamente.", MsgBoxStyle.Information)

                    btnGuardar.Enabled = False
                    btnModificar.Enabled = True

                    'actualizar la tabla
                    RH_BuscarEmpleados.SeleccionarEmpleados()

                    '::::::::::::::::::::::::::::::::::::::::::::: INSERTAR BITACORA ::::::::::::::::::::::
                    'Dim Bitacora As New ClsBitacora

                    'With Bitacora
                    '    .usuario_ = "1"
                    '    .accion_ = "Creación de un empleado."
                    '    .fecha_ = Date.Now
                    '    .registrarBitacora()
                    'End With
                    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                Else
                    MsgBox("Error al querer actualizar los datos del empleado.", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub llenarContratos()
        'llenar el combo box CONTRATOS
        Try
            Dim objContratos As New ClsContratos
            Dim dt As New DataTable
            dt = objContratos.SeleccionarContratos

            'dt.Load(objContratos.SeleccionarContratos)
            cmbxcodigoContrato.DataSource = dt
            cmbxcodigoContrato.DisplayMember = "descripcion"
            cmbxcodigoContrato.ValueMember = "codigo"
            'Dim cant As Integer = dt.Rows.Count
            'Dim row As DataRow
            'cmbxcodigoContrato.Items.Clear()
            'For index As Integer = 0 To cant - 1
            '    row = dt.Rows(index)
            '    cmbxcodigoContrato.Items.Add(CStr(row("descripcion")))
            'Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub txtcodigoHorario_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoHorario.Click
        RH_Horarios.lblform.Text = "RH_Empleados"
        RH_Horarios.Show()
    End Sub

    Private Sub txtcodigoFormaPago_Click(sender As Object, e As EventArgs) Handles txtcodigoFormaPago.Click
        'A_ListarFormasPagoPF.lblForm.Text = "RH_Empleados"
        'A_ListarFormasPagoPF.Show()
    End Sub

    Private Sub cmbxcodigoContrato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxcodigoContrato.Click
        'M_Contratos.show()
    End Sub
    Private Sub btnBuscarImage_Click(sender As Object, e As EventArgs) Handles btnBuscarImage.Click
        SubirImagen()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        txtRuta.Text = ""
        pbxEmpleado.Image = Nothing
    End Sub
    Sub SubirImagen() 'Metodo que selecciona imagen
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then

                Imagen = OpenFileDialog1.FileName
                txtRuta.Text = Imagen.ToString
                Dim largo As Integer = Imagen.Length
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(Imagen), largo - 2, largo))
                If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "GIF" And imagen2 <> "BMP" And imagen2 <> "JPG" And imagen2 <> "JPEG" Then
                    imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(Imagen), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then
                        txtRuta.Text = ""
                        MsgBox("Formato no valido") : Exit Sub
                        If imagen2 <> "log1" Then Exit Sub
                    End If
                    pbxEmpleado.Load(Imagen)
                End If

                pbxEmpleado.Load(Imagen)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la imagen." + ex.Message)
        End Try
    End Sub
    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles txtArea.Click
        RH_Area.lblform.Text = "RH_Empleados"
        RH_Area.Show()
    End Sub
    Private Sub txtdepartamento_click(sender As Object, e As EventArgs) Handles txtdepartamento.Click
        If Trim(txtArea.Text) <> "" Then
            RH_ListadoDepartamentos.lblform.Text = "RH_Empleados"
            RH_ListadoDepartamentos.lblcodeArea.Text = lblcodigoArea.Text
            RH_ListadoDepartamentos.Show()
        End If
    End Sub
    Private Sub txtPuestoTrabajo_click(sender As Object, e As EventArgs) Handles txtPuestoTrabajo.Click
        If Trim(txtdepartamento.Text) <> "" Then
            RH_ListadoPuestoTrabajo.lblform.Text = "RH_Empleados"
            RH_ListadoPuestoTrabajo.lblcodeDepto.Text = lblcodeDepto.Text
            RH_ListadoPuestoTrabajo.lblBandera.Text = "1"
            RH_ListadoPuestoTrabajo.Show()
        ElseIf Trim(txtArea.Text) = "" Then
            RH_ListadoPuestoTrabajo.lblform.Text = "RH_Empleados"
            RH_ListadoPuestoTrabajo.lblBandera.Text = "0"
            RH_ListadoPuestoTrabajo.Show()
        End If
    End Sub
    Private Sub txtcodigoFormaPago_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoFormaPago.TextChanged
        'If (txtcodigoFormaPago.Text <> "") Then
        '    Try
        '        Dim objForPa As New ClsFormaPago
        '        With objForPa
        '            .Codigo_FormaPago = txtcodigoFormaPago.Text
        '        End With
        '        Dim dt As New DataTable
        '        dt = objForPa.buscarFormaPago()
        '        Dim row As DataRow = dt.Rows(0)
        '        txtnombreFormaPago.Text = CStr(row("nombreBanco"))
        '        txtcodigoFormaPago.BackColor = Color.White
        '    Catch ex As Exception
        '        txtcodigoFormaPago.BackColor = Color.Red
        '        txtnombreFormaPago.Text = ""
        '    End Try
        'Else
        '    txtcodigoFormaPago.Text = ""
        '    txtnombreFormaPago.Text = ""
        '    txtcodigoFormaPago.BackColor = Color.White
        'End If
    End Sub

    Private Sub cmbxcodigoContrato_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbxcodigoContrato.SelectedIndexChanged
        'habilitar el boton para imprimir el carnet en caso que sea permanente
        Try
            'If cmbxcodigoContrato.SelectedValue.ToString = "1" Then
            '    btnImprimirCarnet.Enabled = True
            'Else
            '    btnImprimirCarnet.Enabled = False
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsalario_Leave(sender As Object, e As EventArgs) Handles txtsalario.Leave
        'Mostrar el numero con 2 decimales N2 = 1,000.00   y F2 = 1000.00
        Try
            If Trim(txtsalario.Text) <> "" Then
                txtsalario.Text = Convert.ToDecimal(txtsalario.Text).ToString("N2")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtnombreCompleto_TextChanged(sender As Object, e As EventArgs) Handles txtnombreCompleto.TextChanged
        txtnombreCompleto.Text = Replace(txtnombreCompleto.Text, "  ", " ")
    End Sub

End Class