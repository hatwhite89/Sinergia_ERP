Imports System.Data.SqlClient

Public Class ClsDetalleMovimientos_Proveedor
    Dim descripcion, identificador As String
    Dim fecha As Date
    Dim debito, credito As Double
    Dim id, id_Proveedor, id_TipoMovimiento, id_terminoPago As Integer
    Dim pagado, anulado As Boolean
    'Constructor
    Public Sub New()

        End Sub
    Public Property id_ As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property
    Public Property id_Proveedor_ As Integer
        Get
            Return id_Proveedor
        End Get
        Set(value As Integer)
            id_Proveedor = value
        End Set
    End Property
    Public Property id_TipoMovimiento_ As Integer
        Get
            Return id_TipoMovimiento
        End Get
        Set(value As Integer)
            id_TipoMovimiento = value
        End Set
    End Property
    Public Property id_terminoPago_ As Integer
        Get
            Return id_terminoPago
        End Get
        Set(value As Integer)
            id_terminoPago = value
        End Set
    End Property

    Public Property descripcion_ As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property
    Public Property identificador_ As String
        Get
            Return identificador
        End Get
        Set(value As String)
            identificador = value
        End Set
    End Property
    Public Property fecha_ As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property
    Public Property credito_ As Double
        Get
            Return credito
        End Get
        Set(value As Double)
            credito = value
        End Set
    End Property
    Public Property debito_ As Double
        Get
            Return debito
        End Get
        Set(value As Double)
            debito = value
        End Set
    End Property
    Public Property anulado_ As Boolean
        Get
            Return anulado
        End Get
        Set(value As Boolean)
            anulado = value
        End Set
    End Property
    Public Property pagado_ As Boolean
        Get
            Return pagado
        End Get
        Set(value As Boolean)
            pagado = value
        End Set
    End Property


    Public Function RegistrarNuevoDetalleMovimientos_Proveedor() As String

        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarDetalleMovimientos_Proveedor"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_Proveedor" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = id_Proveedor_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_TipoMovimiento" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = id_TipoMovimiento_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = descripcion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "debito" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = debito_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "credito" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = credito_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_TerminoPago" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = id_terminoPago_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pagado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = pagado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "anulado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = anulado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "identificador" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = identificador_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion

        sqlcom.ExecuteNonQuery()

        con.cerrarConexion()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function

    Public Function ModificarDetalleMovimientos_Proveedor() As String

        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarDetalleMovimientos_Proveedor"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = id_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_Proveedor" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = id_Proveedor_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_TipoMovimiento" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = id_TipoMovimiento_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = descripcion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "debito" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = debito_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "credito" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = credito_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_TerminoPago" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = id_terminoPago_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pagado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = pagado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "anulado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = anulado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "identificador" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = identificador_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion

        sqlcom.ExecuteNonQuery()

        con.cerrarConexion()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function

    Public Function BuscarDetalleMovimientos_Proveedor() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarDetalleMovimientos_Proveedor"
            cmd.Parameters.Add("@id_Proveedor", SqlDbType.Int).Value = id_Proveedor_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    Public Function SeleccionarDetalleMovimientos_Proveedor() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarDetalleMovimientos_Proveedor", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

End Class
