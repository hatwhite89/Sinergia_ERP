Public Class CT_Proveedores

    Dim objProv As New ClsProveedor
    Private Sub CT_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTUALIZAR LISTADO
        seleccionarProveedores()

        'AGREGARLE COLOR AL DATAGRIDVIEW
        alternarColoFilasDatagridview(dgbtabla)

        'CAMBIAS NOMBRE COLUMNAS
        dgbtabla.Columns("id").HeaderText = "ID"
        dgbtabla.Columns("nombre").HeaderText = "Nombre"
        dgbtabla.Columns("direccion").HeaderText = "Dirección"
        dgbtabla.Columns("correo").HeaderText = "Correo"
        dgbtabla.Columns("telefono").HeaderText = "Teléfono"
        dgbtabla.Columns("celular").HeaderText = "Celular"
    End Sub
    Public Sub seleccionarProveedores()
        Try
            Dim dv As DataView = objProv.SeleccionarProveedor.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtdescripcionB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
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
            dv.RowFilter = String.Format("nombre Like '%{0}%'", txtNombreB.Text)
            lblcantidad.Text = dv.Count
            dgbtabla.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            If lblForm.Text = "CT_CuentasPorPagar" Then
                Dim n As String = MsgBox("¿Desea utilizar el proveedor?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    CT_CuentasPorPagar.txtId.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    CT_CuentasPorPagar.txtNombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            ElseIf lblForm.Text = "CT_C" Then
                Dim n As String = MsgBox("¿Desea actualizar el proveedor?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    CT_AgregarProveedores.txtId.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    CT_AgregarProveedores.txtNombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub CerrarForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        CT_AgregarProveedores.Show()
    End Sub
End Class