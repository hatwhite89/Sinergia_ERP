Public Class CT_TerminoPago

    Dim objTerm As New ClsTerminoPago
    Private Sub CT_TerminoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTUALIZAR LISTADO
        seleccionarTerminos()

        'AGREGARLE COLOR AL DATAGRIDVIEW
        alternarColoFilasDatagridview(dgbtabla)

        'CAMBIAS NOMBRE COLUMNAS
        dgbtabla.Columns("id").HeaderText = "ID"
        dgbtabla.Columns("descripcion").HeaderText = "Descripción"
    End Sub
    Public Sub seleccionarTerminos()
        Try
            Dim dv As DataView = objTerm.SeleccionarTerminoPago.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CerrarForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            If lblForm.Text = "CT_CuentasPorPagar" And e.RowIndex > 0 Then
                Dim n As String = MsgBox("¿Desea utilizar el término de pago?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    CT_CuentasPorPagar.txtId.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    CT_CuentasPorPagar.txtNombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            ElseIf lblForm.Text = "CT_C" And e.RowIndex > 0 Then
                Dim n As String = MsgBox("¿Desea actualizar el término de pago?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    CT_AgregarProveedores.txtId.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    CT_AgregarProveedores.txtNombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtdescripcionB_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcionB.TextChanged
        'Try

        '    With objContratos
        '        .Descripcion_ = txtdescripcionB.Text
        '    End With

        '    If (Trim(txtdescripcionB.Text) <> "") Then
        '        Dim dv As DataView = objContratos.BuscarContratos.DefaultView
        '        dgbtabla.DataSource = dv
        '        lblcantidad.Text = dv.Count
        '        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        '    Else
        '        Dim dv As DataView = objContratos.SeleccionarContratos.DefaultView
        '        dgbtabla.DataSource = dv
        '        lblcantidad.Text = dv.Count
        '        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        '    End If

        'Catch ex As Exception

        'End Try
        Try
            Dim dv As DataView = dgbtabla.DataSource
            dv.RowFilter = String.Format("descripcion Like '%{0}%'", txtdescripcionB.Text)
            lblcantidad.Text = dv.Count
            dgbtabla.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        CT_AgregarTerminoPago.Show()
    End Sub

End Class