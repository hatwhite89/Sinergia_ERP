Public Class CT_CuentaPorCobrar
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        Try

            dgvDetalleCliente.Rows.Add("0", cbxTipoMov.Text, txtFactura.Text, txtDescripcion.Text, txtDebito.Text, txtCredito.Text, cbxTerminoPa.Text)



            lblmsj.Text = "Se agrego el registro exitosamente."


        Catch ex As Exception

        End Try




    End Sub

    Private Sub dgvDetalleCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleCliente.CellClick

        Try

            If e.ColumnIndex = 7 Then

                dgvDetalleCliente.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow

                dgvDetalleCliente.Rows(e.RowIndex).Cells(5).Value = dgvDetalleCliente.Rows(e.RowIndex).Cells(4).Value
                dgvDetalleCliente.Rows(e.RowIndex).Cells(4).Value = ""

            End If








        Catch ex As Exception

        End Try





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CT_Clientes.Show()
        CT_Clientes.FormularioDeLlamada = "Cobro"



    End Sub
End Class