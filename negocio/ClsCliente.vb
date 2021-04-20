Imports System.Data.SqlClient

Public Class ClsCliente

    'VARIABLES
    Dim idCliente As Integer
    Dim rtn, telefono, nombre, celular, direccion, email As String

    Public Sub New()

    End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::> METODOS SET Y GET
    Public Property ID As Integer
        Get
            Return idCliente
        End Get
        Set(value As Integer)
            idCliente = value
        End Set
    End Property

    Public Property E_MAIL As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property DIRECCION_ As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property CEL_ As String
        Get
            Return celular
        End Get
        Set(value As String)
            celular = value
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

    Public Property RTN_ As String
        Get
            Return rtn
        End Get
        Set(value As String)
            rtn = value
        End Set
    End Property

    Public Property TEL_ As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::> MANTENIMIENTO

    Public Function RegistrarNuevoCliente() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "MANTE_CLIENTES"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = NOMBRE_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "RTN" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = RTN_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = DIRECCION_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = E_MAIL
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telefono" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = TEL_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "celular" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = CEL_
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


    Public Function ActualizarCliente() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "MANTE_CLIENTES"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ID
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = NOMBRE_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "RTN" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = RTN_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = DIRECCION_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = E_MAIL
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telefono" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = TEL_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "celular" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = CEL_
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


    Public Function ListarClientes() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "MANTE_CLIENTES"
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
            cmd.CommandText = "MANTE_CLIENTES"
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

End Class 'FIN DE LA CLASE
