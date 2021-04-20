<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CT_CuentasPorPagar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CT_CuentasPorPagar))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblmsj = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvDetalleProveedor = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cmbxTerminoPago = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCredito = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDebito = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbxTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New UIDC.UI_ButtonImage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnProveedor = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_DetalleCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TerminoPagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetalleProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblmsj})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 747)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1213, 26)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblmsj
        '
        Me.lblmsj.BackColor = System.Drawing.Color.Transparent
        Me.lblmsj.Name = "lblmsj"
        Me.lblmsj.Size = New System.Drawing.Size(18, 20)
        Me.lblmsj.Text = "..."
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtSaldo)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtBuscar)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.dgvDetalleProveedor)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(11, 318)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1191, 378)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Movimientos Contables"
        '
        'txtSaldo
        '
        Me.txtSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaldo.Location = New System.Drawing.Point(925, 23)
        Me.txtSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(256, 22)
        Me.txtSaldo.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(836, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Saldo Total"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(69, 32)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(293, 22)
        Me.txtBuscar.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 36)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Buscar "
        '
        'dgvDetalleProveedor
        '
        Me.dgvDetalleProveedor.AllowUserToAddRows = False
        Me.dgvDetalleProveedor.AllowUserToDeleteRows = False
        Me.dgvDetalleProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleProveedor.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetalleProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_DetalleCliente, Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.TerminoPagos, Me.Fecha, Me.Column7, Me.Column8})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalleProveedor.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalleProveedor.Location = New System.Drawing.Point(5, 64)
        Me.dgvDetalleProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDetalleProveedor.Name = "dgvDetalleProveedor"
        Me.dgvDetalleProveedor.RowHeadersWidth = 51
        Me.dgvDetalleProveedor.Size = New System.Drawing.Size(1183, 306)
        Me.dgvDetalleProveedor.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.cmbxTerminoPago)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCredito)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDebito)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbxTipoMovimiento)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1189, 105)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar Movimiento Contable"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(992, 32)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(983, 53)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(136, 22)
        Me.dtpFecha.TabIndex = 13
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.BackgroundImage = CType(resources.GetObject("btnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Location = New System.Drawing.Point(1133, 45)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(47, 36)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'cmbxTerminoPago
        '
        Me.cmbxTerminoPago.FormattingEnabled = True
        Me.cmbxTerminoPago.Location = New System.Drawing.Point(816, 52)
        Me.cmbxTerminoPago.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbxTerminoPago.Name = "cmbxTerminoPago"
        Me.cmbxTerminoPago.Size = New System.Drawing.Size(160, 24)
        Me.cmbxTerminoPago.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(812, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Termino Pago"
        '
        'txtCredito
        '
        Me.txtCredito.Location = New System.Drawing.Point(652, 53)
        Me.txtCredito.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.Size = New System.Drawing.Size(155, 22)
        Me.txtCredito.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(648, 33)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Credito"
        '
        'txtDebito
        '
        Me.txtDebito.Location = New System.Drawing.Point(488, 53)
        Me.txtDebito.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDebito.Name = "txtDebito"
        Me.txtDebito.Size = New System.Drawing.Size(155, 22)
        Me.txtDebito.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(484, 33)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Debito"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(185, 53)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(293, 22)
        Me.txtDescripcion.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(181, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripción"
        '
        'cmbxTipoMovimiento
        '
        Me.cmbxTipoMovimiento.FormattingEnabled = True
        Me.cmbxTipoMovimiento.Location = New System.Drawing.Point(12, 53)
        Me.cmbxTipoMovimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbxTipoMovimiento.Name = "cmbxTipoMovimiento"
        Me.cmbxTipoMovimiento.Size = New System.Drawing.Size(160, 24)
        Me.cmbxTipoMovimiento.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo Movim."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1221, 69)
        Me.Panel1.TabIndex = 11
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageActive = Nothing
        Me.btnSalir.Location = New System.Drawing.Point(1163, 7)
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnProveedor)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1189, 124)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Cliente"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(540, 23)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Termino Pago"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnProveedor
        '
        Me.btnProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedor.Location = New System.Drawing.Point(816, 68)
        Me.btnProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(161, 28)
        Me.btnProveedor.TabIndex = 4
        Me.btnProveedor.Text = "Buscar Proveedor"
        Me.btnProveedor.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(211, 70)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(596, 22)
        Me.txtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre de Proveedor"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(211, 38)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(132, 22)
        Me.txtId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identificador"
        '
        'id_DetalleCliente
        '
        Me.id_DetalleCliente.HeaderText = "id_DetalleCliente"
        Me.id_DetalleCliente.MinimumWidth = 6
        Me.id_DetalleCliente.Name = "id_DetalleCliente"
        Me.id_DetalleCliente.Visible = False
        Me.id_DetalleCliente.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tipo Mov."
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Descripción"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Debe"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Haber"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Term. Pago"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        Me.Column6.Width = 125
        '
        'TerminoPagos
        '
        Me.TerminoPagos.HeaderText = "Termino de Pago"
        Me.TerminoPagos.MinimumWidth = 6
        Me.TerminoPagos.Name = "TerminoPagos"
        Me.TerminoPagos.Width = 125
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Pagado"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "Anular"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column8.Width = 125
        '
        'CT_CuentasPorPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1213, 773)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CT_CuentasPorPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas Por Pagar"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvDetalleProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblmsj As ToolStripStatusLabel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvDetalleProveedor As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cmbxTerminoPago As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCredito As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDebito As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbxTipoMovimiento As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As UIDC.UI_ButtonImage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnProveedor As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents id_DetalleCliente As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents TerminoPagos As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewButtonColumn
    Friend WithEvents Column8 As DataGridViewCheckBoxColumn
End Class
