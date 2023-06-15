using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TopCinema
{
    public partial class CardSessao : UserControl
    {
        public CardSessao()
        {
            InitializeComponent();
        }

        #region Properties

        private string _nomeFilme;
        private string _horario;
        private string _sala;
        private Image _imagemFilme;

        [Category("Custom Props")]
        public string Nome
        {
            get { return _nomeFilme; }
            set { _nomeFilme = value; lbMovieName.Text = value; }
        }

        [Category("Custom Props")]
        public string Horario
        {
            get { return _horario; }
            set { _horario = value; lbHorario.Text = value; }
        }

        [Category("Custom Props")]
        public Image Imagem
        {
            get { return _imagemFilme; }
            set { _imagemFilme = value; ptMovieImage.Image = value; }
        }

        [Category("Custom Props")]
        public string Sala
        {
            get { return _sala; }
            set { _sala = value; labelSala.Text = value; }
        }

        #endregion

        private void CardSessao_Load(object sender, EventArgs e)
        {

        }
    }
}
