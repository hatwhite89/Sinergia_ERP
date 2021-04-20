<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CT_AgregarCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CT_AgregarCliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnnuevo = New UIDC.UI_ButtonImage()
        Me.btnSalir = New UIDC.UI_ButtonImage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New UIDC.UI_ButtonImage()
        Me.btnCancelar = New UIDC.UI_ButtonImage()
        Me.btnGuardar = New UIDC.UI_ButtonImage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEMAIL = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial7 = New UIDC.UI_LabelMaterial()
        Me.txtCelular = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial6 = New UIDC.UI_LabelMaterial()
        Me.txtTEL = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial5 = New UIDC.UI_LabelMaterial()
        Me.txtRTN = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial4 = New UIDC.UI_LabelMaterial()
        Me.txtDireccion = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial3 = New UIDC.UI_LabelMaterial()
        Me.txtNombre = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial2 = New UIDC.UI_LabelMaterial()
        Me.txtID = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(656, 56)
        Me.Panel1.TabIndex = 8
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.ImageActive = Nothing
        Me.btnnuevo.Location = New System.Drawing.Point(440, 5)
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
        Me.btnSalir.Location = New System.Drawing.Point(612, 6)
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
        Me.btnModificar.Location = New System.Drawing.Point(526, 6)
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
        Me.btnCancelar.Location = New System.Drawing.Point(570, 6)
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
        Me.btnGuardar.Location = New System.Drawing.Point(484, 6)
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
        Me.GroupBox1.Controls.Add(Me.txtEMAIL)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial7)
        Me.GroupBox1.Controls.Add(Me.txtCelular)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial6)
        Me.GroupBox1.Controls.Add(Me.txtTEL)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial5)
        Me.GroupBox1.Controls.Add(Me.txtRTN)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial4)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial2)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 198)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Cliente"
        '
        'txtEMAIL
        '
        Me.txtEMAIL.BackColor = System.Drawing.Color.Transparent
        Me.txtEMAIL.BackgroundColour = System.Drawing.Color.White
        Me.txtEMAIL.Borde = False
        Me.txtEMAIL.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtEMAIL.BorderSize = 3
        Me.txtEMAIL.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtEMAIL.Location = New System.Drawing.Point(403, 143)
        Me.txtEMAIL.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEMAIL.Name = "txtEMAIL"
        Me.txtEMAIL.Radio = 12
        Me.txtEMAIL.Size = New System.Drawing.Size(205, 29)
        Me.txtEMAIL.TabIndex = 183
        Me.txtEMAIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEMAIL.UseSystemPasswordChar = False
        Me.txtEMAIL.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial7
        '
        Me.UI_LabelMaterial7.AutoSize = True
        Me.UI_LabelMaterial7.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial7.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial7.Location = New System.Drawing.Point(400, 124)
        Me.UI_LabelMaterial7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial7.Name = "UI_LabelMaterial7"
        Me.UI_LabelMaterial7.Size = New System.Drawing.Size(47, 17)
        Me.UI_LabelMaterial7.TabIndex = 182
        Me.UI_LabelMaterial7.Text = "E-mail"
        '
        'txtCelular
        '
        Me.txtCelular.BackColor = System.Drawing.Color.Transparent
        Me.txtCelular.BackgroundColour = System.Drawing.Color.White
        Me.txtCelular.Borde = False
        Me.txtCelular.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtCelular.BorderSize = 3
        Me.txtCelular.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCelular.Location = New System.Drawing.Point(403, 89)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Radio = 12
        Me.txtCelular.Size = New System.Drawing.Size(205, 29)
        Me.txtCelular.TabIndex = 181
        Me.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCelular.UseSystemPasswordChar = False
        Me.txtCelular.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial6
        '
        Me.UI_LabelMaterial6.AutoSize = True
        Me.UI_LabelMaterial6.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial6.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial6.Location = New System.Drawing.Point(400, 70)
        Me.UI_LabelMaterial6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial6.Name = "UI_LabelMaterial6"
        Me.UI_LabelMaterial6.Size = New System.Drawing.Size(52, 17)
        Me.UI_LabelMaterial6.TabIndex = 180
        Me.UI_LabelMaterial6.Text = "Celular"
        '
        'txtTEL
        '
        Me.txtTEL.BackColor = System.Drawing.Color.Transparent
        Me.txtTEL.BackgroundColour = System.Drawing.Color.White
        Me.txtTEL.Borde = False
        Me.txtTEL.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtTEL.BorderSize = 3
        Me.txtTEL.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTEL.Location = New System.Drawing.Point(403, 39)
        Me.txtTEL.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Radio = 12
        Me.txtTEL.Size = New System.Drawing.Size(205, 29)
        Me.txtTEL.TabIndex = 179
        Me.txtTEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTEL.UseSystemPasswordChar = False
        Me.txtTEL.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial5
        '
        Me.UI_LabelMaterial5.AutoSize = True
        Me.UI_LabelMaterial5.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial5.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial5.Location = New System.Drawing.Point(400, 20)
        Me.UI_LabelMaterial5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial5.Name = "UI_LabelMaterial5"
        Me.UI_LabelMaterial5.Size = New System.Drawing.Size(64, 17)
        Me.UI_LabelMaterial5.TabIndex = 178
        Me.UI_LabelMaterial5.Text = "Telefono"
        '
        'txtRTN
        '
        Me.txtRTN.BackColor = System.Drawing.Color.Transparent
        Me.txtRTN.BackgroundColour = System.Drawing.Color.White
        Me.txtRTN.Borde = False
        Me.txtRTN.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtRTN.BorderSize = 3
        Me.txtRTN.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtRTN.Location = New System.Drawing.Point(176, 39)
        Me.txtRTN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRTN.Name = "txtRTN"
        Me.txtRTN.Radio = 12
        Me.txtRTN.Size = New System.Drawing.Size(205, 29)
        Me.txtRTN.TabIndex = 177
        Me.txtRTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtRTN.UseSystemPasswordChar = False
        Me.txtRTN.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial4
        '
        Me.UI_LabelMaterial4.AutoSize = True
        Me.UI_LabelMaterial4.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial4.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial4.Location = New System.Drawing.Point(173, 20)
        Me.UI_LabelMaterial4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial4.Name = "UI_LabelMaterial4"
        Me.UI_LabelMaterial4.Size = New System.Drawing.Size(37, 17)
        Me.UI_LabelMaterial4.TabIndex = 176
        Me.UI_LabelMaterial4.Text = "RTN"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.Transparent
        Me.txtDireccion.BackgroundColour = System.Drawing.Color.White
        Me.txtDireccion.Borde = False
        Me.txtDireccion.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtDireccion.BorderSize = 3
        Me.txtDireccion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDireccion.Location = New System.Drawing.Point(25, 143)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Radio = 12
        Me.txtDireccion.Size = New System.Drawing.Size(356, 29)
        Me.txtDireccion.TabIndex = 130
        Me.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDireccion.UseSystemPasswordChar = False
        Me.txtDireccion.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial3
        '
        Me.UI_LabelMaterial3.AutoSize = True
        Me.UI_LabelMaterial3.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial3.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial3.Location = New System.Drawing.Point(22, 124)
        Me.UI_LabelMaterial3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial3.Name = "UI_LabelMaterial3"
        Me.UI_LabelMaterial3.Size = New System.Drawing.Size(67, 17)
        Me.UI_LabelMaterial3.TabIndex = 129
        Me.UI_LabelMaterial3.Text = "Dirección"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.Transparent
        Me.txtNombre.BackgroundColour = System.Drawing.Color.White
        Me.txtNombre.Borde = False
        Me.txtNombre.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtNombre.BorderSize = 3
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(24, 89)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Radio = 12
        Me.txtNombre.Size = New System.Drawing.Size(357, 29)
        Me.txtNombre.TabIndex = 128
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNombre.UseSystemPasswordChar = False
        Me.txtNombre.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial2
        '
        Me.UI_LabelMaterial2.AutoSize = True
        Me.UI_LabelMaterial2.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial2.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial2.Location = New System.Drawing.Point(21, 70)
        Me.UI_LabelMaterial2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial2.Name = "UI_LabelMaterial2"
        Me.UI_LabelMaterial2.Size = New System.Drawing.Size(58, 17)
        Me.UI_LabelMaterial2.TabIndex = 127
        Me.UI_LabelMaterial2.Text = "Nombre"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.Transparent
        Me.txtID.BackgroundColour = System.Drawing.Color.White
        Me.txtID.Borde = False
        Me.txtID.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtID.BorderSize = 3
        Me.txtID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtID.Location = New System.Drawing.Point(24, 39)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Radio = 12
        Me.txtID.Size = New System.Drawing.Size(109, 29)
        Me.txtID.TabIndex = 126
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtID.UseSystemPasswordChar = False
        Me.txtID.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial1
        '
        Me.UI_LabelMaterial1.AutoSize = True
        Me.UI_LabelMaterial1.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial1.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial1.Location = New System.Drawing.Point(21, 20)
        Me.UI_LabelMaterial1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial1.Name = "UI_LabelMaterial1"
        Me.UI_LabelMaterial1.Size = New System.Drawing.Size(21, 17)
        Me.UI_LabelMaterial1.TabIndex = 125
        Me.UI_LabelMaterial1.Text = "ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 264)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(631, 234)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vincular Proveedores"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(625, 215)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "codDetalleCliente"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "codProveedor"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre Proveedor"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Porcentaje"
        Me.Column4.Name = "Column4"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEstado})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 520)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(655, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEstado
        '
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(16, 17)
        Me.lblEstado.Text = "..."
        '
        'CT_AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(655, 542)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CT_AgregarCliente"
        Me.Text = "Registro de Cliente"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnnuevo As UIDC.UI_ButtonImage
    Friend WithEvents btnSalir As UIDC.UI_ButtonImage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnModificar As UIDC.UI_ButtonImage
    Friend WithEvents btnCancelar As UIDC.UI_ButtonImage
    Friend WithEvents btnGuardar As UIDC.UI_ButtonImage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEMAIL As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial7 As UIDC.UI_LabelMaterial
    Friend WithEvents txtCelular As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial6 As UIDC.UI_LabelMaterial
    Friend WithEvents txtTEL As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial5 As UIDC.UI_LabelMaterial
    Friend WithEvents txtRTN As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial4 As UIDC.UI_LabelMaterial
    Friend WithEvents txtDireccion As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial3 As UIDC.UI_LabelMaterial
    Friend WithEvents txtNombre As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial2 As UIDC.UI_LabelMaterial
    Friend WithEvents txtID As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblEstado As ToolStripStatusLabel
End Class
