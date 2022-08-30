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
    public partial class Frm_Login : Form
    {
        public string pswd;
        public string login;
        public Frm_Login()
        {
            InitializeComponent();
            Lbl_Login.Text = "Usuário";
            Lbl_Password.Text = "Senha";
            Btn_Ok.Text = "Confirmar";
            Btn_Cancel.Text = "Cancelar";
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            pswd = Txt_Password.Text;

            DialogResult = DialogResult.OK;

            pswd = Txt_Password.Text;
            login = Txt_Login.Text; 

            this.Close();

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();

        }




    }
}