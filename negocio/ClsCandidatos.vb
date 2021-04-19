Imports System.Data.SqlClient

Public Class ClsCandidatos
    Dim nombre, descripcionExperiencia, telContacto As String
    Dim fechaAplicacion As Date
    Dim codigo, codigoArea, codigoPuestoTrabajo, codigoProfesion As Integer
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
    Public Property codigoArea_ As Integer
        Get
            Return codigoArea
        End Get
        Set(value As Integer)
            codigoArea = value
        End Set
    End Property
    Public Property codigoPuestoTrabajo_ As Integer
        Get
            Return codigoPuestoTrabajo
        End Get
        Set(value As Integer)
            codigoPuestoTrabajo = value
        End Set
    End Property
    Public Property codigoProfesion_ As Integer
        Get
            Return codigoProfesion
        End Get
        Set(value As Integer)
            codigoProfesion = value
        End Set
    End Property

    Public Property Nombre_ As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property descripcionExperiencia_ As String
        Get
            Return descripcionExperiencia
        End Get
        Set(value As String)
            descripcionExperiencia = value
        End Set
    End Property
    Public Property telContacto_ As String
        Get
            Return telContacto
        End Get
        Set(value As String)
            telContacto = value
        End Set
    End Property
    Public Property fechaAplicacion_ As Date
        Get
            Return fechaAplicacion
        End Get
        Set(value As Date)
            fechaAplicacion = value
        End Set
    End Property


    Public Function RegistrarNuevoCandidato() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarCandidatos"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoArea" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoArea_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoPuestoTrabajo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoPuestoTrabajo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcionExperiencia" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = descripcionExperiencia_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telContacto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = telContacto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoProfesion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoProfesion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaAplicacion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaAplicacion_
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

    Public Function ModificarCandidatos() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmModificarCandidatos"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoArea" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoArea_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoPuestoTrabajo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoPuestoTrabajo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcionExperiencia" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = descripcionExperiencia_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telContacto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = telContacto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoProfesion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoProfesion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaAplicacion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaAplicacion_
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


    Public Function BuscarCandidatoNombre() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarCandidatosNombre"
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Nombre_
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

    Public Function BuscarCandidato() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarCandidatos"
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    Public Function SeleccionarCandidatos() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmSeleccionarCandidatos", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    ' Eliminar Candidato
    Public Function EliminarCandidato() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmEliminarCandidato"
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
End Class
