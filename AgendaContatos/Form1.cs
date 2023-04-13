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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MessageBox.Show(conexao.conectar());
        }
    }
}
