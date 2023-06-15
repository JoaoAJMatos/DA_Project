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
    public struct FuncionarioFormValues
    {
        public string nome;
        public string morada;
        public float salario;
        public string funcao;
    }

    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            MostrarFuncionarios();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FuncionarioFormValues formValues = ValidateAndExtractFormValues();

            if (formValues.Equals(default(FuncionarioFormValues))) return;

            FuncionarioController.AddFuncionario(formValues.nome, formValues.morada, formValues.salario, formValues.funcao);
            MostrarFuncionarios();  
        }

        private void MostrarFuncionarios()
        {
            var funcionarios = FuncionarioController.GetFuncionarios();
            lbFuncionarios.DataSource = funcionarios;
            lbFuncionarios.DisplayMember = "Nome";
            lbFuncionarios.SelectedIndex = -1;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            FuncionarioModel funcionario = (FuncionarioModel)lbFuncionarios.SelectedItem;
            
            FuncionarioController.RemoveFuncionario(funcionario.Id);
            MostrarFuncionarios();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FuncionarioModel funcionario = (FuncionarioModel)lbFuncionarios.SelectedItem;

            FuncionarioFormValues formValues = ValidateAndExtractFormValues();
            if (formValues.Equals(default(FuncionarioFormValues))) return;

            FuncionarioController.AlterarFuncionario(funcionario.Id, formValues.nome, formValues.morada, formValues.salario, formValues.funcao);
            MostrarFuncionarios();
        }

        public FuncionarioFormValues ValidateAndExtractFormValues()
        {
            FuncionarioFormValues formValues = new FuncionarioFormValues();

            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return default(FuncionarioFormValues);
            }
            else
            {
                formValues.nome = txtNome.Text;
            }

            if (txtMorada.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return default(FuncionarioFormValues);
            }
            else
            {
                formValues.morada = txtMorada.Text;
            }

            if (txtSalario.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return default(FuncionarioFormValues);
            }
            else
            {
                float valor = float.Parse(txtSalario.Text);
                if (valor < 0)
                {
                    MessageBox.Show("O salario nao pode ser negativo");
                    return default(FuncionarioFormValues);
                }
                else
                {
                    formValues.salario = valor;
                }
            }

            if (txtfuncao.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return default(FuncionarioFormValues);
            }
            else
            {
                formValues.funcao = txtfuncao.Text;
            }

            return formValues;
        }

        private void lbFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFuncionarios.SelectedIndex == -1)
            {
                txtNome.Text = "";
                txtfuncao.Text = "";
                txtSalario.Text = "";
                txtMorada.Text = "";
                btnApagar.Enabled = false;
                btnSalvar.Enabled = false;
            }
            else
            {
                FuncionarioModel funcionario = (FuncionarioModel)lbFuncionarios.SelectedItem;
                txtNome.Text = funcionario.Nome;
                txtfuncao.Text = funcionario.Funcao;
                txtSalario.Text = funcionario.Salario.ToString();
                txtMorada.Text = funcionario.Morada;

                btnApagar.Enabled = true;
                btnSalvar.Enabled = true;
            }
        }
    }
}
