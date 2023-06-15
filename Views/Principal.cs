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
using TopCinema.Controllers;
using TopCinema.Views;

namespace TopCinema
{
    public partial class FormPrincipal : Form
    {
        static int TOLERANCIA = 15; // 15 minutos de tolerancia

        private Timer _timer;
        private string _funcionario;

        public FormPrincipal()
        {
            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += UpdateLabelTime;
            _timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!CinemaController.CinemaExists())
            {
                MessageBox.Show("Nenhum cinema encontrado.", "Por favor configure o cinema.");
                Cinema formCinema = new Cinema();
                formCinema.Show();
            }
            else
            {
                PreencherInformacoes();
            }
        }

        private void UpdateLabelTime(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void MostrarSessoes()
        {
            var sessoes = SessaoController.GetSessoes();
            flowLayoutPanel1.Controls.Clear();

            foreach (var sessao in sessoes)
            {
                if (sessao.HoraInicio.AddMinutes(TOLERANCIA) < DateTime.Now) continue;

                if (sessao.Filme.Ativo)
                {
                    CardSessao cardSessao = new CardSessao();
                    cardSessao.Nome = sessao.Filme.Nome;
                    cardSessao.Horario = sessao.HoraInicio.ToString();
                    cardSessao.Sala = sessao.Sala.Nome;

                    cardSessao.Click += (s, e) =>
                    {
                        new Atendimento(sessao, _funcionario).Show();
                    };

                    flowLayoutPanel1.Controls.Add(cardSessao);
                }
            }
        }

        private void btnFilmes_Click(object sender, EventArgs e)
        {
            new Filmes().Show();
        }

        private void btnCinema_Click(object sender, EventArgs e)
        {
            new Cinema().Show();
        }

        private void btnSessoes_Click(object sender, EventArgs e)
        {
            new FormSessoes().Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new Clientes().Show(); 
        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            new Funcionarios().Show();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            PreencherInformacoes();
        }

        private void PreencherInformacoes()
        {
            var cinema = CinemaController.GetCinema();
            labelName.Text = "Cinema: " + cinema.Name;

            var funcionarios = FuncionarioController.GetFuncionarios();
            comboBoxFuncionario.DataSource = funcionarios;
            comboBoxFuncionario.DisplayMember = "Nome";

            MostrarSessoes();
        }

        private void comboBoxFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {
            _funcionario = comboBoxFuncionario.Text;
        }
    }
}
