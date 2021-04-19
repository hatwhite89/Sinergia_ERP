Imports System.Data.SqlClient

Public Class ClsEmpleados

    Dim codigo, codigoArea, codigoHorario, codigoFormaPago, codigoPuestoTrab, codigoContrato, codigoProfesion, codigoDepto As Integer
    Dim nombre1, nombre2, apellido1, apellido2, nombreCompleto, nIdentidad, nSeguroSocial, banco, cuentaBancaria As String
    Dim parentesco1, parentesco2 As String
    Dim fechaAlta, fechaNacimiento As Date
    Dim fechaBaja, fechaAvisoBaja As System.Nullable(Of Date)
    Dim salario As Double
    Dim motivoBaja, estadoLaboral, direccion1, direccion2, correo1, correo2, telefono, celular, rtn, alergiaAli, alergiaMed, condicionesEspe As String
    Dim lugarNacimiento, grupoSangineo, contactoUrgencias, telUrgencias, celUrgencias, contactoUrgencias2, telUrgencias2, celUrgencias2, imagen, nombreConyugue, nombrePadre, nombreMadre, genero, estadoCivil As String
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
    Public Property salario_ As Double
        Get
            Return salario
        End Get
        Set(value As Double)
            salario = value
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
    Public Property codigoHorario_ As Integer
        Get
            Return codigoHorario
        End Get
        Set(value As Integer)
            codigoHorario = value
        End Set
    End Property
    Public Property codigoFormaPago_ As Integer
        Get
            Return codigoFormaPago
        End Get
        Set(value As Integer)
            codigoFormaPago = value
        End Set
    End Property

    Public Property codigoPuestoTrab_ As Integer
        Get
            Return codigoPuestoTrab
        End Get
        Set(value As Integer)
            codigoPuestoTrab = value
        End Set
    End Property
    Public Property codigoContrato_ As Integer
        Get
            Return codigoContrato
        End Get
        Set(value As Integer)
            codigoContrato = value
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

    Public Property Parentesco1_ As String
        Get
            Return parentesco1
        End Get
        Set(value As String)
            parentesco1 = value
        End Set
    End Property

    Public Property Parentesco2_ As String
        Get
            Return parentesco2
        End Get
        Set(value As String)
            parentesco2 = value
        End Set
    End Property
    Public Property Nombre1_ As String
        Get
            Return nombre1
        End Get
        Set(value As String)
            nombre1 = value
        End Set
    End Property

    Public Property Nombre2_ As String
        Get
            Return nombre2
        End Get
        Set(value As String)
            nombre2 = value
        End Set
    End Property

    Public Property Apellido1_ As String
        Get
            Return apellido1
        End Get
        Set(value As String)
            apellido1 = value
        End Set
    End Property

    Public Property Apellido2_ As String
        Get
            Return apellido2
        End Get
        Set(value As String)
            apellido2 = value
        End Set
    End Property

    Public Property NombreCompleto_ As String
        Get
            Return nombreCompleto
        End Get
        Set(value As String)
            nombreCompleto = value
        End Set
    End Property

    Public Property nIdentidad_ As String
        Get
            Return nIdentidad
        End Get
        Set(value As String)
            nIdentidad = value
        End Set
    End Property

    Public Property nSeguroSocial_ As String
        Get
            Return nSeguroSocial
        End Get
        Set(value As String)
            nSeguroSocial = value
        End Set
    End Property

    Public Property condicionesEspe_ As String
        Get
            Return condicionesEspe
        End Get
        Set(value As String)
            condicionesEspe = value
        End Set
    End Property

    Public Property banco_ As String
        Get
            Return banco
        End Get
        Set(value As String)
            banco = value
        End Set
    End Property

    Public Property cuentaBancaria_ As String
        Get
            Return cuentaBancaria
        End Get
        Set(value As String)
            cuentaBancaria = value
        End Set
    End Property

    Public Property imagen_ As String
        Get
            Return imagen
        End Get
        Set(value As String)
            imagen = value
        End Set
    End Property

    Public Property motivoBaja_ As String
        Get
            Return motivoBaja
        End Get
        Set(value As String)
            motivoBaja = value
        End Set
    End Property

    Public Property codigoDepto_ As Integer
        Get
            Return codigoDepto
        End Get
        Set(value As Integer)
            codigoDepto = value
        End Set
    End Property

    Public Property alergiaMed_ As String
        Get
            Return alergiaMed
        End Get
        Set(value As String)
            alergiaMed = value
        End Set
    End Property
    Public Property alergiaAli_ As String
        Get
            Return alergiaAli
        End Get
        Set(value As String)
            alergiaAli = value
        End Set
    End Property

    Public Property estadoLaboral_ As String
        Get
            Return estadoLaboral
        End Get
        Set(value As String)
            estadoLaboral = value
        End Set
    End Property

    Public Property direccion1_ As String
        Get
            Return direccion1
        End Get
        Set(value As String)
            direccion1 = value
        End Set
    End Property


    Public Property direccion2_ As String
        Get
            Return direccion2
        End Get
        Set(value As String)
            direccion2 = value
        End Set
    End Property

    Public Property correo1_ As String
        Get
            Return correo1
        End Get
        Set(value As String)
            correo1 = value
        End Set
    End Property

    Public Property correo2_ As String
        Get
            Return correo2
        End Get
        Set(value As String)
            correo2 = value
        End Set
    End Property

    Public Property telefono_ As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property celular_ As String
        Get
            Return celular
        End Get
        Set(value As String)
            celular = value
        End Set
    End Property


    Public Property rtn_ As String
        Get
            Return rtn
        End Get
        Set(value As String)
            rtn = value
        End Set
    End Property

    Public Property lugarNacimiento_ As String
        Get
            Return lugarNacimiento
        End Get
        Set(value As String)
            lugarNacimiento = value
        End Set
    End Property

    Public Property grupoSangineo_ As String
        Get
            Return grupoSangineo
        End Get
        Set(value As String)
            grupoSangineo = value
        End Set
    End Property

    Public Property contactoUrgencias_ As String
        Get
            Return contactoUrgencias
        End Get
        Set(value As String)
            contactoUrgencias = value
        End Set
    End Property

    Public Property telUrgencias_ As String
        Get
            Return telUrgencias
        End Get
        Set(value As String)
            telUrgencias = value
        End Set
    End Property

    Public Property celUrgencias_ As String
        Get
            Return celUrgencias
        End Get
        Set(value As String)
            celUrgencias = value
        End Set
    End Property
    Public Property contactoUrgencias2_ As String
        Get
            Return contactoUrgencias2
        End Get
        Set(value As String)
            contactoUrgencias2 = value
        End Set
    End Property

    Public Property telUrgencias2_ As String
        Get
            Return telUrgencias2
        End Get
        Set(value As String)
            telUrgencias2 = value
        End Set
    End Property

    Public Property celUrgencias2_ As String
        Get
            Return celUrgencias2
        End Get
        Set(value As String)
            celUrgencias2 = value
        End Set
    End Property

    Public Property nombreConyugue_ As String
        Get
            Return nombreConyugue
        End Get
        Set(value As String)
            nombreConyugue = value
        End Set
    End Property

    Public Property nombrePadre_ As String
        Get
            Return nombrePadre
        End Get
        Set(value As String)
            nombrePadre = value
        End Set
    End Property

    Public Property nombreMadre_ As String
        Get
            Return nombreMadre
        End Get
        Set(value As String)
            nombreMadre = value
        End Set
    End Property

    Public Property genero_ As String
        Get
            Return genero
        End Get
        Set(value As String)
            genero = value
        End Set
    End Property

    Public Property estadoCivil_ As String
        Get
            Return estadoCivil
        End Get
        Set(value As String)
            estadoCivil = value
        End Set
    End Property

    Public Property fechaAlta_ As Date
        Get
            Return fechaAlta
        End Get
        Set(value As Date)
            fechaAlta = value
        End Set
    End Property
    Public Property fechaBaja_ As System.Nullable(Of Date)
        Get
            Return fechaBaja
        End Get
        Set(value As System.Nullable(Of Date))
            fechaBaja = value
        End Set
    End Property
    Public Property fechaNacimiento_ As Date
        Get
            Return fechaNacimiento
        End Get
        Set(value As Date)
            fechaNacimiento = value
        End Set
    End Property
    Public Property fechaAvisoBaja_ As System.Nullable(Of Date)
        Get
            Return fechaAvisoBaja
        End Get
        Set(value As System.Nullable(Of Date))
            fechaAvisoBaja = value
        End Set
    End Property
    Public Function RegistrarNuevoEmpleados() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarEmpleados"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre1_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "apellido1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Apellido1_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "apellido2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Apellido2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreCompleto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = NombreCompleto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoArea" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoArea_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaAlta" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaAlta_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nIdentidad" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = nIdentidad_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nSeguroSocial" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = nSeguroSocial_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoHorario" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoHorario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "banco" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = banco_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cuentaBancaria" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cuentaBancaria_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoFormaPago" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoFormaPago_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaBaja" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaBaja_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaAvisoBaja" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaAvisoBaja_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "motivoBaja" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = motivoBaja_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoPuestoTrab" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoPuestoTrab_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoDepto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoDepto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoContrato" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoContrato_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estadoLaboral"
        sqlpar.Value = estadoLaboral_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion1"
        sqlpar.Value = direccion1_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion2"
        sqlpar.Value = direccion2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo1"
        sqlpar.Value = correo1_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo2"
        sqlpar.Value = correo2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telefono"
        sqlpar.Value = telefono_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "celular"
        sqlpar.Value = celular_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "rtn"
        sqlpar.Value = rtn_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaNacimiento"
        sqlpar.Value = fechaNacimiento_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "lugarNacimiento"
        sqlpar.Value = lugarNacimiento_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoProfesion"
        sqlpar.Value = codigoProfesion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "grupoSangineo"
        sqlpar.Value = grupoSangineo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "contactoUrgencias"
        sqlpar.Value = contactoUrgencias_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telUrgencias"
        sqlpar.Value = telUrgencias_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "celUrgencias"
        sqlpar.Value = celUrgencias_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreConyugue"
        sqlpar.Value = nombreConyugue_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombrePadre"
        sqlpar.Value = nombrePadre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreMadre"
        sqlpar.Value = nombreMadre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "genero"
        sqlpar.Value = genero_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estadoCivil"
        sqlpar.Value = estadoCivil_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "contactoUrgencias2"
        sqlpar.Value = contactoUrgencias2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telUrgencias2"
        sqlpar.Value = telUrgencias2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "celUrgencias2"
        sqlpar.Value = celUrgencias2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "imagen"
        sqlpar.Value = imagen_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salario"
        sqlpar.Value = salario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "alergiaAli" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = alergiaAli_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "alergiaMed" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = alergiaMed_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "condicionesEspe" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = condicionesEspe_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "parentesco1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Parentesco1_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "parentesco2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Parentesco2_
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
    Public Function ModificarEmpleados() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarEmpleados"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre1_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "apellido1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Apellido1_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "apellido2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Apellido2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreCompleto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = NombreCompleto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoArea" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoArea_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaAlta" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaAlta_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nIdentidad" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = nIdentidad_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nSeguroSocial" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = nSeguroSocial_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoHorario" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoHorario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "banco" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = banco_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cuentaBancaria" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cuentaBancaria_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoFormaPago" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoFormaPago_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaBaja" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaBaja_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaAvisoBaja" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaAvisoBaja_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "motivoBaja" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = motivoBaja_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoPuestoTrab" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoPuestoTrab_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoDepto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoDepto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoContrato" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoContrato_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estadoLaboral"
        sqlpar.Value = estadoLaboral_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion1"
        sqlpar.Value = direccion1_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion2"
        sqlpar.Value = direccion2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo1"
        sqlpar.Value = correo1_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo2"
        sqlpar.Value = correo2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telefono"
        sqlpar.Value = telefono_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "celular"
        sqlpar.Value = celular_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "rtn"
        sqlpar.Value = rtn_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaNacimiento"
        sqlpar.Value = fechaNacimiento_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "lugarNacimiento"
        sqlpar.Value = lugarNacimiento_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoProfesion"
        sqlpar.Value = codigoProfesion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "grupoSangineo"
        sqlpar.Value = grupoSangineo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "contactoUrgencias"
        sqlpar.Value = contactoUrgencias_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telUrgencias"
        sqlpar.Value = telUrgencias_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "celUrgencias"
        sqlpar.Value = celUrgencias_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreConyugue"
        sqlpar.Value = nombreConyugue_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombrePadre"
        sqlpar.Value = nombrePadre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreMadre"
        sqlpar.Value = nombreMadre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "genero"
        sqlpar.Value = genero_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estadoCivil"
        sqlpar.Value = estadoCivil_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "contactoUrgencias2"
        sqlpar.Value = contactoUrgencias2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telUrgencias2"
        sqlpar.Value = telUrgencias2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "celUrgencias2"
        sqlpar.Value = celUrgencias2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "imagen"
        sqlpar.Value = imagen_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salario"
        sqlpar.Value = salario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "alergiaAli" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = alergiaAli_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "alergiaMed" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = alergiaMed_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "condicionesEspe" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = condicionesEspe_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "parentesco1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Parentesco1_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "parentesco2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Parentesco2_
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
    Public Function BuscarDatosEmpleadoPorCodigo() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarDatosEmpleadoPorCodigo"
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo_
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
    Public Function BuscarEmpleadosPorCodigo() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarEmpleadosPorCodigo"
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo_
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
    Public Function BuscarEmpleadosPorNombre() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarEmpleadosPorNombre"
            cmd.Parameters.Add("@nombreCompleto", SqlDbType.VarChar).Value = NombreCompleto_
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
    Public Function SeleccionarEmpleados() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using da As New SqlDataAdapter("M_slmSeleccionarEmpleados", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
    Public Function CapturarEmpleados() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using da As New SqlDataAdapter("M_slmCapturarEmpleados", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    'Comparar Nombre
    Public Function CompararNombre() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmCompararNombreEmpleado"
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = NombreCompleto_
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


    'Capturar horas de trabajo del empleado
    Public Function HorasTrabajo() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmCapturarHorasdeTrabajo"
            cmd.Parameters.Add("@codEmpleado", SqlDbType.VarChar).Value = codigo_
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
