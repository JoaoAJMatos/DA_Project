using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopCinema.Views
{
    public partial class Atendimento : Form
    {
        public Atendimento()
        {
            InitializeComponent();
        }

        private void Atendimento_Load(object sender, EventArgs e)
        {
            ButtonArray();
        }

        public void ButtonArray()
        {
            List<Button> myButtons = new List<Button>();
            for (int i = 0; i < 30; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(25,25);
                btn.BackColor = Color.LawnGreen;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
    }
}
