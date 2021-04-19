Imports System.Data.SqlClient
Public Class ClsHorarios

    Dim codigo As Integer
    Dim nombre, codigoBreve, observacion As String
    Dim lunes, martes, miercoles, jueves, viernes, sabado, domingo As Boolean
    Dim entrada, salida, entradaFinSemana, salidaFinSemana As Date
    'Constructor
    Public Sub New()

    End Sub

    Public Property Codigo_ As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
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

    Public Property codigoBreve_ As String
        Get
            Return codigoBreve
        End Get
        Set(value As String)
            codigoBreve = value
        End Set
    End Property

    Public Property observacion_ As String
        Get
            Return observacion
        End Get
        Set(value As String)
            observacion = value
        End Set
    End Property

    Public Property lunes_ As Boolean
        Get
            Return lunes
        End Get
        Set(value As Boolean)
            lunes = value
        End Set
    End Property

    Public Property martes_ As Boolean
        Get
            Return martes
        End Get
        Set(value As Boolean)
            martes = value
        End Set
    End Property

    Public Property miercoles_ As Boolean
        Get
            Return miercoles
        End Get
        Set(value As Boolean)
            miercoles = value
        End Set
    End Property

    Public Property jueves_ As Boolean
        Get
            Return jueves
        End Get
        Set(value As Boolean)
            jueves = value
        End Set
    End Property

    Public Property viernes_ As Boolean
        Get
            Return viernes
        End Get
        Set(value As Boolean)
            viernes = value
        End Set
    End Property

    Public Property sabado_ As Boolean
        Get
            Return sabado
        End Get
        Set(value As Boolean)
            sabado = value
        End Set
    End Property

    Public Property domingo_ As Boolean
        Get
            Return domingo
        End Get
        Set(value As Boolean)
            domingo = value
        End Set
    End Property
    Public Property entradaFinSemana_ As Date
        Get
            Return entradaFinSemana
        End Get
        Set(value As Date)
            entradaFinSemana = value
        End Set
    End Property
    Public Property salidaFinSemana_ As Date
        Get
            Return salidaFinSemana
        End Get
        Set(value As Date)
            salidaFinSemana = value
        End Set
    End Property
    Public Property entrada_ As Date
        Get
            Return entrada
        End Get
        Set(value As Date)
            entrada = value
        End Set
    End Property

    Public Property salida_ As Date
        Get
            Return salida
        End Get
        Set(value As Date)
            salida = value
        End Set
    End Property

    Public Function RegistrarNuevoHorario() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarHorario"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoBreve" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoBreve_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entrada" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = entrada_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salidaH" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = salida_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "lunes" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = lunes_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "martes" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = martes_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "miercoles" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = miercoles_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "jueves" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = jueves_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "viernes" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = viernes_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sabado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = sabado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "domingo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = domingo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observacion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = observacion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entradaFinSemana" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = entradaFinSemana_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salidaFinSemana" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = salidaFinSemana_
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

    Public Function ModificarHorario() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarHorario"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoBreve" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoBreve_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entrada" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = entrada_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salidaH" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = salida_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "lunes" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = lunes_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "martes" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = martes_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "miercoles" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = miercoles_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "jueves" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = jueves_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "viernes" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = viernes_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sabado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = sabado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "domingo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = domingo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observacion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = observacion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entradaFinSemana" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = entradaFinSemana_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salidaFinSemana" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = salidaFinSemana_
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


    Public Function BuscarHorarioNombre() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarHorarioNombre"
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


    Public Function SeleccionarHorario() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarHorario", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function


    Public Function BuscarHorario() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarHorario"
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = Codigo_
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
