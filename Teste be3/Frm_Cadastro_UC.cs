using Bliblioteca;
using Bliblioteca.Classes.Database;
using System;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;


namespace Teste_be3
{
    public partial class Frm_Cadastro_UC : UserControl
    {
        public Frm_Cadastro_UC()
        {
            InitializeComponent();

            Cmb_Genero.Items.Clear();
            Cmb_Genero.Items.Add("Masculino");
            Cmb_Genero.Items.Add("Feminino");
            Cmb_Genero.Items.Add("Outros");

            Cmb_UF.Items.Clear();
            Cmb_UF.Items.Add("AC");
            Cmb_UF.Items.Add("Al");
            Cmb_UF.Items.Add("AP");
            Cmb_UF.Items.Add("AM");
            Cmb_UF.Items.Add("BA");
            Cmb_UF.Items.Add("CE");
            Cmb_UF.Items.Add("DF");
            Cmb_UF.Items.Add("ES");
            Cmb_UF.Items.Add("GO");
            Cmb_UF.Items.Add("MA");
            Cmb_UF.Items.Add("MT");
            Cmb_UF.Items.Add("MG");
            Cmb_UF.Items.Add("PA");
            Cmb_UF.Items.Add("PB");
            Cmb_UF.Items.Add("PR");
            Cmb_UF.Items.Add("PB");
            Cmb_UF.Items.Add("PR");
            Cmb_UF.Items.Add("PE");
            Cmb_UF.Items.Add("PI");
            Cmb_UF.Items.Add("RJ");
            Cmb_UF.Items.Add("RN");
            Cmb_UF.Items.Add("RS");
            Cmb_UF.Items.Add("RO");
            Cmb_UF.Items.Add("RR");
            Cmb_UF.Items.Add("SC");
            Cmb_UF.Items.Add("SP");
            Cmb_UF.Items.Add("SE");
            Cmb_UF.Items.Add("TO");


        }

        private void Grb_Dados_Enter(object sender, EventArgs e)
        {

        } 


       public Paciente.Unit LeituraForm() 
        {
            Paciente.Unit P = new Paciente.Unit();

            P.Prontuario = Txt_prontuario.Text;
            P.Nome = Txt_Nome.Text;
            P.Sobrenome = Txt_Sobrenome.Text;
            P.CPF = Mtb_CPF.Text;
            P.Nascimento = Mtb_Nasc.Text;
            P.RG = Mtb_RG.Text;
            P.Genero = Cmb_Genero.Text;
            P.UF = Cmb_UF.Text;
            P.Email = Txt_Email.Text;
            P.Cel = Mtb_Cel.Text;
            P.Tel = Mtb_Tel.Text;
            P.Convenio = Txt_Convenio.Text;
            P.Carterinha = Txt_carterinha.Text;
            P.Validade = Mtb_Validade.Text;
            return P;
        }

        void EscreveFormulario(Paciente.Unit P)
        {
           

           Txt_prontuario.Text = P.Prontuario ;
           Txt_Nome.Text = P.Nome ;
            Txt_Sobrenome.Text = P.Sobrenome ;
            Mtb_CPF.Text = P.CPF ;
            Mtb_RG.Text = P.RG;
            Cmb_Genero.Text = P.Genero;
            Cmb_UF.Text = P.UF ;
            Txt_Email.Text = P.Email ;
            Mtb_Cel.Text = P.Cel ;
            Mtb_Tel.Text = P.Tel;
            Txt_Convenio.Text = P.Convenio ;
            Txt_carterinha.Text  = P.Carterinha;
            Mtb_Validade.Text = P.Validade;
            Mtb_Nasc.Text = P.Nascimento;
        }


        private void novoToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {

                Paciente.Unit P = new Paciente.Unit();
                P = LeituraForm();
                P.validaClasse();
                string PacienteJson = Paciente.SerialzedClassUnit(P);
                Fichario F = new Fichario("C:\\WindowsForms\\Fichario");
                if (F.status)
                {
                    F.Incluir(P.Prontuario, PacienteJson);
                    if (F.status)
                    {
                        MessageBox.Show(F.mensagem, "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Err: " + F.mensagem, "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Err: "+F.mensagem, "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void AbrirToolStripButton_Click_1(object sender, EventArgs e)


        {
            if (Txt_prontuario.Text == "")
            {
                MessageBox.Show("Prontuario vazio", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Fichario F = new Fichario("C:\\WindowsForms\\Fichario");
                if (F.status)
                {
                    string PacienteJson = F.Buscar(Txt_prontuario.Text);
                    Paciente.Unit P = new Paciente.Unit();

                    P = Paciente.DesSerialzedClassUnit(PacienteJson);
                    EscreveFormulario(P);

                }
                else
                {
                    MessageBox.Show("Err: " + F.mensagem, "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_prontuario.Text == "")
            {
                MessageBox.Show("Prontuario vazio", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {

                    Paciente.Unit P = new Paciente.Unit();
                    P = LeituraForm();
                    P.validaClasse();
                    string PacienteJson = Paciente.SerialzedClassUnit(P);
                    Fichario F = new Fichario("C:\\WindowsForms\\Fichario");
                    if (F.status)
                    {
                        F.Alterar(P.Prontuario, PacienteJson);
                        if (F.status)
                        {
                            MessageBox.Show(F.mensagem, "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Err: " + F.mensagem, "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Err: " + F.mensagem, "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (ValidationException Ex)
                {
                    MessageBox.Show(Ex.Message, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
         
}
