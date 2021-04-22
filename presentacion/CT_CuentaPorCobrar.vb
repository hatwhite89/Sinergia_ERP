Public Class CT_CuentaPorCobrar
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CT_Clientes.Show()
        CT_Clientes.FormularioDeLlamada = "Cobro"

    End Sub

    Private Sub SUMARDEBE()
        Dim Total As Single
        For Each row As DataGridViewRow In dgvDetalleCliente.Rows
            Total += Val(row.Cells(5).Value)
        Next
        txtSaldo.Text = "L." + Total.ToString
    End Sub

    Private Sub CARGAR_DETALLE()

        If txtId.Text <> "" Then

            Dim objDetalleCLiente As New ClsDetalleMovimientos_Cliente
            Dim dt As New DataTable
            Dim row As DataRow

            With objDetalleCLiente

                .Id_Cliente = Integer.Parse(txtId.Text)
                dt = .MostrarDetalleXCliente

                For i = 0 To dt.Rows.Count - 1
                    row = dt.Rows(i)

                    dgvDetalleCliente.Rows.Insert(0, New String() {CStr(row("id")), row("idTipoMovimiento"), row("nombre"), row("identificador"), row("descripcion"), row("debito"), row("credito"), row("idTerminoPago"), row("descrip"), row("fecha"), row("pagado"), row("anulado")})
                    SUMARDEBE()
                    COLOR_PAGADOS()
                    TACHAR_ANULADOS()


                Next

            End With

        End If

    End Sub

    Private Sub COLOR_PAGADOS()


        If dgvDetalleCliente.Rows.Count <> 0 Then

            For i = 0 To dgvDetalleCliente.Rows.Count - 1

                If dgvDetalleCliente.Rows(i).Cells(10).Value = True Then

                    dgvDetalleCliente.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
                End If

            Next

        End If

    End Sub

    Private Sub TACHAR_ANULADOS()


        If dgvDetalleCliente.Rows.Count <> 0 Then

            For i = 0 To dgvDetalleCliente.Rows.Count - 1

                If dgvDetalleCliente.Rows(i).Cells(11).Value = True Then
                    dgvDetalleCliente.Rows(i).DefaultCellStyle.BackColor = Color.White
                    dgvDetalleCliente.Rows(i).DefaultCellStyle.Font = New Font(Font.Name, Font.Size, FontStyle.Strikeout)
                End If

            Next

        End If

    End Sub

    Private Sub GUARDAR_DETALLE()

        If txtDescripcion.Text <> "" Then

            If txtDebito.Text <> "" Or txtCredito.Text <> "" Then

                Dim objDetalle As New ClsDetalleMovimientos_Cliente
                Dim codigo As String

                With objDetalle

                    .Id_Cliente = Integer.Parse(txtId.Text)
                    .id_TipoMovimiento_ = Integer.Parse(cbxTipoMov.SelectedValue)
                    .descripcion_ = txtDescripcion.Text

                    If txtDebito.Text <> "" Then
                        .debito_ = Double.Parse(txtDebito.Text)
                    Else
                        .debito_ = 0
                    End If

                    If txtCredito.Text <> "" Then
                        .credito_ = Double.Parse(txtCredito.Text)
                    Else
                        .credito_ = 0
                    End If
                    .id_terminoPago_ = Integer.Parse(cbxTerminoPago.SelectedValue)
                    .fecha_ = DateTimePicker1.Value
                    .pagado_ = 0
                    .anulado_ = 0
                    .identificador_ = txtFactura.Text
                    codigo = .RegistrarNuevoDetalle

                    If codigo > 0 Then

                        dgvDetalleCliente.Rows.Insert(0, New String() {codigo, cbxTipoMov.SelectedValue, cbxTipoMov.Text, txtFactura.Text, txtDescripcion.Text, txtDebito.Text, txtCredito.Text, cbxTerminoPago.SelectedValue, cbxTerminoPago.Text, DateTimePicker1.Value, "", False})
                        SUMARDEBE()
                        lblmsj.Text = "Se inserto un movimiento contable correctamente."


                    End If

                End With

            End If

        End If



    End Sub

    Public Sub llenarTerminoPago()
        Try
            Dim objTerm As New ClsTerminoPago
            'llenar el combobox tipo permiso
            Dim dt As New DataTable
            dt = objTerm.SeleccionarTerminoPago()
            cbxTerminoPago.DataSource = dt
            cbxTerminoPago.DisplayMember = "descripcion"
            cbxTerminoPago.ValueMember = "id"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub

    Public Sub llenarMovimientos()
        Try
            Dim objMov As New ClsTipoMovimiento
            'llenar el combobox tipo permiso
            Dim dt As New DataTable
            dt = objMov.ListarTipoMov()
            cbxTipoMov.DataSource = dt
            cbxTipoMov.DisplayMember = "nombre"
            cbxTipoMov.ValueMember = "id_tipomov"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub CT_CuentaPorCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            llenarMovimientos()
            llenarTerminoPago()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Try

            If txtNombre.Text = "" Then

                GroupBox2.Enabled = False
            Else
                GroupBox2.Enabled = True

                If dgvDetalleCliente.Rows.Count <> 0 Then

                    dgvDetalleCliente.Rows.Clear()
                    CARGAR_DETALLE()
                Else
                    CARGAR_DETALLE()

                End If




            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            GUARDAR_DETALLE()

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

        End Try
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub dgvDetalleCliente_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleCliente.CellEndEdit


        Try


            If e.ColumnIndex = 4 Then


                MODIFICAR_DETALLE(e.RowIndex)
                dgvDetalleCliente.Rows.Clear()
                CARGAR_DETALLE()
            ElseIf e.ColumnIndex = 3 Then
                MODIFICAR_DETALLE(e.RowIndex)
                dgvDetalleCliente.Rows.Clear()
                CARGAR_DETALLE()
            ElseIf e.ColumnIndex = 10 Then
                MODIFICAR_DETALLE(e.RowIndex)
                dgvDetalleCliente.Rows.Clear()
                COLOR_PAGADOS()
                CARGAR_DETALLE()
                TACHAR_ANULADOS()
            ElseIf e.ColumnIndex = 11 Then
                MODIFICAR_DETALLE(e.RowIndex)
                dgvDetalleCliente.Rows.Clear()
                CARGAR_DETALLE()
                COLOR_PAGADOS()
                TACHAR_ANULADOS()
            End If


        Catch ex As Exception

        End Try


    End Sub


    Private Sub MODIFICAR_DETALLE(fila As Integer)


        Dim objDetalleModificar As New ClsDetalleMovimientos_Cliente

        With objDetalleModificar

            .id_ = Integer.Parse(dgvDetalleCliente.Rows(fila).Cells(0).Value)
            .identificador_ = dgvDetalleCliente.Rows(fila).Cells(3).Value
            .descripcion_ = dgvDetalleCliente.Rows(fila).Cells(4).Value
            .debito_ = Double.Parse(dgvDetalleCliente.Rows(fila).Cells(5).Value)
            .credito_ = Double.Parse(dgvDetalleCliente.Rows(fila).Cells(6).Value)
            .pagado_ = dgvDetalleCliente.Rows(fila).Cells(10).Value
            .anulado_ = dgvDetalleCliente.Rows(fila).Cells(11).Value
            .ActualizarDetalle()
            CARGAR_DETALLE()
            COLOR_PAGADOS()
        End With

    End Sub

End Class