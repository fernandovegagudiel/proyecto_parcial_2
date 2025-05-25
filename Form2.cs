using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minicraft
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            string nombre = textBoxUser.Text.Trim();
            string contraseña = textBoxContraseña.Text.Trim();

            bool encontrado = false;

            if (File.Exists("usuarios.txt"))
            {
                foreach (string linea in File.ReadAllLines("usuarios.txt"))
                {
                    string[] datos = linea.Split(',');

                    if (datos.Length == 2 && datos[0] == nombre && datos[1] == contraseña)
                    {
                        encontrado = true;
                        break;
                    }
                }
            }

            if (encontrado)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContraseña.Clear();
                textBoxUser.Focus();
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = textBoxUser.Text;
            string nuevaContrasena = textBoxContraseña.Text;

          
            if (string.IsNullOrEmpty(nuevoUsuario) || string.IsNullOrEmpty(nuevaContrasena))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario y una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nuevoRegistro = $"{nuevoUsuario},{nuevaContrasena}\n";
            File.AppendAllText("usuarios.txt", nuevoRegistro);

            MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxUser.Clear();
            textBoxContraseña.Clear();
        }

    }

}

