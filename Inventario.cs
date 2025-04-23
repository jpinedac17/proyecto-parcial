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

namespace proyecto_parcial
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarJugadores();
        }

        private void CargarJugadores()
        {
            string conexion = "Server=DESKTOP-DVB2F0D\\SQLEXPRESS;Database=Jugadores;Integrated Security=True; TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string consulta = "SELECT Id, Nombre FROM Jugadores ORDER BY Nombre;";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbJugadores.DataSource = dt;
                    cmbJugadores.DisplayMember = "Nombre";   // Lo que ve el usuario
                    cmbJugadores.ValueMember = "Id";  // Lo que se usa internamente
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar jugadores: " + ex.Message);
                }
            }
        }

        private void FiltrarPorJugador(int jugadorId)
        {
            string conexion = "Server=DESKTOP-DVB2F0D\\SQLEXPRESS;Database=Jugadores;Integrated Security=True; TrustServerCertificate=True;";
            string consulta = @"
        SELECT 
            Jugadores.Nombre AS Jugador,
            Jugadores.Nivel,
            Bloques.Nombre AS Bloque,
            Inventario.Cantidad
        FROM 
            Inventario
        INNER JOIN 
            Jugadores ON Inventario.JugadorId = Jugadores.Id
        INNER JOIN 
            Bloques ON Inventario.BloqueId = Bloques.Id
        WHERE 
            Inventario.JugadorId = @JugadorId
        ORDER BY 
            Bloques.Nombre;";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    SqlCommand comando = new SqlCommand(consulta, conn);
                    comando.Parameters.AddWithValue("@JugadorId", jugadorId);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al filtrar: " + ex.Message);
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cmbJugadores.SelectedValue != null)
            {
                int jugadorId = Convert.ToInt32(cmbJugadores.SelectedValue);
                FiltrarPorJugador(jugadorId); // Usamos la función que ya hicimos antes
            }
        }

        private void btnExportarCsv_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "Archivo CSV (*.csv)|*.csv";
            guardarArchivo.Title = "Guardar archivo CSV";
            guardarArchivo.FileName = "InventarioJugador.csv";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(guardarArchivo.FileName, false, Encoding.UTF8))
                    {
                        // Escribir encabezados
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            sw.Write(dataGridView1.Columns[i].HeaderText);
                            if (i < dataGridView1.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        // Escribir filas
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            if (!fila.IsNewRow)
                            {
                                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                {
                                    sw.Write(fila.Cells[i].Value?.ToString());
                                    if (i < dataGridView1.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Archivo CSV exportado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message);
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form nuevoFormulario = new TiposBloques();
            this.Hide();
            nuevoFormulario.ShowDialog(); // Muestra el nuevo formulario
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nuevoFormulario = new Form1();
            this.Hide();
            nuevoFormulario.ShowDialog(); // Muestra el nuevo formulario
            this.Close();
        }
    }
}
