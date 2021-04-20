<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CT_AgregarProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CT_AgregarProveedores))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCorreo = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial7 = New UIDC.UI_LabelMaterial()
        Me.txtCelular = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial6 = New UIDC.UI_LabelMaterial()
        Me.txtTelefono = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial5 = New UIDC.UI_LabelMaterial()
        Me.txtRTN = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial4 = New UIDC.UI_LabelMaterial()
        Me.txtDireccion = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial3 = New UIDC.UI_LabelMaterial()
        Me.txtNombre = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial2 = New UIDC.UI_LabelMaterial()
        Me.txtId = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnnuevo = New UIDC.UI_ButtonImage()
        Me.btnSalir = New UIDC.UI_ButtonImage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New UIDC.UI_ButtonImage()
        Me.btnCancelar = New UIDC.UI_ButtonImage()
        Me.btnGuardar = New UIDC.UI_ButtonImage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial7)
        Me.GroupBox1.Controls.Add(Me.txtCelular)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial6)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial5)
        Me.GroupBox1.Controls.Add(Me.txtRTN)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial4)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial2)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 74)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(841, 244)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Proveedor"
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.Transparent
        Me.txtCorreo.BackgroundColour = System.Drawing.Color.White
        Me.txtCorreo.Borde = False
        Me.txtCorreo.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtCorreo.BorderSize = 3
        Me.txtCorreo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCorreo.Location = New System.Drawing.Point(537, 176)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Radio = 12
        Me.txtCorreo.Size = New System.Drawing.Size(273, 34)
        Me.txtCorreo.TabIndex = 183
        Me.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCorreo.UseSystemPasswordChar = False
        Me.txtCorreo.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial7
        '
        Me.UI_LabelMaterial7.AutoSize = True
        Me.UI_LabelMaterial7.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial7.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial7.Location = New System.Drawing.Point(533, 153)
        Me.UI_LabelMaterial7.Name = "UI_LabelMaterial7"
        Me.UI_LabelMaterial7.Size = New System.Drawing.Size(57, 20)
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
        Me.txtCelular.Location = New System.Drawing.Point(537, 110)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Radio = 12
        Me.txtCelular.Size = New System.Drawing.Size(273, 34)
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
        Me.UI_LabelMaterial6.Location = New System.Drawing.Point(533, 86)
        Me.UI_LabelMaterial6.Name = "UI_LabelMaterial6"
        Me.UI_LabelMaterial6.Size = New System.Drawing.Size(62, 20)
        Me.UI_LabelMaterial6.TabIndex = 180
        Me.UI_LabelMaterial6.Text = "Celular"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.Transparent
        Me.txtTelefono.BackgroundColour = System.Drawing.Color.White
        Me.txtTelefono.Borde = False
        Me.txtTelefono.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtTelefono.BorderSize = 3
        Me.txtTelefono.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTelefono.Location = New System.Drawing.Point(537, 48)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Radio = 12
        Me.txtTelefono.Size = New System.Drawing.Size(273, 34)
        Me.txtTelefono.TabIndex = 179
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTelefono.UseSystemPasswordChar = False
        Me.txtTelefono.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial5
        '
        Me.UI_LabelMaterial5.AutoSize = True
        Me.UI_LabelMaterial5.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial5.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial5.Location = New System.Drawing.Point(533, 25)
        Me.UI_LabelMaterial5.Name = "UI_LabelMaterial5"
        Me.UI_LabelMaterial5.Size = New System.Drawing.Size(73, 20)
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
        Me.txtRTN.Location = New System.Drawing.Point(235, 48)
        Me.txtRTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRTN.Name = "txtRTN"
        Me.txtRTN.Radio = 12
        Me.txtRTN.Size = New System.Drawing.Size(273, 34)
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
        Me.UI_LabelMaterial4.Location = New System.Drawing.Point(231, 25)
        Me.UI_LabelMaterial4.Name = "UI_LabelMaterial4"
        Me.UI_LabelMaterial4.Size = New System.Drawing.Size(43, 20)
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
        Me.txtDireccion.Location = New System.Drawing.Point(33, 176)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Radio = 12
        Me.txtDireccion.Size = New System.Drawing.Size(475, 34)
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
        Me.UI_LabelMaterial3.Location = New System.Drawing.Point(29, 153)
        Me.UI_LabelMaterial3.Name = "UI_LabelMaterial3"
        Me.UI_LabelMaterial3.Size = New System.Drawing.Size(81, 20)
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
        Me.txtNombre.Location = New System.Drawing.Point(32, 110)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Radio = 12
        Me.txtNombre.Size = New System.Drawing.Size(476, 34)
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
        Me.UI_LabelMaterial2.Location = New System.Drawing.Point(28, 86)
        Me.UI_LabelMaterial2.Name = "UI_LabelMaterial2"
        Me.UI_LabelMaterial2.Size = New System.Drawing.Size(68, 20)
        Me.UI_LabelMaterial2.TabIndex = 127
        Me.UI_LabelMaterial2.Text = "Nombre"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.Transparent
        Me.txtId.BackgroundColour = System.Drawing.Color.White
        Me.txtId.Borde = False
        Me.txtId.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtId.BorderSize = 3
        Me.txtId.Enabled = False
        Me.txtId.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtId.Location = New System.Drawing.Point(32, 48)
        Me.txtId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtId.Name = "txtId"
        Me.txtId.Radio = 12
        Me.txtId.Size = New System.Drawing.Size(145, 34)
        Me.txtId.TabIndex = 126
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtId.UseSystemPasswordChar = False
        Me.txtId.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial1
        '
        Me.UI_LabelMaterial1.AutoSize = True
        Me.UI_LabelMaterial1.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial1.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial1.Location = New System.Drawing.Point(28, 25)
        Me.UI_LabelMaterial1.Name = "UI_LabelMaterial1"
        Me.UI_LabelMaterial1.Size = New System.Drawing.Size(26, 20)
        Me.UI_LabelMaterial1.TabIndex = 125
        Me.UI_LabelMaterial1.Text = "ID"
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(873, 69)
        Me.Panel1.TabIndex = 10
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.ImageActive = Nothing
        Me.btnnuevo.Location = New System.Drawing.Point(585, 6)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(47, 57)
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
        Me.btnSalir.Location = New System.Drawing.Point(815, 7)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(47, 57)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.TabStop = False
        Me.btnSalir.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageActive = Nothing
        Me.btnModificar.Location = New System.Drawing.Point(700, 7)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(47, 57)
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
        Me.btnCancelar.Location = New System.Drawing.Point(759, 7)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(47, 57)
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
        Me.btnGuardar.Location = New System.Drawing.Point(644, 7)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(47, 57)
        Me.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Zoom = 10
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 336)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(872, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'CT_AgregarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(872, 358)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CT_AgregarProveedores"
        Me.Text = "Registro de Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCorreo As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial7 As UIDC.UI_LabelMaterial
    Friend WithEvents txtCelular As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial6 As UIDC.UI_LabelMaterial
    Friend WithEvents txtTelefono As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial5 As UIDC.UI_LabelMaterial
    Friend WithEvents txtRTN As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial4 As UIDC.UI_LabelMaterial
    Friend WithEvents txtDireccion As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial3 As UIDC.UI_LabelMaterial
    Friend WithEvents txtNombre As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial2 As UIDC.UI_LabelMaterial
    Friend WithEvents txtId As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnnuevo As UIDC.UI_ButtonImage
    Friend WithEvents btnSalir As UIDC.UI_ButtonImage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnModificar As UIDC.UI_ButtonImage
    Friend WithEvents btnCancelar As UIDC.UI_ButtonImage
    Friend WithEvents btnGuardar As UIDC.UI_ButtonImage
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
