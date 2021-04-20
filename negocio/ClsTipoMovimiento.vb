Imports System.Data.SqlClient

Public Class ClsTipoMovimiento


    'VARIABLES
    Dim id_tipomov As Integer
    Dim nombre As String

    Public Sub New()

    End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::> METODOS SET Y GET
    Public Property ID As Integer
        Get
            Return id_tipomov
        End Get
        Set(value As Integer)
            id_tipomov = value
        End Set
    End Property

    Public Property NOMBRE_ As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::> MANTENIMIENTO

    Public Function RegistrarNuevoTipoMov() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "MANTE_TIPOMOV"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = NOMBRE_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "accion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = 1
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


    Public Function ActualizarTipoMov() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "MANTE_TIPOMOV"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_tipomov" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ID
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = NOMBRE_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "accion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = 2
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


    Public Function ListarTipoMov() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "MANTE_TIPOMOV"
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

    Public Function BuscarClientesXNombre() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "MANTE_TIPOMOV"
            cmd.Parameters.Add("@accion", SqlDbType.Int).Value = 3
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = NOMBRE_
            cmd.Parameters.Add("@salida", SqlDbType.Int).Value = ""
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


End Class
