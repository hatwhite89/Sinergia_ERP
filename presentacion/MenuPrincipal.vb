Public Class MenuPrincipal

    Dim SELECCION As String

    Private Sub llenarContabilidad()

        dgvOpciones.Rows.Clear()
        dgvOpciones.Columns("Opciones").HeaderText = "Opciones de Contabilidad"
        dgvOpciones.Rows.Add("Crear Cuentas")
        dgvOpciones.Rows.Add("Cuentas por Pagar")
        dgvOpciones.Rows.Add("Cuentas por Cobrar")
        dgvOpciones.Rows.Add("Clientes")
        dgvOpciones.Rows.Add("Tipo de Movimientos")
        dgvOpciones.Rows.Add("Proveedores")
        dgvOpciones.Rows.Add("Terminos de Pago")
        dgvOpciones.Rows.Add("Movimientos Contables")

    End Sub

    Private Sub llenartalentohumano()

        dgvOpciones.Rows.Clear()

        dgvOpciones.Columns("Opciones").HeaderText = "Opciones de Talento Humano"

        dgvOpciones.Rows.Add("Empleado")
        dgvOpciones.Rows.Add("Departamentos")
        dgvOpciones.Rows.Add("Puestos de Trabajo")
        dgvOpciones.Rows.Add("Horarios de Trabajo")
        dgvOpciones.Rows.Add("Permisos")
        dgvOpciones.Rows.Add("Tipos de Permisos")
        dgvOpciones.Rows.Add("Sucursales")
        dgvOpciones.Rows.Add("Contratos")
        dgvOpciones.Rows.Add("Areas")
        dgvOpciones.Rows.Add("Profesiones")
        dgvOpciones.Rows.Add("Vacaciones")
        dgvOpciones.Rows.Add("Candidatos")



    End Sub

    Private Sub llenaralmacen()

        dgvOpciones.Rows.Clear()

        dgvOpciones.Columns("Opciones").HeaderText = "Opciones de Almacen"
        dgvOpciones.Rows.Add("Crear Proveedor")
        dgvOpciones.Rows.Add("Crear Categorias de Proveedor")

    End Sub

    Private Sub llenarConfiguracionSistema()

        dgvOpciones.Rows.Clear()

        dgvOpciones.Columns("Opciones").HeaderText = "Opciones de Sistema"
        dgvOpciones.Rows.Add("Crear Usuario")
        dgvOpciones.Rows.Add("Crear Perfiles de Usuario")
        dgvOpciones.Rows.Add("Modificar Usuarios")
        dgvOpciones.Rows.Add("Modificar Perfiles de Usuarios")

    End Sub

    Private Sub UI_ButtonImage1_Click(sender As Object, e As EventArgs) Handles UI_ButtonImage1.Click
        llenarContabilidad()

    End Sub

    Private Sub UI_TitleBanner1_Click(sender As Object, e As EventArgs) Handles UI_TitleBanner1.Click
        Try
            dgvOpciones.Rows.Add("Seleccione una opcion del panel...")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UI_ButtonImage2_Click(sender As Object, e As EventArgs) Handles UI_ButtonImage2.Click
        llenartalentohumano()

    End Sub

    Private Sub UI_ButtonImage3_Click(sender As Object, e As EventArgs) Handles UI_ButtonImage3.Click
        llenaralmacen()

    End Sub

    Private Sub UI_ButtonImage4_Click(sender As Object, e As EventArgs) Handles UI_ButtonImage4.Click
        llenarConfiguracionSistema()

    End Sub

    Private Sub UI_ButtonImage5_Click(sender As Object, e As EventArgs) Handles UI_ButtonImage5.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub dgvOpciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOpciones.CellDoubleClick
        Try

            SELECCION = dgvOpciones.Rows(e.RowIndex).Cells(0).Value

            If SELECCION = "Puestos de Trabajo" Then
                RH_PuestoTrabajo.Show()
            ElseIf SELECCION = "Horarios de Trabajo" Then
                RH_Horarios.Show()
            ElseIf SELECCION = "Contratos" Then
                RH_Contratos.Show()
            ElseIf SELECCION = "Profesiones" Then
                RH_Profesion.Show()
            ElseIf SELECCION = "Sucursales" Then
                RH_Sucursal.Show()
            ElseIf SELECCION = "Permisos" Then
                RH_Permisos.Show()
            ElseIf SELECCION = "Vacaciones" Then
                RH_Vacaciones.Show()
            ElseIf SELECCION = "Areas" Then
                RH_Area.Show()
            ElseIf SELECCION = "Departamentos" Then
                RH_Departamentos.Show()
            ElseIf SELECCION = "Empleado" Then
                RH_ListadoEmpleados.Show()
            ElseIf SELECCION = "Candidatos" Then
                RH_Candidatos.Show()
            ElseIf SELECCION = "Capacitaciones" Then
                RH_BuscarCapacitaciones.Show()
            ElseIf SELECCION = "Tipos de Permisos" Then
                RH_TipoPermiso.Show()
            ElseIf SELECCION = "Crear Cuentas" Then
                CT_Cuentas.Show()
            ElseIf SELECCION = "Cuentas por Pagar" Then
                CT_CuentasPorPagar.Show()
            ElseIf SELECCION = "Cuentas por Cobrar" Then
                CT_CuentaPorCobrar.Show()
            ElseIf SELECCION = "Clientes" Then
                CT_Clientes.Show()
            ElseIf SELECCION = "Tipo de Movimientos" Then
                CT_TipoMovimiento.Show()
            ElseIf SELECCION = "Proveedores" Then
                CT_Proveedores.Show()
            ElseIf SELECCION = "Terminos de Pago" Then
                CT_TerminoPago.Show()
            ElseIf SELECCION = "Movimientos Contables" Then
                CT_TipoMovimiento.Show()
            End If

        Catch ex As Exception

        End Try
    End Sub


End Class