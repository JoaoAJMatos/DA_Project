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

namespace TopCinema.Views
{
    public partial class Estatisticas : Form
    {
        public Estatisticas()
        {
            InitializeComponent();
        }

        private void Estatisticas_Load(object sender, EventArgs e)
        {
            int numeroBilhetesTotal = BilheteController.GetNumeroBilhetesTotal();
            float valorTotal = SessaoController.GetTotalArrecadado();

            labelNumBilhetesTotal.Text = "Numero total de bilhetes vendidos: " + numeroBilhetesTotal.ToString();
            labelTotalValor.Text = "Valor total arrecadado:" + valorTotal.ToString() + "€";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
