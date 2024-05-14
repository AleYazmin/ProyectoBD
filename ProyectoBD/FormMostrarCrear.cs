using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ProyectoBD
{


    public partial class FormMostrarCrear
    {
        private string query;
        private string valorRecibido;
        private int DiferenciaRecibida;

        public FormMostrarCrear(string valor, int Diferencia)
        {
            InitializeComponent();
            // Guardar el valor recibido en la variable privada
            valorRecibido = valor;
            DiferenciaRecibida = Diferencia;
        }

        private void InicializarDatos()
        {
            query = "select id,marca from marca";
            ComboBoxMarca.DataSource = Conexion.SelectQuery(query);
            ComboBoxMarca.DisplayMember = "marca";
            ComboBoxMarca.ValueMember = "id";
            // Modelo
            query = "select id,modelo from modelo";
            ComboBoxModelo.DataSource = Conexion.SelectQuery(query);
            ComboBoxModelo.DisplayMember = "modelo";
            ComboBoxModelo.ValueMember = "id";
            // Version Auto
            query = "select id,versionAuto from Versionauto";
            ComboBoxVersionAuto.DataSource = Conexion.SelectQuery(query);
            ComboBoxVersionAuto.DisplayMember = "versionAuto";
            ComboBoxVersionAuto.ValueMember = "id";
            // carroceria
            query = "select id,carroceria from Carroceria";
            ComboBoxCarroceria.DataSource = Conexion.SelectQuery(query);
            ComboBoxCarroceria.DisplayMember = "carroceria";
            ComboBoxCarroceria.ValueMember = "id";
            // Transmicion
            query = "select id,transmision from Transmision";
            ComboBoxTransmicion.DataSource = Conexion.SelectQuery(query);
            ComboBoxTransmicion.DisplayMember = "transmision";
            ComboBoxTransmicion.ValueMember = "id";
            // Color
            query = "select id,color from color";
            ComboBoxColor.DataSource = Conexion.SelectQuery(query);
            ComboBoxColor.DisplayMember = "color";
            ComboBoxColor.ValueMember = "id";

            // Venta
            query = "SELECT id, vendedor FROM Venta";
            ComboBoxVenta.DataSource = Conexion.SelectQuery(query);
            ComboBoxVenta.DisplayMember = "vendedor";
            ComboBoxVenta.ValueMember = "id";

            if (DiferenciaRecibida == 1)
            {
                // Ejecutar un procedimiento almacenado
                string procedureName = "SP_BuscarVehiculoPorID";
                SqlParameter[] parameters = new[] { new SqlParameter("@vehiculoID", valorRecibido) };


                // Obtener un lector de datos para el resultado del procedimiento almacenado
                var reader = Conexion.ExecuteStoredProcedureReader(procedureName, parameters);

                // Verificar si hay filas devueltas por el procedimiento almacenado
                if (reader.HasRows)
                {
                    // Si hay filas, leer la primera fila (suponiendo que solo hay una fila)
                    if (reader.Read())
                    {
                        // Obtener los datos de las columnas y asignarlos a las variables de la clase Caché
                        // Obtener los datos de las columnas y asignarlos a las variables de la clase Caché
                        TextBoxAño.Text = !(reader["año"] is DBNull) ? Convert.ToString(reader["año"]) : "";
                        TextBoxKilometraje.Text = !(reader["kilometraje"] is DBNull) ? Convert.ToString(reader["kilometraje"]) : "";
                        TextBoxInterior.Text = !(reader["interior"] is DBNull) ? Convert.ToString(reader["interior"]) : "";

                        ComboBoxMarca.SelectedValue = !(reader["idMarca"] is DBNull) ? Convert.ToInt32(reader["idMarca"]) : -1;
                        ComboBoxModelo.SelectedValue = !(reader["idModelo"] is DBNull) ? Convert.ToInt32(reader["idModelo"]) : -1;
                        ComboBoxVersionAuto.SelectedValue = !(reader["idVersionAuto"] is DBNull) ? Convert.ToInt32(reader["idVersionAuto"]) : -1;
                        ComboBoxCarroceria.SelectedValue = !(reader["idCarroceria"] is DBNull) ? Convert.ToInt32(reader["idCarroceria"]) : -1;
                        ComboBoxTransmicion.SelectedValue = !(reader["idTransmision"] is DBNull) ? Convert.ToInt32(reader["idTransmision"]) : -1;
                        ComboBoxColor.SelectedValue = !(reader["idColor"] is DBNull) ? Convert.ToInt32(reader["idColor"]) : -1;
                        ComboBoxVenta.SelectedValue = !(reader["idVenta"] is DBNull) ? Convert.ToInt32(reader["idVenta"]) : -1;


                    }
                }

                Conexion.Disconect();
                // Configurar campos de texto como solo lectura
                TextBoxAño.Enabled = false;
                TextBoxKilometraje.Enabled = false;
                TextBoxInterior.Enabled = false;

                // Configurar ComboBox como solo lectura
                ComboBoxMarca.Enabled = false;
                ComboBoxModelo.Enabled = false;
                ComboBoxVersionAuto.Enabled = false;
                ComboBoxCarroceria.Enabled = false;
                ComboBoxTransmicion.Enabled = false;
                ComboBoxColor.Enabled = false;
                ComboBoxVenta.Enabled = false;
                ButtonActualizar.Visible = false;
                Buttonagregar.Visible = false;
            }

            else if (DiferenciaRecibida == 2)
            {
                ButtonActualizar.Visible = false;
            }
            else if (DiferenciaRecibida == 3)
            {
                Buttonagregar.Visible = false;
                // Ejecutar un procedimiento almacenado
                string procedureName = "SP_BuscarVehiculoPorID";
                SqlParameter[] parameters = new[] { new SqlParameter("@vehiculoID", valorRecibido) };


                // Obtener un lector de datos para el resultado del procedimiento almacenado
                var reader = Conexion.ExecuteStoredProcedureReader(procedureName, parameters);

                // Verificar si hay filas devueltas por el procedimiento almacenado
                if (reader.HasRows)
                {
                    // Si hay filas, leer la primera fila (suponiendo que solo hay una fila)
                    if (reader.Read())
                    {
                        // Obtener los datos de las columnas y asignarlos a las variables de la clase Caché
                        TextBoxAño.Text = !(reader["año"] is DBNull) ? Convert.ToString(reader["año"]) : "";
                        TextBoxKilometraje.Text = !(reader["kilometraje"] is DBNull) ? Convert.ToString(reader["kilometraje"]) : "";
                        TextBoxInterior.Text = !(reader["interior"] is DBNull) ? Convert.ToString(reader["interior"]) : "";

                        ComboBoxMarca.SelectedValue = !(reader["idMarca"] is DBNull) ? Convert.ToInt32(reader["idMarca"]) : -1;
                        ComboBoxModelo.SelectedValue = !(reader["idModelo"] is DBNull) ? Convert.ToInt32(reader["idModelo"]) : -1;
                        ComboBoxVersionAuto.SelectedValue = !(reader["idVersionAuto"] is DBNull) ? Convert.ToInt32(reader["idVersionAuto"]) : -1;
                        ComboBoxCarroceria.SelectedValue = !(reader["idCarroceria"] is DBNull) ? Convert.ToInt32(reader["idCarroceria"]) : -1;
                        ComboBoxTransmicion.SelectedValue = !(reader["idTransmision"] is DBNull) ? Convert.ToInt32(reader["idTransmision"]) : -1;
                        ComboBoxColor.SelectedValue = !(reader["idColor"] is DBNull) ? Convert.ToInt32(reader["idColor"]) : -1;
                        ComboBoxVenta.SelectedValue = !(reader["idVenta"] is DBNull) ? Convert.ToInt32(reader["idVenta"]) : -1;


                    }
                }
                Conexion.Disconect();
                Buttonagregar.Visible = false;
            }

        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMostrarCrear_Load(object sender, EventArgs e)
        {
            InicializarDatos();
        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int usuariomodifica = 1;
                string procedureName = "SP_ActualizarVehiculo";
                SqlParameter[] parameters = new[] { new SqlParameter("@id", valorRecibido), new SqlParameter("@año", Convert.ToInt32(TextBoxAño.Text)), new SqlParameter("@kilometraje", Convert.ToInt32(TextBoxKilometraje.Text)), new SqlParameter("@interior", TextBoxInterior.Text), new SqlParameter("@idMarca", Convert.ToInt32(ComboBoxMarca.SelectedValue)), new SqlParameter("@idModelo", Convert.ToInt32(ComboBoxModelo.SelectedValue)), new SqlParameter("@idVersionAuto", Convert.ToInt32(ComboBoxVersionAuto.SelectedValue)), new SqlParameter("@idCarroceria", Convert.ToInt32(ComboBoxCarroceria.SelectedValue)), new SqlParameter("@idTransmision", Convert.ToInt32(ComboBoxTransmicion.SelectedValue)), new SqlParameter("@idColor", Convert.ToInt32(ComboBoxColor.SelectedValue)), new SqlParameter("@idVenta", Convert.ToInt32(ComboBoxVenta.SelectedValue)), new SqlParameter("@idUsuarioModifica", usuariomodifica) };

                // Ejecutar el procedimiento almacenado
                Conexion.ExecuteStoredProcedure(procedureName, parameters);
                Interaction.MsgBox("Vehículo actualizado exitosamente");
            }
            catch (Exception ex)
            {
                // Manejar el error
                MessageBox.Show("Se produjo un error al actualizar el vehículo: " + ex.Message);
                // Puedes hacer un retorno aquí si lo deseas
                return;
            }

            // Actualizar el DataGridView con los datos actualizados
            query = @"SELECT TOP 500 *
FROM VW_vehiculosBusqueda where estatus=1";
            My.MyProject.Forms.Form1.DataGridView1.DataSource = Conexion.SelectQuery(query);
        }

        private void Buttonagregar_Click(object sender, EventArgs e)
        {
            try
            {
                int usuariomodifica = 1;
                string procedureName = "SP_InsertarVehiculo";
                SqlParameter[] parameters = new[] { new SqlParameter("@año", Convert.ToInt32(TextBoxAño.Text)), new SqlParameter("@kilometraje", Convert.ToInt32(TextBoxKilometraje.Text)), new SqlParameter("@interior", TextBoxInterior.Text), new SqlParameter("@idMarca", Convert.ToInt32(ComboBoxMarca.SelectedValue)), new SqlParameter("@idModelo", Convert.ToInt32(ComboBoxModelo.SelectedValue)), new SqlParameter("@idVersionAuto", Convert.ToInt32(ComboBoxVersionAuto.SelectedValue)), new SqlParameter("@idCarroceria", Convert.ToInt32(ComboBoxCarroceria.SelectedValue)), new SqlParameter("@idTransmision", Convert.ToInt32(ComboBoxTransmicion.SelectedValue)), new SqlParameter("@idColor", Convert.ToInt32(ComboBoxColor.SelectedValue)), new SqlParameter("@idVenta", Convert.ToInt32(ComboBoxVenta.SelectedValue)), new SqlParameter("@idUsuarioCrea", usuariomodifica) };

                // Ejecutar el procedimiento almacenado
                Conexion.ExecuteStoredProcedure(procedureName, parameters);
                Interaction.MsgBox("Vehículo insertado exitosamente");
            }
            catch (Exception ex)
            {
                // Manejar el error
                MessageBox.Show("Se produjo un error al insertar el vehículo: " + ex.Message);
                // Puedes hacer un retorno aquí si lo deseas
                return;
            }

            // Actualizar el DataGridView con los datos insertados
            query = @"SELECT TOP 500 *
FROM VW_vehiculosBusqueda where estatus=1";
            My.MyProject.Forms.Form1.DataGridView1.DataSource = Conexion.SelectQuery(query);

        }
    }
}