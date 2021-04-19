<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RH_Departamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RH_Departamentos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnnuevo = New UIDC.UI_ButtonImage()
        Me.btnSalir = New UIDC.UI_ButtonImage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New UIDC.UI_ButtonImage()
        Me.btnCancelar = New UIDC.UI_ButtonImage()
        Me.btnGuardar = New UIDC.UI_ButtonImage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblform = New System.Windows.Forms.Label()
        Me.txtnombreArea = New UIDC.UI_UserLoginTextBox()
        Me.btnArea = New UIDC.UI_ButtonMaterial()
        Me.txtcodigoArea = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial3 = New UIDC.UI_LabelMaterial()
        Me.txtnombre = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial2 = New UIDC.UI_LabelMaterial()
        Me.txtcodigo = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.txtNombreB = New UIDC.UI_UserLoginTextBox()
        Me.Nombre = New UIDC.UI_LabelMaterial()
        Me.Panel1.SuspendLayout()
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 56)
        Me.Panel1.TabIndex = 2
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.ImageActive = Nothing
        Me.btnnuevo.Location = New System.Drawing.Point(388, 5)
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
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageActive = Nothing
        Me.btnSalir.Location = New System.Drawing.Point(560, 6)
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
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageActive = Nothing
        Me.btnModificar.Location = New System.Drawing.Point(474, 6)
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
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageActive = Nothing
        Me.btnCancelar.Location = New System.Drawing.Point(518, 6)
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
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageActive = Nothing
        Me.btnGuardar.Location = New System.Drawing.Point(432, 6)
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
        Me.GroupBox1.Controls.Add(Me.lblform)
        Me.GroupBox1.Controls.Add(Me.txtnombreArea)
        Me.GroupBox1.Controls.Add(Me.btnArea)
        Me.GroupBox1.Controls.Add(Me.txtcodigoArea)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial3)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial2)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 65)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(582, 156)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(525, 18)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(37, 13)
        Me.lblform.TabIndex = 7
        Me.lblform.Text = "lblform"
        '
        'txtnombreArea
        '
        Me.txtnombreArea.BackColor = System.Drawing.Color.Transparent
        Me.txtnombreArea.BackgroundColour = System.Drawing.Color.White
        Me.txtnombreArea.Borde = False
        Me.txtnombreArea.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtnombreArea.BorderSize = 3
        Me.txtnombreArea.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtnombreArea.Location = New System.Drawing.Point(113, 103)
        Me.txtnombreArea.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreArea.Name = "txtnombreArea"
        Me.txtnombreArea.Radio = 12
        Me.txtnombreArea.Size = New System.Drawing.Size(394, 29)
        Me.txtnombreArea.TabIndex = 6
        Me.txtnombreArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtnombreArea.UseSystemPasswordChar = False
        Me.txtnombreArea.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'btnArea
        '
        Me.btnArea.BGColor = "#508ef5"
        Me.btnArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArea.Location = New System.Drawing.Point(511, 103)
        Me.btnArea.Margin = New System.Windows.Forms.Padding(2)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(53, 27)
        Me.btnArea.TabIndex = 2
        Me.btnArea.Text = "Buscar"
        Me.btnArea.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArea.UIFontColor = "#ffffff"
        Me.btnArea.UseVisualStyleBackColor = True
        '
        'txtcodigoArea
        '
        Me.txtcodigoArea.BackColor = System.Drawing.Color.Transparent
        Me.txtcodigoArea.BackgroundColour = System.Drawing.Color.White
        Me.txtcodigoArea.Borde = False
        Me.txtcodigoArea.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtcodigoArea.BorderSize = 3
        Me.txtcodigoArea.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtcodigoArea.Location = New System.Drawing.Point(14, 103)
        Me.txtcodigoArea.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoArea.Name = "txtcodigoArea"
        Me.txtcodigoArea.Radio = 12
        Me.txtcodigoArea.Size = New System.Drawing.Size(95, 29)
        Me.txtcodigoArea.TabIndex = 5
        Me.txtcodigoArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtcodigoArea.UseSystemPasswordChar = False
        Me.txtcodigoArea.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial3
        '
        Me.UI_LabelMaterial3.AutoSize = True
        Me.UI_LabelMaterial3.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial3.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial3.Location = New System.Drawing.Point(11, 82)
        Me.UI_LabelMaterial3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial3.Name = "UI_LabelMaterial3"
        Me.UI_LabelMaterial3.Size = New System.Drawing.Size(38, 17)
        Me.UI_LabelMaterial3.TabIndex = 4
        Me.UI_LabelMaterial3.Text = "Area"
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.Transparent
        Me.txtnombre.BackgroundColour = System.Drawing.Color.White
        Me.txtnombre.Borde = False
        Me.txtnombre.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtnombre.BorderSize = 3
        Me.txtnombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtnombre.Location = New System.Drawing.Point(182, 46)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Radio = 12
        Me.txtnombre.Size = New System.Drawing.Size(382, 29)
        Me.txtnombre.TabIndex = 3
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtnombre.UseSystemPasswordChar = False
        Me.txtnombre.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial2
        '
        Me.UI_LabelMaterial2.AutoSize = True
        Me.UI_LabelMaterial2.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial2.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial2.Location = New System.Drawing.Point(178, 25)
        Me.UI_LabelMaterial2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial2.Name = "UI_LabelMaterial2"
        Me.UI_LabelMaterial2.Size = New System.Drawing.Size(58, 17)
        Me.UI_LabelMaterial2.TabIndex = 2
        Me.UI_LabelMaterial2.Text = "Nombre"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblcantidad)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgbtabla)
        Me.GroupBox2.Controls.Add(Me.txtNombreB)
        Me.GroupBox2.Controls.Add(Me.Nombre)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(9, 226)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(582, 332)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(110, 311)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(16, 13)
        Me.lblcantidad.TabIndex = 10
        Me.lblcantidad.Text = "---"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Total de Registros"
        '
        'dgbtabla
        '
        Me.dgbtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgbtabla.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgbtabla.GridColor = System.Drawing.Color.Gray
        Me.dgbtabla.Location = New System.Drawing.Point(5, 53)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.Size = New System.Drawing.Size(572, 251)
        Me.dgbtabla.TabIndex = 9
        '
        'txtNombreB
        '
        Me.txtNombreB.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreB.BackgroundColour = System.Drawing.Color.White
        Me.txtNombreB.Borde = False
        Me.txtNombreB.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtNombreB.BorderSize = 3
        Me.txtNombreB.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombreB.Location = New System.Drawing.Point(103, 19)
        Me.txtNombreB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreB.Name = "txtNombreB"
        Me.txtNombreB.Radio = 12
        Me.txtNombreB.Size = New System.Drawing.Size(394, 29)
        Me.txtNombreB.TabIndex = 8
        Me.txtNombreB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNombreB.UseSystemPasswordChar = False
        Me.txtNombreB.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.BackColor = System.Drawing.Color.Transparent
        Me.Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Nombre.ForeColor = System.Drawing.Color.White
        Me.Nombre.Location = New System.Drawing.Point(12, 25)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(82, 17)
        Me.Nombre.TabIndex = 7
        Me.Nombre.Text = "Descripción"
        '
        'RH_Departamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(603, 569)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RH_Departamentos"
        Me.Text = "Departamentos"
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
        Me.GroupBox2.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As UIDC.UI_ButtonImage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnModificar As UIDC.UI_ButtonImage
    Friend WithEvents btnCancelar As UIDC.UI_ButtonImage
    Friend WithEvents btnGuardar As UIDC.UI_ButtonImage
    Friend WithEvents btnnuevo As UIDC.UI_ButtonImage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblform As Label
    Friend WithEvents txtnombreArea As UIDC.UI_UserLoginTextBox
    Friend WithEvents btnArea As UIDC.UI_ButtonMaterial
    Friend WithEvents txtcodigoArea As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial3 As UIDC.UI_LabelMaterial
    Friend WithEvents txtnombre As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial2 As UIDC.UI_LabelMaterial
    Friend WithEvents txtcodigo As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents txtNombreB As UIDC.UI_UserLoginTextBox
    Friend WithEvents Nombre As UIDC.UI_LabelMaterial
End Class
