using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;

namespace proyecto_parcial
{
    public partial class Form1 : Form
    {
        DatabaseManager Jugadores;
        string? bloquesRareza;
        JugadorService serviciosJugador;
        string? nombre;
        string? nivel;
        string? id;


        public Form1()
        {
            InitializeComponent();
            Jugadores = new DatabaseManager();
            serviciosJugador = new JugadorService(Jugadores);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bloquesRareza = Jugadores.ObtenerBloquesPorRareza("Común");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nombre = textBoxNombre.Text;
            nivel = textBoxNivel.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(nivel))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            Jugadores.AgregarJugador(nombre, nivel);

            textBoxNombre.Text = "";
            textBoxNivel.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nombre = textBoxNombre.Text;
            nivel = textBoxNivel.Text;
            id = textBoxId.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nivel))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            Jugadores.ActualizarJugador(id, nombre, nivel);

            textBoxNombre.Text = "";
            textBoxNivel.Text = "";
            textBoxId.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            id = textBoxId.Text;

            Jugadores.EliminarJugador(id);
            textBoxNombre.Text = "";
            textBoxNivel.Text = "";
            textBoxId.Text = "";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form nuevoFormulario = new Inventario();
            this.Hide();
            nuevoFormulario.ShowDialog(); // Muestra el nuevo formulario
            this.Close();
        }
    }
}
