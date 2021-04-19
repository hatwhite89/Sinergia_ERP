<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CT_AgregarCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CT_AgregarCuenta))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnnuevo = New UIDC.UI_ButtonImage()
        Me.btnSalir = New UIDC.UI_ButtonImage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New UIDC.UI_ButtonImage()
        Me.btnCancelar = New UIDC.UI_ButtonImage()
        Me.btnGuardar = New UIDC.UI_ButtonImage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UI_LabelMaterial8 = New UIDC.UI_LabelMaterial()
        Me.cmbxTipoPermiso = New UIDC.UI_ComboBox()
        Me.UI_UserLoginTextBox2 = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial3 = New UIDC.UI_LabelMaterial()
        Me.UI_UserLoginTextBox1 = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial2 = New UIDC.UI_LabelMaterial()
        Me.txtCodigoB = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.Panel1.SuspendLayout()
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(588, 56)
        Me.Panel1.TabIndex = 7
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.ImageActive = Nothing
        Me.btnnuevo.Location = New System.Drawing.Point(372, 5)
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
        Me.btnSalir.Location = New System.Drawing.Point(544, 6)
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
        Me.btnModificar.Location = New System.Drawing.Point(458, 6)
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
        Me.btnCancelar.Location = New System.Drawing.Point(502, 6)
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
        Me.btnGuardar.Location = New System.Drawing.Point(416, 6)
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
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial8)
        Me.GroupBox1.Controls.Add(Me.cmbxTipoPermiso)
        Me.GroupBox1.Controls.Add(Me.UI_UserLoginTextBox2)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial3)
        Me.GroupBox1.Controls.Add(Me.UI_UserLoginTextBox1)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial2)
        Me.GroupBox1.Controls.Add(Me.txtCodigoB)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 162)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Cuenta"
        '
        'UI_LabelMaterial8
        '
        Me.UI_LabelMaterial8.AutoSize = True
        Me.UI_LabelMaterial8.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial8.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial8.Location = New System.Drawing.Point(5, 116)
        Me.UI_LabelMaterial8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial8.Name = "UI_LabelMaterial8"
        Me.UI_LabelMaterial8.Size = New System.Drawing.Size(105, 17)
        Me.UI_LabelMaterial8.TabIndex = 175
        Me.UI_LabelMaterial8.Text = "Tipo de Cuenta"
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
        Me.cmbxTipoPermiso.Items.AddRange(New Object() {"Activo", "Pasivo", "Capital", "Gastos"})
        Me.cmbxTipoPermiso.LineColour = System.Drawing.Color.DodgerBlue
        Me.cmbxTipoPermiso.Location = New System.Drawing.Point(133, 107)
        Me.cmbxTipoPermiso.Name = "cmbxTipoPermiso"
        Me.cmbxTipoPermiso.Size = New System.Drawing.Size(200, 26)
        Me.cmbxTipoPermiso.SqaureColour = System.Drawing.Color.Gainsboro
        Me.cmbxTipoPermiso.SqaureHoverColour = System.Drawing.Color.Gray
        Me.cmbxTipoPermiso.StartIndex = 0
        Me.cmbxTipoPermiso.TabIndex = 174
        '
        'UI_UserLoginTextBox2
        '
        Me.UI_UserLoginTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.UI_UserLoginTextBox2.BackgroundColour = System.Drawing.Color.White
        Me.UI_UserLoginTextBox2.Borde = False
        Me.UI_UserLoginTextBox2.BorderColour = System.Drawing.Color.DodgerBlue
        Me.UI_UserLoginTextBox2.BorderSize = 3
        Me.UI_UserLoginTextBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UI_UserLoginTextBox2.Location = New System.Drawing.Point(133, 64)
        Me.UI_UserLoginTextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.UI_UserLoginTextBox2.Name = "UI_UserLoginTextBox2"
        Me.UI_UserLoginTextBox2.Radio = 12
        Me.UI_UserLoginTextBox2.Size = New System.Drawing.Size(356, 29)
        Me.UI_UserLoginTextBox2.TabIndex = 130
        Me.UI_UserLoginTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UI_UserLoginTextBox2.UseSystemPasswordChar = False
        Me.UI_UserLoginTextBox2.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial3
        '
        Me.UI_LabelMaterial3.AutoSize = True
        Me.UI_LabelMaterial3.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial3.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial3.Location = New System.Drawing.Point(28, 73)
        Me.UI_LabelMaterial3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial3.Name = "UI_LabelMaterial3"
        Me.UI_LabelMaterial3.Size = New System.Drawing.Size(82, 17)
        Me.UI_LabelMaterial3.TabIndex = 129
        Me.UI_LabelMaterial3.Text = "Descripción"
        '
        'UI_UserLoginTextBox1
        '
        Me.UI_UserLoginTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.UI_UserLoginTextBox1.BackgroundColour = System.Drawing.Color.White
        Me.UI_UserLoginTextBox1.Borde = False
        Me.UI_UserLoginTextBox1.BorderColour = System.Drawing.Color.DodgerBlue
        Me.UI_UserLoginTextBox1.BorderSize = 3
        Me.UI_UserLoginTextBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UI_UserLoginTextBox1.Location = New System.Drawing.Point(380, 26)
        Me.UI_UserLoginTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.UI_UserLoginTextBox1.Name = "UI_UserLoginTextBox1"
        Me.UI_UserLoginTextBox1.Radio = 12
        Me.UI_UserLoginTextBox1.Size = New System.Drawing.Size(109, 29)
        Me.UI_UserLoginTextBox1.TabIndex = 128
        Me.UI_UserLoginTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UI_UserLoginTextBox1.UseSystemPasswordChar = False
        Me.UI_UserLoginTextBox1.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial2
        '
        Me.UI_LabelMaterial2.AutoSize = True
        Me.UI_LabelMaterial2.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial2.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial2.Location = New System.Drawing.Point(301, 33)
        Me.UI_LabelMaterial2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial2.Name = "UI_LabelMaterial2"
        Me.UI_LabelMaterial2.Size = New System.Drawing.Size(75, 17)
        Me.UI_LabelMaterial2.TabIndex = 127
        Me.UI_LabelMaterial2.Text = "N# Cuenta"
        '
        'txtCodigoB
        '
        Me.txtCodigoB.BackColor = System.Drawing.Color.Transparent
        Me.txtCodigoB.BackgroundColour = System.Drawing.Color.White
        Me.txtCodigoB.Borde = False
        Me.txtCodigoB.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtCodigoB.BorderSize = 3
        Me.txtCodigoB.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoB.Location = New System.Drawing.Point(133, 26)
        Me.txtCodigoB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoB.Name = "txtCodigoB"
        Me.txtCodigoB.Radio = 12
        Me.txtCodigoB.Size = New System.Drawing.Size(109, 29)
        Me.txtCodigoB.TabIndex = 126
        Me.txtCodigoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCodigoB.UseSystemPasswordChar = False
        Me.txtCodigoB.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial1
        '
        Me.UI_LabelMaterial1.AutoSize = True
        Me.UI_LabelMaterial1.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial1.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial1.Location = New System.Drawing.Point(89, 31)
        Me.UI_LabelMaterial1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial1.Name = "UI_LabelMaterial1"
        Me.UI_LabelMaterial1.Size = New System.Drawing.Size(21, 17)
        Me.UI_LabelMaterial1.TabIndex = 125
        Me.UI_LabelMaterial1.Text = "ID"
        '
        'CT_AgregarCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 234)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CT_AgregarCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Cuenta"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents UI_UserLoginTextBox2 As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial3 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_UserLoginTextBox1 As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial2 As UIDC.UI_LabelMaterial
    Friend WithEvents txtCodigoB As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial8 As UIDC.UI_LabelMaterial
    Friend WithEvents cmbxTipoPermiso As UIDC.UI_ComboBox
End Class
