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
    public partial class ListSessoes : UserControl
    {
        public ListSessoes()
        {
            InitializeComponent();
        }

        #region Properties

        private string _movieName;
        private string _horario;
        private Image _movieImage;

        [Category("Custom Props")]
        public string MovieName
        {
            get { return _movieName; }
            set { _movieName = value; lbMovieName.Text = value; }
        }

        [Category("Custom Props")]
        public string Horario
        {
            get { return _horario; }
            set { _horario = value; lbHorario.Text = value; }
        }

        [Category("Custom Props")]
        public Image MovieImage
        {
            get { return _movieImage; }
            set { _movieImage = value; ptMovieImage.Image = value; }
        }

        #endregion
    }
}
