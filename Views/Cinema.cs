using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopCinema.Controllers;
using TopCinema.Models;

namespace TopCinema.Views
{
    public partial class Cinema : Form
    {
        public Cinema()
        {
            InitializeComponent();
            var Salas = SalaController.GetSalas();
            lbSalas.DataSource = Salas;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool nome = txtNome.Enabled;
            bool email = txtEmail.Enabled;
            bool morada = txtMorada.Enabled;

            if (nome && email && morada)
            {
                txtNome.Enabled = false;
                txtEmail.Enabled = false;
                txtMorada.Enabled = false;
            }
            else
            {
                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                txtMorada.Enabled = true;
            }
        }

        private void lbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalaModel sala = (SalaModel)lbSalas.SelectedItem;
            txtNomeSala.Text = sala.Name;
            numericUpDownColunas.Value = sala.Colunas;
            numericUpDownFilas.Value = sala.Filas;
            //SalaController.GetSala();


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nomesala = txtNomeSala.Text;
            int colunas = (int)numericUpDownColunas.Value;
            int filas = (int)numericUpDownFilas.Value;

            SalaController.AddSala(nomesala, colunas, filas);
            mostrarSala();
            
        }

        private void mostrarSala()
        {
            var Salas = SalaController.GetSalas();
            lbSalas.DataSource = Salas;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            SalaModel sala = (SalaModel)lbSalas.SelectedItem;

            SalaController.DeleteSala(sala);
            mostrarSala();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SalaModel sala = (SalaModel)lbSalas.SelectedItem;
            string nomesala = txtNomeSala.Text;
            int colunas = (int)numericUpDownColunas.Value;
            int filas = (int)numericUpDownFilas.Value;
            SalaController.AlterarSala(sala,nomesala,colunas,filas);
            mostrarSala();
        }
    }
}
