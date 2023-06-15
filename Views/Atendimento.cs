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
    internal partial class Atendimento : Form
    {
        private SessaoModel _sessao;
        private string _funcionario;
        private List<Button> _lugaresSelecionados = new List<Button>();

        public Atendimento(SessaoModel sessao, string funcionario)
        {
            this._sessao = sessao;
            this._funcionario = funcionario;

            InitializeComponent();
        }

        private void Atendimento_Load(object sender, EventArgs e)
        {
            List<int> filasColunas = SalaController.GetSalaFilasColunas(_sessao.Sala.Nome);
            int filas = filasColunas[0];
            int colunas = filasColunas[1];

            CriarButoesLugares(filas, colunas);

            labelNomeFilme.Text = "Filme: " + _sessao.Filme.Nome;
            labelSala.Text = "Sala: " + _sessao.Sala.Nome;
            labelDataHora.Text = "Inicio: " + _sessao.HoraInicio.ToString("dd/MM/yyyy HH:mm");
            labelDuracao.Text = "Duracao: " + _sessao.Filme.Duracao.ToString() + " minutos";
            labelLugaresLivres.Text = "Lugares livres: " + SessaoController.GetLugaresLivres(_sessao).ToString();
        }

        public void CriarButoesLugares(int filas, int colunas)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            var bilhetesSessao = SessaoController.GetBilhetesSessao(_sessao.Id);

            for (int i = 0; i < filas; i++)
            {
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.AutoSize = true;
                flowLayoutPanel.Margin = new Padding(0, 0, 0, 0);
                flowLayoutPanel.Padding = new Padding(0, 0, 0, 0);

                for (int j = 0; j < colunas; j++)
                {
                    Button btn = new Button();
                    btn.Text = (i + 1) + "-" + (j + 1);
                    btn.Tag = new int[] { i + 1, j + 1 };
                    btn.Margin = new Padding(0, 0, 0, 0);
                    btn.Padding = new Padding(0, 0, 0, 0);
                    btn.Width = 50;
                    btn.Height = 50;

                    if (bilhetesSessao.Where(b => b.Fila == (i + 1) && b.Coluna == (j + 1)).Count() > 0)
                    {
                        btn.BackColor = Color.Gray;
                        btn.ForeColor = Color.Black;
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.BackColor = Color.Green;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 0);
                        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 255, 0);
                        btn.Click += new EventHandler(btn_Click);
                    }

                    flowLayoutPanel.Controls.Add(btn);
                }

                flowLayoutPanel1.Controls.Add(flowLayoutPanel);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int[] posicao = (int[])btn.Tag;
            int fila = posicao[0];
            int coluna = posicao[1];

            if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.Black;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 0, 0);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 0, 0);

                _lugaresSelecionados.Add(btn);
            }
            else
            {
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 0);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 255, 0);

                _lugaresSelecionados.Remove(btn);
            }

            labelLugaresLivres.Text = "Lugares livres: " + (SessaoController.GetLugaresLivres(_sessao) - _lugaresSelecionados.Count).ToString();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            string NIF = textBoxPesquisa.Text;

            try
            {
                ClienteModel cliente = ClienteController.GetClientePorNIF(NIF);

                if (cliente != null)
                {
                    txtNome.Text = cliente.Nome;
                    txtNIF.Text = cliente.Nif.ToString();
                    txtMorada.Text = cliente.Morada;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente não encontrado");
            }
        }

        private void btnEmitirBilhetes_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string NIF = txtNIF.Text;
            string morada = txtMorada.Text;
            bool registarCliente = checkBoxRegistarCliente.Checked;

            int nif = 0;

            if (nome == "" || NIF == "" || morada == "")
            {
                MessageBox.Show("Preencha todos os campos do cliente");
                return;
            }

            if (NIF.Length != 9 || !int.TryParse(NIF, out nif))
            {
                MessageBox.Show("NIF invalido.");
                return;
            }

            if (!ClienteModel.NifValido(nif))
            {
                MessageBox.Show("NIF invalido.");
                return;
            }

            if (registarCliente)
            {
                try
                {
                    ClienteController.AddCliente(nome, morada, nif);
                }
                catch
                {
                    MessageBox.Show("O cliente ja se encontra registado");
                }
            }

            try
            {
                if (_lugaresSelecionados.Count > 0)
                {
                    foreach (Button btn in _lugaresSelecionados)
                    {
                        int[] posicao = (int[])btn.Tag;
                        int fila = posicao[0];
                        int coluna = posicao[1];

                        SessaoController.AdicionarReserva(_sessao.Id, _funcionario, nif, fila, coluna);
                        try
                        {
                            SessaoController.EmitirRecibo(_sessao.Id, nif, fila, coluna, _funcionario);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    MessageBox.Show("Bilhetes emitidos com sucesso");
                }
                else
                {
                    MessageBox.Show("Selecione um lugar");
                }

                _lugaresSelecionados.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Give more context to the exception
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonVerBilhetes_Click(object sender, EventArgs e)
        {
            Bilhetes bilhetesForm = new Bilhetes(_sessao);
            bilhetesForm.Show();
        }
    }
}
