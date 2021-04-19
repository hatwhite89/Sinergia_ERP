Imports System.Data.SqlClient

Public Class ClsConnection
    'esta clase sirve para abrir una conexxion en la base de datos 


    Private sqlcon As SqlConnection
    Public str_con As String
    'String Conexion
    Public Sub New()
        'str_con = "Data Source=DESKTOP-9C0CHLT\SQLEXPRESS ;Initial Catalog=slm_test; Min Pool Size=0;Max Pool Size=1024;Pooling=true;  Integrated Security = True;"
        str_con = "Data Source=181.115.100.251; Initial Catalog=ERP_Sinergia;  User Id=sa; Password=@Tatiana1987"
    End Sub

    Public Function getConexion() As SqlConnection

        Try
            sqlcon = New SqlConnection(str_con)
            ''se conecta a la base de datos
            sqlcon.Open()
            ''abre la conexión a la base de datos
            Return sqlcon
            ''retorna la conexión abierta
        Catch ex As Exception
            MsgBox("Error en la conexión con la base de datos. No se podrá generar registros en el sistema.")
        End Try

    End Function
    Public Sub cerrarConexion()
        'cierra la conexión con la base de datos

        sqlcon.Close()

        'Modificar close
        'Destructor para cerrar proceso
    End Sub

End Class

