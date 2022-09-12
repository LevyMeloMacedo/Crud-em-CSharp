namespace Win02
{
    partial class CadastroFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.rbPJ = new System.Windows.Forms.RadioButton();
            this.rbAutonomo = new System.Windows.Forms.RadioButton();
            this.rbCLT = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(195, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 69);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(11, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 121);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(14, 137);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 5;
            this.txtSalario.Text = "0,00";
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(244, 221);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(26, 13);
            this.lblErro.TabIndex = 8;
            this.lblErro.Text = "Erro";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 273);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.SalvarAction);
            // 
            // rbPJ
            // 
            this.rbPJ.AutoSize = true;
            this.rbPJ.Location = new System.Drawing.Point(91, 19);
            this.rbPJ.Name = "rbPJ";
            this.rbPJ.Size = new System.Drawing.Size(37, 17);
            this.rbPJ.TabIndex = 10;
            this.rbPJ.Text = "PJ";
            this.rbPJ.UseVisualStyleBackColor = true;
            this.rbPJ.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbAutonomo
            // 
            this.rbAutonomo.AutoSize = true;
            this.rbAutonomo.Location = new System.Drawing.Point(155, 19);
            this.rbAutonomo.Name = "rbAutonomo";
            this.rbAutonomo.Size = new System.Drawing.Size(73, 17);
            this.rbAutonomo.TabIndex = 11;
            this.rbAutonomo.Text = "Autonomo";
            this.rbAutonomo.UseVisualStyleBackColor = true;
            // 
            // rbCLT
            // 
            this.rbCLT.AutoSize = true;
            this.rbCLT.Checked = true;
            this.rbCLT.Location = new System.Drawing.Point(22, 19);
            this.rbCLT.Name = "rbCLT";
            this.rbCLT.Size = new System.Drawing.Size(45, 17);
            this.rbCLT.TabIndex = 12;
            this.rbCLT.TabStop = true;
            this.rbCLT.Text = "CLT";
            this.rbCLT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAutonomo);
            this.groupBox1.Controls.Add(this.rbPJ);
            this.groupBox1.Controls.Add(this.rbCLT);
            this.groupBox1.Location = new System.Drawing.Point(247, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 57);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Contrato:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFeminino);
            this.groupBox2.Controls.Add(this.rbMasculino);
            this.groupBox2.Location = new System.Drawing.Point(247, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 68);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo:";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(127, 30);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 1;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(22, 30);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroFuncionario";
            this.Text = "Cadastro de Funcionario";
            this.Load += new System.EventHandler(this.CadastroFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.RadioButton rbPJ;
        private System.Windows.Forms.RadioButton rbAutonomo;
        private System.Windows.Forms.RadioButton rbCLT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
    }
}