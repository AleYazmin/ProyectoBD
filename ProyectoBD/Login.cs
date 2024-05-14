using System;
using System.Data.SqlClient;

namespace ProyectoBD
{
    public partial class Login
    {
        private SqlCommand comando = new SqlCommand();

        public Login()
        {
            InitializeComponent();
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
        }
    }
}