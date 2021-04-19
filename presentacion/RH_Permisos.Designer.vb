<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RH_Permisos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RH_Permisos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnnuevo = New UIDC.UI_ButtonImage()
        Me.btnSalir = New UIDC.UI_ButtonImage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New UIDC.UI_ButtonImage()
        Me.btnCancelar = New UIDC.UI_ButtonImage()
        Me.btnGuardar = New UIDC.UI_ButtonImage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmpleado = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial2 = New UIDC.UI_LabelMaterial()
        Me.txtcodigo = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.txtjefeInmediato = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial3 = New UIDC.UI_LabelMaterial()
        Me.txtDepto = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial4 = New UIDC.UI_LabelMaterial()
        Me.lblcodigoEmpleado = New System.Windows.Forms.Label()
        Me.lblcodeDepto = New System.Windows.Forms.Label()
        Me.lblcodeJefeInme = New System.Windows.Forms.Label()
        Me.lblform = New System.Windows.Forms.Label()
        Me.UI_LabelMaterial5 = New UIDC.UI_LabelMaterial()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.UI_LabelMaterial6 = New UIDC.UI_LabelMaterial()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.txtTotalDias = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial7 = New UIDC.UI_LabelMaterial()
        Me.cmbxTipoPermiso = New UIDC.UI_ComboBox()
        Me.UI_LabelMaterial8 = New UIDC.UI_LabelMaterial()
        Me.btnTipoPermiso = New UIDC.UI_ButtonMaterial()
        Me.UI_LabelMaterial9 = New UIDC.UI_LabelMaterial()
        Me.UI_LabelMaterial10 = New UIDC.UI_LabelMaterial()
        Me.dtpEntradaTarde = New System.Windows.Forms.DateTimePicker()
        Me.dtpSalidaTemprano = New System.Windows.Forms.DateTimePicker()
        Me.rtxtObservaciones = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial11 = New UIDC.UI_LabelMaterial()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtnombreB = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial12 = New UIDC.UI_LabelMaterial()
        Me.Panel1.SuspendLayout()
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1049, 56)
        Me.Panel1.TabIndex = 4
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.ImageActive = Nothing
        Me.btnnuevo.Location = New System.Drawing.Point(833, 5)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(35, 46)
        Me.btnnuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnnuevo.TabIndex = 14
        Me.btnnuevo.TabStop = False
        Me.btnnuevo.Zoom = 10
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageActive = Nothing
        Me.btnSalir.Location = New System.Drawing.Point(1005, 6)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(35, 46)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.TabStop = False
        Me.btnSalir.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageActive = Nothing
        Me.btnModificar.Location = New System.Drawing.Point(919, 6)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(35, 46)
        Me.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.TabStop = False
        Me.btnModificar.Zoom = 10
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageActive = Nothing
        Me.btnCancelar.Location = New System.Drawing.Point(963, 6)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(35, 46)
        Me.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Zoom = 10
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageActive = Nothing
        Me.btnGuardar.Location = New System.Drawing.Point(877, 6)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(35, 46)
        Me.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Zoom = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rtxtObservaciones)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial11)
        Me.GroupBox1.Controls.Add(Me.dtpSalidaTemprano)
        Me.GroupBox1.Controls.Add(Me.dtpEntradaTarde)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial10)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial9)
        Me.GroupBox1.Controls.Add(Me.btnTipoPermiso)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial8)
        Me.GroupBox1.Controls.Add(Me.cmbxTipoPermiso)
        Me.GroupBox1.Controls.Add(Me.txtTotalDias)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial7)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial6)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial5)
        Me.GroupBox1.Controls.Add(Me.lblform)
        Me.GroupBox1.Controls.Add(Me.lblcodeJefeInme)
        Me.GroupBox1.Controls.Add(Me.lblcodeDepto)
        Me.GroupBox1.Controls.Add(Me.lblcodigoEmpleado)
        Me.GroupBox1.Controls.Add(Me.txtjefeInmediato)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial3)
        Me.GroupBox1.Controls.Add(Me.txtDepto)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial4)
        Me.GroupBox1.Controls.Add(Me.txtEmpleado)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial2)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(8, 69)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1031, 293)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'txtEmpleado
        '
        Me.txtEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.txtEmpleado.BackgroundColour = System.Drawing.Color.White
        Me.txtEmpleado.Borde = False
        Me.txtEmpleado.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtEmpleado.BorderSize = 3
        Me.txtEmpleado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEmpleado.Location = New System.Drawing.Point(168, 46)
        Me.txtEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Radio = 12
        Me.txtEmpleado.Size = New System.Drawing.Size(319, 29)
        Me.txtEmpleado.TabIndex = 3
        Me.txtEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEmpleado.UseSystemPasswordChar = False
        Me.txtEmpleado.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial2
        '
        Me.UI_LabelMaterial2.AutoSize = True
        Me.UI_LabelMaterial2.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial2.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial2.Location = New System.Drawing.Point(164, 25)
        Me.UI_LabelMaterial2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial2.Name = "UI_LabelMaterial2"
        Me.UI_LabelMaterial2.Size = New System.Drawing.Size(145, 17)
        Me.UI_LabelMaterial2.TabIndex = 2
        Me.UI_LabelMaterial2.Text = "Nombre de Empleado"
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.Transparent
        Me.txtcodigo.BackgroundColour = System.Drawing.Color.White
        Me.txtcodigo.Borde = False
        Me.txtcodigo.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtcodigo.BorderSize = 3
        Me.txtcodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtcodigo.Location = New System.Drawing.Point(14, 46)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Radio = 12
        Me.txtcodigo.Size = New System.Drawing.Size(135, 29)
        Me.txtcodigo.TabIndex = 1
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtcodigo.UseSystemPasswordChar = False
        Me.txtcodigo.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial1
        '
        Me.UI_LabelMaterial1.AutoSize = True
        Me.UI_LabelMaterial1.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial1.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial1.Location = New System.Drawing.Point(11, 25)
        Me.UI_LabelMaterial1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial1.Name = "UI_LabelMaterial1"
        Me.UI_LabelMaterial1.Size = New System.Drawing.Size(52, 17)
        Me.UI_LabelMaterial1.TabIndex = 0
        Me.UI_LabelMaterial1.Text = "Código"
        '
        'txtjefeInmediato
        '
        Me.txtjefeInmediato.BackColor = System.Drawing.Color.Transparent
        Me.txtjefeInmediato.BackgroundColour = System.Drawing.Color.White
        Me.txtjefeInmediato.Borde = False
        Me.txtjefeInmediato.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtjefeInmediato.BorderSize = 3
        Me.txtjefeInmediato.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtjefeInmediato.Location = New System.Drawing.Point(751, 46)
        Me.txtjefeInmediato.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjefeInmediato.Name = "txtjefeInmediato"
        Me.txtjefeInmediato.Radio = 12
        Me.txtjefeInmediato.Size = New System.Drawing.Size(264, 29)
        Me.txtjefeInmediato.TabIndex = 7
        Me.txtjefeInmediato.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtjefeInmediato.UseSystemPasswordChar = False
        Me.txtjefeInmediato.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial3
        '
        Me.UI_LabelMaterial3.AutoSize = True
        Me.UI_LabelMaterial3.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial3.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial3.Location = New System.Drawing.Point(747, 25)
        Me.UI_LabelMaterial3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial3.Name = "UI_LabelMaterial3"
        Me.UI_LabelMaterial3.Size = New System.Drawing.Size(100, 17)
        Me.UI_LabelMaterial3.TabIndex = 6
        Me.UI_LabelMaterial3.Text = "Jefe Inmediato"
        '
        'txtDepto
        '
        Me.txtDepto.BackColor = System.Drawing.Color.Transparent
        Me.txtDepto.BackgroundColour = System.Drawing.Color.White
        Me.txtDepto.Borde = False
        Me.txtDepto.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtDepto.BorderSize = 3
        Me.txtDepto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDepto.Location = New System.Drawing.Point(504, 46)
        Me.txtDepto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDepto.Name = "txtDepto"
        Me.txtDepto.Radio = 12
        Me.txtDepto.Size = New System.Drawing.Size(231, 29)
        Me.txtDepto.TabIndex = 5
        Me.txtDepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDepto.UseSystemPasswordChar = False
        Me.txtDepto.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial4
        '
        Me.UI_LabelMaterial4.AutoSize = True
        Me.UI_LabelMaterial4.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial4.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial4.Location = New System.Drawing.Point(501, 25)
        Me.UI_LabelMaterial4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial4.Name = "UI_LabelMaterial4"
        Me.UI_LabelMaterial4.Size = New System.Drawing.Size(98, 17)
        Me.UI_LabelMaterial4.TabIndex = 4
        Me.UI_LabelMaterial4.Text = "Departamento"
        '
        'lblcodigoEmpleado
        '
        Me.lblcodigoEmpleado.AutoSize = True
        Me.lblcodigoEmpleado.Location = New System.Drawing.Point(790, 179)
        Me.lblcodigoEmpleado.Name = "lblcodigoEmpleado"
        Me.lblcodigoEmpleado.Size = New System.Drawing.Size(46, 13)
        Me.lblcodigoEmpleado.TabIndex = 8
        Me.lblcodigoEmpleado.Text = "codEmp"
        Me.lblcodigoEmpleado.Visible = False
        '
        'lblcodeDepto
        '
        Me.lblcodeDepto.AutoSize = True
        Me.lblcodeDepto.Location = New System.Drawing.Point(841, 179)
        Me.lblcodeDepto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeDepto.Name = "lblcodeDepto"
        Me.lblcodeDepto.Size = New System.Drawing.Size(62, 13)
        Me.lblcodeDepto.TabIndex = 163
        Me.lblcodeDepto.Text = "codTalHum"
        Me.lblcodeDepto.Visible = False
        '
        'lblcodeJefeInme
        '
        Me.lblcodeJefeInme.AutoSize = True
        Me.lblcodeJefeInme.Location = New System.Drawing.Point(907, 179)
        Me.lblcodeJefeInme.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeJefeInme.Name = "lblcodeJefeInme"
        Me.lblcodeJefeInme.Size = New System.Drawing.Size(45, 13)
        Me.lblcodeJefeInme.TabIndex = 164
        Me.lblcodeJefeInme.Text = "codJeIn"
        Me.lblcodeJefeInme.Visible = False
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(956, 179)
        Me.lblform.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(39, 13)
        Me.lblform.TabIndex = 165
        Me.lblform.Text = "Label1"
        Me.lblform.Visible = False
        '
        'UI_LabelMaterial5
        '
        Me.UI_LabelMaterial5.AutoSize = True
        Me.UI_LabelMaterial5.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial5.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial5.Location = New System.Drawing.Point(11, 93)
        Me.UI_LabelMaterial5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial5.Name = "UI_LabelMaterial5"
        Me.UI_LabelMaterial5.Size = New System.Drawing.Size(86, 17)
        Me.UI_LabelMaterial5.TabIndex = 166
        Me.UI_LabelMaterial5.Text = "Fecha Inicial"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(14, 121)
        Me.dtpFechaInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(151, 20)
        Me.dtpFechaInicial.TabIndex = 167
        '
        'UI_LabelMaterial6
        '
        Me.UI_LabelMaterial6.AutoSize = True
        Me.UI_LabelMaterial6.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial6.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial6.Location = New System.Drawing.Point(186, 93)
        Me.UI_LabelMaterial6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial6.Name = "UI_LabelMaterial6"
        Me.UI_LabelMaterial6.Size = New System.Drawing.Size(81, 17)
        Me.UI_LabelMaterial6.TabIndex = 168
        Me.UI_LabelMaterial6.Text = "Fecha Final"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(189, 121)
        Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(151, 20)
        Me.dtpFechaFinal.TabIndex = 169
        '
        'txtTotalDias
        '
        Me.txtTotalDias.BackColor = System.Drawing.Color.Transparent
        Me.txtTotalDias.BackgroundColour = System.Drawing.Color.White
        Me.txtTotalDias.Borde = False
        Me.txtTotalDias.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtTotalDias.BorderSize = 3
        Me.txtTotalDias.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTotalDias.Location = New System.Drawing.Point(371, 115)
        Me.txtTotalDias.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalDias.Name = "txtTotalDias"
        Me.txtTotalDias.Radio = 12
        Me.txtTotalDias.Size = New System.Drawing.Size(264, 29)
        Me.txtTotalDias.TabIndex = 171
        Me.txtTotalDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTotalDias.UseSystemPasswordChar = False
        Me.txtTotalDias.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial7
        '
        Me.UI_LabelMaterial7.AutoSize = True
        Me.UI_LabelMaterial7.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial7.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial7.Location = New System.Drawing.Point(367, 94)
        Me.UI_LabelMaterial7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial7.Name = "UI_LabelMaterial7"
        Me.UI_LabelMaterial7.Size = New System.Drawing.Size(90, 17)
        Me.UI_LabelMaterial7.TabIndex = 170
        Me.UI_LabelMaterial7.Text = "Total de días"
        '
        'cmbxTipoPermiso
        '
        Me.cmbxTipoPermiso.ArrowColour = System.Drawing.Color.DodgerBlue
        Me.cmbxTipoPermiso.BackColor = System.Drawing.Color.Transparent
        Me.cmbxTipoPermiso.BaseColour = System.Drawing.Color.White
        Me.cmbxTipoPermiso.BorderColour = System.Drawing.Color.Gray
        Me.cmbxTipoPermiso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbxTipoPermiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxTipoPermiso.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbxTipoPermiso.FontColour = System.Drawing.Color.Black
        Me.cmbxTipoPermiso.FormattingEnabled = True
        Me.cmbxTipoPermiso.LineColour = System.Drawing.Color.DodgerBlue
        Me.cmbxTipoPermiso.Location = New System.Drawing.Point(659, 116)
        Me.cmbxTipoPermiso.Name = "cmbxTipoPermiso"
        Me.cmbxTipoPermiso.Size = New System.Drawing.Size(200, 26)
        Me.cmbxTipoPermiso.SqaureColour = System.Drawing.Color.Gainsboro
        Me.cmbxTipoPermiso.SqaureHoverColour = System.Drawing.Color.Gray
        Me.cmbxTipoPermiso.StartIndex = 0
        Me.cmbxTipoPermiso.TabIndex = 172
        '
        'UI_LabelMaterial8
        '
        Me.UI_LabelMaterial8.AutoSize = True
        Me.UI_LabelMaterial8.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial8.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial8.Location = New System.Drawing.Point(656, 93)
        Me.UI_LabelMaterial8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial8.Name = "UI_LabelMaterial8"
        Me.UI_LabelMaterial8.Size = New System.Drawing.Size(111, 17)
        Me.UI_LabelMaterial8.TabIndex = 173
        Me.UI_LabelMaterial8.Text = "Tipo de Permiso"
        '
        'btnTipoPermiso
        '
        Me.btnTipoPermiso.BGColor = "#508ef5"
        Me.btnTipoPermiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipoPermiso.Location = New System.Drawing.Point(864, 116)
        Me.btnTipoPermiso.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTipoPermiso.Name = "btnTipoPermiso"
        Me.btnTipoPermiso.Size = New System.Drawing.Size(53, 27)
        Me.btnTipoPermiso.TabIndex = 174
        Me.btnTipoPermiso.Text = "Buscar"
        Me.btnTipoPermiso.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipoPermiso.UIFontColor = "#ffffff"
        Me.btnTipoPermiso.UseVisualStyleBackColor = True
        '
        'UI_LabelMaterial9
        '
        Me.UI_LabelMaterial9.AutoSize = True
        Me.UI_LabelMaterial9.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial9.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial9.Location = New System.Drawing.Point(11, 160)
        Me.UI_LabelMaterial9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial9.Name = "UI_LabelMaterial9"
        Me.UI_LabelMaterial9.Size = New System.Drawing.Size(155, 17)
        Me.UI_LabelMaterial9.TabIndex = 175
        Me.UI_LabelMaterial9.Text = "Hora de Entrada Tarde"
        '
        'UI_LabelMaterial10
        '
        Me.UI_LabelMaterial10.AutoSize = True
        Me.UI_LabelMaterial10.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial10.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial10.Location = New System.Drawing.Point(186, 160)
        Me.UI_LabelMaterial10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial10.Name = "UI_LabelMaterial10"
        Me.UI_LabelMaterial10.Size = New System.Drawing.Size(171, 17)
        Me.UI_LabelMaterial10.TabIndex = 176
        Me.UI_LabelMaterial10.Text = "Hora de Salida Temprano"
        '
        'dtpEntradaTarde
        '
        Me.dtpEntradaTarde.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEntradaTarde.Location = New System.Drawing.Point(15, 190)
        Me.dtpEntradaTarde.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpEntradaTarde.Name = "dtpEntradaTarde"
        Me.dtpEntradaTarde.ShowUpDown = True
        Me.dtpEntradaTarde.Size = New System.Drawing.Size(151, 20)
        Me.dtpEntradaTarde.TabIndex = 177
        '
        'dtpSalidaTemprano
        '
        Me.dtpSalidaTemprano.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSalidaTemprano.Location = New System.Drawing.Point(189, 190)
        Me.dtpSalidaTemprano.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpSalidaTemprano.Name = "dtpSalidaTemprano"
        Me.dtpSalidaTemprano.ShowUpDown = True
        Me.dtpSalidaTemprano.Size = New System.Drawing.Size(151, 20)
        Me.dtpSalidaTemprano.TabIndex = 178
        '
        'rtxtObservaciones
        '
        Me.rtxtObservaciones.BackColor = System.Drawing.Color.Transparent
        Me.rtxtObservaciones.BackgroundColour = System.Drawing.Color.White
        Me.rtxtObservaciones.Borde = False
        Me.rtxtObservaciones.BorderColour = System.Drawing.Color.DodgerBlue
        Me.rtxtObservaciones.BorderSize = 3
        Me.rtxtObservaciones.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rtxtObservaciones.Location = New System.Drawing.Point(14, 245)
        Me.rtxtObservaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxtObservaciones.Name = "rtxtObservaciones"
        Me.rtxtObservaciones.Radio = 12
        Me.rtxtObservaciones.Size = New System.Drawing.Size(1001, 29)
        Me.rtxtObservaciones.TabIndex = 180
        Me.rtxtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.rtxtObservaciones.UseSystemPasswordChar = False
        Me.rtxtObservaciones.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial11
        '
        Me.UI_LabelMaterial11.AutoSize = True
        Me.UI_LabelMaterial11.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial11.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial11.Location = New System.Drawing.Point(10, 224)
        Me.UI_LabelMaterial11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial11.Name = "UI_LabelMaterial11"
        Me.UI_LabelMaterial11.Size = New System.Drawing.Size(103, 17)
        Me.UI_LabelMaterial11.TabIndex = 179
        Me.UI_LabelMaterial11.Text = "Observaciones"
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxbusqueda.BackColor = System.Drawing.Color.Transparent
        Me.gbxbusqueda.Controls.Add(Me.txtnombreB)
        Me.gbxbusqueda.Controls.Add(Me.UI_LabelMaterial12)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Location = New System.Drawing.Point(8, 366)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(1031, 262)
        Me.gbxbusqueda.TabIndex = 117
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR PERMISOS ESPECIALES"
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.ForeColor = System.Drawing.Color.White
        Me.lblcantidad.Location = New System.Drawing.Point(221, 241)
        Me.lblcantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(25, 13)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(4, 57)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersVisible = False
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(1023, 177)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.ForeColor = System.Drawing.Color.White
        Me.lbltotal.Location = New System.Drawing.Point(4, 241)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(187, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE PERMISOS ESPECIALES"
        '
        'txtnombreB
        '
        Me.txtnombreB.BackColor = System.Drawing.Color.Transparent
        Me.txtnombreB.BackgroundColour = System.Drawing.Color.White
        Me.txtnombreB.Borde = False
        Me.txtnombreB.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtnombreB.BorderSize = 3
        Me.txtnombreB.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtnombreB.Location = New System.Drawing.Point(157, 21)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Radio = 12
        Me.txtnombreB.Size = New System.Drawing.Size(605, 29)
        Me.txtnombreB.TabIndex = 182
        Me.txtnombreB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtnombreB.UseSystemPasswordChar = False
        Me.txtnombreB.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial12
        '
        Me.UI_LabelMaterial12.AutoSize = True
        Me.UI_LabelMaterial12.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial12.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial12.Location = New System.Drawing.Point(11, 26)
        Me.UI_LabelMaterial12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial12.Name = "UI_LabelMaterial12"
        Me.UI_LabelMaterial12.Size = New System.Drawing.Size(145, 17)
        Me.UI_LabelMaterial12.TabIndex = 181
        Me.UI_LabelMaterial12.Text = "Nombre de Empleado"
        '
        'RH_Permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1043, 633)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RH_Permisos"
        Me.Text = "Permisos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnnuevo As UIDC.UI_ButtonImage
    Friend WithEvents btnSalir As UIDC.UI_ButtonImage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnModificar As UIDC.UI_ButtonImage
    Friend WithEvents btnCancelar As UIDC.UI_ButtonImage
    Friend WithEvents btnGuardar As UIDC.UI_ButtonImage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UI_LabelMaterial8 As UIDC.UI_LabelMaterial
    Friend WithEvents cmbxTipoPermiso As UIDC.UI_ComboBox
    Friend WithEvents txtTotalDias As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial7 As UIDC.UI_LabelMaterial
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents UI_LabelMaterial6 As UIDC.UI_LabelMaterial
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents UI_LabelMaterial5 As UIDC.UI_LabelMaterial
    Friend WithEvents lblform As Label
    Friend WithEvents lblcodeJefeInme As Label
    Friend WithEvents lblcodeDepto As Label
    Friend WithEvents lblcodigoEmpleado As Label
    Friend WithEvents txtjefeInmediato As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial3 As UIDC.UI_LabelMaterial
    Friend WithEvents txtDepto As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial4 As UIDC.UI_LabelMaterial
    Friend WithEvents txtEmpleado As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial2 As UIDC.UI_LabelMaterial
    Friend WithEvents txtcodigo As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
    Friend WithEvents rtxtObservaciones As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial11 As UIDC.UI_LabelMaterial
    Friend WithEvents dtpSalidaTemprano As DateTimePicker
    Friend WithEvents dtpEntradaTarde As DateTimePicker
    Friend WithEvents UI_LabelMaterial10 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial9 As UIDC.UI_LabelMaterial
    Friend WithEvents btnTipoPermiso As UIDC.UI_ButtonMaterial
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents txtnombreB As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial12 As UIDC.UI_LabelMaterial
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
End Class
