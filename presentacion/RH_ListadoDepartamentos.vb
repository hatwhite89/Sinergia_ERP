Public Class RH_ListadoDepartamentos
    Dim objDepto As New ClsDepartamento
    Private Sub M_ListadoDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarDepartamentos()
        Me.dgbtabla.Columns("codigoArea").Visible = False
    End Sub
    Private Sub seleccionarDepartamentos()
        objDepto.codigoArea_ = Convert.ToInt64(lblcodeArea.Text)
        Dim dv As DataView = objDepto.BuscarDepartamentoArea.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        alternarColoFilasDatagridview(dgbtabla)
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            If lblform.Text = "RH_Empleados" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el departamento seleccionado?", MsgBoxStyle.YesNo, "Validación")
                End If
                If n = vbYes Then
                    RH_Empleados.lblcodeDepto.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    RH_Empleados.txtdepartamento.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    RH_Empleados.txtPuestoTrabajo.Text = ""
                    RH_Empleados.lblcodePuesto.Text = ""
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class