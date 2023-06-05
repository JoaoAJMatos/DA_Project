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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            var clientes = ClienteController.GetClientes();
            lbClientes.DataSource = clientes;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string morada = txtMorada.Text;
            int nif = int.Parse(txtNIF.Text);

            ClienteController.AddCliente(nome, morada, nif);
            mostrarClientes();

        }
        private void mostrarClientes()
        {
            var clientes = ClienteController.GetClientes();
            lbClientes.DataSource = clientes;
        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void txtMorada_TextChanged(object sender, EventArgs e)
        {

        }

        private void Morada_Click(object sender, EventArgs e)
        {

        }

        private void NIF_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ClienteModel cliente = (ClienteModel)lbClientes.SelectedItem;

            ClienteController.RemoveCliente(cliente);
            mostrarClientes();
        }

        private void txtNIF_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClienteModel cliente = (ClienteModel)lbClientes.SelectedItem;
            string nome = txtNome.Text;
            string morada = txtMorada.Text;
            int nif = int.Parse(txtNIF.Text);
            ClienteController.AlterarCliente(cliente, nome,morada,nif);
            mostrarClientes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClienteModel cliente = (ClienteModel)lbClientes.SelectedItem;
            txtNome.Text = cliente.Name;
            txtMorada.Text = cliente.Morada;
            txtNIF.Text = cliente.NumFiscal.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
