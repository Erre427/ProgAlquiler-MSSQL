using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALQUILER
{
    public partial class Empresas : Form
    {
        // Instancia de clase para conectarse a la base de datos sql
        SqlConnection conexion = SQLConnect.ObtenerConexion();

        public Empresas()
        {
            InitializeComponent();
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aLQUILERDataSet.EMPRESA' table. You can move, or remove it, as needed.
            this.eMPRESATableAdapter.Fill(this.aLQUILERDataSet.EMPRESA);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Menu = new Form1();
            this.Close();
            Menu.Location = this.Location;
            Menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Alta = "INSERT INTO EMPRESA(ID_EMPRESA,NOMBRE_EMPRESA,DIREC_EMPRESA,GIRO,TELEFONO) VALUES(@idempresa,@nombrempresa,@direcempresa,@giro,@telefono)";
            
            try
            {
                SqlCommand cmdAlta = new SqlCommand(Alta,conexion);
                cmdAlta.Parameters.AddWithValue("idempresa", idempresa.Text);
                cmdAlta.Parameters.AddWithValue("nombrempresa", nombrempresa.Text);
                cmdAlta.Parameters.AddWithValue("direcempresa", direcempresa.Text);
                cmdAlta.Parameters.AddWithValue("giro", giro.Text);
                cmdAlta.Parameters.AddWithValue("telefono", telefono.Text);
                if(string.IsNullOrWhiteSpace(idempresa.Text)|| string.IsNullOrWhiteSpace(nombrempresa.Text) 
                    || string.IsNullOrWhiteSpace(direcempresa.Text) || string.IsNullOrWhiteSpace(giro.Text) || 
                        string.IsNullOrWhiteSpace(telefono.Text))
                {
                    throw new Exception("No se permiten espacios en blanco");
                }
                conexion.Open();
                cmdAlta.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se agrego la empresa con exito!");

                idempresa.Clear();
                nombrempresa.Clear();
                direcempresa.Clear();
                giro.Clear();
                telefono.Clear();
            }

            catch (SqlException ex)
            {
                if(ex.Number == 2627)
                {
                    MessageBox.Show("No se pueden replicar ID's");
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception md)
            {
                MessageBox.Show(md.Message);
            }
            
            
        }
    }
}
