<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RH_Horarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RH_Horarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnnuevo = New UIDC.UI_ButtonImage()
        Me.btnSalir = New UIDC.UI_ButtonImage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New UIDC.UI_ButtonImage()
        Me.btnCancelar = New UIDC.UI_ButtonImage()
        Me.btnGuardar = New UIDC.UI_ButtonImage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtxtObservacion = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial8 = New UIDC.UI_LabelMaterial()
        Me.estadoForm = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpSalidaFinSemana = New System.Windows.Forms.DateTimePicker()
        Me.dtpEntradaFinSemana = New System.Windows.Forms.DateTimePicker()
        Me.UI_LabelMaterial6 = New UIDC.UI_LabelMaterial()
        Me.UI_LabelMaterial7 = New UIDC.UI_LabelMaterial()
        Me.cbxDomingo = New UIDC.UI_CheckBox()
        Me.cbxSabado = New UIDC.UI_CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpSalida = New System.Windows.Forms.DateTimePicker()
        Me.dtpEntrada = New System.Windows.Forms.DateTimePicker()
        Me.UI_LabelMaterial5 = New UIDC.UI_LabelMaterial()
        Me.UI_LabelMaterial4 = New UIDC.UI_LabelMaterial()
        Me.cbxMartes = New UIDC.UI_CheckBox()
        Me.cbxJueves = New UIDC.UI_CheckBox()
        Me.cbxMiercoles = New UIDC.UI_CheckBox()
        Me.cbxViernes = New UIDC.UI_CheckBox()
        Me.cbxLunes = New UIDC.UI_CheckBox()
        Me.lblform = New System.Windows.Forms.Label()
        Me.txtnombre = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial3 = New UIDC.UI_LabelMaterial()
        Me.txtcodigoBreve = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial2 = New UIDC.UI_LabelMaterial()
        Me.txtcodigo = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial1 = New UIDC.UI_LabelMaterial()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.txtNombreB = New UIDC.UI_UserLoginTextBox()
        Me.UI_LabelMaterial9 = New UIDC.UI_LabelMaterial()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.btnnuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 56)
        Me.Panel1.TabIndex = 3
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.ImageActive = Nothing
        Me.btnnuevo.Location = New System.Drawing.Point(516, 6)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(35, 46)
        Me.btnnuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnnuevo.TabIndex = 15
        Me.btnnuevo.TabStop = False
        Me.btnnuevo.Zoom = 10
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageActive = Nothing
        Me.btnSalir.Location = New System.Drawing.Point(692, 6)
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
        Me.btnModificar.Location = New System.Drawing.Point(602, 6)
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
        Me.btnCancelar.Location = New System.Drawing.Point(645, 6)
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
        Me.btnGuardar.Location = New System.Drawing.Point(558, 6)
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
        Me.GroupBox1.Controls.Add(Me.rtxtObservacion)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial8)
        Me.GroupBox1.Controls.Add(Me.estadoForm)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lblform)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial3)
        Me.GroupBox1.Controls.Add(Me.txtcodigoBreve)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial2)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.UI_LabelMaterial1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(11, 68)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(707, 345)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'rtxtObservacion
        '
        Me.rtxtObservacion.BackColor = System.Drawing.Color.Transparent
        Me.rtxtObservacion.BackgroundColour = System.Drawing.Color.White
        Me.rtxtObservacion.Borde = False
        Me.rtxtObservacion.BorderColour = System.Drawing.Color.DodgerBlue
        Me.rtxtObservacion.BorderSize = 3
        Me.rtxtObservacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rtxtObservacion.Location = New System.Drawing.Point(14, 108)
        Me.rtxtObservacion.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxtObservacion.Name = "rtxtObservacion"
        Me.rtxtObservacion.Radio = 12
        Me.rtxtObservacion.Size = New System.Drawing.Size(674, 29)
        Me.rtxtObservacion.TabIndex = 12
        Me.rtxtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.rtxtObservacion.UseSystemPasswordChar = False
        Me.rtxtObservacion.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial8
        '
        Me.UI_LabelMaterial8.AutoSize = True
        Me.UI_LabelMaterial8.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial8.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial8.Location = New System.Drawing.Point(11, 86)
        Me.UI_LabelMaterial8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial8.Name = "UI_LabelMaterial8"
        Me.UI_LabelMaterial8.Size = New System.Drawing.Size(103, 17)
        Me.UI_LabelMaterial8.TabIndex = 11
        Me.UI_LabelMaterial8.Text = "Observaciones"
        '
        'estadoForm
        '
        Me.estadoForm.AutoSize = True
        Me.estadoForm.Location = New System.Drawing.Point(367, 15)
        Me.estadoForm.Name = "estadoForm"
        Me.estadoForm.Size = New System.Drawing.Size(39, 13)
        Me.estadoForm.TabIndex = 10
        Me.estadoForm.Text = "Label1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpSalidaFinSemana)
        Me.GroupBox3.Controls.Add(Me.dtpEntradaFinSemana)
        Me.GroupBox3.Controls.Add(Me.UI_LabelMaterial6)
        Me.GroupBox3.Controls.Add(Me.UI_LabelMaterial7)
        Me.GroupBox3.Controls.Add(Me.cbxDomingo)
        Me.GroupBox3.Controls.Add(Me.cbxSabado)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(362, 152)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(326, 172)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fin de Semana"
        '
        'dtpSalidaFinSemana
        '
        Me.dtpSalidaFinSemana.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSalidaFinSemana.Location = New System.Drawing.Point(161, 128)
        Me.dtpSalidaFinSemana.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpSalidaFinSemana.Name = "dtpSalidaFinSemana"
        Me.dtpSalidaFinSemana.ShowUpDown = True
        Me.dtpSalidaFinSemana.Size = New System.Drawing.Size(135, 20)
        Me.dtpSalidaFinSemana.TabIndex = 157
        '
        'dtpEntradaFinSemana
        '
        Me.dtpEntradaFinSemana.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEntradaFinSemana.Location = New System.Drawing.Point(161, 53)
        Me.dtpEntradaFinSemana.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpEntradaFinSemana.Name = "dtpEntradaFinSemana"
        Me.dtpEntradaFinSemana.ShowUpDown = True
        Me.dtpEntradaFinSemana.Size = New System.Drawing.Size(135, 20)
        Me.dtpEntradaFinSemana.TabIndex = 156
        '
        'UI_LabelMaterial6
        '
        Me.UI_LabelMaterial6.AutoSize = True
        Me.UI_LabelMaterial6.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial6.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial6.Location = New System.Drawing.Point(203, 102)
        Me.UI_LabelMaterial6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial6.Name = "UI_LabelMaterial6"
        Me.UI_LabelMaterial6.Size = New System.Drawing.Size(47, 17)
        Me.UI_LabelMaterial6.TabIndex = 6
        Me.UI_LabelMaterial6.Text = "Salida"
        '
        'UI_LabelMaterial7
        '
        Me.UI_LabelMaterial7.AutoSize = True
        Me.UI_LabelMaterial7.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial7.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial7.Location = New System.Drawing.Point(197, 27)
        Me.UI_LabelMaterial7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial7.Name = "UI_LabelMaterial7"
        Me.UI_LabelMaterial7.Size = New System.Drawing.Size(58, 17)
        Me.UI_LabelMaterial7.TabIndex = 5
        Me.UI_LabelMaterial7.Text = "Entrada"
        '
        'cbxDomingo
        '
        Me.cbxDomingo.AutoSize = True
        Me.cbxDomingo.CheckColor = "#508ef5"
        Me.cbxDomingo.ForeColor = System.Drawing.Color.Chartreuse
        Me.cbxDomingo.Location = New System.Drawing.Point(22, 53)
        Me.cbxDomingo.Name = "cbxDomingo"
        Me.cbxDomingo.Size = New System.Drawing.Size(80, 20)
        Me.cbxDomingo.TabIndex = 4
        Me.cbxDomingo.Text = "Domingo"
        Me.cbxDomingo.UseVisualStyleBackColor = True
        '
        'cbxSabado
        '
        Me.cbxSabado.AutoSize = True
        Me.cbxSabado.CheckColor = "#508ef5"
        Me.cbxSabado.ForeColor = System.Drawing.Color.Chartreuse
        Me.cbxSabado.Location = New System.Drawing.Point(22, 27)
        Me.cbxSabado.Name = "cbxSabado"
        Me.cbxSabado.Size = New System.Drawing.Size(71, 20)
        Me.cbxSabado.TabIndex = 0
        Me.cbxSabado.Text = "Sabado"
        Me.cbxSabado.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpSalida)
        Me.GroupBox2.Controls.Add(Me.dtpEntrada)
        Me.GroupBox2.Controls.Add(Me.UI_LabelMaterial5)
        Me.GroupBox2.Controls.Add(Me.UI_LabelMaterial4)
        Me.GroupBox2.Controls.Add(Me.cbxMartes)
        Me.GroupBox2.Controls.Add(Me.cbxJueves)
        Me.GroupBox2.Controls.Add(Me.cbxMiercoles)
        Me.GroupBox2.Controls.Add(Me.cbxViernes)
        Me.GroupBox2.Controls.Add(Me.cbxLunes)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(14, 152)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(326, 172)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Días Semanales"
        '
        'dtpSalida
        '
        Me.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSalida.Location = New System.Drawing.Point(159, 125)
        Me.dtpSalida.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpSalida.Name = "dtpSalida"
        Me.dtpSalida.ShowUpDown = True
        Me.dtpSalida.Size = New System.Drawing.Size(135, 20)
        Me.dtpSalida.TabIndex = 147
        '
        'dtpEntrada
        '
        Me.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEntrada.Location = New System.Drawing.Point(159, 53)
        Me.dtpEntrada.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpEntrada.Name = "dtpEntrada"
        Me.dtpEntrada.ShowUpDown = True
        Me.dtpEntrada.Size = New System.Drawing.Size(135, 20)
        Me.dtpEntrada.TabIndex = 146
        '
        'UI_LabelMaterial5
        '
        Me.UI_LabelMaterial5.AutoSize = True
        Me.UI_LabelMaterial5.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial5.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial5.Location = New System.Drawing.Point(200, 102)
        Me.UI_LabelMaterial5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial5.Name = "UI_LabelMaterial5"
        Me.UI_LabelMaterial5.Size = New System.Drawing.Size(47, 17)
        Me.UI_LabelMaterial5.TabIndex = 6
        Me.UI_LabelMaterial5.Text = "Salida"
        '
        'UI_LabelMaterial4
        '
        Me.UI_LabelMaterial4.AutoSize = True
        Me.UI_LabelMaterial4.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_LabelMaterial4.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial4.Location = New System.Drawing.Point(197, 27)
        Me.UI_LabelMaterial4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial4.Name = "UI_LabelMaterial4"
        Me.UI_LabelMaterial4.Size = New System.Drawing.Size(58, 17)
        Me.UI_LabelMaterial4.TabIndex = 5
        Me.UI_LabelMaterial4.Text = "Entrada"
        '
        'cbxMartes
        '
        Me.cbxMartes.AutoSize = True
        Me.cbxMartes.CheckColor = "#508ef5"
        Me.cbxMartes.ForeColor = System.Drawing.Color.Chartreuse
        Me.cbxMartes.Location = New System.Drawing.Point(22, 53)
        Me.cbxMartes.Name = "cbxMartes"
        Me.cbxMartes.Size = New System.Drawing.Size(68, 20)
        Me.cbxMartes.TabIndex = 4
        Me.cbxMartes.Text = "Martes"
        Me.cbxMartes.UseVisualStyleBackColor = True
        '
        'cbxJueves
        '
        Me.cbxJueves.AutoSize = True
        Me.cbxJueves.CheckColor = "#508ef5"
        Me.cbxJueves.ForeColor = System.Drawing.Color.Chartreuse
        Me.cbxJueves.Location = New System.Drawing.Point(22, 102)
        Me.cbxJueves.Name = "cbxJueves"
        Me.cbxJueves.Size = New System.Drawing.Size(69, 20)
        Me.cbxJueves.TabIndex = 3
        Me.cbxJueves.Text = "Jueves"
        Me.cbxJueves.UseVisualStyleBackColor = True
        '
        'cbxMiercoles
        '
        Me.cbxMiercoles.AutoSize = True
        Me.cbxMiercoles.CheckColor = "#508ef5"
        Me.cbxMiercoles.ForeColor = System.Drawing.Color.Chartreuse
        Me.cbxMiercoles.Location = New System.Drawing.Point(22, 78)
        Me.cbxMiercoles.Name = "cbxMiercoles"
        Me.cbxMiercoles.Size = New System.Drawing.Size(85, 20)
        Me.cbxMiercoles.TabIndex = 2
        Me.cbxMiercoles.Text = "Miércoles"
        Me.cbxMiercoles.UseVisualStyleBackColor = True
        '
        'cbxViernes
        '
        Me.cbxViernes.AutoSize = True
        Me.cbxViernes.CheckColor = "#508ef5"
        Me.cbxViernes.ForeColor = System.Drawing.Color.Chartreuse
        Me.cbxViernes.Location = New System.Drawing.Point(22, 128)
        Me.cbxViernes.Name = "cbxViernes"
        Me.cbxViernes.Size = New System.Drawing.Size(71, 20)
        Me.cbxViernes.TabIndex = 1
        Me.cbxViernes.Text = "Viernes"
        Me.cbxViernes.UseVisualStyleBackColor = True
        '
        'cbxLunes
        '
        Me.cbxLunes.AutoSize = True
        Me.cbxLunes.CheckColor = "#508ef5"
        Me.cbxLunes.ForeColor = System.Drawing.Color.Chartreuse
        Me.cbxLunes.Location = New System.Drawing.Point(22, 27)
        Me.cbxLunes.Name = "cbxLunes"
        Me.cbxLunes.Size = New System.Drawing.Size(62, 20)
        Me.cbxLunes.TabIndex = 0
        Me.cbxLunes.Text = "Lunes"
        Me.cbxLunes.UseVisualStyleBackColor = True
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(324, 15)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(37, 13)
        Me.lblform.TabIndex = 7
        Me.lblform.Text = "lblform"
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.Transparent
        Me.txtnombre.BackgroundColour = System.Drawing.Color.White
        Me.txtnombre.Borde = False
        Me.txtnombre.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtnombre.BorderSize = 3
        Me.txtnombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtnombre.Location = New System.Drawing.Point(407, 46)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Radio = 12
        Me.txtnombre.Size = New System.Drawing.Size(281, 29)
        Me.txtnombre.TabIndex = 6
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtnombre.UseSystemPasswordChar = False
        Me.txtnombre.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial3
        '
        Me.UI_LabelMaterial3.AutoSize = True
        Me.UI_LabelMaterial3.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial3.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial3.Location = New System.Drawing.Point(404, 24)
        Me.UI_LabelMaterial3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial3.Name = "UI_LabelMaterial3"
        Me.UI_LabelMaterial3.Size = New System.Drawing.Size(58, 17)
        Me.UI_LabelMaterial3.TabIndex = 4
        Me.UI_LabelMaterial3.Text = "Nombre"
        '
        'txtcodigoBreve
        '
        Me.txtcodigoBreve.BackColor = System.Drawing.Color.Transparent
        Me.txtcodigoBreve.BackgroundColour = System.Drawing.Color.White
        Me.txtcodigoBreve.Borde = False
        Me.txtcodigoBreve.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtcodigoBreve.BorderSize = 3
        Me.txtcodigoBreve.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtcodigoBreve.Location = New System.Drawing.Point(163, 46)
        Me.txtcodigoBreve.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoBreve.Name = "txtcodigoBreve"
        Me.txtcodigoBreve.Radio = 12
        Me.txtcodigoBreve.Size = New System.Drawing.Size(226, 29)
        Me.txtcodigoBreve.TabIndex = 3
        Me.txtcodigoBreve.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtcodigoBreve.UseSystemPasswordChar = False
        Me.txtcodigoBreve.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial2
        '
        Me.UI_LabelMaterial2.AutoSize = True
        Me.UI_LabelMaterial2.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial2.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial2.Location = New System.Drawing.Point(159, 25)
        Me.UI_LabelMaterial2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial2.Name = "UI_LabelMaterial2"
        Me.UI_LabelMaterial2.Size = New System.Drawing.Size(74, 17)
        Me.UI_LabelMaterial2.TabIndex = 2
        Me.UI_LabelMaterial2.Text = "Cód Breve"
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
        'gbxbusqueda
        '
        Me.gbxbusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxbusqueda.BackColor = System.Drawing.Color.Transparent
        Me.gbxbusqueda.Controls.Add(Me.txtNombreB)
        Me.gbxbusqueda.Controls.Add(Me.UI_LabelMaterial9)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.ForeColor = System.Drawing.Color.White
        Me.gbxbusqueda.Location = New System.Drawing.Point(8, 417)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(710, 276)
        Me.gbxbusqueda.TabIndex = 115
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR HORARIO DE TRABAJO"
        '
        'txtNombreB
        '
        Me.txtNombreB.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreB.BackgroundColour = System.Drawing.Color.White
        Me.txtNombreB.Borde = False
        Me.txtNombreB.BorderColour = System.Drawing.Color.DodgerBlue
        Me.txtNombreB.BorderSize = 3
        Me.txtNombreB.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombreB.Location = New System.Drawing.Point(73, 22)
        Me.txtNombreB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreB.Name = "txtNombreB"
        Me.txtNombreB.Radio = 12
        Me.txtNombreB.Size = New System.Drawing.Size(281, 29)
        Me.txtNombreB.TabIndex = 14
        Me.txtNombreB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNombreB.UseSystemPasswordChar = False
        Me.txtNombreB.VisualImage = UIDC.UI_UserLoginTextBox.Visual.Suprimir
        '
        'UI_LabelMaterial9
        '
        Me.UI_LabelMaterial9.AutoSize = True
        Me.UI_LabelMaterial9.BackColor = System.Drawing.Color.Transparent
        Me.UI_LabelMaterial9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_LabelMaterial9.ForeColor = System.Drawing.Color.White
        Me.UI_LabelMaterial9.Location = New System.Drawing.Point(11, 26)
        Me.UI_LabelMaterial9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UI_LabelMaterial9.Name = "UI_LabelMaterial9"
        Me.UI_LabelMaterial9.Size = New System.Drawing.Size(58, 17)
        Me.UI_LabelMaterial9.TabIndex = 13
        Me.UI_LabelMaterial9.Text = "Nombre"
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.ForeColor = System.Drawing.Color.White
        Me.lblcantidad.Location = New System.Drawing.Point(227, 253)
        Me.lblcantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(25, 13)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
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
        Me.dgbtabla.Location = New System.Drawing.Point(8, 58)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(698, 187)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.ForeColor = System.Drawing.Color.White
        Me.lbltotal.Location = New System.Drawing.Point(10, 253)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(190, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE HORARIOS DE TRABAJO"
        '
        'RH_Horarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(733, 701)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RH_Horarios"
        Me.Text = "Horarios de Trabajo"
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblform As Label
    Friend WithEvents txtnombre As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial3 As UIDC.UI_LabelMaterial
    Friend WithEvents txtcodigoBreve As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial2 As UIDC.UI_LabelMaterial
    Friend WithEvents txtcodigo As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial1 As UIDC.UI_LabelMaterial
    Friend WithEvents rtxtObservacion As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial8 As UIDC.UI_LabelMaterial
    Friend WithEvents estadoForm As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpSalidaFinSemana As DateTimePicker
    Friend WithEvents dtpEntradaFinSemana As DateTimePicker
    Friend WithEvents UI_LabelMaterial6 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial7 As UIDC.UI_LabelMaterial
    Friend WithEvents cbxDomingo As UIDC.UI_CheckBox
    Friend WithEvents cbxSabado As UIDC.UI_CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpSalida As DateTimePicker
    Friend WithEvents dtpEntrada As DateTimePicker
    Friend WithEvents UI_LabelMaterial5 As UIDC.UI_LabelMaterial
    Friend WithEvents UI_LabelMaterial4 As UIDC.UI_LabelMaterial
    Friend WithEvents cbxMartes As UIDC.UI_CheckBox
    Friend WithEvents cbxJueves As UIDC.UI_CheckBox
    Friend WithEvents cbxMiercoles As UIDC.UI_CheckBox
    Friend WithEvents cbxViernes As UIDC.UI_CheckBox
    Friend WithEvents cbxLunes As UIDC.UI_CheckBox
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents txtNombreB As UIDC.UI_UserLoginTextBox
    Friend WithEvents UI_LabelMaterial9 As UIDC.UI_LabelMaterial
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
End Class
