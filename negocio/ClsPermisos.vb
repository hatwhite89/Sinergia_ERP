Imports System.Data.SqlClient

Public Class ClsPermisos
    Dim observaciones As String
    'Dim goseSueldo As Boolean
    Dim codigo, codigoEmpleado, codigoJefeInmediato, codigoTipoPermiso, totalDias As Integer
    Dim fechaInicial, fechaFinal As Date
    Dim entradaTarde, salidaTemprano As System.Nullable(Of Date)
    'Constructor
    Public Sub New()

    End Sub
    Public Property codigo_ As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
        End Set
    End Property
    Public Property fechaFinal_ As Date
        Get
            Return fechaFinal
        End Get
        Set(value As Date)
            fechaFinal = value
        End Set
    End Property
    Public Property fechaInicial_ As Date
        Get
            Return fechaInicial
        End Get
        Set(value As Date)
            fechaInicial = value
        End Set
    End Property

    Public Property observaciones_ As String
        Get
            Return observaciones
        End Get
        Set(value As String)
            observaciones = value
        End Set
    End Property
    Public Property codigoEmpleado_ As Integer
        Get
            Return codigoEmpleado
        End Get
        Set(value As Integer)
            codigoEmpleado = value
        End Set
    End Property
    Public Property codigoJefeInmediato_ As Integer
        Get
            Return codigoJefeInmediato
        End Get
        Set(value As Integer)
            codigoJefeInmediato = value
        End Set
    End Property
    Public Property codigoTipoPermiso_ As Integer
        Get
            Return codigoTipoPermiso
        End Get
        Set(value As Integer)
            codigoTipoPermiso = value
        End Set
    End Property
    Public Property totalDias_ As Integer
        Get
            Return totalDias
        End Get
        Set(value As Integer)
            totalDias = value
        End Set
    End Property
    Public Property entradaTarde_ As System.Nullable(Of Date)
        Get
            Return entradaTarde
        End Get
        Set(value As System.Nullable(Of Date))
            entradaTarde = value
        End Set
    End Property
    Public Property salidaTemprano_ As System.Nullable(Of Date)
        Get
            Return salidaTemprano
        End Get
        Set(value As System.Nullable(Of Date))
            salidaTemprano = value
        End Set
    End Property

    'Public Property goseSueldo_ As Boolean
    '    Get
    '        Return goseSueldo
    '    End Get
    '    Set(value As Boolean)
    '        goseSueldo = value
    '    End Set
    'End Property

    Public Function RegistrarNuevoPermiso() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarPermisos"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoEmpleado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoEmpleado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoJefeInmediato" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoJefeInmediato_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaInicial" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaInicial_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaFinal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaFinal_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTipoPermiso" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTipoPermiso_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "totalDias" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = totalDias_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entradaTarde" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = entradaTarde_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salidaTemprano" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = salidaTemprano_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observaciones" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = observaciones_
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

    Public Function ModificarPermisos() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarPermisos"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoEmpleado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoEmpleado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoJefeInmediato" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoJefeInmediato_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaInicial" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaInicial_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaFinal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaFinal_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTipoPermiso" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTipoPermiso_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "totalDias" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = totalDias_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entradaTarde" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = entradaTarde_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salidaTemprano" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = salidaTemprano_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observaciones" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = observaciones_
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


    Public Function BuscarPermisosNombre() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarPermisosNombre"
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = observaciones_
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

    Public Function BuscarPermisoJefeInmediato(ByVal codigoDepto_ As Integer) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarPermisoJefeInmediato"
            cmd.Parameters.Add("@codigoDepto", SqlDbType.Int).Value = codigoDepto_
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

    Public Function BuscarJefeTalentoHumano() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmBuscarPermisoJefeTalentoHumano", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function BuscarPermisos() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarPermiso"
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    Public Function SeleccionarPermisos() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarPermisos", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

End Class
