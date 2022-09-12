using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win02
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {

            InitializeComponent();

            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            dgvTabelaFuncionario.DataSource = Banco.FuncionarioDataAcsess.PegarFuncionarios();
        }
        private void NovoAction(object sender, EventArgs e)
        {
            new CadastroFuncionario(this).Show();
        }

        private void EditarAction(object sender, EventArgs e)
        {
            int id = (int)dgvTabelaFuncionario.SelectedRows[0].Cells[0].Value;
            new CadastroFuncionario(this,id).Show();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ExcluirAction(object sender, EventArgs e)
        {
            int id = (int)dgvTabelaFuncionario.SelectedRows[0].Cells[0].Value;
            Win02.Banco.FuncionarioDataAcsess.ExcluirFuncionario(id);
            AtualizarTabela();
        }
    }
}
