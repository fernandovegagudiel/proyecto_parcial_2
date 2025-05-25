using System.Data;
using System.Web;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Minicraft

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);


            JugadorService jugadorService = new JugadorService(new DatabaseManager());
            Jugador jugador = jugadorService.ObtenerPorId(id);
            if (jugador != null)
            {

                textBoxNombre.Text = jugador.Nombre;
                textBoxNivel.Text = jugador.Nivel.ToString();
                textBoxFechaCreacion.Text = jugador.FechaCreacion.ToShortDateString();
            }
            else
            {

                MessageBox.Show("Jugador no encontrado.");
                textBoxID.Text = " ";
                textBoxNombre.Text = " ";
                textBoxNivel.Text = "  ";
                textBoxFechaCreacion.Text = " ";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador
            {
                Nombre = textBoxNombre.Text,
                Nivel = int.Parse(textBoxNivel.Text) // ¡Asegúrate de que sea un número válido!
            };

            try
            {
                var servicioJugador = new JugadorService(new DatabaseManager());
                servicioJugador.Crear(jugador);

                MessageBox.Show($"¡Jugador creado exitosamente con ID {jugador.Id}!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el jugador: {ex.Message}");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(textBoxID.Text);
                JugadorService servicioJugador = new JugadorService(new DatabaseManager());
                servicioJugador.Eliminar(id);

                MessageBox.Show("Operación de eliminación finalizada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el jugador: {ex.Message}");
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxID.Text);
                string nombre = textBoxNombre.Text;
                int nivel = int.Parse(textBoxNivel.Text);

                Jugador jugador = new Jugador
                {
                    Id = id,
                    Nombre = nombre,
                    Nivel = nivel
                };

                JugadorService servicioJugador = new JugadorService(new DatabaseManager());
                servicioJugador.Actualizar(jugador);

                MessageBox.Show("Operación de actualización finalizada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el jugador: {ex.Message}");
            }
        }

        private void comboBoxTipoBloque_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            BloqueService bloque = new BloqueService(new DatabaseManager());
            string? opcion = comboBoxTipoBloque.SelectedItem?.ToString();
            List<Bloque> bloquesTodo = bloque.ObtenerTodos();
            switch (opcion)
            {
                case "Todo":
               
                    dataGridView.DataSource = bloquesTodo;
                    break;
                case "Madera":
                    dataGridView.DataSource = bloque.BuscarPorTipo("Madera");

                    break;

                case "Mineral":
                    dataGridView.DataSource = bloque.BuscarPorTipo("Mineral");
                    break;

                case "Épico":
                    dataGridView.DataSource = bloque.BuscarPorRareza("Épico");
                    break;

                case "Común":
                    dataGridView.DataSource = bloque.BuscarPorRareza("Común");
                    break;

                default:
                    dataGridView.DataSource = bloque.BuscarPorRareza("Raro");
                    break;
            }
        }


        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var cell = dataGridView.Rows[e.RowIndex].Cells[1].Value;
                if (cell != null)
                {
                    string opcion = cell.ToString().Trim();

                    switch (opcion)
                    {
                        case "Madera de roble":
                            labelNombre.Text = "Madera de roble";
                            pictureBoxBloque.Image = Image.FromFile(@"imagen\Grid_Tronco_de_roble_oscuro.png");

                            break;

                        case "Piedra":
                            labelNombre.Text = "Piedra";
                            pictureBoxBloque.Image = Image.FromFile(@"imagen\Bedrock_JE2_BE2.png");
                            break;
                        case "Hierro":
                            labelNombre.Text = "Hierro";
                            pictureBoxBloque.Image = Image.FromFile(@"imagen\hiero-removebg-preview.png");

                            break;
                        case "Oro":
                            labelNombre.Text = "Oro";
                            pictureBoxBloque.Image = Image.FromFile(@"imagen\oro.png");
                            break;
                        case "Diamante":
                            labelNombre.Text = "Diamante";
                            pictureBoxBloque.Image = Image.FromFile(@"imagen\Diamond.png");
                            break;
                        case "Esmeralda":
                            labelNombre.Text = "Esmeralda";
                            pictureBoxBloque.Image = Image.FromFile(@"imagen\Emerald.png");
                            break;
                        case "Redstone":
                            labelNombre.Text = "Redstone";
                            pictureBoxBloque.Image = Image.FromFile(@"imagen\Redstone.png");
                            break;
                        case "Lapislázuli":
                            labelNombre.Text = "Lapislázuli";
                            pictureBoxBloque.Image = Image.FromFile(@"imagen\ItemLapisLazuliOre1.png");
                            break;
                        case "Obsidiana":
                            labelNombre.Text = "Obsidiana";
                            pictureBoxBloque.Image = Image.FromFile(@"imagen\Obsidiana.png");
                            break;
                        case "Bloque de netherita":
                            labelNombre.Text = "Bloque de netherita";
                            pictureBoxBloque.Image = Image.FromFile(@"imagen\Bloque de netherita.png");
                            break;
                        default:
                            pictureBoxBloque.Image = null;
                            break;

                    }
                }
            }
        }
            
        

        private void pictureBoxBloque_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

            
  


        }
    }
}



