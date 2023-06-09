﻿using System;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("A alteração precisa de um código.");
            }

            else
            {
                cont.CodContato = int.Parse(txtCodigo.Text);
                cont.Nome = txtNome.Text;
                cont.Telefone = txtTelefone.Text;
                cont.Email = txtEmail.Text;
                cont.Celular = txtCelular.Text;

                MessageBox.Show(controle.Alterar(cont));
                limpar();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("A deleção precisa de um código.");
            }
            else
            {
                cont.CodContato = int.Parse(txtCodigo.Text);

                MessageBox.Show(controle.Deletar(cont));
                limpar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cont = controle.buscar(int.Parse(txtCodigo.Text));
                if (cont is null)
                {
                    MessageBox.Show("O registro não foi encontrado");
                    limpar();
                    txtCodigo.Focus();
                }
                else
                {
                    txtCodigo.Text = cont.CodContato.ToString();
                    txtNome.Text = cont.Nome;
                    txtEmail.Text = cont.Email;
                    txtTelefone.Text = cont.Telefone;
                    txtCelular.Text = cont.Celular;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
