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
    public struct FilmeFormValues
    {
        public string nome;
        public int duracao;
        public string categoria;
        public bool estado;
    }

    public partial class Filmes : Form
    {
        public Filmes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FilmeFormValues valoresForm = ValidateAndExtractFormValues();

            // Nao foi possivel extrair os dados do form
            if (valoresForm.Equals(default(FilmeFormValues))) return;

            try
            {
                FilmeController.AddFilme(valoresForm.nome, valoresForm.duracao, valoresForm.categoria, valoresForm.estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MostrarFilmes();
            lbFilmes.SelectedIndex = -1;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            FilmeModel filme = (FilmeModel)lbFilmes.SelectedItem;
            FilmeController.RemoverFilme(filme.Id);
            MostrarFilmes();
            lbFilmes.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FilmeModel filme = (FilmeModel)lbFilmes.SelectedItem;
            FilmeFormValues valoresForm = ValidateAndExtractFormValues();

            // Nao foi possivel extrair os dados do form
            if (valoresForm.Equals(default(FilmeFormValues))) return;

            try
            {
                FilmeController.AlterarFilme(filme.Id, valoresForm.nome, valoresForm.duracao, valoresForm.categoria, valoresForm.estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MostrarFilmes();
            lbFilmes.SelectedIndex = -1;
        }

        private void MostrarFilmes()
        {
            var filmes = FilmeController.GetFilmes();
            lbFilmes.Controls.Clear();
            lbFilmes.DataSource = filmes;
            lbFilmes.DisplayMember = "Nome";
        }

        private void Filmes_Load(object sender, EventArgs e)
        {
            MostrarFilmes();
            lbFilmes.SelectedIndex = -1;
        }

        private void lbFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFilmes.SelectedIndex == -1)
            {
                txtNome.Text = "";
                numericUpDownDuracao.Value = 1;
                comboBoxCategoria.SelectedIndex = -1;
                cbEstado.SelectedIndex = -1;
                btnApagar.Enabled = false;
                btnSalvar.Enabled = false;
            }
            else
            {
                FilmeModel filme = (FilmeModel)lbFilmes.SelectedItem;
                txtNome.Text = filme.Nome;
                numericUpDownDuracao.Value = filme.Duracao;
                comboBoxCategoria.Text = filme.Categoria.Nome;

                if (filme.Ativo == true)
                    cbEstado.SelectedIndex = 0;
                else
                    cbEstado.SelectedIndex = 1;

                btnApagar.Enabled = true;
                btnSalvar.Enabled = true;
            }
        }

        private FilmeFormValues ValidateAndExtractFormValues()
        {
            FilmeFormValues formValues = new FilmeFormValues();
            formValues.nome = txtNome.Text;
            formValues.duracao = (int)numericUpDownDuracao.Value;
            formValues.categoria = comboBoxCategoria.Text;

            if (cbEstado.SelectedIndex == 0)
                formValues.estado = true;
            else
                formValues.estado = false;

            if (formValues.nome == "" || formValues.duracao == 0 || formValues.categoria == "")
            {
                MessageBox.Show("Por favor preencha todos os campos");
                return default(FilmeFormValues);
            }

            return formValues;
        }
    }
}
