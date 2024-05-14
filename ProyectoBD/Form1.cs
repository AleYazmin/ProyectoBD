using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ProyectoBD
{

    public partial class Form1
    {
        private string query;
        private bool auto;
        // Create a constructor
        public Form1()
        {
            auto = true;

            // This call is required by the designer.
            InitializeComponent();
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // Add any initialization after the InitializeComponent() call.
            // Create a new instance of the Connection class

            query = "SELECT id, marca FROM Marca";
            CBVehiculo.DataSource = Conexion.SelectQuery(query);
            CBVehiculo.DisplayMember = "marca";
            CBVehiculo.ValueMember = "id";
            auto = false;
            DataGridView1.ReadOnly = true;

            query = @"SELECT TOP 500 *
FROM VW_vehiculosBusqueda where estatus=1";
            DataGridView1.DataSource = Conexion.SelectQuery(query);
            ButtonMostrar.Enabled = false;
            ButtonActualizar.Enabled = false;
            ButtonEliminar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CBVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Realizar la consulta para obtener los vehículos de la marca seleccionada
            string query = "SELECT * FROM VW_vehiculosBusqueda WHERE marca = '" + CBVehiculo.Text + "'"; // Reemplaza "VW_vehiculosBusqueda" por el nombre de tu vista
            var dataTable = Conexion.SelectQuery(query);

            // Mostrar los resultados en el control DataGridView
            DataGridView1.DataSource = dataTable;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string buscarTexto = TextBox1.Text.Trim();
            string query = "";
            query = @"SELECT * FROM VW_vehiculosBusqueda
where Modelo LIKE '%" + buscarTexto + "%' and Estatus=1";
            // Ejecutar la consulta SQL y mostrar los resultados en el DataGridView
            var dt = Conexion.SelectQuery(query);

            DataGridView1.DataSource = dt;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada en el DataGridView
            if (DataGridView1.SelectedRows.Count > 0)
            {
                // Habilita los tres botones
                ButtonMostrar.Enabled = true;
                ButtonActualizar.Enabled = true;
                ButtonEliminar.Enabled = true;
            }
            else
            {
                // Deshabilita los tres botones si no hay ninguna fila seleccionada
                ButtonMostrar.Enabled = false;
                ButtonActualizar.Enabled = false;
                ButtonEliminar.Enabled = false;
            }
        }

        private void ButtonMostrar_Click(object sender, EventArgs e)
        {

            // Verifica si hay al menos una fila seleccionada en el DataGridView
            if (DataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene el valor de la primera celda de la fila seleccionada (asumiendo que es una celda de texto)
                string valor = Conversions.ToString(DataGridView1.SelectedRows[0].Cells[0].Value);
                int Diferencia = 1;
                // Crea una instancia del formulario al que deseas pasar el valor
                var otroFormulario = new FormMostrarCrear(valor, Diferencia);

                // Muestra el otro formulario
                otroFormulario.Show();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }


        }

        private void ButtonCrear_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada en el DataGridView
            if (DataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene el valor de la primera celda de la fila seleccionada (asumiendo que es una celda de texto)
                string valor = Conversions.ToString(DataGridView1.SelectedRows[0].Cells[0].Value);
                int Diferencia = 2;
                // Crea una instancia del formulario al que deseas pasar el valor
                var otroFormulario = new FormMostrarCrear(valor, Diferencia);

                // Muestra el otro formulario
                otroFormulario.Show();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            string valor = Conversions.ToString(DataGridView1.SelectedRows[0].Cells[0].Value);
            try
            {
                string procedureName = "SP_EliminarVehiculo";
                SqlParameter[] parameters = new[] { new SqlParameter("@vehiculoId", valor) };

                // Ejecutar el procedimiento almacenado
                Conexion.ExecuteStoredProcedure(procedureName, parameters);
                Interaction.MsgBox("Vehículo eliminado exitosamente");
            }
            catch (Exception ex)
            {
                // Manejar el error
                MessageBox.Show("Se produjo un error al eliminar el vehículo: " + ex.Message);
                // Puedes hacer un retorno aquí si lo deseas
                return;
            }

            // Actualizar el DataGridView con los vehículos restantes
            query = "SELECT id, año, kilometraje, interior, idMarca, idModelo, idVersionAuto, idCarroceria, idTransmision, idColor, idVenta FROM Vehiculo WHERE estatus = 1";
            DataGridView1.DataSource = Conexion.SelectQuery(query);

        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada en el DataGridView
            if (DataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene el valor de la primera celda de la fila seleccionada (asumiendo que es una celda de texto)
                string valor = Conversions.ToString(DataGridView1.SelectedRows[0].Cells[0].Value);
                int Diferencia = 3;
                // Crea una instancia del formulario al que deseas pasar el valor
                var otroFormulario = new FormMostrarCrear(valor, Diferencia);

                // Muestra el otro formulario
                otroFormulario.Show();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }
    }
}