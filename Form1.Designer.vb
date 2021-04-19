<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UI_ButtonMaterial1 = New UIDC.UI_ButtonMaterial()
        Me.UI_PictureBox1 = New UIDC.UI_PictureBox()
        Me.UI_ButtonMaterial2 = New UIDC.UI_ButtonMaterial()
        Me.UI_UserLoginTextBox1 = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.UI_LabelMaterial2 = New UIDC.UI_LabelMaterial()
        Me.txtPass = New UIDC.UI_UserPasswordTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UI_PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 22)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Iniciar Sesión"
        '
        'UI_ButtonMaterial1
        '
        Me.UI_ButtonMaterial1.BGColor = "#0061b6"
        Me.UI_ButtonMaterial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_ButtonMaterial1.Location = New System.Drawing.Point(138, 292)
        Me.UI_ButtonMaterial1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UI_ButtonMaterial1.Name = "UI_ButtonMaterial1"
        Me.UI_ButtonMaterial1.Size = New System.Drawing.Size(107, 33)
        Me.UI_ButtonMaterial1.TabIndex = 5
        Me.UI_ButtonMaterial1.Text = "Cerrar Programa"
        Me.UI_ButtonMaterial1.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_ButtonMaterial1.UIFontColor = "#ffffff"
        Me.UI_ButtonMaterial1.UseVisualStyleBackColor = True
        '
        'UI_PictureBox1
        '
        Me.UI_PictureBox1.Image = CType(resources.GetObject("UI_PictureBox1.Image"), System.Drawing.Image)
        Me.UI_PictureBox1.Location = New System.Drawing.Point(270, -8)
        Me.UI_PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UI_PictureBox1.Name = "UI_PictureBox1"
        Me.UI_PictureBox1.Size = New System.Drawing.Size(335, 367)
        Me.UI_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UI_PictureBox1.TabIndex = 6
        Me.UI_PictureBox1.TabStop = False
        '
        'UI_ButtonMaterial2
        '
        Me.UI_ButtonMaterial2.BGColor = "#0061b6"
        Me.UI_ButtonMaterial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_ButtonMaterial2.Location = New System.Drawing.Point(26, 292)
        Me.UI_ButtonMaterial2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UI_ButtonMaterial2.Name = "UI_ButtonMaterial2"
        Me.UI_ButtonMaterial2.Size = New System.Drawing.Size(107, 33)
        Me.UI_ButtonMaterial2.TabIndex = 7
        Me.UI_ButtonMaterial2.Text = "Entrar"
        Me.UI_ButtonMaterial2.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_ButtonMaterial2.UIFontColor = "#ffffff"
        Me.UI_ButtonMaterial2.UseVisualStyleBackColor = True
        '
        'UI_UserLoginTextBox1
        '
        Me.UI_UserLoginTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.UI_UserLoginTextBox1.BackgroundColour = System.Drawing.Color.Gainsboro
        Me.UI_UserLoginTextBox1.Borde = False
        Me.UI_UserLoginTextBox1.BorderColour = System.Drawing.Color.DodgerBlue
        Me.UI_UserLoginTextBox1.BorderSize = 3
        Me.UI_UserLoginTextBox1.ForeColor = System.Drawing.Color.White
        Me.UI_UserLoginTextBox1.Location = New System.Drawing.Point(13, 164)
        Me.UI_UserLoginTextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UI_UserLoginTextBox1.Name = "UI_UserLoginTextBox1"
        Me.UI_UserLoginTextBox1.Radio = 12
        Me.UI_UserLoginTextBox1.Size = New System.Drawing.Size(232, 29)
        Me.UI_UserLoginTextBox1.TabIndex = 8
        Me.UI_UserLoginTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UI_UserLoginTextBox1.UseSystemPasswordChar = False
        Me.UI_UserLoginTextBox1.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Black
        '
        'UI_LabelMaterial1
        '
        Me.UI_LabelMaterial1.AutoSize = True
        Me.UI_LabelMaterial1.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.UI_LabelMaterial1.Location = New System.Drawing.Point(17, 142)
        Me.UI_LabelMaterial1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial1.Name = "UI_LabelMaterial1"
        Me.UI_LabelMaterial1.Size = New System.Drawing.Size(125, 17)
        Me.UI_LabelMaterial1.TabIndex = 10
        Me.UI_LabelMaterial1.Text = "Ingrese su usuario"
        '
        'UI_LabelMaterial2
        '
        Me.UI_LabelMaterial2.AutoSize = True
        Me.UI_LabelMaterial2.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.UI_LabelMaterial2.Location = New System.Drawing.Point(17, 203)
        Me.UI_LabelMaterial2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial2.Name = "UI_LabelMaterial2"
        Me.UI_LabelMaterial2.Size = New System.Drawing.Size(149, 17)
        Me.UI_LabelMaterial2.TabIndex = 11
        Me.UI_LabelMaterial2.Text = "Ingrese su contraseña"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.Transparent
        Me.txtPass.BackgroundColour = System.Drawing.Color.Gainsboro
        Me.txtPass.Borde = False
        Me.txtPass.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtPass.BorderSize = 3
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.Location = New System.Drawing.Point(15, 230)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Radio = 12
        Me.txtPass.Size = New System.Drawing.Size(230, 29)
        Me.txtPass.TabIndex = 12
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPass.UseSystemPasswordChar = True
        Me.txtPass.VisualImage = UIDC.UI_UserPasswordTextBox.Visual.Black
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 352)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.UI_LabelMaterial2)
        Me.Controls.Add(Me.UI_LabelMaterial1)
        Me.Controls.Add(Me.UI_UserLoginTextBox1)
        Me.Controls.Add(Me.UI_ButtonMaterial2)
        Me.Controls.Add(Me.UI_ButtonMaterial1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UI_PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UI_PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UI_ButtonMaterial1 As UIDC.UI_ButtonMaterial
    Friend WithEvents UI_PictureBox1 As UIDC.UI_PictureBox
    Friend WithEvents UI_ButtonMaterial2 As UIDC.UI_ButtonMaterial
    Friend WithEvents UI_UserLoginTextBox1 As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial2 As UIDC.UI_LabelMaterial
    Friend WithEvents txtPass As UIDC.UI_UserPasswordTextBox
End Class
