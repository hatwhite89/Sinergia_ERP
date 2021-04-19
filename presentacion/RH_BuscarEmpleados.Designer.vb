<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RH_BuscarEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RH_BuscarEmpleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnombreB = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial2 = New UIDC.UI_LabelMaterial()
        Me.txtcodigoB = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 56)
        Me.Panel1.TabIndex = 3
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Controls.Add(Me.lblcantidad)
        Me.GroupBox1.Controls.Add(Me.dgbtabla)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtnombreB)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial2)
        Me.GroupBox1.Controls.Add(Me.txtcodigoB)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(743, 490)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registros de Empleados"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(14, 464)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(129, 13)
        Me.lbltotal.TabIndex = 123
        Me.lbltotal.Text = "TOTAL DE EMPLEADOS"
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(185, 464)
        Me.lblcantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(25, 13)
        Me.lblcantidad.TabIndex = 124
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
        Me.dgbtabla.Location = New System.Drawing.Point(5, 119)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(733, 332)
        Me.dgbtabla.TabIndex = 122
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(182, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(387, 13)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Haga doble click sobre una fila para cargar los datos del empleado"
        '
        'txtnombreB
        '
        Me.txtnombreB.BackColor = System.Drawing.Color.Transparent
        Me.txtnombreB.BackgroundColour = System.Drawing.Color.White
        Me.txtnombreB.Borde = False
        Me.txtnombreB.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtnombreB.BorderSize = 3
        Me.txtnombreB.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtnombreB.Location = New System.Drawing.Point(185, 45)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Radio = 12
        Me.txtnombreB.Size = New System.Drawing.Size(382, 29)
        Me.txtnombreB.TabIndex = 7
        Me.txtnombreB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtnombreB.UseSystemPasswordChar = False
        Me.txtnombreB.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial2
        '
        Me.UI_LabelMaterial2.AutoSize = True
        Me.UI_LabelMaterial2.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial2.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial2.Location = New System.Drawing.Point(181, 24)
        Me.UI_LabelMaterial2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial2.Name = "UI_LabelMaterial2"
        Me.UI_LabelMaterial2.Size = New System.Drawing.Size(58, 17)
        Me.UI_LabelMaterial2.TabIndex = 6
        Me.UI_LabelMaterial2.Text = "Nombre"
        '
        'txtcodigoB
        '
        Me.txtcodigoB.BackColor = System.Drawing.Color.Transparent
        Me.txtcodigoB.BackgroundColour = System.Drawing.Color.White
        Me.txtcodigoB.Borde = False
        Me.txtcodigoB.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtcodigoB.BorderSize = 3
        Me.txtcodigoB.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtcodigoB.Location = New System.Drawing.Point(17, 45)
        Me.txtcodigoB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoB.Name = "txtcodigoB"
        Me.txtcodigoB.Radio = 12
        Me.txtcodigoB.Size = New System.Drawing.Size(135, 29)
        Me.txtcodigoB.TabIndex = 5
        Me.txtcodigoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtcodigoB.UseSystemPasswordChar = False
        Me.txtcodigoB.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial1
        '
        Me.UI_LabelMaterial1.AutoSize = True
        Me.UI_LabelMaterial1.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial1.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial1.Location = New System.Drawing.Point(14, 24)
        Me.UI_LabelMaterial1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial1.Name = "UI_LabelMaterial1"
        Me.UI_LabelMaterial1.Size = New System.Drawing.Size(52, 17)
        Me.UI_LabelMaterial1.TabIndex = 4
        Me.UI_LabelMaterial1.Text = "Código"
        '
        'RH_BuscarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 563)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RH_BuscarEmpleados"
        Me.Text = "Buscar Empleados"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnombreB As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial2 As UIDC.UI_LabelMaterial
    Friend WithEvents txtcodigoB As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
End Class
