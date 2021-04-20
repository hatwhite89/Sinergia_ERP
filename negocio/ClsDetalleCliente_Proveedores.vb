Imports System.Data.SqlClient

Public Class ClsDetalleCliente_Proveedores

    'VARIABLES
    Dim iddetallecliente, idProveedor, idCliente, porcentaje As Integer

    Public Sub New()

    End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::> METODOS SET Y GET
    Public Property PORCENTAJE_ As Integer
        Get
            Return porcentaje
        End Get
        Set(value As Integer)
            porcentaje = value
        End Set
    End Property

    Public Property ID_Proveedor As Integer
        Get
            Return idProveedor
        End Get
        Set(value As Integer)
            idProveedor = value
        End Set
    End Property

    Public Property ID_Cliente As Integer
        Get
            Return idCliente
        End Get
        Set(value As Integer)
            idCliente = value
        End Set
    End Property

    Public Property ID As Integer
        Get
            Return iddetallecliente
        End Get
        Set(value As Integer)
            iddetallecliente = value
        End Set
    End Property
    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::> MANTENIMIENTO

    Public Function RegistrarNuevoDetalle() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "MANTE_DETALLE_CLIENTE_PROVEEDORES"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "idcliente" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ID_Cliente
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "idproveedor" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ID_Proveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "porcentaje" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = PORCENTAJE_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "accion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = 1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = 0
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion

        sqlcom.ExecuteNonQuery()

        con.cerrarConexion()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function


    Public Function ActualizarDetalle() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "MANTE_DETALLE_CLIENTE_PROVEEDORES"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ID
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "idcliente" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ID_Cliente
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "idproveedor" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ID_Proveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "porcentaje" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = PORCENTAJE_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "accion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = 1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = 0
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion

        sqlcom.ExecuteNonQuery()

        con.cerrarConexion()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function


    Public Function ListarProveedoresXCliente() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "MANTE_DETALLE_CLIENTE_PROVEEDORES"
            cmd.Parameters.Add("@idcliente", SqlDbType.Int).Value = ID_Cliente
            cmd.Parameters.Add("@accion", SqlDbType.Int).Value = 0
            cmd.Parameters.Add("@salida", SqlDbType.Int).Value = 0
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
            End Using
        End Using

    End Function

    Public Function Eliminar() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "MANTE_DETALLE_CLIENTE_PROVEEDORES"
            cmd.Parameters.Add("@idcliente", SqlDbType.Int).Value = ID
            cmd.Parameters.Add("@accion", SqlDbType.Int).Value = 3
            cmd.Parameters.Add("@salida", SqlDbType.Int).Value = 0
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
            End Using
        End Using

    End Function

End Class 'FIN DE CLASE
