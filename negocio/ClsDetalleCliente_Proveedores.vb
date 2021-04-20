Public Class ClsDetalleCliente_Proveedores

    'VARIABLES
    Dim iddetallecliente, idProveedor, porcentaje As Integer

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

    Public Property ID As Integer
        Get
            Return iddetallecliente
        End Get
        Set(value As Integer)
            iddetallecliente = value
        End Set
    End Property
    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::> MANTENIMIENTO


End Class 'FIN DE CLASE
