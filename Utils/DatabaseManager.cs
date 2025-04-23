using System;
using System.Data;
using Microsoft.Data.SqlClient;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MinecraftManager.Utils
{
    public class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager()
        {
            _connectionString = "Server=DESKTOP-DVB2F0D\\SQLEXPRESS;Database=Jugadores;Integrated Security=True; TrustServerCertificate=True;";
        }

        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            return connection;
        }

        public bool TestConnection()
        {
            try
            {
                using var connection = GetConnection();
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error de conexión: {ex.Message}");
                return false;
            }
        }

        public string? ObtenerBloquesPorRareza(string rareza)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Nombre FROM Bloques WHERE Rareza = @Rareza";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Rareza", rareza);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return reader["Nombre"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return null;
        }

        public string? AgregarJugador(string nombre, string nivel)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "Insert into Jugadores (Nombre, Nivel) values (@Nombre, @Nivel)";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Nivel", nivel);

                    command.ExecuteNonQuery();
                    Console.WriteLine("Jugador agregado correctamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
            }
            return null;
        }

        public string? ActualizarJugador(string id, string nombre, string nivel)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "Update Jugadores set Nombre = @Nombre, Nivel = @Nivel where id = @id";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Nivel", nivel);

                    int filas = command.ExecuteNonQuery();
                    Console.WriteLine(filas > 0 ? "Alumno actualizado" : "No se encontró el alumno");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
            }
            return null;
        }

        public void EliminarJugador(string id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "Delete from Jugadores where id = @id";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    int filas = command.ExecuteNonQuery();
                    Console.WriteLine(filas > 0 ? "Alumno eliminado" : "No se encontró el alumno");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }


        // Funciones del DataGridView
        

    }
}