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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            FormCadastro cadastro = new FormCadastro();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MessageBox.Show(conexao.conectar());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Text = DateTime.Now.ToString();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 sobre = new AboutBox1();
            sobre.Show();
        }
    }
}
