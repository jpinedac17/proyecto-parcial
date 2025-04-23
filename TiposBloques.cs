using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MinecraftManager.Utils;

namespace proyecto_parcial
{
    public partial class TiposBloques : Form
    {
        DatabaseManager Jugadores;
        string? tipoBloque;
        public TiposBloques()
        {
            InitializeComponent();
            Jugadores = new DatabaseManager();
        }

        private void TiposBloques_Load(object sender, EventArgs e)
        {
            CargarTiposBloques();
        }

        private void CargarTiposBloques()
        {
            string conexion = "Server=DESKTOP-DVB2F0D\\SQLEXPRESS;Database=Jugadores;Integrated Security=True; TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string consulta = "SELECT DISTINCT Tipo FROM Bloques ORDER BY Tipo";
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                comboBoxBloques.Items.Clear();

                while (reader.Read())
                {
                    comboBoxBloques.Items.Add(reader["Tipo"].ToString());
                }
            }
        }

        private void FiltrarBloquesPorTipo(string tipoBloque)
        {
            string conexion = "Server=DESKTOP-DVB2F0D\\SQLEXPRESS;Database=Jugadores;Integrated Security=True; TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string consulta = "SELECT Nombre FROM Bloques WHERE Tipo = @TipoBloque ORDER BY Nombre;";
                    SqlCommand cmd = new SqlCommand(consulta, conn);
                    cmd.Parameters.AddWithValue("@TipoBloque", tipoBloque);

                    SqlDataReader reader = cmd.ExecuteReader();
                    Lista_Bloques.Items.Clear();

                    while (reader.Read())
                    {
                        Lista_Bloques.Items.Add(reader["Nombre"].ToString());
                    }

                    if (Lista_Bloques.Items.Count == 0)
                    {
                        Lista_Bloques.Items.Add("No se encontraron bloques con ese tipo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al filtrar bloques: " + ex.Message);
                }
            }
        }

        private void btnFiltral_Click(object sender, EventArgs e)
        {
            tipoBloque = comboBoxBloques.Text;

            FiltrarBloquesPorTipo(tipoBloque);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nuevoFormulario = new Inventario();
            this.Hide();
            nuevoFormulario.ShowDialog(); // Muestra el nuevo formulario
            this.Close();
        }
    }
}
