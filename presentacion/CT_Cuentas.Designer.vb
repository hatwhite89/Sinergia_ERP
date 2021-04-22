<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CT_Cuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CT_Cuentas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnnuevo = New UIDC.UI_ButtonImage()
        Me.btnSalir = New UIDC.UI_ButtonImage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.txtNombreB = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial2 = New UIDC.UI_LabelMaterial()
        Me.txtCodigoB = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.lblfila = New System.Windows.Forms.Label()
        Me.lblform = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltipoCta = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 56)
        Me.Panel1.TabIndex = 126
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.ImageActive = Nothing
        Me.btnnuevo.Location = New System.Drawing.Point(707, 2)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(35, 46)
        Me.btnnuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnnuevo.TabIndex = 17
        Me.btnnuevo.TabStop = False
        Me.btnnuevo.Zoom = 10
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageActive = Nothing
        Me.btnSalir.Location = New System.Drawing.Point(755, 2)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(35, 46)
        Me.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSalir.TabIndex = 16
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
        'gbxbusqueda
        '
        Me.gbxbusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxbusqueda.BackColor = System.Drawing.Color.Transparent
        Me.gbxbusqueda.Controls.Add(Me.txtNombreB)
        Me.gbxbusqueda.Controls.Add(Me.UI_LabelMaterial2)
        Me.gbxbusqueda.Controls.Add(Me.txtCodigoB)
        Me.gbxbusqueda.Controls.Add(Me.UI_LabelMaterial1)
        Me.gbxbusqueda.Controls.Add(Me.lblfila)
        Me.gbxbusqueda.Controls.Add(Me.lblform)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltipoCta)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.ForeColor = System.Drawing.Color.White
        Me.gbxbusqueda.Location = New System.Drawing.Point(11, 59)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(778, 380)
        Me.gbxbusqueda.TabIndex = 127
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR CUENTA"
        '
        'txtNombreB
        '
        Me.txtNombreB.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreB.BackgroundColour = System.Drawing.Color.White
        Me.txtNombreB.Borde = False
        Me.txtNombreB.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtNombreB.BorderSize = 3
        Me.txtNombreB.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombreB.Location = New System.Drawing.Point(300, 23)
        Me.txtNombreB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreB.Name = "txtNombreB"
        Me.txtNombreB.Radio = 12
        Me.txtNombreB.Size = New System.Drawing.Size(382, 29)
        Me.txtNombreB.TabIndex = 126
        Me.txtNombreB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNombreB.UseSystemPasswordChar = False
        Me.txtNombreB.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial2
        '
        Me.UI_LabelMaterial2.AutoSize = True
        Me.UI_LabelMaterial2.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial2.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial2.Location = New System.Drawing.Point(238, 28)
        Me.UI_LabelMaterial2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial2.Name = "UI_LabelMaterial2"
        Me.UI_LabelMaterial2.Size = New System.Drawing.Size(58, 17)
        Me.UI_LabelMaterial2.TabIndex = 125
        Me.UI_LabelMaterial2.Text = "Nombre"
        '
        'txtCodigoB
        '
        Me.txtCodigoB.BackColor = System.Drawing.Color.Transparent
        Me.txtCodigoB.BackgroundColour = System.Drawing.Color.White
        Me.txtCodigoB.Borde = False
        Me.txtCodigoB.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtCodigoB.BorderSize = 3
        Me.txtCodigoB.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoB.Location = New System.Drawing.Point(105, 23)
        Me.txtCodigoB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoB.Name = "txtCodigoB"
        Me.txtCodigoB.Radio = 12
        Me.txtCodigoB.Size = New System.Drawing.Size(109, 29)
        Me.txtCodigoB.TabIndex = 124
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
        Me.UI_LabelMaterial1.Location = New System.Drawing.Point(26, 27)
        Me.UI_LabelMaterial1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial1.Name = "UI_LabelMaterial1"
        Me.UI_LabelMaterial1.Size = New System.Drawing.Size(75, 17)
        Me.UI_LabelMaterial1.TabIndex = 123
        Me.UI_LabelMaterial1.Text = "N# Cuenta"
        '
        'lblfila
        '
        Me.lblfila.AutoSize = True
        Me.lblfila.Location = New System.Drawing.Point(198, -2)
        Me.lblfila.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfila.Name = "lblfila"
        Me.lblfila.Size = New System.Drawing.Size(0, 13)
        Me.lblfila.TabIndex = 122
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(707, 30)
        Me.lblform.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(40, 13)
        Me.lblform.TabIndex = 121
        Me.lblform.Text = "Código"
        Me.lblform.Visible = False
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgbtabla.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgbtabla.Location = New System.Drawing.Point(5, 66)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(769, 277)
        Me.dgbtabla.TabIndex = 119
        '
        'lbltipoCta
        '
        Me.lbltipoCta.AutoSize = True
        Me.lbltipoCta.Location = New System.Drawing.Point(214, 148)
        Me.lbltipoCta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltipoCta.Name = "lbltipoCta"
        Me.lbltipoCta.Size = New System.Drawing.Size(0, 13)
        Me.lbltipoCta.TabIndex = 116
        Me.lbltipoCta.Visible = False
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(253, 361)
        Me.lblcantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(25, 13)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(15, 361)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(114, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE CUENTAS"
        '
        'CT_Cuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CT_Cuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registros de Cuentas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnnuevo As UIDC.UI_ButtonImage
    Friend WithEvents btnSalir As UIDC.UI_ButtonImage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents txtNombreB As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial2 As UIDC.UI_LabelMaterial
    Friend WithEvents txtCodigoB As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
    Friend WithEvents lblfila As Label
    Friend WithEvents lblform As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltipoCta As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents lbltotal As Label
End Class
