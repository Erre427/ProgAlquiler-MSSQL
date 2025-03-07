using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ALQUILER
{
    public partial class Form1 : Form
    {
        // Instancia de clase para conectarse a la base de datos sql
        SqlConnection conexion = SQLConnect.ObtenerConexion();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empresas formEmpresas = new Empresas();
            formEmpresas.Show();
            formEmpresas.Location = this.Location;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Oficinas formOficinas = new Oficinas();
            formOficinas.Show();
            formOficinas.Location = this.Location;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Autoscs formAutos = new Autoscs();
            formAutos.Show();
            formAutos.Location = this.Location;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Alquileres formAlquileres = new Alquileres();
            formAlquileres.Show();
            formAlquileres.Location = this.Location;
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clientes formClientes = new Clientes();
            formClientes.Show();
            formClientes.Location = this.Location;
            this.Hide();
        }
    }
}
