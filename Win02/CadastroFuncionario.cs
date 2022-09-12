using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win02.Modelo;
using Win02.Banco;

namespace Win02
{
    public partial class CadastroFuncionario : Form
    {
        private TelaPrincipal telaPrincipal;
        private Funcionario func;
        public CadastroFuncionario(TelaPrincipal tela)
        {
            telaPrincipal = tela;
            InitializeComponent();
        }
        public CadastroFuncionario(TelaPrincipal tela,int Id)
        {
            telaPrincipal = tela;
            InitializeComponent();

            func = FuncionarioDataAcsess.PegarFuncionario(Id);
            FuncionarioParaTela(func);
        }
        private void FuncionarioParaTela(Funcionario funcionario)
        {


            txtNome.Text = funcionario.Nome.Trim();

            txtEmail.Text = funcionario.Email.Trim();

            txtSalario.Text = funcionario.Salario.ToString();

            if (funcionario.Sexo == "M")
            { rbMasculino.Checked = true; }
            else
            { rbFeminino.Checked = true; };

            if (funcionario.TipoContrato == "CLT")
            { rbCLT.Checked = true; }
            else if (funcionario.TipoContrato == "Pj") { rbPJ.Checked = true; } else { rbAutonomo.Checked = true; };
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SalvarAction(object sender, EventArgs e)
        {
            Funcionario funcionario;
            if (func != null)
            {
                //Atualizacao
                funcionario = func;
                funcionario.DataAtualizacao = DateTime.Now;
            }
            else
            {
                //Cadastro Novo
                funcionario = new Funcionario();
                funcionario.DataCadastra = DateTime.Now;
            }

            //  Mover dados para classe funcionario

            funcionario.Nome = txtNome.Text.Trim();

            funcionario.Email = txtEmail.Text.Trim();

            funcionario.Salario = decimal.Parse(txtSalario.Text);

            funcionario.Sexo = (rbMasculino.Checked) ? "M" : "F";

            funcionario.TipoContrato = (rbCLT.Checked) ? "CLT" : (rbPJ.Checked) ? "PJ" : "AUT";

            funcionario.DataCadastra = DateTime.Now;
            //Validar dados
            List<ValidationResult> listErros = new List<ValidationResult>();
            ValidationContext contexto = new ValidationContext(funcionario);
            bool validado = Validator.TryValidateObject(funcionario, contexto, listErros, true);
            if (validado)
            {
                //Salvar dados

                //Fechar e atualizar a tela principal 
                bool resultado;
                if (func !=null)
                {
                    //Atualizar
                    resultado = FuncionarioDataAcsess.AtualizarFuncionario(funcionario);
                }
                else
                {
                    resultado = FuncionarioDataAcsess.SalvarFuncionario(funcionario);
                }
                if (resultado)
                {
                    //Sucesso
                    telaPrincipal.AtualizarTabela();
                    this.Close();
                }
                else
                {
                    //Erro
                    lblErro.Text = "Erro no Banco";
                }
            }
            else
            {
                //Validacao Erro
                StringBuilder sb = new StringBuilder();
                foreach(ValidationResult erro in listErros)
                {
                    sb.Append(erro.ErrorMessage + "\n");
                }
                lblErro.Text=sb.ToString();
            }




        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
