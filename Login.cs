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
using MinecraftManager.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_parcial
{
    public partial class Login : Form
    {
        string? usuario;
        public Login()
        {
            InitializeComponent();
        }

        public bool ValidarUsuario(string usuario)
        {
            string conexion = "Server=DESKTOP-DVB2F0D\\SQLEXPRESS;Database=Jugadores;Integrated Security=True; TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                string query = "SELECT COUNT(*) FROM Jugadores WHERE Nombre = @Usuario";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Usuario", usuario);

                try
                {
                    conn.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Si existe al menos un registro, el usuario es válido
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al validar el usuario: {ex.Message}");
                    return false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario.");
                return;
            }

            // Validar si el usuario existe en la base de datos
            if (ValidarUsuario(usuario))
            {
                Form nuevoFormulario = new Form1();
                this.Hide();
                nuevoFormulario.ShowDialog(); // Muestra el nuevo formulario
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
