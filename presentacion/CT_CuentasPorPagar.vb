Public Class CT_CuentasPorPagar

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        CT_Proveedores.lblForm.Text = "CT_CuentasPorPagar"
        CT_Proveedores.Show()
    End Sub
    Public Sub llenarTerminoPago()
        Try
            'llenar el combobox termino de pago
            Dim objTerm As New ClsTerminoPago
            Dim dt As New DataTable
            dt = objTerm.SeleccionarTerminoPago()
            cmbxTerminoPago.DataSource = dt
            cmbxTerminoPago.DisplayMember = "descripcion"
            cmbxTerminoPago.ValueMember = "id"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CT_TerminoPago.Show()
    End Sub
    Private Sub CerrarForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub txtDebito_Leave(sender As Object, e As EventArgs) Handles txtDebito.Leave
        'Mostrar el numero con 2 decimales N2 = 1,000.00   y F2 = 1000.00
        Try
            If Trim(txtDebito.Text) <> "" Then
                txtDebito.Text = Convert.ToDecimal(txtDebito.Text).ToString("N2")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCredito_Leave(sender As Object, e As EventArgs) Handles txtCredito.Leave
        'Mostrar el numero con 2 decimales N2 = 1,000.00   y F2 = 1000.00
        Try
            If Trim(txtCredito.Text) <> "" Then
                txtCredito.Text = Convert.ToDecimal(txtCredito.Text).ToString("N2")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SUMARHABER()
        Dim Total As Single
        For Each row As DataGridViewRow In dgvDetalleProveedor.Rows
            Total += Val(row.Cells(6).Value)
        Next
        txtSaldo.Text = "L." + Total.ToString
    End Sub

    Public Sub llenarMovimientos()
        Try
            Dim objMov As New ClsTipoMovimiento
            'llenar el combobox tipo permiso
            Dim dt As New DataTable
            dt = objMov.ListarTipoMov()
            cmbxTipoMovimiento.DataSource = dt
            cmbxTipoMovimiento.DisplayMember = "nombre"
            cmbxTipoMovimiento.ValueMember = "id_tipomov"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub CT_CuentasPorPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenar combo box termino de pago
        llenarTerminoPago()
        llenarMovimientos()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub sinDobleEspacio(ByRef cadena As String)
        Dim texto As String = ""
        Dim testArray() As String = Split(cadena)
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                texto += testArray(i) + " "
            End If
        Next
        cadena = RTrim(texto)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Trim(txtDescripcion.Text) <> "" And Trim(txtId.Text) <> "" Then

                Dim objDetMov As New ClsDetalleMovimientos_Proveedor
                Dim id As String
                sinDobleEspacio(txtNombre.Text)
                With objDetMov
                    .id_Proveedor_ = Integer.Parse(txtId.Text)
                    .id_TipoMovimiento_ = 1
                    .descripcion_ = txtDescripcion.Text
                    If txtDebito.Text = "" Then
                        .debito_ = 0
                    Else
                        .debito_ = Double.Parse(txtDebito.Text)
                    End If
                    If txtCredito.Text = "" Then
                        .credito_ = 0
                    Else
                        .credito_ = Double.Parse(txtCredito.Text)
                    End If
                    .credito_ = Double.Parse(txtCredito.Text)
                    .id_terminoPago_ = cmbxTerminoPago.SelectedValue
                    .fecha_ = dtpFecha.Value
                    .pagado_ = 0
                    .anulado_ = 0
                    .identificador_ = txtIdentificador.Text
                End With

                id = objDetMov.RegistrarNuevoDetalleMovimientos_Proveedor()

                'dgvDetalleProveedor.Rows.Add(id, cmbxTipoMovimiento.Text, txtDescripcion.Text, txtDebito.Text, txtCredito.Text, cmbxTerminoPago.Text, dtpFecha.Value)
                dgvDetalleProveedor.Rows.Insert(0, New String() {id, cmbxTipoMovimiento.Text, cmbxTipoMovimiento.SelectedValue, txtIdentificador.Text, txtDescripcion.Text, txtDebito.Text, txtCredito.Text, cmbxTerminoPago.SelectedValue, cmbxTerminoPago.Text, dtpFecha.Value, False, False})
                lblmsj.Text = "Se agrego el registro exitosamente."
                SUMARHABER()
            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvDetalleProveedor_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleProveedor.CellEndEdit
        Try
            If e.ColumnIndex = 4 Then
                MODIFICAR_DETALLE(e.RowIndex)
                dgvDetalleProveedor.Rows.Clear()
                CARGAR_DETALLE()
            ElseIf e.ColumnIndex = 3 Then
                MODIFICAR_DETALLE(e.RowIndex)
                dgvDetalleProveedor.Rows.Clear()
                CARGAR_DETALLE()
            ElseIf e.ColumnIndex = 10 Then
                MODIFICAR_DETALLE_PAGO(e.RowIndex)
                dgvDetalleProveedor.Rows.Clear()
                CARGAR_DETALLE()
            ElseIf e.ColumnIndex = 11 Then
                MODIFICAR_DETALLE(e.RowIndex)
                dgvDetalleProveedor.Rows.Clear()
                CARGAR_DETALLE()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSaldo_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged
        Try
            If txtSaldo.Text <> "L.0" Then
                txtSaldo.BackColor = Color.Salmon
            Else
                txtSaldo.BackColor = Color.White
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub CARGAR_DETALLE()
        Try
            If Trim(txtId.Text) <> "" Then
                Dim objDetMovi As New ClsDetalleMovimientos_Proveedor
                objDetMovi.id_Proveedor_ = Integer.Parse(txtId.Text)
                Dim dt As DataTable = objDetMovi.BuscarDetalleMovimientos_Proveedor
                Dim row As DataRow
                For index = 0 To dt.Rows.Count - 1
                    row = dt.Rows(index)
                    dgvDetalleProveedor.Rows.Insert(0, New String() {CStr(row("id")), CStr(row("TipoMovimiento")), CStr(row("id_TipoMovimiento")), CStr(row("identificador")), CStr(row("descripcion")), CStr(row("debito")), CStr(row("credito")), CStr(row("id_TerminoPago")), CStr(row("TerminoPago")), CStr(row("fecha")), CStr(row("pagado")), CStr(row("anulado"))})
                Next
                SUMARHABER()
                CambioColoresDataGridView()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub COLOR_PAGADOS()

        If dgvDetalleProveedor.Rows.Count <> 0 Then

            For i = 0 To dgvDetalleProveedor.Rows.Count - 1
                If dgvDetalleProveedor.Rows(i).Cells(10).Value = True Then
                    dgvDetalleProveedor.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
                End If
            Next

        End If

    End Sub

    Private Sub CambioColoresDataGridView()
        If dgvDetalleProveedor.Rows.Count <> 0 Then
            For i = 0 To dgvDetalleProveedor.Rows.Count - 1
                'Tacha los anulados
                If dgvDetalleProveedor.Rows(i).Cells(11).Value = True Then
                    dgvDetalleProveedor.Rows(i).DefaultCellStyle.BackColor = Color.White
                    dgvDetalleProveedor.Rows(i).DefaultCellStyle.Font = New Font(Font.Name, Font.Size, FontStyle.Strikeout)
                End If
                'Muestra los pagados en amarillo
                If dgvDetalleProveedor.Rows(i).Cells(10).Value = True Then
                    dgvDetalleProveedor.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
                End If
            Next
        End If
    End Sub

    Private Sub TACHAR_ANULADOS()


        If dgvDetalleProveedor.Rows.Count <> 0 Then

            For i = 0 To dgvDetalleProveedor.Rows.Count - 1
                'Tacha los anulados
                If dgvDetalleProveedor.Rows(i).Cells(11).Value = True Then
                    dgvDetalleProveedor.Rows(i).DefaultCellStyle.BackColor = Color.White
                    dgvDetalleProveedor.Rows(i).DefaultCellStyle.Font = New Font(Font.Name, Font.Size, FontStyle.Strikeout)
                End If
            Next

        End If

    End Sub
    'Private Sub dgvDetalleProveedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleProveedor.CellClick
    '    Try
    '        If e.ColumnIndex = 10 Then
    '            MsgBox("Entra en cellclick")
    '            With objDetMov
    '                .id_ = dgvDetalleProveedor.Rows(e.RowIndex).Cells(0).Value
    '                .id_Proveedor_ = Integer.Parse(txtId.Text)
    '                .id_TipoMovimiento_ = dgvDetalleProveedor.Rows(e.RowIndex).Cells(2).Value
    '                .descripcion_ = dgvDetalleProveedor.Rows(e.RowIndex).Cells(4).Value
    '                If dgvDetalleProveedor.Rows(e.RowIndex).Cells(10).Value Then
    '                    .debito_ = 0
    '                    .credito_ = Double.Parse(dgvDetalleProveedor.Rows(e.RowIndex).Cells(5).Value)
    '                Else
    '                    .debito_ = Double.Parse(dgvDetalleProveedor.Rows(e.RowIndex).Cells(6).Value)
    '                    .credito_ = Double.Parse(dgvDetalleProveedor.Rows(e.RowIndex).Cells(5).Value)
    '                End If
    '                .id_terminoPago_ = Integer.Parse(dgvDetalleProveedor.Rows(e.RowIndex).Cells(7).Value)
    '                .fecha_ = dgvDetalleProveedor.Rows(e.RowIndex).Cells(9).Value
    '                .pagado_ = dgvDetalleProveedor.Rows(e.RowIndex).Cells(10).Value
    '                .anulado_ = dgvDetalleProveedor.Rows(e.RowIndex).Cells(11).Value
    '                .identificador_ = dgvDetalleProveedor.Rows(e.RowIndex).Cells(3).Value
    '                'MsgBox(dgvDetalleProveedor.Rows(e.RowIndex).Cells(9).Value)
    '                If .ModificarDetalleMovimientos_Proveedor = 1 Then
    '                    'dgvDetalleProveedor.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
    '                    'dgvDetalleProveedor.Rows(e.RowIndex).Cells(6).Value = dgvDetalleProveedor.Rows(e.RowIndex).Cells(5).Value
    '                    'dgvDetalleProveedor.Rows(e.RowIndex).Cells(5).Value = "0"
    '                    lblmsj.Text = "Se actualizo el registro exitosamente."
    '                End If
    '                CARGAR_DETALLE()
    '            End With
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)

    '    End Try
    'End Sub
    Private Sub MODIFICAR_DETALLE(fila As Integer)
        MsgBox("Entra al actualizar")
        Dim objDetMov As New ClsDetalleMovimientos_Proveedor
        With objDetMov
            .id_ = dgvDetalleProveedor.Rows(fila).Cells(0).Value
            .id_Proveedor_ = Integer.Parse(txtId.Text)
            .id_TipoMovimiento_ = dgvDetalleProveedor.Rows(fila).Cells(2).Value
            .descripcion_ = dgvDetalleProveedor.Rows(fila).Cells(4).Value
            .debito_ = Double.Parse(dgvDetalleProveedor.Rows(fila).Cells(5).Value)
            .credito_ = Double.Parse(dgvDetalleProveedor.Rows(fila).Cells(6).Value)
            .id_terminoPago_ = Integer.Parse(dgvDetalleProveedor.Rows(fila).Cells(7).Value)
            .fecha_ = dgvDetalleProveedor.Rows(fila).Cells(9).Value
            .pagado_ = dgvDetalleProveedor.Rows(fila).Cells(10).Value
            .anulado_ = dgvDetalleProveedor.Rows(fila).Cells(11).Value
            .identificador_ = dgvDetalleProveedor.Rows(fila).Cells(3).Value
            If .ModificarDetalleMovimientos_Proveedor = 1 Then
                lblmsj.Text = "Se actualizo el registro exitosamente."
            End If
            CARGAR_DETALLE()
        End With

    End Sub
    Private Sub MODIFICAR_DETALLE_PAGO(fila As Integer)
        MsgBox("Entra al darle check en pagar")
        Dim objDetMov As New ClsDetalleMovimientos_Proveedor
        With objDetMov
            .id_ = dgvDetalleProveedor.Rows(fila).Cells(0).Value
            .id_Proveedor_ = Integer.Parse(txtId.Text)
            .id_TipoMovimiento_ = dgvDetalleProveedor.Rows(fila).Cells(2).Value
            .descripcion_ = dgvDetalleProveedor.Rows(fila).Cells(4).Value
            If dgvDetalleProveedor.Rows(fila).Cells(10).Value Then
                .debito_ = Double.Parse(dgvDetalleProveedor.Rows(fila).Cells(6).Value)
                .credito_ = Double.Parse(dgvDetalleProveedor.Rows(fila).Cells(5).Value)
            Else
                .debito_ = Double.Parse(dgvDetalleProveedor.Rows(fila).Cells(6).Value)
                .credito_ = Double.Parse(dgvDetalleProveedor.Rows(fila).Cells(5).Value)
            End If
            .id_terminoPago_ = Integer.Parse(dgvDetalleProveedor.Rows(fila).Cells(7).Value)
            .fecha_ = dgvDetalleProveedor.Rows(fila).Cells(9).Value
            .pagado_ = dgvDetalleProveedor.Rows(fila).Cells(10).Value
            .anulado_ = dgvDetalleProveedor.Rows(fila).Cells(11).Value
            .identificador_ = dgvDetalleProveedor.Rows(fila).Cells(3).Value
            'MsgBox(dgvDetalleProveedor.Rows(fila).Cells(9).Value)
            If .ModificarDetalleMovimientos_Proveedor = 1 Then
                'dgvDetalleProveedor.Rows(fila).DefaultCellStyle.BackColor = Color.Yellow
                'dgvDetalleProveedor.Rows(fila).Cells(6).Value = dgvDetalleProveedor.Rows(fila).Cells(5).Value
                'dgvDetalleProveedor.Rows(fila).Cells(5).Value = "0"
                lblmsj.Text = "Se actualizo el registro exitosamente."
            End If
            CARGAR_DETALLE()
        End With

    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Try
            If Trim(txtId.Text) <> "" Then
                Dim objDetMov As New ClsDetalleMovimientos_Proveedor
                If dgvDetalleProveedor.Rows.Count <> 0 Then
                    dgvDetalleProveedor.Rows.Clear()
                End If
                objDetMov.id_Proveedor_ = Integer.Parse(txtId.Text)
                Dim dt As DataTable = objDetMov.BuscarDetalleMovimientos_Proveedor
                Dim row As DataRow
                For index = 0 To dt.Rows.Count - 1
                    row = dt.Rows(index)
                    dgvDetalleProveedor.Rows.Insert(0, New String() {CStr(row("id")), CStr(row("TipoMovimiento")), CStr(row("id_TipoMovimiento")), CStr(row("identificador")), CStr(row("descripcion")), CStr(row("debito")), CStr(row("credito")), CStr(row("id_TerminoPago")), CStr(row("TerminoPago")), CStr(row("fecha")), CStr(row("pagado")), CStr(row("anulado"))})
                Next
                CambioColoresDataGridView()
                SUMARHABER()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class