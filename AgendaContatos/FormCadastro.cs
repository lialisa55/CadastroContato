using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContatos
{
    public partial class FormCadastro : Form
    {
        public string operacao = "";
        Contato cont = new Contato();
        Controle controle = new Controle();

        private void limpar()
        {
            txtCelular.Clear();
            txtCodigo.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
        }
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O cadastro precisa de um nome.");
            }

            else
            {
                cont.Nome = txtNome.Text;
                cont.Telefone = txtTelefone.Text;
                cont.Email = txtEmail.Text;
                cont.Celular = txtCelular.Text;

                MessageBox.Show(controle.Cadastrar(cont));
                limpar();
            }
        }
    }
}
