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
        }

        private void Cinema_Load(object sender, EventArgs e)
        {
            var Salas = SalaController.GetSalas();
            lbSalas.DataSource = Salas;
            lbSalas.DisplayMember = "Nome";

            try
            {
                var cinema = CinemaController.GetCinema();
                txtNome.Text = cinema.Name;
                txtMorada.Text = cinema.Morada;
                txtEmail.Text = cinema.Email;
            }
            catch
            { 
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string morada = txtMorada.Text;

            if (nome == "" || email == "" || morada == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return;
            }

            if (!CinemaController.CinemaExists())
            {
                CinemaController.AddCinema(nome, morada, email);
            }
            else
            {
                CinemaController.EditCinema(nome, morada, email);
            }

            var cinema = CinemaController.GetCinema();
            txtNome.Text = cinema.Name;
            txtMorada.Text = cinema.Morada;
            txtEmail.Text = cinema.Email;
        }

        private void lbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalaModel sala = (SalaModel)lbSalas.SelectedItem;
            txtNomeSala.Text = sala.Nome;
            numericUpDownColunas.Value = sala.Colunas;
            numericUpDownFilas.Value = sala.Filas;

            btnApagar.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nomesala = txtNomeSala.Text;
            int colunas = (int)numericUpDownColunas.Value;
            int filas = (int)numericUpDownFilas.Value;

            if (nomesala == "")
            {
                MessageBox.Show("A sala precisa de ter um nome.");
                return;
            }

            if (colunas == 0 || filas == 0)
            {
                MessageBox.Show("Tamanho da sala invalido.");
                return;
            }

            try
            {
                SalaController.AddSala(nomesala, colunas, filas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateSalas();
        }

        private void UpdateSalas()
        {
            var Salas = SalaController.GetSalas();
            lbSalas.DataSource = Salas;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            SalaModel sala = (SalaModel)lbSalas.SelectedItem;

            SalaController.DeleteSala(sala.Id);
            UpdateSalas();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SalaModel sala = (SalaModel)lbSalas.SelectedItem;
            string nomesala = txtNomeSala.Text;
            int colunas = (int)numericUpDownColunas.Value;
            int filas = (int)numericUpDownFilas.Value;
            SalaController.AlterarSala(sala.Id, nomesala, colunas, filas);
            UpdateSalas();
        }
    }
}
