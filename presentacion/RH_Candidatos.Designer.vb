<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RH_Candidatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RH_Candidatos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnnuevo = New UIDC.UI_ButtonImage()
        Me.btnSalir = New UIDC.UI_ButtonImage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New UIDC.UI_ButtonImage()
        Me.btnCancelar = New UIDC.UI_ButtonImage()
        Me.btnGuardar = New UIDC.UI_ButtonImage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCandidato = New System.Windows.Forms.Label()
        Me.lblcodCargo = New System.Windows.Forms.Label()
        Me.lblcodProfesion = New System.Windows.Forms.Label()
        Me.lblcodArea = New System.Windows.Forms.Label()
        Me.UI_LabelMaterial7 = New UIDC.UI_LabelMaterial()
        Me.txtDescripcion = New UIDC.UI_RadioTextBox()
        Me.btnBuscarCargo = New UIDC.UI_ButtonMaterial()
        Me.btnBuscar = New UIDC.UI_ButtonMaterial()
        Me.btnBuscarPro = New UIDC.UI_ButtonMaterial()
        Me.txtArea = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial6 = New UIDC.UI_LabelMaterial()
        Me.txtCargo = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial5 = New UIDC.UI_LabelMaterial()
        Me.txtProfesion = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial4 = New UIDC.UI_LabelMaterial()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.UI_LabelMaterial3 = New UIDC.UI_LabelMaterial()
        Me.txtNombre = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial2 = New UIDC.UI_LabelMaterial()
        Me.txtContacto = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtCandidatos = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtCandidatos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(775, 56)
        Me.Panel1.TabIndex = 6
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.ImageActive = Nothing
        Me.btnnuevo.Location = New System.Drawing.Point(559, 5)
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
        Me.btnSalir.Location = New System.Drawing.Point(731, 6)
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
        Me.btnModificar.Location = New System.Drawing.Point(645, 6)
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
        Me.btnCancelar.Location = New System.Drawing.Point(689, 6)
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
        Me.btnGuardar.Location = New System.Drawing.Point(603, 6)
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
        Me.GroupBox1.Controls.Add(Me.lblCandidato)
        Me.GroupBox1.Controls.Add(Me.lblcodCargo)
        Me.GroupBox1.Controls.Add(Me.lblcodProfesion)
        Me.GroupBox1.Controls.Add(Me.lblcodArea)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial7)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCargo)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.btnBuscarPro)
        Me.GroupBox1.Controls.Add(Me.txtArea)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial6)
        Me.GroupBox1.Controls.Add(Me.txtCargo)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial5)
        Me.GroupBox1.Controls.Add(Me.txtProfesion)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial4)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial2)
        Me.GroupBox1.Controls.Add(Me.txtContacto)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 244)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Candidato"
        '
        'lblCandidato
        '
        Me.lblCandidato.AutoSize = True
        Me.lblCandidato.Location = New System.Drawing.Point(735, 113)
        Me.lblCandidato.Name = "lblCandidato"
        Me.lblCandidato.Size = New System.Drawing.Size(0, 13)
        Me.lblCandidato.TabIndex = 27
        Me.lblCandidato.Visible = False
        '
        'lblcodCargo
        '
        Me.lblcodCargo.AutoSize = True
        Me.lblcodCargo.Location = New System.Drawing.Point(735, 130)
        Me.lblcodCargo.Name = "lblcodCargo"
        Me.lblcodCargo.Size = New System.Drawing.Size(0, 13)
        Me.lblcodCargo.TabIndex = 26
        Me.lblcodCargo.Visible = False
        '
        'lblcodProfesion
        '
        Me.lblcodProfesion.AutoSize = True
        Me.lblcodProfesion.Location = New System.Drawing.Point(641, 130)
        Me.lblcodProfesion.Name = "lblcodProfesion"
        Me.lblcodProfesion.Size = New System.Drawing.Size(0, 13)
        Me.lblcodProfesion.TabIndex = 25
        Me.lblcodProfesion.Visible = False
        '
        'lblcodArea
        '
        Me.lblcodArea.AutoSize = True
        Me.lblcodArea.Location = New System.Drawing.Point(641, 113)
        Me.lblcodArea.Name = "lblcodArea"
        Me.lblcodArea.Size = New System.Drawing.Size(0, 13)
        Me.lblcodArea.TabIndex = 24
        Me.lblcodArea.Visible = False
        '
        'UI_LabelMaterial7
        '
        Me.UI_LabelMaterial7.AutoSize = True
        Me.UI_LabelMaterial7.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial7.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial7.Location = New System.Drawing.Point(9, 146)
        Me.UI_LabelMaterial7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial7.Name = "UI_LabelMaterial7"
        Me.UI_LabelMaterial7.Size = New System.Drawing.Size(179, 17)
        Me.UI_LabelMaterial7.TabIndex = 20
        Me.UI_LabelMaterial7.Text = "Descripción de Experiencia"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.txtDescripcion.BackgroundColour = System.Drawing.Color.White
        Me.txtDescripcion.Borde = False
        Me.txtDescripcion.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtDescripcion.BorderSize = 3
        Me.txtDescripcion.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 166)
        Me.txtDescripcion.MaxLength = 32767
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Radio = 12
        Me.txtDescripcion.ReadOnly = False
        Me.txtDescripcion.Size = New System.Drawing.Size(714, 60)
        Me.txtDescripcion.TabIndex = 19
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDescripcion.TextColour = System.Drawing.Color.DodgerBlue
        Me.txtDescripcion.UseSystemPasswordChar = False
        '
        'btnBuscarCargo
        '
        Me.btnBuscarCargo.BGColor = "#508ef5"
        Me.btnBuscarCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCargo.Location = New System.Drawing.Point(585, 105)
        Me.btnBuscarCargo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarCargo.Name = "btnBuscarCargo"
        Me.btnBuscarCargo.Size = New System.Drawing.Size(35, 27)
        Me.btnBuscarCargo.TabIndex = 18
        Me.btnBuscarCargo.Text = "..."
        Me.btnBuscarCargo.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCargo.UIFontColor = "#ffffff"
        Me.btnBuscarCargo.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BGColor = "#508ef5"
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(361, 105)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(35, 27)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.UIFontColor = "#ffffff"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnBuscarPro
        '
        Me.btnBuscarPro.BGColor = "#508ef5"
        Me.btnBuscarPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPro.Location = New System.Drawing.Point(151, 107)
        Me.btnBuscarPro.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarPro.Name = "btnBuscarPro"
        Me.btnBuscarPro.Size = New System.Drawing.Size(35, 27)
        Me.btnBuscarPro.TabIndex = 16
        Me.btnBuscarPro.Text = "..."
        Me.btnBuscarPro.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPro.UIFontColor = "#ffffff"
        Me.btnBuscarPro.UseVisualStyleBackColor = True
        '
        'txtArea
        '
        Me.txtArea.BackColor = System.Drawing.Color.Transparent
        Me.txtArea.BackgroundColour = System.Drawing.Color.White
        Me.txtArea.Borde = False
        Me.txtArea.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtArea.BorderSize = 3
        Me.txtArea.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtArea.Location = New System.Drawing.Point(223, 105)
        Me.txtArea.Margin = New System.Windows.Forms.Padding(2)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Radio = 12
        Me.txtArea.Size = New System.Drawing.Size(135, 29)
        Me.txtArea.TabIndex = 15
        Me.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtArea.UseSystemPasswordChar = False
        Me.txtArea.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial6
        '
        Me.UI_LabelMaterial6.AutoSize = True
        Me.UI_LabelMaterial6.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial6.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial6.Location = New System.Drawing.Point(220, 84)
        Me.UI_LabelMaterial6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial6.Name = "UI_LabelMaterial6"
        Me.UI_LabelMaterial6.Size = New System.Drawing.Size(38, 17)
        Me.UI_LabelMaterial6.TabIndex = 14
        Me.UI_LabelMaterial6.Text = "Area"
        '
        'txtCargo
        '
        Me.txtCargo.BackColor = System.Drawing.Color.Transparent
        Me.txtCargo.BackgroundColour = System.Drawing.Color.White
        Me.txtCargo.Borde = False
        Me.txtCargo.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtCargo.BorderSize = 3
        Me.txtCargo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCargo.Location = New System.Drawing.Point(446, 105)
        Me.txtCargo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Radio = 12
        Me.txtCargo.Size = New System.Drawing.Size(135, 29)
        Me.txtCargo.TabIndex = 13
        Me.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCargo.UseSystemPasswordChar = False
        Me.txtCargo.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial5
        '
        Me.UI_LabelMaterial5.AutoSize = True
        Me.UI_LabelMaterial5.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial5.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial5.Location = New System.Drawing.Point(443, 84)
        Me.UI_LabelMaterial5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial5.Name = "UI_LabelMaterial5"
        Me.UI_LabelMaterial5.Size = New System.Drawing.Size(46, 17)
        Me.UI_LabelMaterial5.TabIndex = 12
        Me.UI_LabelMaterial5.Text = "Cargo"
        '
        'txtProfesion
        '
        Me.txtProfesion.BackColor = System.Drawing.Color.Transparent
        Me.txtProfesion.BackgroundColour = System.Drawing.Color.White
        Me.txtProfesion.Borde = False
        Me.txtProfesion.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtProfesion.BorderSize = 3
        Me.txtProfesion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtProfesion.Location = New System.Drawing.Point(12, 105)
        Me.txtProfesion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProfesion.Name = "txtProfesion"
        Me.txtProfesion.Radio = 12
        Me.txtProfesion.Size = New System.Drawing.Size(135, 29)
        Me.txtProfesion.TabIndex = 11
        Me.txtProfesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtProfesion.UseSystemPasswordChar = False
        Me.txtProfesion.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial4
        '
        Me.UI_LabelMaterial4.AutoSize = True
        Me.UI_LabelMaterial4.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial4.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial4.Location = New System.Drawing.Point(9, 84)
        Me.UI_LabelMaterial4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial4.Name = "UI_LabelMaterial4"
        Me.UI_LabelMaterial4.Size = New System.Drawing.Size(68, 17)
        Me.UI_LabelMaterial4.TabIndex = 10
        Me.UI_LabelMaterial4.Text = "Profesión"
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(568, 45)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(130, 20)
        Me.dtpFecha.TabIndex = 9
        '
        'UI_LabelMaterial3
        '
        Me.UI_LabelMaterial3.AutoSize = True
        Me.UI_LabelMaterial3.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial3.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial3.Location = New System.Drawing.Point(565, 20)
        Me.UI_LabelMaterial3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial3.Name = "UI_LabelMaterial3"
        Me.UI_LabelMaterial3.Size = New System.Drawing.Size(47, 17)
        Me.UI_LabelMaterial3.TabIndex = 8
        Me.UI_LabelMaterial3.Text = "Fecha"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.Transparent
        Me.txtNombre.BackgroundColour = System.Drawing.Color.White
        Me.txtNombre.Borde = False
        Me.txtNombre.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtNombre.BorderSize = 3
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(12, 41)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Radio = 12
        Me.txtNombre.Size = New System.Drawing.Size(382, 29)
        Me.txtNombre.TabIndex = 7
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNombre.UseSystemPasswordChar = False
        Me.txtNombre.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial2
        '
        Me.UI_LabelMaterial2.AutoSize = True
        Me.UI_LabelMaterial2.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial2.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial2.Location = New System.Drawing.Point(8, 20)
        Me.UI_LabelMaterial2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial2.Name = "UI_LabelMaterial2"
        Me.UI_LabelMaterial2.Size = New System.Drawing.Size(149, 17)
        Me.UI_LabelMaterial2.TabIndex = 6
        Me.UI_LabelMaterial2.Text = "Nombre del Candidato"
        '
        'txtContacto
        '
        Me.txtContacto.BackColor = System.Drawing.Color.Transparent
        Me.txtContacto.BackgroundColour = System.Drawing.Color.White
        Me.txtContacto.Borde = False
        Me.txtContacto.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtContacto.BorderSize = 3
        Me.txtContacto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtContacto.Location = New System.Drawing.Point(411, 41)
        Me.txtContacto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Radio = 12
        Me.txtContacto.Size = New System.Drawing.Size(135, 29)
        Me.txtContacto.TabIndex = 5
        Me.txtContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtContacto.UseSystemPasswordChar = False
        Me.txtContacto.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial1
        '
        Me.UI_LabelMaterial1.AutoSize = True
        Me.UI_LabelMaterial1.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial1.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial1.Location = New System.Drawing.Point(408, 20)
        Me.UI_LabelMaterial1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial1.Name = "UI_LabelMaterial1"
        Me.UI_LabelMaterial1.Size = New System.Drawing.Size(64, 17)
        Me.UI_LabelMaterial1.TabIndex = 4
        Me.UI_LabelMaterial1.Text = "Contacto"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.dtCandidatos)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 310)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(750, 294)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Candidatos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(258, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(272, 13)
        Me.Label13.TabIndex = 119
        Me.Label13.Text = "Seleccione una fila para cargar la información "
        '
        'dtCandidatos
        '
        Me.dtCandidatos.AllowUserToAddRows = False
        Me.dtCandidatos.AllowUserToDeleteRows = False
        Me.dtCandidatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtCandidatos.BackgroundColor = System.Drawing.Color.White
        Me.dtCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtCandidatos.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtCandidatos.GridColor = System.Drawing.Color.Gray
        Me.dtCandidatos.Location = New System.Drawing.Point(3, 32)
        Me.dtCandidatos.Name = "dtCandidatos"
        Me.dtCandidatos.ReadOnly = True
        Me.dtCandidatos.RowHeadersWidth = 51
        Me.dtCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtCandidatos.Size = New System.Drawing.Size(744, 254)
        Me.dtCandidatos.TabIndex = 8
        '
        'RH_Candidatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(774, 598)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RH_Candidatos"
        Me.Text = "RH_Candidatos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dtCandidatos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtArea As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial6 As UIDC.UI_LabelMaterial
    Friend WithEvents txtCargo As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial5 As UIDC.UI_LabelMaterial
    Friend WithEvents txtProfesion As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial4 As UIDC.UI_LabelMaterial
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents UI_LabelMaterial3 As UIDC.UI_LabelMaterial
    Friend WithEvents txtNombre As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial2 As UIDC.UI_LabelMaterial
    Friend WithEvents txtContacto As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial7 As UIDC.UI_LabelMaterial
    Friend WithEvents txtDescripcion As UIDC.UI_RadioTextBox
    Friend WithEvents btnBuscarCargo As UIDC.UI_ButtonMaterial
    Friend WithEvents btnBuscar As UIDC.UI_ButtonMaterial
    Friend WithEvents btnBuscarPro As UIDC.UI_ButtonMaterial
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtCandidatos As DataGridView
    Friend WithEvents lblCandidato As Label
    Friend WithEvents lblcodCargo As Label
    Friend WithEvents lblcodProfesion As Label
    Friend WithEvents lblcodArea As Label
End Class
