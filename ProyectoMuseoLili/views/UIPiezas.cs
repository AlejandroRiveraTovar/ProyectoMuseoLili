using ProyectoMuseoLili.controllers;
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
    public partial class UIPiezas : Form
    {
        public UIPiezas()
        {
            InitializeComponent();
        }

        private void UIPiezas_Load(object sender, EventArgs e)
        {

        }

        private void LoadDepartments(object sender, EventArgs e)
        {
            ControllerCategoria objC = new ControllerCategoria();
            listD = objC.BuscarCategoria();
            for (int i = 0; i < listD.Count; i++)
            {
                comboBox1.Items.Add(listD[i].NombreDepartamento);
                // comboBox2.Items.Add(listD[i].NombreE);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
       
            this.Hide();
            Form mainForm = new Main();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
       
        }
    }
}
