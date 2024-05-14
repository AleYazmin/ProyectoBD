Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Dim query As String
    Dim auto As Boolean
    'Create a constructor
    Public Sub New()
        auto = True

        ' This call is required by the designer.
        InitializeComponent()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ' Add any initialization after the InitializeComponent() call.
        'Create a new instance of the Connection class

        query = "SELECT id, marca FROM Marca"
        CBVehiculo.DataSource = Conexion.SelectQuery(query)
        CBVehiculo.DisplayMember = "marca"
        CBVehiculo.ValueMember = "id"
        auto = False
        DataGridView1.ReadOnly = True

        query = "SELECT TOP 500 *
FROM VW_vehiculosBusqueda where estatus=1"
        DataGridView1.DataSource = Conexion.SelectQuery(query)
        ButtonMostrar.Enabled = False
        ButtonActualizar.Enabled = False
        ButtonEliminar.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CBVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBVehiculo.SelectedIndexChanged

        ' Realizar la consulta para obtener los vehículos de la marca seleccionada
        Dim query As String = "SELECT * FROM VW_vehiculosBusqueda WHERE marca = '" & CBVehiculo.Text & "'" ' Reemplaza "VW_vehiculosBusqueda" por el nombre de tu vista
        Dim dataTable As DataTable = Conexion.SelectQuery(query)

        ' Mostrar los resultados en el control DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim buscarTexto As String = TextBox1.Text.Trim()
        Dim query As String = ""
        query = "SELECT * FROM VW_vehiculosBusqueda
where Modelo LIKE '%" & buscarTexto & "%' and Estatus=1"
        ' Ejecutar la consulta SQL y mostrar los resultados en el DataGridView
        Dim dt As DataTable = Conexion.SelectQuery(query)

        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        ' Verifica si hay al menos una fila seleccionada en el DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Habilita los tres botones
            ButtonMostrar.Enabled = True
            ButtonActualizar.Enabled = True
            ButtonEliminar.Enabled = True
        Else
            ' Deshabilita los tres botones si no hay ninguna fila seleccionada
            ButtonMostrar.Enabled = False
            ButtonActualizar.Enabled = False
            ButtonEliminar.Enabled = False
        End If
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click

        ' Verifica si hay al menos una fila seleccionada en el DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtiene el valor de la primera celda de la fila seleccionada (asumiendo que es una celda de texto)
            Dim valor As String = DataGridView1.SelectedRows(0).Cells(0).Value
            Dim Diferencia As Integer = 1
            ' Crea una instancia del formulario al que deseas pasar el valor
            Dim otroFormulario As New FormMostrarCrear(valor, Diferencia)

            ' Muestra el otro formulario
            otroFormulario.Show()
        Else
            MessageBox.Show("No se ha seleccionado ninguna fila.")
        End If


    End Sub

    Private Sub ButtonCrear_Click(sender As Object, e As EventArgs) Handles ButtonCrear.Click
        ' Verifica si hay al menos una fila seleccionada en el DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtiene el valor de la primera celda de la fila seleccionada (asumiendo que es una celda de texto)
            Dim valor As String = DataGridView1.SelectedRows(0).Cells(0).Value
            Dim Diferencia As Integer = 2
            ' Crea una instancia del formulario al que deseas pasar el valor
            Dim otroFormulario As New FormMostrarCrear(valor, Diferencia)

            ' Muestra el otro formulario
            otroFormulario.Show()
        Else
            MessageBox.Show("No se ha seleccionado ninguna fila.")
        End If
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim valor As String = DataGridView1.SelectedRows(0).Cells(0).Value
        Try
            Dim procedureName As String = "SP_EliminarVehiculo"
            Dim parameters As SqlParameter() = {
        New SqlParameter("@vehiculoId", valor)
    }

            ' Ejecutar el procedimiento almacenado
            Conexion.ExecuteStoredProcedure(procedureName, parameters)
            MsgBox("Vehículo eliminado exitosamente")
        Catch ex As Exception
            ' Manejar el error
            MessageBox.Show("Se produjo un error al eliminar el vehículo: " & ex.Message)
            ' Puedes hacer un retorno aquí si lo deseas
            Return
        End Try

        ' Actualizar el DataGridView con los vehículos restantes
        query = "SELECT id, año, kilometraje, interior, idMarca, idModelo, idVersionAuto, idCarroceria, idTransmision, idColor, idVenta FROM Vehiculo WHERE estatus = 1"
        DataGridView1.DataSource = Conexion.SelectQuery(query)

    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        ' Verifica si hay al menos una fila seleccionada en el DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtiene el valor de la primera celda de la fila seleccionada (asumiendo que es una celda de texto)
            Dim valor As String = DataGridView1.SelectedRows(0).Cells(0).Value
            Dim Diferencia As Integer = 3
            ' Crea una instancia del formulario al que deseas pasar el valor
            Dim otroFormulario As New FormMostrarCrear(valor, Diferencia)

            ' Muestra el otro formulario
            otroFormulario.Show()
        Else
            MessageBox.Show("No se ha seleccionado ninguna fila.")
        End If
    End Sub
End Class
