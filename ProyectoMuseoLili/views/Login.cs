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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correo = textBox1.Text;
            string password = textBox2.Text;

            ControllerUsuario contrlU = new ControllerUsuario();
           
            Usuario objU = contrlU.LoginUsuario(correo, password);

            

            if( objU == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            else
            {
                MessageBox.Show("Bienvenido " + objU.Nombre1Usuario);
                this.Hide();
                Form mainForm = new Main(objU);
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form mainForm = new OlvideContrasena();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form mainForm = new Registrarse();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }
    }
}
