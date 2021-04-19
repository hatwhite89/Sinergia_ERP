<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RH_PuestoTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RH_PuestoTrabajo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblform = New System.Windows.Forms.Label()
        Me.txtnombreDepto = New UIDC.UI_UserLoginTextBox()
        Me.btnBuscar = New UIDC.UI_ButtonMaterial()
        Me.txtcodigoDepto = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial3 = New UIDC.UI_LabelMaterial()
        Me.rtxtdescripcion = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial2 = New UIDC.UI_LabelMaterial()
        Me.txtcodigo = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnnuevo = New UIDC.UI_ButtonImage()
        Me.btnSalir = New UIDC.UI_ButtonImage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New UIDC.UI_ButtonImage()
        Me.btnCancelar = New UIDC.UI_ButtonImage()
        Me.btnGuardar = New UIDC.UI_ButtonImage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.txtdescripcionB = New UIDC.UI_UserLoginTextBox()
        Me.txtdescrip = New UIDC.UI_LabelMaterial()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblform)
        Me.GroupBox1.Controls.Add(Me.txtnombreDepto)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtcodigoDepto)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial3)
        Me.GroupBox1.Controls.Add(Me.rtxtdescripcion)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial2)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 60)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(582, 156)
        Me.GroupBox1.TabIndex = 0
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
        'txtnombreDepto
        '
        Me.txtnombreDepto.BackColor = System.Drawing.Color.Transparent
        Me.txtnombreDepto.BackgroundColour = System.Drawing.Color.White
        Me.txtnombreDepto.Borde = False
        Me.txtnombreDepto.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtnombreDepto.BorderSize = 3
        Me.txtnombreDepto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtnombreDepto.Location = New System.Drawing.Point(113, 103)
        Me.txtnombreDepto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreDepto.Name = "txtnombreDepto"
        Me.txtnombreDepto.Radio = 12
        Me.txtnombreDepto.Size = New System.Drawing.Size(394, 29)
        Me.txtnombreDepto.TabIndex = 6
        Me.txtnombreDepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtnombreDepto.UseSystemPasswordChar = False
        Me.txtnombreDepto.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'btnBuscar
        '
        Me.btnBuscar.BGColor = "#508ef5"
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(511, 103)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(53, 27)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.UIFontColor = "#ffffff"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtcodigoDepto
        '
        Me.txtcodigoDepto.BackColor = System.Drawing.Color.Transparent
        Me.txtcodigoDepto.BackgroundColour = System.Drawing.Color.White
        Me.txtcodigoDepto.Borde = False
        Me.txtcodigoDepto.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtcodigoDepto.BorderSize = 3
        Me.txtcodigoDepto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtcodigoDepto.Location = New System.Drawing.Point(14, 103)
        Me.txtcodigoDepto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoDepto.Name = "txtcodigoDepto"
        Me.txtcodigoDepto.Radio = 12
        Me.txtcodigoDepto.Size = New System.Drawing.Size(95, 29)
        Me.txtcodigoDepto.TabIndex = 5
        Me.txtcodigoDepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtcodigoDepto.UseSystemPasswordChar = False
        Me.txtcodigoDepto.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
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
        Me.UI_LabelMaterial3.Size = New System.Drawing.Size(98, 17)
        Me.UI_LabelMaterial3.TabIndex = 4
        Me.UI_LabelMaterial3.Text = "Departamento"
        '
        'rtxtdescripcion
        '
        Me.rtxtdescripcion.BackColor = System.Drawing.Color.Transparent
        Me.rtxtdescripcion.BackgroundColour = System.Drawing.Color.White
        Me.rtxtdescripcion.Borde = False
        Me.rtxtdescripcion.BorderColour = System.Drawing.Color.DodgerBlue
        Me.rtxtdescripcion.BorderSize = 3
        Me.rtxtdescripcion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rtxtdescripcion.Location = New System.Drawing.Point(182, 46)
        Me.rtxtdescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxtdescripcion.Name = "rtxtdescripcion"
        Me.rtxtdescripcion.Radio = 12
        Me.rtxtdescripcion.Size = New System.Drawing.Size(382, 29)
        Me.rtxtdescripcion.TabIndex = 3
        Me.rtxtdescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.rtxtdescripcion.UseSystemPasswordChar = False
        Me.rtxtdescripcion.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
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
        Me.UI_LabelMaterial2.Size = New System.Drawing.Size(82, 17)
        Me.UI_LabelMaterial2.TabIndex = 2
        Me.UI_LabelMaterial2.Text = "Descripción"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 56)
        Me.Panel1.TabIndex = 1
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.ImageActive = Nothing
        Me.btnnuevo.Location = New System.Drawing.Point(386, 6)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(35, 46)
        Me.btnnuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnnuevo.TabIndex = 13
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
        Me.btnModificar.Location = New System.Drawing.Point(471, 6)
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
        Me.btnCancelar.Location = New System.Drawing.Point(513, 6)
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
        Me.btnGuardar.Location = New System.Drawing.Point(427, 6)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(35, 46)
        Me.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Zoom = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblcantidad)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgbtabla)
        Me.GroupBox2.Controls.Add(Me.txtdescripcionB)
        Me.GroupBox2.Controls.Add(Me.txtdescrip)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(9, 220)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(582, 332)
        Me.GroupBox2.TabIndex = 6
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
        'txtdescripcionB
        '
        Me.txtdescripcionB.BackColor = System.Drawing.Color.Transparent
        Me.txtdescripcionB.BackgroundColour = System.Drawing.Color.White
        Me.txtdescripcionB.Borde = False
        Me.txtdescripcionB.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtdescripcionB.BorderSize = 3
        Me.txtdescripcionB.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtdescripcionB.Location = New System.Drawing.Point(103, 19)
        Me.txtdescripcionB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdescripcionB.Name = "txtdescripcionB"
        Me.txtdescripcionB.Radio = 12
        Me.txtdescripcionB.Size = New System.Drawing.Size(394, 29)
        Me.txtdescripcionB.TabIndex = 8
        Me.txtdescripcionB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtdescripcionB.UseSystemPasswordChar = False
        Me.txtdescripcionB.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'txtdescrip
        '
        Me.txtdescrip.AutoSize = True
        Me.txtdescrip.BackColor = System.Drawing.Color.Transparent
        Me.txtdescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtdescrip.ForeColor = System.Drawing.Color.White
        Me.txtdescrip.Location = New System.Drawing.Point(12, 25)
        Me.txtdescrip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtdescrip.Name = "txtdescrip"
        Me.txtdescrip.Size = New System.Drawing.Size(82, 17)
        Me.txtdescrip.TabIndex = 7
        Me.txtdescrip.Text = "Descripción"
        '
        'RH_PuestoTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 557)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RH_PuestoTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Puestos de Trabajo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtcodigoDepto As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial3 As UIDC.UI_LabelMaterial
    Friend WithEvents rtxtdescripcion As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial2 As UIDC.UI_LabelMaterial
    Friend WithEvents txtcodigo As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSalir As UIDC.UI_ButtonImage
    Friend WithEvents btnCancelar As UIDC.UI_ButtonImage
    Friend WithEvents btnModificar As UIDC.UI_ButtonImage
    Friend WithEvents btnGuardar As UIDC.UI_ButtonImage
    Friend WithEvents btnBuscar As UIDC.UI_ButtonMaterial
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtnombreDepto As UIDC.UI_UserLoginTextBox
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents txtdescripcionB As UIDC.UI_UserLoginTextBox
    Friend WithEvents txtdescrip As UIDC.UI_LabelMaterial
    Friend WithEvents lblform As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnnuevo As UIDC.UI_ButtonImage
End Class
