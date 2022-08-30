using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_be3
{
    public partial class Frm_Menu : Form
    {
        public int ControleCadastro { get; private set; }

        public Frm_Menu()
        {
            InitializeComponent();
            conectarToolStripMenuItem.Enabled = true;
            desconectarToolStripMenuItem.Enabled = false;
            fichasToolStripMenuItem.Enabled = false;
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
          
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            {
                conectarToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = true;
                fichasToolStripMenuItem.Enabled = true; 

                string pswd = F.pswd;
                string login = F.login;

                if (Validacao.ValidaSenha(pswd) == true)
                {
                  
                    MessageBox.Show("Bem vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else 
                {
                    MessageBox.Show("Senha errada!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conectarToolStripMenuItem.Enabled = true;
            desconectarToolStripMenuItem.Enabled = false;
            fichasToolStripMenuItem.Enabled = false;
            

        }

        private void prontuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ControleCadastro == 0)
            {
                ControleCadastro += 1;
                Frm_Cadastro_UC UC = new Frm_Cadastro_UC();
                TabPage TB = new TabPage();
                TB.Name = "Pacientes";
                TB.Text = "Pacientes";
                TB.Controls.Add(UC);
                Tbc_abas.TabPages.Add(TB);
            }
            else 
            {
                 MessageBox.Show("Numero maximo de paginas atigindo", "Fichas") ;            
            }
        }

        private void Frm_Menu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
