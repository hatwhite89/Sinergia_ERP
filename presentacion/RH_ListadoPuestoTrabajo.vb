Public Class RH_ListadoPuestoTrabajo
    Dim objPuesto As New ClsPuestoTrabajo
    Private Sub M_ListadoPuestoTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblBandera.Text = "1" Then
            seleccionarPuestoTrabajoPorDepto()
            Me.dgbtabla.Columns("codigoDepto").Visible = False
            Me.dgbtabla.Columns("codigoArea").Visible = False
        Else
            seleccionarPuestoTrabajo()
            Me.dgbtabla.Columns("codigoDepto").Visible = False
            Me.dgbtabla.Columns("codigoArea").Visible = False
        End If
        alternarColoFilasDatagridview(dgbtabla)
    End Sub
    Private Sub seleccionarPuestoTrabajoPorDepto()
        objPuesto.codigoDepto_ = Convert.ToInt64(lblcodeDepto.Text)
        Dim dv As DataView = objPuesto.BuscarPuestoTrabajoDepto.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub seleccionarPuestoTrabajo()
        Dim dv As DataView = objPuesto.SeleccionarPuestoTrabajo.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            If lblform.Text = "RH_Empleados" And lblBandera.Text = "1" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el puesto de trabajo seleccionado?", MsgBoxStyle.YesNo, "Validación")
                End If
                If n = vbYes Then
                    RH_Empleados.lblcodePuesto.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    RH_Empleados.txtPuestoTrabajo.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            ElseIf lblform.Text = "RH_Empleados" And lblBandera.Text = "0" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el puesto de trabajo seleccionado?", MsgBoxStyle.YesNo, "Validación")
                End If
                If n = vbYes Then
                    RH_Empleados.lblcodePuesto.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    RH_Empleados.txtPuestoTrabajo.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    RH_Empleados.lblcodeDepto.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value()
                    RH_Empleados.lblcodigoArea.Text = dgbtabla.Rows(e.RowIndex).Cells(3).Value()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class