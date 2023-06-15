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
    public struct ClienteFormValues
    {
        public string nome;
        public string morada;
        public int nif;
    }

    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClienteFormValues formValues = ValidateAndExtractFormValues();
            if (formValues.Equals(default(ClienteFormValues))) return;

            try
            {
                ClienteController.AddCliente(formValues.nome, formValues.morada, formValues.nif);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            mostrarClientes();
        }

        private void CriarColunasAdicionais()
        {
            DataGridViewTextBoxColumn bilhetesComprados = new DataGridViewTextBoxColumn();
            bilhetesComprados.HeaderText = "Bilhetes Comprados";
            bilhetesComprados.Name = "BilhetesComprados";
            bilhetesComprados.ReadOnly = true;

            DataGridViewTextBoxColumn valorGasto = new DataGridViewTextBoxColumn();
            valorGasto.HeaderText = "Valor Gasto";
            valorGasto.Name = "ValorGasto";
            valorGasto.ReadOnly = true;

            dataGridViewClientes.Columns.Add(bilhetesComprados);
            dataGridViewClientes.Columns.Add(valorGasto);
        }

        private void mostrarClientes()
        {
            var clientes = ClienteController.GetClientes();
           
            dataGridViewClientes.DataSource = clientes;
            dataGridViewClientes.Columns["Id"].Visible = false;
            dataGridViewClientes.Columns["Nome"].HeaderText = "Nome";
            dataGridViewClientes.Columns["Morada"].HeaderText = "Morada";
            dataGridViewClientes.Columns["NIF"].HeaderText = "NIF";

            if (dataGridViewClientes.Columns["BilhetesComprados"] == null || dataGridViewClientes.Columns["ValorGasto"] == null)
            {
                CriarColunasAdicionais();
            }

            foreach (DataGridViewRow row in dataGridViewClientes.Rows)
            {
                ClienteModel cliente = (ClienteModel)row.DataBoundItem;
                row.Cells["BilhetesComprados"].Value = ClienteController.GetBilhetesComprados(cliente.Id);
            }

            foreach (DataGridViewRow row in dataGridViewClientes.Rows)
            {
                ClienteModel cliente = (ClienteModel)row.DataBoundItem;
                row.Cells["ValorGasto"].Value = ClienteController.GetValorGasto(cliente.Id);
            }

            txtNome.Clear();
            txtMorada.Clear();
            txtNIF.Clear();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ClienteModel cliente = (ClienteModel)dataGridViewClientes.CurrentRow.DataBoundItem;

            ClienteController.RemoveCliente(cliente.Id);
            mostrarClientes();
        }

        private void txtNIF_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClienteFormValues formValues = ValidateAndExtractFormValues();
            if (formValues.Equals(default(ClienteFormValues))) return;

            ClienteModel cliente = (ClienteModel)dataGridViewClientes.CurrentRow.DataBoundItem;

            try
            {
                ClienteController.AlterarCliente(cliente.Id, formValues.nome, formValues.morada, formValues.nif);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            mostrarClientes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        public ClienteFormValues ValidateAndExtractFormValues()
        {
            string nome = txtNome.Text;
            string morada = txtMorada.Text;
            string NIF = txtNIF.Text;
            int nif;

            if (nome == "")
            {
                MessageBox.Show("Nome não pode ser vazio");
                return default(ClienteFormValues);
            }

            if (morada == "")
            {
                MessageBox.Show("Morada não pode ser vazia");
                return default(ClienteFormValues);
            }

            if (NIF == "")
            {
                MessageBox.Show("NIF não pode ser vazio");
                return default(ClienteFormValues);
            }

            if (NIF.Length != 9)
            {
                MessageBox.Show("NIF tem de ter 9 digitos");
                return default(ClienteFormValues);
            }

            if (!int.TryParse(NIF, out nif))
            {
                MessageBox.Show("NIF tem de ser um numero");
                return default(ClienteFormValues);
            }

            if (!ClienteModel.NifValido(nif))
            {
                MessageBox.Show("NIF tem de ser valido");
                return default(ClienteFormValues);
            }

            ClienteFormValues valoresForm = new ClienteFormValues();
            valoresForm.nome = nome;
            valoresForm.morada = morada;
            valoresForm.nif = nif;

            return valoresForm;
        }

        private void dataGridViewClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentCell.RowIndex == -1) return;

            ClienteModel cliente = (ClienteModel)dataGridViewClientes.CurrentRow.DataBoundItem;

            txtNome.Text = cliente.Nome;
            txtMorada.Text = cliente.Morada;
            txtNIF.Text = cliente.Nif.ToString();

            btnAlterar.Enabled = true;
            btnApagar.Enabled = true;
        }
    }
}
