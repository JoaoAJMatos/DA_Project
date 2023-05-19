using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TopCinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }
        
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Views.Atendimento().Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void ShowSessions()
        {
            ListSessoes[] listSessoes = new ListSessoes[10];
            
            for (int i = 0; i < listSessoes.Length; i++)
            {
                listSessoes[i] = new ListSessoes();

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(listSessoes[i]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowSessions();
        }
    }
}
