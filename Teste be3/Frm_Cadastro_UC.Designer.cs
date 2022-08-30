namespace Teste_be3
{
    partial class Frm_Cadastro_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro_UC));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Grb_Convenio = new System.Windows.Forms.GroupBox();
            this.Mtb_Validade = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Validade = new System.Windows.Forms.Label();
            this.Txt_carterinha = new System.Windows.Forms.TextBox();
            this.Lbl_carterinha = new System.Windows.Forms.Label();
            this.Txt_Convenio = new System.Windows.Forms.TextBox();
            this.Lbl_Convenio = new System.Windows.Forms.Label();
            this.Grb_Dados = new System.Windows.Forms.GroupBox();
            this.Mtb_RG = new System.Windows.Forms.MaskedTextBox();
            this.Mtb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Mtb_Tel = new System.Windows.Forms.MaskedTextBox();
            this.Mtb_Cel = new System.Windows.Forms.MaskedTextBox();
            this.Mtb_Nasc = new System.Windows.Forms.MaskedTextBox();
            this.Cmb_UF = new System.Windows.Forms.ComboBox();
            this.Lbl_Tel = new System.Windows.Forms.Label();
            this.Lbl_Cel = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Lbl_UF = new System.Windows.Forms.Label();
            this.Lbl_RG = new System.Windows.Forms.Label();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Cmb_Genero = new System.Windows.Forms.ComboBox();
            this.Lbl_Genero = new System.Windows.Forms.Label();
            this.Lbl_Nasc = new System.Windows.Forms.Label();
            this.Txt_Sobrenome = new System.Windows.Forms.TextBox();
            this.Lbl_Sobrenome = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Grb_Prontuario = new System.Windows.Forms.GroupBox();
            this.Txt_prontuario = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.Grb_Convenio.SuspendLayout();
            this.Grb_Dados.SuspendLayout();
            this.Grb_Prontuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.abrirToolStripButton,
            this.salvarToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(629, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.novoToolStripButton.Text = "&Novo";
            this.novoToolStripButton.Click += new System.EventHandler(this.novoToolStripButton_Click_1);
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStripButton.Text = "&Abrir";
            this.abrirToolStripButton.Click += new System.EventHandler(this.AbrirToolStripButton_Click_1);
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // Grb_Convenio
            // 
            this.Grb_Convenio.Controls.Add(this.Mtb_Validade);
            this.Grb_Convenio.Controls.Add(this.Lbl_Validade);
            this.Grb_Convenio.Controls.Add(this.Txt_carterinha);
            this.Grb_Convenio.Controls.Add(this.Lbl_carterinha);
            this.Grb_Convenio.Controls.Add(this.Txt_Convenio);
            this.Grb_Convenio.Controls.Add(this.Lbl_Convenio);
            this.Grb_Convenio.Location = new System.Drawing.Point(53, 319);
            this.Grb_Convenio.Name = "Grb_Convenio";
            this.Grb_Convenio.Size = new System.Drawing.Size(478, 69);
            this.Grb_Convenio.TabIndex = 6;
            this.Grb_Convenio.TabStop = false;
            this.Grb_Convenio.Text = "Dados Covenio";
            // 
            // Mtb_Validade
            // 
            this.Mtb_Validade.Location = new System.Drawing.Point(369, 36);
            this.Mtb_Validade.Mask = "00/00";
            this.Mtb_Validade.Name = "Mtb_Validade";
            this.Mtb_Validade.Size = new System.Drawing.Size(100, 20);
            this.Mtb_Validade.TabIndex = 26;
            // 
            // Lbl_Validade
            // 
            this.Lbl_Validade.AutoSize = true;
            this.Lbl_Validade.Location = new System.Drawing.Point(366, 20);
            this.Lbl_Validade.Name = "Lbl_Validade";
            this.Lbl_Validade.Size = new System.Drawing.Size(113, 13);
            this.Lbl_Validade.TabIndex = 6;
            this.Lbl_Validade.Text = "Validade da carterinha";
            // 
            // Txt_carterinha
            // 
            this.Txt_carterinha.Location = new System.Drawing.Point(192, 36);
            this.Txt_carterinha.Name = "Txt_carterinha";
            this.Txt_carterinha.Size = new System.Drawing.Size(100, 20);
            this.Txt_carterinha.TabIndex = 5;
            // 
            // Lbl_carterinha
            // 
            this.Lbl_carterinha.AutoSize = true;
            this.Lbl_carterinha.Location = new System.Drawing.Point(192, 20);
            this.Lbl_carterinha.Name = "Lbl_carterinha";
            this.Lbl_carterinha.Size = new System.Drawing.Size(101, 13);
            this.Lbl_carterinha.TabIndex = 4;
            this.Lbl_carterinha.Text = "carterinha convenio";
            // 
            // Txt_Convenio
            // 
            this.Txt_Convenio.Location = new System.Drawing.Point(10, 36);
            this.Txt_Convenio.Name = "Txt_Convenio";
            this.Txt_Convenio.Size = new System.Drawing.Size(100, 20);
            this.Txt_Convenio.TabIndex = 3;
            // 
            // Lbl_Convenio
            // 
            this.Lbl_Convenio.AutoSize = true;
            this.Lbl_Convenio.Location = new System.Drawing.Point(10, 20);
            this.Lbl_Convenio.Name = "Lbl_Convenio";
            this.Lbl_Convenio.Size = new System.Drawing.Size(51, 13);
            this.Lbl_Convenio.TabIndex = 2;
            this.Lbl_Convenio.Text = "convenio";
            // 
            // Grb_Dados
            // 
            this.Grb_Dados.Controls.Add(this.Mtb_RG);
            this.Grb_Dados.Controls.Add(this.Mtb_CPF);
            this.Grb_Dados.Controls.Add(this.Mtb_Tel);
            this.Grb_Dados.Controls.Add(this.Mtb_Cel);
            this.Grb_Dados.Controls.Add(this.Mtb_Nasc);
            this.Grb_Dados.Controls.Add(this.Cmb_UF);
            this.Grb_Dados.Controls.Add(this.Lbl_Tel);
            this.Grb_Dados.Controls.Add(this.Lbl_Cel);
            this.Grb_Dados.Controls.Add(this.Txt_Email);
            this.Grb_Dados.Controls.Add(this.Lbl_Email);
            this.Grb_Dados.Controls.Add(this.Lbl_UF);
            this.Grb_Dados.Controls.Add(this.Lbl_RG);
            this.Grb_Dados.Controls.Add(this.Lbl_CPF);
            this.Grb_Dados.Controls.Add(this.Cmb_Genero);
            this.Grb_Dados.Controls.Add(this.Lbl_Genero);
            this.Grb_Dados.Controls.Add(this.Lbl_Nasc);
            this.Grb_Dados.Controls.Add(this.Txt_Sobrenome);
            this.Grb_Dados.Controls.Add(this.Lbl_Sobrenome);
            this.Grb_Dados.Controls.Add(this.Txt_Nome);
            this.Grb_Dados.Controls.Add(this.Lbl_Nome);
            this.Grb_Dados.Location = new System.Drawing.Point(53, 87);
            this.Grb_Dados.Name = "Grb_Dados";
            this.Grb_Dados.Size = new System.Drawing.Size(478, 215);
            this.Grb_Dados.TabIndex = 5;
            this.Grb_Dados.TabStop = false;
            this.Grb_Dados.Text = "Dados Pessoais";
            this.Grb_Dados.Enter += new System.EventHandler(this.Grb_Dados_Enter);
            // 
            // Mtb_RG
            // 
            this.Mtb_RG.Location = new System.Drawing.Point(189, 86);
            this.Mtb_RG.Mask = "00.000.000-0";
            this.Mtb_RG.Name = "Mtb_RG";
            this.Mtb_RG.Size = new System.Drawing.Size(100, 20);
            this.Mtb_RG.TabIndex = 25;
            // 
            // Mtb_CPF
            // 
            this.Mtb_CPF.Location = new System.Drawing.Point(189, 36);
            this.Mtb_CPF.Mask = "000.000.000-00";
            this.Mtb_CPF.Name = "Mtb_CPF";
            this.Mtb_CPF.Size = new System.Drawing.Size(100, 20);
            this.Mtb_CPF.TabIndex = 24;
            // 
            // Mtb_Tel
            // 
            this.Mtb_Tel.Location = new System.Drawing.Point(372, 136);
            this.Mtb_Tel.Mask = "(999) 000-0000";
            this.Mtb_Tel.Name = "Mtb_Tel";
            this.Mtb_Tel.Size = new System.Drawing.Size(100, 20);
            this.Mtb_Tel.TabIndex = 23;
            // 
            // Mtb_Cel
            // 
            this.Mtb_Cel.Location = new System.Drawing.Point(372, 86);
            this.Mtb_Cel.Mask = "(999) 000-0000";
            this.Mtb_Cel.Name = "Mtb_Cel";
            this.Mtb_Cel.Size = new System.Drawing.Size(100, 20);
            this.Mtb_Cel.TabIndex = 22;
            // 
            // Mtb_Nasc
            // 
            this.Mtb_Nasc.Location = new System.Drawing.Point(10, 136);
            this.Mtb_Nasc.Mask = "00/00/0000";
            this.Mtb_Nasc.Name = "Mtb_Nasc";
            this.Mtb_Nasc.Size = new System.Drawing.Size(100, 20);
            this.Mtb_Nasc.TabIndex = 21;
            this.Mtb_Nasc.ValidatingType = typeof(System.DateTime);
            // 
            // Cmb_UF
            // 
            this.Cmb_UF.FormattingEnabled = true;
            this.Cmb_UF.Location = new System.Drawing.Point(189, 135);
            this.Cmb_UF.Name = "Cmb_UF";
            this.Cmb_UF.Size = new System.Drawing.Size(100, 21);
            this.Cmb_UF.TabIndex = 20;
            // 
            // Lbl_Tel
            // 
            this.Lbl_Tel.AutoSize = true;
            this.Lbl_Tel.Location = new System.Drawing.Point(372, 119);
            this.Lbl_Tel.Name = "Lbl_Tel";
            this.Lbl_Tel.Size = new System.Drawing.Size(71, 13);
            this.Lbl_Tel.TabIndex = 18;
            this.Lbl_Tel.Text = "Telefone Fixo";
            // 
            // Lbl_Cel
            // 
            this.Lbl_Cel.AutoSize = true;
            this.Lbl_Cel.Location = new System.Drawing.Point(372, 70);
            this.Lbl_Cel.Name = "Lbl_Cel";
            this.Lbl_Cel.Size = new System.Drawing.Size(39, 13);
            this.Lbl_Cel.TabIndex = 16;
            this.Lbl_Cel.Text = "Celular";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(372, 36);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(100, 20);
            this.Txt_Email.TabIndex = 15;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Location = new System.Drawing.Point(372, 20);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Email.TabIndex = 14;
            this.Lbl_Email.Text = "Email";
            // 
            // Lbl_UF
            // 
            this.Lbl_UF.AutoSize = true;
            this.Lbl_UF.Location = new System.Drawing.Point(189, 119);
            this.Lbl_UF.Name = "Lbl_UF";
            this.Lbl_UF.Size = new System.Drawing.Size(55, 13);
            this.Lbl_UF.TabIndex = 12;
            this.Lbl_UF.Text = "UF do RG";
            // 
            // Lbl_RG
            // 
            this.Lbl_RG.AutoSize = true;
            this.Lbl_RG.Location = new System.Drawing.Point(189, 70);
            this.Lbl_RG.Name = "Lbl_RG";
            this.Lbl_RG.Size = new System.Drawing.Size(23, 13);
            this.Lbl_RG.TabIndex = 10;
            this.Lbl_RG.Text = "RG";
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Location = new System.Drawing.Point(189, 20);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(27, 13);
            this.Lbl_CPF.TabIndex = 8;
            this.Lbl_CPF.Text = "CPF";
            // 
            // Cmb_Genero
            // 
            this.Cmb_Genero.FormattingEnabled = true;
            this.Cmb_Genero.Location = new System.Drawing.Point(10, 184);
            this.Cmb_Genero.Name = "Cmb_Genero";
            this.Cmb_Genero.Size = new System.Drawing.Size(100, 21);
            this.Cmb_Genero.TabIndex = 7;
            // 
            // Lbl_Genero
            // 
            this.Lbl_Genero.AutoSize = true;
            this.Lbl_Genero.Location = new System.Drawing.Point(10, 168);
            this.Lbl_Genero.Name = "Lbl_Genero";
            this.Lbl_Genero.Size = new System.Drawing.Size(42, 13);
            this.Lbl_Genero.TabIndex = 6;
            this.Lbl_Genero.Text = "Genero";
            // 
            // Lbl_Nasc
            // 
            this.Lbl_Nasc.AutoSize = true;
            this.Lbl_Nasc.Location = new System.Drawing.Point(10, 119);
            this.Lbl_Nasc.Name = "Lbl_Nasc";
            this.Lbl_Nasc.Size = new System.Drawing.Size(104, 13);
            this.Lbl_Nasc.TabIndex = 4;
            this.Lbl_Nasc.Text = "Data de Nascimento";
            // 
            // Txt_Sobrenome
            // 
            this.Txt_Sobrenome.Location = new System.Drawing.Point(10, 86);
            this.Txt_Sobrenome.Name = "Txt_Sobrenome";
            this.Txt_Sobrenome.Size = new System.Drawing.Size(100, 20);
            this.Txt_Sobrenome.TabIndex = 3;
            // 
            // Lbl_Sobrenome
            // 
            this.Lbl_Sobrenome.AutoSize = true;
            this.Lbl_Sobrenome.Location = new System.Drawing.Point(10, 70);
            this.Lbl_Sobrenome.Name = "Lbl_Sobrenome";
            this.Lbl_Sobrenome.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Sobrenome.TabIndex = 2;
            this.Lbl_Sobrenome.Text = "Sobrenome";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(10, 36);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nome.TabIndex = 1;
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(10, 20);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Nome.TabIndex = 0;
            this.Lbl_Nome.Text = "Nome";
            // 
            // Grb_Prontuario
            // 
            this.Grb_Prontuario.Controls.Add(this.Txt_prontuario);
            this.Grb_Prontuario.Location = new System.Drawing.Point(53, 27);
            this.Grb_Prontuario.Name = "Grb_Prontuario";
            this.Grb_Prontuario.Size = new System.Drawing.Size(183, 54);
            this.Grb_Prontuario.TabIndex = 4;
            this.Grb_Prontuario.TabStop = false;
            this.Grb_Prontuario.Text = "Prontuario";
            // 
            // Txt_prontuario
            // 
            this.Txt_prontuario.Location = new System.Drawing.Point(7, 19);
            this.Txt_prontuario.Name = "Txt_prontuario";
            this.Txt_prontuario.Size = new System.Drawing.Size(170, 20);
            this.Txt_prontuario.TabIndex = 0;
            // 
            // Frm_Cadastro_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Grb_Convenio);
            this.Controls.Add(this.Grb_Dados);
            this.Controls.Add(this.Grb_Prontuario);
            this.Name = "Frm_Cadastro_UC";
            this.Size = new System.Drawing.Size(629, 401);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Grb_Convenio.ResumeLayout(false);
            this.Grb_Convenio.PerformLayout();
            this.Grb_Dados.ResumeLayout(false);
            this.Grb_Dados.PerformLayout();
            this.Grb_Prontuario.ResumeLayout(false);
            this.Grb_Prontuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox Grb_Convenio;
        private System.Windows.Forms.MaskedTextBox Mtb_Validade;
        private System.Windows.Forms.Label Lbl_Validade;
        private System.Windows.Forms.TextBox Txt_carterinha;
        private System.Windows.Forms.Label Lbl_carterinha;
        private System.Windows.Forms.TextBox Txt_Convenio;
        private System.Windows.Forms.Label Lbl_Convenio;
        private System.Windows.Forms.GroupBox Grb_Dados;
        private System.Windows.Forms.MaskedTextBox Mtb_RG;
        private System.Windows.Forms.MaskedTextBox Mtb_CPF;
        private System.Windows.Forms.MaskedTextBox Mtb_Tel;
        private System.Windows.Forms.MaskedTextBox Mtb_Cel;
        private System.Windows.Forms.MaskedTextBox Mtb_Nasc;
        private System.Windows.Forms.ComboBox Cmb_UF;
        private System.Windows.Forms.Label Lbl_Tel;
        private System.Windows.Forms.Label Lbl_Cel;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Label Lbl_UF;
        private System.Windows.Forms.Label Lbl_RG;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.ComboBox Cmb_Genero;
        private System.Windows.Forms.Label Lbl_Genero;
        private System.Windows.Forms.Label Lbl_Nasc;
        private System.Windows.Forms.TextBox Txt_Sobrenome;
        private System.Windows.Forms.Label Lbl_Sobrenome;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.GroupBox Grb_Prontuario;
        private System.Windows.Forms.TextBox Txt_prontuario;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
    }
}
