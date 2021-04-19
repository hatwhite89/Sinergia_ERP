Public Class RH_BuscarCapacitaciones
    Dim objCap As New ClsCapacitaciones
    Dim dv As DataView = objCap.SeleccionarCapacitaciones.DefaultView
    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        RH_Capacitaciones.limpiar()
        RH_Capacitaciones.Show()
    End Sub
    Public Sub SeleccionarCapacitaciones()
        dv = objCap.SeleccionarCapacitaciones.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count

    End Sub

    Private Sub M_BuscarCapacitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeleccionarCapacitaciones()
        alternarColoFilasDatagridview(dgbtabla)
        'CAMBIO DE NOMBRE COLUMNAS
        dgbtabla.Columns("codigo").HeaderText = "Código"
        dgbtabla.Columns("fecha").HeaderText = "Fecha Capacitación"
        dgbtabla.Columns("nombre").HeaderText = "Nombre"
        dgbtabla.Columns("cantidadHoras").HeaderText = "Cantidad de Horas"
        dgbtabla.Columns("proveedor").HeaderText = "Proveedor"
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        objCap.desde_ = dtpDesde.Value
        objCap.hasta_ = dtpHasta.Value
        dv = objCap.BuscarCapacitacionPorFechas.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count

    End Sub

    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        dv.RowFilter = String.Format("nombre Like '%{0}%'", txtnombreB.Text)
        lblcantidad.Text = dv.Count

        If lblcantidad.Text = "0" Then
            MsgBox("No existe la capacitación.", MsgBoxStyle.Exclamation)
            txtnombreB.Text = ""
            SeleccionarCapacitaciones()
        End If
    End Sub

    Private Sub txtProveedorB_TextChanged(sender As Object, e As EventArgs) Handles txtProveedorB.TextChanged
        dv.RowFilter = String.Format("proveedor Like '%{0}%'", txtProveedorB.Text)
        lblcantidad.Text = dv.Count

        If lblcantidad.Text = "0" Then
            MsgBox("No existe la capacitación.", MsgBoxStyle.Exclamation)
            txtProveedorB.Text = ""
            SeleccionarCapacitaciones()
        End If
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim dt As New DataTable
            Dim row As DataRow
            If lblform.Text = "M_BuscarCapacitaciones" Then
                Dim n As String = ""
                'Dim temp As String = M_ListaPrecios.dgbtabla.Rows(lblFila.Text).Cells(2).Value()
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea actualizar la capacitación que a seleccionado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'Llenado campos de capacitacion
                    RH_Capacitaciones.txtCodigo.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    RH_Capacitaciones.dtpFecha.Value = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    RH_Capacitaciones.txtNombre.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value()
                    RH_Capacitaciones.txtCantidadHoras.Text = dgbtabla.Rows(e.RowIndex).Cells(3).Value()
                    RH_Capacitaciones.txtProveedor.Text = dgbtabla.Rows(e.RowIndex).Cells(4).Value()
                    Dim objDetFact As New ClsDetalleCapacitaciones
                    objDetFact.codigoCapacitacion_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    dt = objDetFact.BuscarDetalleCapacitacion()
                    For index As Integer = 0 To dt.Rows.Count - 1
                        'Llenado beneficiarios
                        row = dt.Rows(index)
                        RH_Capacitaciones.dgvBeneficiarios.Rows.Add(New String() {CStr(row("codigo")), CStr(row("codigoEmpleado")), CStr(row("nombreCompleto")), CStr(row("puestoTrabajo")), CStr(row("Departamento"))})
                    Next
                End If
                RH_Capacitaciones.btnGuardar.Enabled = False
                RH_Capacitaciones.btnModificar.Enabled = True
                RH_Capacitaciones.Show()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            'limpiar()
            Me.Close()
        End If
    End Sub
End Class