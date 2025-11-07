using ProyectoMuseoLili.controllers;
using ProyectoMuseoLili.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMuseoLili.views
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form mainForm = new Login();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox6.Text;
            string apellido = textBox5.Text;
            
            string password = textBox2.Text;
            string cedula = textBox4.Text;
            string telefono = textBox3.Text;
     
            string? nombre2 = string.IsNullOrWhiteSpace(textBox8.Text) ? null : textBox8.Text.Trim();
            string? apellido2 = string.IsNullOrWhiteSpace(textBox7.Text) ? null : textBox7.Text.Trim();
            string uuid = Guid.NewGuid().ToString();

            string correo = textBox1.Text;
            if (!correo.Contains("@")) 
            {
                MessageBox.Show("Escribe un correo valido que contenga @");
                return;
            }
            Usuario newUser = new Usuario
            {
                UUIDUsuario1 = uuid,
                Nombre1Usuario = nombre,
                Apellido1Usuario = apellido,
                EmailUsuario = correo,
                PasswordUsuario = password,
                CedulaUsuario = cedula,
                TelefonoUsuario = telefono,
                Nombre2Usuario = nombre2,
                Apellido2Usuario = apellido2,
                IdRol_RU = 4
            };

            ControllerUsuario contrlU = new ControllerUsuario();

            bool registroExitoso = contrlU.InsertNewUsuario(newUser);
            if (registroExitoso)
            {
                MessageBox.Show("Registro exitoso. Ahora puede iniciar sesión.");
                MessageBox.Show("Se te asignara un rol TEMPORAL que te permitira navegar la app hasta que un administrador te asigne un rol.");
                this.Hide();
                Form mainForm = new Login();
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Error en el registro. Inténtelo de nuevo.");
            }
        }
    }
}
