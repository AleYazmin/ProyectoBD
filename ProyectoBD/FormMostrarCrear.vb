Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient


Public Class FormMostrarCrear
    Dim query As String
    Private valorRecibido As String
    Private DiferenciaRecibida As Integer

    Public Sub New(ByVal valor As String, ByVal Diferencia As Integer)
        InitializeComponent()
        ' Guardar el valor recibido en la variable privada
        valorRecibido = valor
        DiferenciaRecibida = Diferencia
    End Sub

    Private Sub InicializarDatos()
        query = "select id,marca from marca"
        ComboBoxMarca.DataSource = Conexion.SelectQuery(query)
        ComboBoxMarca.DisplayMember = "marca"
        ComboBoxMarca.ValueMember = "id"
        'Modelo
        query = "select id,modelo from modelo"
        ComboBoxModelo.DataSource = Conexion.SelectQuery(query)
        ComboBoxModelo.DisplayMember = "modelo"
        ComboBoxModelo.ValueMember = "id"
        'Version Auto
        query = "select id,versionAuto from Versionauto"
        ComboBoxVersionAuto.DataSource = Conexion.SelectQuery(query)
        ComboBoxVersionAuto.DisplayMember = "versionAuto"
        ComboBoxVersionAuto.ValueMember = "id"
        'carroceria
        query = "select id,carroceria from Carroceria"
        ComboBoxCarroceria.DataSource = Conexion.SelectQuery(query)
        ComboBoxCarroceria.DisplayMember = "carroceria"
        ComboBoxCarroceria.ValueMember = "id"
        'Transmicion
        query = "select id,transmision from Transmision"
        ComboBoxTransmicion.DataSource = Conexion.SelectQuery(query)
        ComboBoxTransmicion.DisplayMember = "transmision"
        ComboBoxTransmicion.ValueMember = "id"
        'Color
        query = "select id,color from color"
        ComboBoxColor.DataSource = Conexion.SelectQuery(query)
        ComboBoxColor.DisplayMember = "color"
        ComboBoxColor.ValueMember = "id"

        'Venta
        query = "SELECT id, vendedor FROM Venta"
        ComboBoxVenta.DataSource = Conexion.SelectQuery(query)
        ComboBoxVenta.DisplayMember = "vendedor"
        ComboBoxVenta.ValueMember = "id"

        If DiferenciaRecibida = 1 Then
            ' Ejecutar un procedimiento almacenado
            Dim procedureName As String = "SP_BuscarVehiculoPorID"
            Dim parameters As SqlParameter() = {
            New SqlParameter("@vehiculoID", valorRecibido)
             }


            ' Obtener un lector de datos para el resultado del procedimiento almacenado
            Dim reader As SqlDataReader = Conexion.ExecuteStoredProcedureReader(procedureName, parameters)

            ' Verificar si hay filas devueltas por el procedimiento almacenado
            If reader.HasRows Then
                ' Si hay filas, leer la primera fila (suponiendo que solo hay una fila)
                If reader.Read() Then
                    ' Obtener los datos de las columnas y asignarlos a las variables de la clase Caché
                    ' Obtener los datos de las columnas y asignarlos a las variables de la clase Caché
                    TextBoxAño.Text = If(Not IsDBNull(reader("año")), Convert.ToString(reader("año")), "")
                    TextBoxKilometraje.Text = If(Not IsDBNull(reader("kilometraje")), Convert.ToString(reader("kilometraje")), "")
                    TextBoxInterior.Text = If(Not IsDBNull(reader("interior")), Convert.ToString(reader("interior")), "")

                    ComboBoxMarca.SelectedValue = If(Not IsDBNull(reader("idMarca")), Convert.ToInt32(reader("idMarca")), -1)
                    ComboBoxModelo.SelectedValue = If(Not IsDBNull(reader("idModelo")), Convert.ToInt32(reader("idModelo")), -1)
                    ComboBoxVersionAuto.SelectedValue = If(Not IsDBNull(reader("idVersionAuto")), Convert.ToInt32(reader("idVersionAuto")), -1)
                    ComboBoxCarroceria.SelectedValue = If(Not IsDBNull(reader("idCarroceria")), Convert.ToInt32(reader("idCarroceria")), -1)
                    ComboBoxTransmicion.SelectedValue = If(Not IsDBNull(reader("idTransmision")), Convert.ToInt32(reader("idTransmision")), -1)
                    ComboBoxColor.SelectedValue = If(Not IsDBNull(reader("idColor")), Convert.ToInt32(reader("idColor")), -1)
                    ComboBoxVenta.SelectedValue = If(Not IsDBNull(reader("idVenta")), Convert.ToInt32(reader("idVenta")), -1)


                End If
            End If

            Conexion.Disconect()
            ' Configurar campos de texto como solo lectura
            TextBoxAño.Enabled = False
            TextBoxKilometraje.Enabled = False
            TextBoxInterior.Enabled = False

            ' Configurar ComboBox como solo lectura
            ComboBoxMarca.Enabled = False
            ComboBoxModelo.Enabled = False
            ComboBoxVersionAuto.Enabled = False
            ComboBoxCarroceria.Enabled = False
            ComboBoxTransmicion.Enabled = False
            ComboBoxColor.Enabled = False
            ComboBoxVenta.Enabled = False
            ButtonActualizar.Visible = False
            Buttonagregar.Visible = False

        ElseIf DiferenciaRecibida = 2 Then
            ButtonActualizar.Visible = False
        ElseIf DiferenciaRecibida = 3 Then
            Buttonagregar.Visible = False
            ' Ejecutar un procedimiento almacenado
            Dim procedureName As String = "SP_BuscarVehiculoPorID"
            Dim parameters As SqlParameter() = {
            New SqlParameter("@vehiculoID", valorRecibido)
             }


            ' Obtener un lector de datos para el resultado del procedimiento almacenado
            Dim reader As SqlDataReader = Conexion.ExecuteStoredProcedureReader(procedureName, parameters)

            ' Verificar si hay filas devueltas por el procedimiento almacenado
            If reader.HasRows Then
                ' Si hay filas, leer la primera fila (suponiendo que solo hay una fila)
                If reader.Read() Then
                    ' Obtener los datos de las columnas y asignarlos a las variables de la clase Caché
                    TextBoxAño.Text = If(Not IsDBNull(reader("año")), Convert.ToString(reader("año")), "")
                    TextBoxKilometraje.Text = If(Not IsDBNull(reader("kilometraje")), Convert.ToString(reader("kilometraje")), "")
                    TextBoxInterior.Text = If(Not IsDBNull(reader("interior")), Convert.ToString(reader("interior")), "")

                    ComboBoxMarca.SelectedValue = If(Not IsDBNull(reader("idMarca")), Convert.ToInt32(reader("idMarca")), -1)
                    ComboBoxModelo.SelectedValue = If(Not IsDBNull(reader("idModelo")), Convert.ToInt32(reader("idModelo")), -1)
                    ComboBoxVersionAuto.SelectedValue = If(Not IsDBNull(reader("idVersionAuto")), Convert.ToInt32(reader("idVersionAuto")), -1)
                    ComboBoxCarroceria.SelectedValue = If(Not IsDBNull(reader("idCarroceria")), Convert.ToInt32(reader("idCarroceria")), -1)
                    ComboBoxTransmicion.SelectedValue = If(Not IsDBNull(reader("idTransmision")), Convert.ToInt32(reader("idTransmision")), -1)
                    ComboBoxColor.SelectedValue = If(Not IsDBNull(reader("idColor")), Convert.ToInt32(reader("idColor")), -1)
                    ComboBoxVenta.SelectedValue = If(Not IsDBNull(reader("idVenta")), Convert.ToInt32(reader("idVenta")), -1)


                End If
            End If
            Conexion.Disconect()
            Buttonagregar.Visible = False
        End If

    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

    Private Sub FormMostrarCrear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarDatos()
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        Try
            Dim usuariomodifica As Integer = 1
            Dim procedureName As String = "SP_ActualizarVehiculo"
            Dim parameters As SqlParameter() = {
                New SqlParameter("@id", valorRecibido),
                New SqlParameter("@año", Convert.ToInt32(TextBoxAño.Text)),
                New SqlParameter("@kilometraje", Convert.ToInt32(TextBoxKilometraje.Text)),
                New SqlParameter("@interior", TextBoxInterior.Text),
                New SqlParameter("@idMarca", Convert.ToInt32(ComboBoxMarca.SelectedValue)),
                New SqlParameter("@idModelo", Convert.ToInt32(ComboBoxModelo.SelectedValue)),
                New SqlParameter("@idVersionAuto", Convert.ToInt32(ComboBoxVersionAuto.SelectedValue)),
                New SqlParameter("@idCarroceria", Convert.ToInt32(ComboBoxCarroceria.SelectedValue)),
                New SqlParameter("@idTransmision", Convert.ToInt32(ComboBoxTransmicion.SelectedValue)),
                New SqlParameter("@idColor", Convert.ToInt32(ComboBoxColor.SelectedValue)),
                New SqlParameter("@idVenta", Convert.ToInt32(ComboBoxVenta.SelectedValue)),
                New SqlParameter("@idUsuarioModifica", usuariomodifica)
            }

            ' Ejecutar el procedimiento almacenado
            Conexion.ExecuteStoredProcedure(procedureName, parameters)
            MsgBox("Vehículo actualizado exitosamente")
        Catch ex As Exception
            ' Manejar el error
            MessageBox.Show("Se produjo un error al actualizar el vehículo: " & ex.Message)
            ' Puedes hacer un retorno aquí si lo deseas
            Return
        End Try

        ' Actualizar el DataGridView con los datos actualizados
        query = "SELECT TOP 500 *
FROM VW_vehiculosBusqueda where estatus=1"
        Form1.DataGridView1.DataSource = Conexion.SelectQuery(query)
    End Sub

    Private Sub Buttonagregar_Click(sender As Object, e As EventArgs) Handles Buttonagregar.Click
        Try
            Dim usuariomodifica As Integer = 1
            Dim procedureName As String = "SP_InsertarVehiculo"
            Dim parameters As SqlParameter() = {
        New SqlParameter("@año", Convert.ToInt32(TextBoxAño.Text)),
        New SqlParameter("@kilometraje", Convert.ToInt32(TextBoxKilometraje.Text)),
        New SqlParameter("@interior", TextBoxInterior.Text),
        New SqlParameter("@idMarca", Convert.ToInt32(ComboBoxMarca.SelectedValue)),
        New SqlParameter("@idModelo", Convert.ToInt32(ComboBoxModelo.SelectedValue)),
        New SqlParameter("@idVersionAuto", Convert.ToInt32(ComboBoxVersionAuto.SelectedValue)),
        New SqlParameter("@idCarroceria", Convert.ToInt32(ComboBoxCarroceria.SelectedValue)),
        New SqlParameter("@idTransmision", Convert.ToInt32(ComboBoxTransmicion.SelectedValue)),
        New SqlParameter("@idColor", Convert.ToInt32(ComboBoxColor.SelectedValue)),
        New SqlParameter("@idVenta", Convert.ToInt32(ComboBoxVenta.SelectedValue)),
        New SqlParameter("@idUsuarioCrea", usuariomodifica)
    }

            ' Ejecutar el procedimiento almacenado
            Conexion.ExecuteStoredProcedure(procedureName, parameters)
            MsgBox("Vehículo insertado exitosamente")
        Catch ex As Exception
            ' Manejar el error
            MessageBox.Show("Se produjo un error al insertar el vehículo: " & ex.Message)
            ' Puedes hacer un retorno aquí si lo deseas
            Return
        End Try

        ' Actualizar el DataGridView con los datos insertados
        query = "SELECT TOP 500 *
FROM VW_vehiculosBusqueda where estatus=1"
        Form1.DataGridView1.DataSource = Conexion.SelectQuery(query)

    End Sub
End Class