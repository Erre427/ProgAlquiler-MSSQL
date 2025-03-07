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
        // SqlConnection connection = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=ALQUILER; integrated security=true");
        SqlConnection connection = new SqlConnection(@"Server=localhost;Database=ALQUILER;Trusted_Connection=True;");

        public Form1()
        {
            InitializeComponent();
        }

        private void altaEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(idempresa.Text) || string.IsNullOrWhiteSpace(nombre.Text) || string.IsNullOrWhiteSpace(giro.Text) || string.IsNullOrWhiteSpace(direccion.Text) || string.IsNullOrWhiteSpace(telefono.Text))
                {
                    throw new Exception("No se pueden enviar espacios en blanco");
                }
                SqlCommand altas = new SqlCommand
                                                ("INSERT INTO EMPRESA(ID_EMPRESA,NOMBRE_EMPRESA,DIREC_EMPRESA,GIRO,TELEFONO) VALUES (@idempresa,@nombre,@direccion,@giro,@telefono)", connection);
                altas.Parameters.AddWithValue("idempresa", idempresa.Text);
                altas.Parameters.AddWithValue("nombre", nombre.Text);
                altas.Parameters.AddWithValue("giro", giro.Text);
                altas.Parameters.AddWithValue("direccion", direccion.Text);
                altas.Parameters.AddWithValue("telefono", telefono.Text);

                connection.Open();
                altas.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Empresa registrada");

                idempresa.Clear();
                nombre.Clear();
                giro.Clear();
                direccion.Clear();
                telefono.Clear();
            }
                
            catch(SqlException msj)
            {
                if(msj.Number == 2627)
                {
                    MessageBox.Show("Ya existe una ID registrada");
                }
            }
            catch(Exception id)
            {
                MessageBox.Show($"Error: {id.Message}");
            }
            
        }
    }
}
