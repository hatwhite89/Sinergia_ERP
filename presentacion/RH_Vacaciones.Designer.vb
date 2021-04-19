<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RH_Vacaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RH_Vacaciones))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnnuevo = New UIDC.UI_ButtonImage()
        Me.btnSalir = New UIDC.UI_ButtonImage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New UIDC.UI_ButtonImage()
        Me.btnCancelar = New UIDC.UI_ButtonImage()
        Me.btnGuardar = New UIDC.UI_ButtonImage()
        Me.gbxRegistrar = New System.Windows.Forms.GroupBox()
        Me.rtxtObservaciones = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial9 = New UIDC.UI_LabelMaterial()
        Me.rtxtcubrira = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial8 = New UIDC.UI_LabelMaterial()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.UI_LabelMaterial7 = New UIDC.UI_LabelMaterial()
        Me.rbtnNo = New UIDC.UI_RadioButton()
        Me.rbtnSi = New UIDC.UI_RadioButton()
        Me.UI_LabelMaterial6 = New UIDC.UI_LabelMaterial()
        Me.txtTotalDias = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial5 = New UIDC.UI_LabelMaterial()
        Me.UI_LabelMaterial4 = New UIDC.UI_LabelMaterial()
        Me.UI_LabelMaterial3 = New UIDC.UI_LabelMaterial()
        Me.txtEmpleado = New UIDC.UI_UserLoginTextBox()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.UI_LabelMaterial2 = New UIDC.UI_LabelMaterial()
        Me.txtcodigo = New UIDC.UI_UserLoginTextBox()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblcodeEmpleado = New System.Windows.Forms.Label()
        Me.lblform = New System.Windows.Forms.Label()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.txtnombreB = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial10 = New UIDC.UI_LabelMaterial()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRegistrar.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 56)
        Me.Panel1.TabIndex = 6
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.ImageActive = Nothing
        Me.btnnuevo.Location = New System.Drawing.Point(587, 5)
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
        Me.btnSalir.Location = New System.Drawing.Point(759, 6)
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
        Me.btnModificar.Location = New System.Drawing.Point(673, 6)
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
        Me.btnCancelar.Location = New System.Drawing.Point(717, 6)
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
        Me.btnGuardar.Location = New System.Drawing.Point(631, 6)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(35, 46)
        Me.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Zoom = 10
        '
        'gbxRegistrar
        '
        Me.gbxRegistrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.gbxRegistrar.Controls.Add(Me.rtxtObservaciones)
        Me.gbxRegistrar.Controls.Add(Me.UI_LabelMaterial9)
        Me.gbxRegistrar.Controls.Add(Me.rtxtcubrira)
        Me.gbxRegistrar.Controls.Add(Me.UI_LabelMaterial8)
        Me.gbxRegistrar.Controls.Add(Me.dtpfecha)
        Me.gbxRegistrar.Controls.Add(Me.UI_LabelMaterial7)
        Me.gbxRegistrar.Controls.Add(Me.rbtnNo)
        Me.gbxRegistrar.Controls.Add(Me.rbtnSi)
        Me.gbxRegistrar.Controls.Add(Me.UI_LabelMaterial6)
        Me.gbxRegistrar.Controls.Add(Me.txtTotalDias)
        Me.gbxRegistrar.Controls.Add(Me.UI_LabelMaterial5)
        Me.gbxRegistrar.Controls.Add(Me.UI_LabelMaterial4)
        Me.gbxRegistrar.Controls.Add(Me.UI_LabelMaterial3)
        Me.gbxRegistrar.Controls.Add(Me.txtEmpleado)
        Me.gbxRegistrar.Controls.Add(Me.dtpFechaFinal)
        Me.gbxRegistrar.Controls.Add(Me.UI_LabelMaterial2)
        Me.gbxRegistrar.Controls.Add(Me.txtcodigo)
        Me.gbxRegistrar.Controls.Add(Me.dtpFechaInicial)
        Me.gbxRegistrar.Controls.Add(Me.UI_LabelMaterial1)
        Me.gbxRegistrar.Controls.Add(Me.lblEstado)
        Me.gbxRegistrar.Controls.Add(Me.lblcodeEmpleado)
        Me.gbxRegistrar.Controls.Add(Me.lblform)
        Me.gbxRegistrar.ForeColor = System.Drawing.Color.White
        Me.gbxRegistrar.Location = New System.Drawing.Point(11, 59)
        Me.gbxRegistrar.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxRegistrar.Name = "gbxRegistrar"
        Me.gbxRegistrar.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxRegistrar.Size = New System.Drawing.Size(778, 268)
        Me.gbxRegistrar.TabIndex = 118
        Me.gbxRegistrar.TabStop = False
        Me.gbxRegistrar.Text = "REGISTRAR HOJA DE INASISTENCIA O SOLICITUD DE VACACIONES"
        '
        'rtxtObservaciones
        '
        Me.rtxtObservaciones.BackColor = System.Drawing.Color.Transparent
        Me.rtxtObservaciones.BackgroundColour = System.Drawing.Color.White
        Me.rtxtObservaciones.Borde = False
        Me.rtxtObservaciones.BorderColour = System.Drawing.Color.DodgerBlue
        Me.rtxtObservaciones.BorderSize = 3
        Me.rtxtObservaciones.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rtxtObservaciones.Location = New System.Drawing.Point(11, 222)
        Me.rtxtObservaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxtObservaciones.Name = "rtxtObservaciones"
        Me.rtxtObservaciones.Radio = 12
        Me.rtxtObservaciones.Size = New System.Drawing.Size(749, 29)
        Me.rtxtObservaciones.TabIndex = 194
        Me.rtxtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.rtxtObservaciones.UseSystemPasswordChar = False
        Me.rtxtObservaciones.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial9
        '
        Me.UI_LabelMaterial9.AutoSize = True
        Me.UI_LabelMaterial9.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial9.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial9.Location = New System.Drawing.Point(8, 203)
        Me.UI_LabelMaterial9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial9.Name = "UI_LabelMaterial9"
        Me.UI_LabelMaterial9.Size = New System.Drawing.Size(103, 17)
        Me.UI_LabelMaterial9.TabIndex = 193
        Me.UI_LabelMaterial9.Text = "Observaciones"
        '
        'rtxtcubrira
        '
        Me.rtxtcubrira.BackColor = System.Drawing.Color.Transparent
        Me.rtxtcubrira.BackgroundColour = System.Drawing.Color.White
        Me.rtxtcubrira.Borde = False
        Me.rtxtcubrira.BorderColour = System.Drawing.Color.DodgerBlue
        Me.rtxtcubrira.BorderSize = 3
        Me.rtxtcubrira.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rtxtcubrira.Location = New System.Drawing.Point(12, 166)
        Me.rtxtcubrira.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxtcubrira.Name = "rtxtcubrira"
        Me.rtxtcubrira.Radio = 12
        Me.rtxtcubrira.Size = New System.Drawing.Size(489, 29)
        Me.rtxtcubrira.TabIndex = 192
        Me.rtxtcubrira.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.rtxtcubrira.UseSystemPasswordChar = False
        Me.rtxtcubrira.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial8
        '
        Me.UI_LabelMaterial8.AutoSize = True
        Me.UI_LabelMaterial8.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial8.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial8.Location = New System.Drawing.Point(9, 147)
        Me.UI_LabelMaterial8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial8.Name = "UI_LabelMaterial8"
        Me.UI_LabelMaterial8.Size = New System.Drawing.Size(54, 17)
        Me.UI_LabelMaterial8.TabIndex = 191
        Me.UI_LabelMaterial8.Text = "Cubrirá"
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(634, 79)
        Me.dtpfecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(106, 20)
        Me.dtpfecha.TabIndex = 190
        '
        'UI_LabelMaterial7
        '
        Me.UI_LabelMaterial7.AutoSize = True
        Me.UI_LabelMaterial7.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial7.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial7.Location = New System.Drawing.Point(582, 79)
        Me.UI_LabelMaterial7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial7.Name = "UI_LabelMaterial7"
        Me.UI_LabelMaterial7.Size = New System.Drawing.Size(51, 17)
        Me.UI_LabelMaterial7.TabIndex = 189
        Me.UI_LabelMaterial7.Text = "Fecha:"
        '
        'rbtnNo
        '
        Me.rbtnNo.AutoSize = True
        Me.rbtnNo.CheckColor = "#508ef5"
        Me.rbtnNo.Location = New System.Drawing.Point(684, 42)
        Me.rbtnNo.Name = "rbtnNo"
        Me.rbtnNo.Size = New System.Drawing.Size(41, 19)
        Me.rbtnNo.TabIndex = 188
        Me.rbtnNo.TabStop = True
        Me.rbtnNo.Text = "No"
        Me.rbtnNo.UseVisualStyleBackColor = True
        '
        'rbtnSi
        '
        Me.rbtnSi.AutoSize = True
        Me.rbtnSi.BackColor = System.Drawing.Color.Transparent
        Me.rbtnSi.CheckColor = "#508ef5"
        Me.rbtnSi.Location = New System.Drawing.Point(638, 42)
        Me.rbtnSi.Name = "rbtnSi"
        Me.rbtnSi.Size = New System.Drawing.Size(36, 19)
        Me.rbtnSi.TabIndex = 187
        Me.rbtnSi.TabStop = True
        Me.rbtnSi.Text = "Sí"
        Me.rbtnSi.UseVisualStyleBackColor = False
        '
        'UI_LabelMaterial6
        '
        Me.UI_LabelMaterial6.AutoSize = True
        Me.UI_LabelMaterial6.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial6.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial6.Location = New System.Drawing.Point(555, 42)
        Me.UI_LabelMaterial6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial6.Name = "UI_LabelMaterial6"
        Me.UI_LabelMaterial6.Size = New System.Drawing.Size(78, 17)
        Me.UI_LabelMaterial6.TabIndex = 186
        Me.UI_LabelMaterial6.Text = "Se notificó:"
        '
        'txtTotalDias
        '
        Me.txtTotalDias.BackColor = System.Drawing.Color.Transparent
        Me.txtTotalDias.BackgroundColour = System.Drawing.Color.White
        Me.txtTotalDias.Borde = False
        Me.txtTotalDias.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtTotalDias.BorderSize = 3
        Me.txtTotalDias.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTotalDias.Location = New System.Drawing.Point(308, 103)
        Me.txtTotalDias.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalDias.Name = "txtTotalDias"
        Me.txtTotalDias.Radio = 12
        Me.txtTotalDias.Size = New System.Drawing.Size(193, 29)
        Me.txtTotalDias.TabIndex = 185
        Me.txtTotalDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTotalDias.UseSystemPasswordChar = False
        Me.txtTotalDias.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial5
        '
        Me.UI_LabelMaterial5.AutoSize = True
        Me.UI_LabelMaterial5.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial5.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial5.Location = New System.Drawing.Point(305, 82)
        Me.UI_LabelMaterial5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial5.Name = "UI_LabelMaterial5"
        Me.UI_LabelMaterial5.Size = New System.Drawing.Size(92, 17)
        Me.UI_LabelMaterial5.TabIndex = 184
        Me.UI_LabelMaterial5.Text = "Total de Días"
        '
        'UI_LabelMaterial4
        '
        Me.UI_LabelMaterial4.AutoSize = True
        Me.UI_LabelMaterial4.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial4.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial4.Location = New System.Drawing.Point(164, 85)
        Me.UI_LabelMaterial4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial4.Name = "UI_LabelMaterial4"
        Me.UI_LabelMaterial4.Size = New System.Drawing.Size(86, 17)
        Me.UI_LabelMaterial4.TabIndex = 183
        Me.UI_LabelMaterial4.Text = "Fecha Inicial"
        '
        'UI_LabelMaterial3
        '
        Me.UI_LabelMaterial3.AutoSize = True
        Me.UI_LabelMaterial3.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial3.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial3.Location = New System.Drawing.Point(12, 87)
        Me.UI_LabelMaterial3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial3.Name = "UI_LabelMaterial3"
        Me.UI_LabelMaterial3.Size = New System.Drawing.Size(86, 17)
        Me.UI_LabelMaterial3.TabIndex = 182
        Me.UI_LabelMaterial3.Text = "Fecha Inicial"
        '
        'txtEmpleado
        '
        Me.txtEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.txtEmpleado.BackgroundColour = System.Drawing.Color.White
        Me.txtEmpleado.Borde = False
        Me.txtEmpleado.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtEmpleado.BorderSize = 3
        Me.txtEmpleado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEmpleado.Location = New System.Drawing.Point(163, 42)
        Me.txtEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Radio = 12
        Me.txtEmpleado.Size = New System.Drawing.Size(338, 29)
        Me.txtEmpleado.TabIndex = 181
        Me.txtEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEmpleado.UseSystemPasswordChar = False
        Me.txtEmpleado.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(166, 112)
        Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechaFinal.TabIndex = 180
        '
        'UI_LabelMaterial2
        '
        Me.UI_LabelMaterial2.AutoSize = True
        Me.UI_LabelMaterial2.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial2.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial2.Location = New System.Drawing.Point(160, 21)
        Me.UI_LabelMaterial2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial2.Name = "UI_LabelMaterial2"
        Me.UI_LabelMaterial2.Size = New System.Drawing.Size(148, 17)
        Me.UI_LabelMaterial2.TabIndex = 180
        Me.UI_LabelMaterial2.Text = "Nombre del Empleado"
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.Transparent
        Me.txtcodigo.BackgroundColour = System.Drawing.Color.White
        Me.txtcodigo.Borde = False
        Me.txtcodigo.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtcodigo.BorderSize = 3
        Me.txtcodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtcodigo.Location = New System.Drawing.Point(13, 42)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Radio = 12
        Me.txtcodigo.Size = New System.Drawing.Size(135, 29)
        Me.txtcodigo.TabIndex = 179
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtcodigo.UseSystemPasswordChar = False
        Me.txtcodigo.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(12, 113)
        Me.dtpFechaInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechaInicial.TabIndex = 178
        '
        'UI_LabelMaterial1
        '
        Me.UI_LabelMaterial1.AutoSize = True
        Me.UI_LabelMaterial1.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial1.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial1.Location = New System.Drawing.Point(10, 21)
        Me.UI_LabelMaterial1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial1.Name = "UI_LabelMaterial1"
        Me.UI_LabelMaterial1.Size = New System.Drawing.Size(52, 17)
        Me.UI_LabelMaterial1.TabIndex = 178
        Me.UI_LabelMaterial1.Text = "Código"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(681, 151)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(66, 13)
        Me.lblEstado.TabIndex = 177
        Me.lblEstado.Text = "LabelEstado"
        Me.lblEstado.Visible = False
        '
        'lblcodeEmpleado
        '
        Me.lblcodeEmpleado.AutoSize = True
        Me.lblcodeEmpleado.Location = New System.Drawing.Point(587, 118)
        Me.lblcodeEmpleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeEmpleado.Name = "lblcodeEmpleado"
        Me.lblcodeEmpleado.Size = New System.Drawing.Size(46, 13)
        Me.lblcodeEmpleado.TabIndex = 160
        Me.lblcodeEmpleado.Text = "codEmp"
        Me.lblcodeEmpleado.Visible = False
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(615, 151)
        Me.lblform.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(39, 13)
        Me.lblform.TabIndex = 149
        Me.lblform.Text = "Label1"
        Me.lblform.Visible = False
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxbusqueda.BackColor = System.Drawing.Color.Transparent
        Me.gbxbusqueda.Controls.Add(Me.txtnombreB)
        Me.gbxbusqueda.Controls.Add(Me.UI_LabelMaterial10)
        Me.gbxbusqueda.Controls.Add(Me.Label10)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.ForeColor = System.Drawing.Color.White
        Me.gbxbusqueda.Location = New System.Drawing.Point(8, 331)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(778, 325)
        Me.gbxbusqueda.TabIndex = 119
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR HOJA DE INASISTENCIA O SOLICITUD DE VACACIONES"
        '
        'txtnombreB
        '
        Me.txtnombreB.BackColor = System.Drawing.Color.Transparent
        Me.txtnombreB.BackgroundColour = System.Drawing.Color.White
        Me.txtnombreB.Borde = False
        Me.txtnombreB.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtnombreB.BorderSize = 3
        Me.txtnombreB.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtnombreB.Location = New System.Drawing.Point(165, 21)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Radio = 12
        Me.txtnombreB.Size = New System.Drawing.Size(338, 29)
        Me.txtnombreB.TabIndex = 196
        Me.txtnombreB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtnombreB.UseSystemPasswordChar = False
        Me.txtnombreB.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial10
        '
        Me.UI_LabelMaterial10.AutoSize = True
        Me.UI_LabelMaterial10.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial10.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial10.Location = New System.Drawing.Point(13, 25)
        Me.UI_LabelMaterial10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial10.Name = "UI_LabelMaterial10"
        Me.UI_LabelMaterial10.Size = New System.Drawing.Size(148, 17)
        Me.UI_LabelMaterial10.TabIndex = 195
        Me.UI_LabelMaterial10.Text = "Nombre del Empleado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(267, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(272, 13)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "Seleccione una fila para cargar la información "
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(398, 305)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgbtabla.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgbtabla.Location = New System.Drawing.Point(4, 76)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(770, 223)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(1, 305)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(346, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE HOJA DE INASISTENCIA O SOLICITUD DE VACACIONES"
        '
        'RH_Vacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 667)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxRegistrar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RH_Vacaciones"
        Me.Text = "RH_Vacaciones"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRegistrar.ResumeLayout(False)
        Me.gbxRegistrar.PerformLayout()
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
    Friend WithEvents gbxRegistrar As GroupBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblcodeEmpleado As Label
    Friend WithEvents lblform As Label
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents rtxtObservaciones As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial9 As UIDC.UI_LabelMaterial
    Friend WithEvents rtxtcubrira As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial8 As UIDC.UI_LabelMaterial
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents UI_LabelMaterial7 As UIDC.UI_LabelMaterial
    Friend WithEvents rbtnNo As UIDC.UI_RadioButton
    Friend WithEvents rbtnSi As UIDC.UI_RadioButton
    Friend WithEvents UI_LabelMaterial6 As UIDC.UI_LabelMaterial
    Friend WithEvents txtTotalDias As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial5 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial4 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial3 As UIDC.UI_LabelMaterial
    Friend WithEvents txtEmpleado As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial2 As UIDC.UI_LabelMaterial
    Friend WithEvents txtcodigo As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents txtnombreB As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial10 As UIDC.UI_LabelMaterial
    Friend WithEvents Label10 As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
End Class
