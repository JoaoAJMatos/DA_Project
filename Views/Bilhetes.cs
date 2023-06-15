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
    internal partial class Bilhetes : Form
    {
        private readonly SessaoModel _sessao;

        public Bilhetes(SessaoModel sessao)
        {
            this._sessao = sessao;
            InitializeComponent();
        }

        private void Bilhetes_Load(object sender, EventArgs e)
        {
            var bilhetes = SessaoController.GetBilhetesSessao(_sessao.Id);

            checkedListBoxBilhetes.Items.Clear();
            foreach (var bilhete in bilhetes)
            {
                checkedListBoxBilhetes.Items.Add(bilhete);
            }

            checkedListBoxBilhetes.DisplayMember = "LugarStr";
            checkedListBoxBilhetes.ValueMember = "Id";

            foreach (var bilhete in bilhetes)
            {
                if (bilhete.Usado)
                {
                    checkedListBoxBilhetes.SetItemChecked(checkedListBoxBilhetes.Items.IndexOf(bilhete), true);
                    checkedListBoxBilhetes.SetItemCheckState(checkedListBoxBilhetes.Items.IndexOf(bilhete), CheckState.Indeterminate);
                }
            }
        }

        private void buttonAtivarBilhete_Click(object sender, EventArgs e)
        {
            var idsBilhetes = new List<int>();
            foreach (var item in checkedListBoxBilhetes.CheckedItems)
            {
                var bilhete = (BilheteModel)item;
                idsBilhetes.Add(bilhete.Id);
            }

            foreach (var id in idsBilhetes)
            {
                BilheteController.AtivarBilhete(id);
            }

            MessageBox.Show("Bilhetes ativados com sucesso!");
        }
    }
}
