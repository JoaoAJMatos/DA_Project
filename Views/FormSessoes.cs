using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopCinema.Models;

namespace TopCinema.Views
{
    public struct SessaoFormValues
    {
        public string filme;
        public string sala;
        public DateTime data;
        public float preco;
    }

    public partial class FormSessoes : Form
    {
        public FormSessoes()
        {
            InitializeComponent();
        }

        private void FormSessoes_Load(object sender, EventArgs e)
        {
            var filmes = Controllers.FilmeController.GetFilmes();
            var salas = Controllers.SalaController.GetSalas();

            comboBoxFilme.DataSource = filmes;
            comboBoxFilme.DisplayMember = "Nome";
            comboBoxFilme.SelectedIndex = -1;

            comboBoxSala.DataSource = salas;
            comboBoxSala.DisplayMember = "Nome";
            comboBoxFilme.SelectedIndex = -1;

            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.ShowUpDown = true;

            MostrarSessoes();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            SessaoFormValues formValues = ValidateAndExtractFormValues();

            if (formValues.Equals(default(SessaoFormValues))) return;

            try
            {
                Controllers.SessaoController.AddSessao(formValues.data, formValues.preco, formValues.sala, formValues.filme);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            MostrarSessoes();
        }

        private SessaoFormValues ValidateAndExtractFormValues()
        {
            DateTime data = dateTimePickerData.Value.Date + dateTimePickerHora.Value.TimeOfDay;
            float preco = 0;

            if (string.IsNullOrWhiteSpace(comboBoxFilme.Text))
            {
                MessageBox.Show("O campo 'Filme' é obrigatório.");
                return default(SessaoFormValues);
            }

            if (string.IsNullOrWhiteSpace(comboBoxSala.Text))
            {
                MessageBox.Show("O campo 'Sala' é obrigatório.");
                return default(SessaoFormValues);
            }

            if (numericUpDownPreco.Value > 0)
            {
                preco = (float)numericUpDownPreco.Value;
            }
            else
            {
                MessageBox.Show("O campo 'Preço' é obrigatório.");
                return default(SessaoFormValues);
            }

            return new SessaoFormValues
            {
                filme = comboBoxFilme.Text,
                sala = comboBoxSala.Text,
                data = data,
                preco = preco
            };
        }

        private void MostrarSessoes()
        {
            var sessoes = Controllers.SessaoController.GetSessoes();
            lbSessoes.DataSource = sessoes;
            lbSessoes.DisplayMember = "HoraInicio";
            lbSessoes.SelectedIndex = -1;
        }

        private void lbSessoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSessoes.SelectedIndex == -1)
            {
                dateTimePickerData.Value = DateTime.Now;
                dateTimePickerHora.Value = DateTime.Now;
                numericUpDownPreco.Value = 0;
                comboBoxFilme.SelectedIndex = -1;
                comboBoxSala.SelectedIndex = -1;

                btnApagar.Enabled = false;
                btnSalvar.Enabled = false;
            }
            else
            {
                SessaoModel sessao = (SessaoModel)lbSessoes.SelectedItem;
                dateTimePickerData.Value = sessao.HoraInicio.Date;
                dateTimePickerHora.Value = sessao.HoraInicio;
                numericUpDownPreco.Value = (decimal)sessao.Preco;
                comboBoxFilme.Text = sessao.Filme.Nome;
                comboBoxSala.Text = sessao.Sala.Nome;

                btnApagar.Enabled = true;
                btnSalvar.Enabled = true;
            }
        }
    }
}
