<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UI_TitleBanner1 = New UIDC.UI_TitleBanner()
        Me.UI_Separator1 = New UIDC.uI_Separator()
        Me.UI_ButtonImage1 = New UIDC.UI_ButtonImage()
        Me.UI_ButtonImage2 = New UIDC.UI_ButtonImage()
        Me.UI_ButtonImage3 = New UIDC.UI_ButtonImage()
        Me.UI_ButtonImage4 = New UIDC.UI_ButtonImage()
        Me.UI_ButtonImage5 = New UIDC.UI_ButtonImage()
        Me.dgvOpciones = New System.Windows.Forms.DataGridView()
        Me.Opciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.UI_ButtonImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UI_ButtonImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UI_ButtonImage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UI_ButtonImage4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UI_ButtonImage5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UI_TitleBanner1
        '
        Me.UI_TitleBanner1.Animate = UIDC.UI_TitleBanner.Anim.AnimateOFF
        Me.UI_TitleBanner1.BackColor = System.Drawing.Color.RoyalBlue
        Me.UI_TitleBanner1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UI_TitleBanner1.ButtonMenuActive = UIDC.UI_TitleBanner.Active.ActiveOff
        Me.UI_TitleBanner1.ButtonsVisible = UIDC.UI_TitleBanner.ButtonVisible.Close_Maximize_Minimize
        Me.UI_TitleBanner1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UI_TitleBanner1.FlatAppearance.BorderSize = 0
        Me.UI_TitleBanner1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.UI_TitleBanner1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.UI_TitleBanner1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UI_TitleBanner1.Font = New System.Drawing.Font("Roboto", 15.0!)
        Me.UI_TitleBanner1.ForeColor = System.Drawing.Color.White
        Me.UI_TitleBanner1.Location = New System.Drawing.Point(0, 0)
        Me.UI_TitleBanner1.Margin = New System.Windows.Forms.Padding(2)
        Me.UI_TitleBanner1.MoveActive = False
        Me.UI_TitleBanner1.Name = "UI_TitleBanner1"
        Me.UI_TitleBanner1.Padding = New System.Windows.Forms.Padding(15, 12, 0, 0)
        Me.UI_TitleBanner1.ParentControl = Me
        Me.UI_TitleBanner1.Size = New System.Drawing.Size(668, 70)
        Me.UI_TitleBanner1.TabIndex = 1
        Me.UI_TitleBanner1.Text = "Menu Principal"
        Me.UI_TitleBanner1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.UI_TitleBanner1.TypeWindows = UIDC.UI_TitleBanner.TypeTheme.Material
        Me.UI_TitleBanner1.UseVisualStyleBackColor = False
        '
        'UI_Separator1
        '
        Me.UI_Separator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UI_Separator1.BackColor = System.Drawing.Color.Transparent
        Me.UI_Separator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.UI_Separator1.LineSize = 3
        Me.UI_Separator1.Location = New System.Drawing.Point(178, 164)
        Me.UI_Separator1.Margin = New System.Windows.Forms.Padding(2)
        Me.UI_Separator1.Name = "UI_Separator1"
        Me.UI_Separator1.Size = New System.Drawing.Size(300, 15)
        Me.UI_Separator1.TabIndex = 2
        Me.UI_Separator1.Transparency = 100
        Me.UI_Separator1.Vertical = False
        '
        'UI_ButtonImage1
        '
        Me.UI_ButtonImage1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_ButtonImage1.Image = CType(resources.GetObject("UI_ButtonImage1.Image"), System.Drawing.Image)
        Me.UI_ButtonImage1.ImageActive = Nothing
        Me.UI_ButtonImage1.Location = New System.Drawing.Point(110, 74)
        Me.UI_ButtonImage1.Margin = New System.Windows.Forms.Padding(2)
        Me.UI_ButtonImage1.Name = "UI_ButtonImage1"
        Me.UI_ButtonImage1.Size = New System.Drawing.Size(77, 81)
        Me.UI_ButtonImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UI_ButtonImage1.TabIndex = 3
        Me.UI_ButtonImage1.TabStop = False
        Me.UI_ButtonImage1.Zoom = 10
        '
        'UI_ButtonImage2
        '
        Me.UI_ButtonImage2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_ButtonImage2.Image = CType(resources.GetObject("UI_ButtonImage2.Image"), System.Drawing.Image)
        Me.UI_ButtonImage2.ImageActive = Nothing
        Me.UI_ButtonImage2.Location = New System.Drawing.Point(205, 62)
        Me.UI_ButtonImage2.Margin = New System.Windows.Forms.Padding(2)
        Me.UI_ButtonImage2.Name = "UI_ButtonImage2"
        Me.UI_ButtonImage2.Size = New System.Drawing.Size(80, 93)
        Me.UI_ButtonImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UI_ButtonImage2.TabIndex = 4
        Me.UI_ButtonImage2.TabStop = False
        Me.UI_ButtonImage2.Zoom = 10
        '
        'UI_ButtonImage3
        '
        Me.UI_ButtonImage3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_ButtonImage3.Image = CType(resources.GetObject("UI_ButtonImage3.Image"), System.Drawing.Image)
        Me.UI_ButtonImage3.ImageActive = Nothing
        Me.UI_ButtonImage3.Location = New System.Drawing.Point(295, 62)
        Me.UI_ButtonImage3.Margin = New System.Windows.Forms.Padding(2)
        Me.UI_ButtonImage3.Name = "UI_ButtonImage3"
        Me.UI_ButtonImage3.Size = New System.Drawing.Size(77, 93)
        Me.UI_ButtonImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UI_ButtonImage3.TabIndex = 5
        Me.UI_ButtonImage3.TabStop = False
        Me.UI_ButtonImage3.Zoom = 10
        '
        'UI_ButtonImage4
        '
        Me.UI_ButtonImage4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_ButtonImage4.Image = CType(resources.GetObject("UI_ButtonImage4.Image"), System.Drawing.Image)
        Me.UI_ButtonImage4.ImageActive = Nothing
        Me.UI_ButtonImage4.Location = New System.Drawing.Point(386, 62)
        Me.UI_ButtonImage4.Margin = New System.Windows.Forms.Padding(2)
        Me.UI_ButtonImage4.Name = "UI_ButtonImage4"
        Me.UI_ButtonImage4.Size = New System.Drawing.Size(79, 93)
        Me.UI_ButtonImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UI_ButtonImage4.TabIndex = 6
        Me.UI_ButtonImage4.TabStop = False
        Me.UI_ButtonImage4.Zoom = 10
        '
        'UI_ButtonImage5
        '
        Me.UI_ButtonImage5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UI_ButtonImage5.Image = CType(resources.GetObject("UI_ButtonImage5.Image"), System.Drawing.Image)
        Me.UI_ButtonImage5.ImageActive = Nothing
        Me.UI_ButtonImage5.Location = New System.Drawing.Point(478, 62)
        Me.UI_ButtonImage5.Margin = New System.Windows.Forms.Padding(2)
        Me.UI_ButtonImage5.Name = "UI_ButtonImage5"
        Me.UI_ButtonImage5.Size = New System.Drawing.Size(74, 93)
        Me.UI_ButtonImage5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UI_ButtonImage5.TabIndex = 7
        Me.UI_ButtonImage5.TabStop = False
        Me.UI_ButtonImage5.Zoom = 10
        '
        'dgvOpciones
        '
        Me.dgvOpciones.AllowUserToAddRows = False
        Me.dgvOpciones.AllowUserToDeleteRows = False
        Me.dgvOpciones.AllowUserToResizeColumns = False
        Me.dgvOpciones.AllowUserToResizeRows = False
        Me.dgvOpciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOpciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvOpciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOpciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOpciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOpciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Opciones})
        Me.dgvOpciones.GridColor = System.Drawing.Color.White
        Me.dgvOpciones.Location = New System.Drawing.Point(9, 183)
        Me.dgvOpciones.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvOpciones.MultiSelect = False
        Me.dgvOpciones.Name = "dgvOpciones"
        Me.dgvOpciones.ReadOnly = True
        Me.dgvOpciones.RowHeadersWidth = 51
        Me.dgvOpciones.RowTemplate.Height = 24
        Me.dgvOpciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOpciones.Size = New System.Drawing.Size(648, 336)
        Me.dgvOpciones.TabIndex = 8
        '
        'Opciones
        '
        Me.Opciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Opciones.HeaderText = "Opciones"
        Me.Opciones.MinimumWidth = 6
        Me.Opciones.Name = "Opciones"
        Me.Opciones.ReadOnly = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(668, 529)
        Me.Controls.Add(Me.UI_TitleBanner1)
        Me.Controls.Add(Me.dgvOpciones)
        Me.Controls.Add(Me.UI_ButtonImage5)
        Me.Controls.Add(Me.UI_ButtonImage4)
        Me.Controls.Add(Me.UI_ButtonImage3)
        Me.Controls.Add(Me.UI_ButtonImage2)
        Me.Controls.Add(Me.UI_ButtonImage1)
        Me.Controls.Add(Me.UI_Separator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        CType(Me.UI_ButtonImage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UI_ButtonImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UI_ButtonImage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UI_ButtonImage4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UI_ButtonImage5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UI_TitleBanner1 As UIDC.UI_TitleBanner
    Friend WithEvents UI_Separator1 As UIDC.uI_Separator
    Friend WithEvents UI_ButtonImage2 As UIDC.UI_ButtonImage
    Friend WithEvents UI_ButtonImage1 As UIDC.UI_ButtonImage
    Friend WithEvents UI_ButtonImage4 As UIDC.UI_ButtonImage
    Friend WithEvents UI_ButtonImage3 As UIDC.UI_ButtonImage
    Friend WithEvents UI_ButtonImage5 As UIDC.UI_ButtonImage
    Friend WithEvents dgvOpciones As DataGridView
    Friend WithEvents Opciones As DataGridViewTextBoxColumn
End Class
