using ProyectoMuseoLili.controllers;
using ProyectoMuseoLili.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMuseoLili.views
{
    public partial class OlvideContrasena : Form
    {
        private int resetCode;
        private string correo;
        public OlvideContrasena()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            correo = textBox1.Text;
            Usuario user = new Usuario(correo);

            ControllerUsuario contrlU = new ControllerUsuario();

            user = contrlU.BuscarUsuarioPorCorreo(correo);
            if (user == null)
            {
                MessageBox.Show("El correo no está registrado o erroneo.");
                return;
            }
            else
            {
                MessageBox.Show("Se ha enviado un codigo a " + correo + " para restablecer su contraseña.");
                resetCode = new Random().Next(1000, 9999);
                Debug.WriteLine("Código de restablecimiento: " + resetCode);
                textBox4.Enabled = true;
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputCode = textBox4.Text;

            if (inputCode.Equals(resetCode.ToString()))
            {
                MessageBox.Show("Código verificado. Ahora puede restablecer su contraseña.");
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Código incorrecto. Inténtelo de nuevo.");
                MessageBox.Show("Se ha enviado un codigo a " + correo + " para restablecer su contraseña.");
                resetCode = new Random().Next(1000, 9999);
                Debug.WriteLine("Código de restablecimiento: " + resetCode);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string contrasena1 = textBox2.Text;
            string contrasena2 = textBox3.Text;
            ControllerUsuario contrlU = new ControllerUsuario();
            if (contrasena1 != contrasena2)
            {
                MessageBox.Show("Las contraseñas no coinciden. Inténtelo de nuevo.");
                return;
            }
            else
            {
                bool actualizacion = contrlU.ActualizarContrasena(new Usuario(correo, contrasena1));
                if (actualizacion)
                {
                    MessageBox.Show("Contraseña actualizada exitosamente.");
                    this.Hide();
                    Form mainForm = new Login();
                    mainForm.Closed += (s, args) => this.Close();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la contraseña. Inténtelo de nuevo.");
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form mainForm = new Login();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }
    }
}
