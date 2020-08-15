namespace PI
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.bt_Logar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.llbl_esq_senha = new System.Windows.Forms.LinkLabel();
            this.txt_senha_cad = new System.Windows.Forms.TextBox();
            this.txt_email_cad = new System.Windows.Forms.TextBox();
            this.ptb_comp = new System.Windows.Forms.PictureBox();
            this.ptb_prop = new System.Windows.Forms.PictureBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.txt_conf_senha_cad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rB_M = new System.Windows.Forms.RadioButton();
            this.rB_F = new System.Windows.Forms.RadioButton();
            this.grB_Sexo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_prop)).BeginInit();
            this.grB_Sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_email.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.Location = new System.Drawing.Point(71, 179);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(230, 22);
            this.txt_email.TabIndex = 1;
            // 
            // bt_Logar
            // 
            this.bt_Logar.BackColor = System.Drawing.Color.DimGray;
            this.bt_Logar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Logar.FlatAppearance.BorderSize = 3;
            this.bt_Logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Logar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Logar.ForeColor = System.Drawing.Color.Transparent;
            this.bt_Logar.Location = new System.Drawing.Point(208, 249);
            this.bt_Logar.Name = "bt_Logar";
            this.bt_Logar.Size = new System.Drawing.Size(93, 31);
            this.bt_Logar.TabIndex = 3;
            this.bt_Logar.Text = "Logar";
            this.bt_Logar.UseVisualStyleBackColor = false;
            this.bt_Logar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_senha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.Color.Black;
            this.txt_senha.Location = new System.Drawing.Point(71, 209);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(230, 22);
            this.txt_senha.TabIndex = 2;
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_sobrenome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sobrenome.ForeColor = System.Drawing.Color.Black;
            this.txt_sobrenome.Location = new System.Drawing.Point(631, 175);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(111, 22);
            this.txt_sobrenome.TabIndex = 6;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_cadastrar.BackColor = System.Drawing.Color.DimGray;
            this.bt_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_cadastrar.FlatAppearance.BorderSize = 3;
            this.bt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.ForeColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.Location = new System.Drawing.Point(496, 460);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(132, 35);
            this.bt_cadastrar.TabIndex = 12;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click_1);
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.Black;
            this.txt_nome.Location = new System.Drawing.Point(405, 175);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(113, 22);
            this.txt_nome.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(537, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sobrenome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(350, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(350, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(350, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email:";
            // 
            // llbl_esq_senha
            // 
            this.llbl_esq_senha.AutoSize = true;
            this.llbl_esq_senha.BackColor = System.Drawing.Color.Transparent;
            this.llbl_esq_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_esq_senha.ForeColor = System.Drawing.Color.White;
            this.llbl_esq_senha.Location = new System.Drawing.Point(15, 264);
            this.llbl_esq_senha.Name = "llbl_esq_senha";
            this.llbl_esq_senha.Size = new System.Drawing.Size(123, 16);
            this.llbl_esq_senha.TabIndex = 4;
            this.llbl_esq_senha.TabStop = true;
            this.llbl_esq_senha.Text = "Esqueci a senha";
            this.llbl_esq_senha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_esq_senha_LinkClicked);
            // 
            // txt_senha_cad
            // 
            this.txt_senha_cad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_senha_cad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha_cad.ForeColor = System.Drawing.Color.Black;
            this.txt_senha_cad.Location = new System.Drawing.Point(475, 322);
            this.txt_senha_cad.Name = "txt_senha_cad";
            this.txt_senha_cad.PasswordChar = '*';
            this.txt_senha_cad.Size = new System.Drawing.Size(267, 22);
            this.txt_senha_cad.TabIndex = 10;
            // 
            // txt_email_cad
            // 
            this.txt_email_cad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_email_cad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_cad.ForeColor = System.Drawing.Color.Black;
            this.txt_email_cad.Location = new System.Drawing.Point(475, 276);
            this.txt_email_cad.Name = "txt_email_cad";
            this.txt_email_cad.Size = new System.Drawing.Size(267, 22);
            this.txt_email_cad.TabIndex = 9;
            // 
            // ptb_comp
            // 
            this.ptb_comp.Location = new System.Drawing.Point(-3, -4);
            this.ptb_comp.Name = "ptb_comp";
            this.ptb_comp.Size = new System.Drawing.Size(774, 140);
            this.ptb_comp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_comp.TabIndex = 15;
            this.ptb_comp.TabStop = false;
            // 
            // ptb_prop
            // 
            this.ptb_prop.Location = new System.Drawing.Point(9, 322);
            this.ptb_prop.Name = "ptb_prop";
            this.ptb_prop.Size = new System.Drawing.Size(292, 182);
            this.ptb_prop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_prop.TabIndex = 16;
            this.ptb_prop.TabStop = false;
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.DimGray;
            this.bt_sair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_sair.FlatAppearance.BorderSize = 3;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.Transparent;
            this.bt_sair.Location = new System.Drawing.Point(650, 460);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(92, 35);
            this.bt_sair.TabIndex = 13;
            this.bt_sair.Text = "Voltar";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // txt_conf_senha_cad
            // 
            this.txt_conf_senha_cad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_conf_senha_cad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conf_senha_cad.ForeColor = System.Drawing.Color.Black;
            this.txt_conf_senha_cad.Location = new System.Drawing.Point(475, 363);
            this.txt_conf_senha_cad.Name = "txt_conf_senha_cad";
            this.txt_conf_senha_cad.PasswordChar = '*';
            this.txt_conf_senha_cad.Size = new System.Drawing.Size(267, 22);
            this.txt_conf_senha_cad.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(350, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Confirmar senha:";
            // 
            // rB_M
            // 
            this.rB_M.AutoSize = true;
            this.rB_M.Location = new System.Drawing.Point(78, 14);
            this.rB_M.Name = "rB_M";
            this.rB_M.Size = new System.Drawing.Size(90, 20);
            this.rB_M.TabIndex = 7;
            this.rB_M.TabStop = true;
            this.rB_M.Text = "Masculino";
            this.rB_M.UseVisualStyleBackColor = true;
            // 
            // rB_F
            // 
            this.rB_F.AutoSize = true;
            this.rB_F.Location = new System.Drawing.Point(237, 14);
            this.rB_F.Name = "rB_F";
            this.rB_F.Size = new System.Drawing.Size(86, 20);
            this.rB_F.TabIndex = 8;
            this.rB_F.TabStop = true;
            this.rB_F.Text = "Feminino";
            this.rB_F.UseVisualStyleBackColor = true;
            // 
            // grB_Sexo
            // 
            this.grB_Sexo.BackColor = System.Drawing.Color.Transparent;
            this.grB_Sexo.Controls.Add(this.rB_F);
            this.grB_Sexo.Controls.Add(this.rB_M);
            this.grB_Sexo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grB_Sexo.ForeColor = System.Drawing.Color.Black;
            this.grB_Sexo.Location = new System.Drawing.Point(350, 212);
            this.grB_Sexo.Name = "grB_Sexo";
            this.grB_Sexo.Size = new System.Drawing.Size(392, 40);
            this.grB_Sexo.TabIndex = 23;
            this.grB_Sexo.TabStop = false;
            this.grB_Sexo.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(350, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(400, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ao clicar em Cadastre-se, você concorda com nossos Termos, Política de Dados ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 516);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grB_Sexo);
            this.Controls.Add(this.txt_sobrenome);
            this.Controls.Add(this.txt_conf_senha_cad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.ptb_prop);
            this.Controls.Add(this.ptb_comp);
            this.Controls.Add(this.txt_email_cad);
            this.Controls.Add(this.txt_senha_cad);
            this.Controls.Add(this.llbl_esq_senha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.bt_Logar);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_prop)).EndInit();
            this.grB_Sexo.ResumeLayout(false);
            this.grB_Sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button bt_Logar;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel llbl_esq_senha;
        private System.Windows.Forms.TextBox txt_senha_cad;
        private System.Windows.Forms.TextBox txt_email_cad;
        private System.Windows.Forms.PictureBox ptb_comp;
        private System.Windows.Forms.PictureBox ptb_prop;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.TextBox txt_conf_senha_cad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rB_M;
        private System.Windows.Forms.RadioButton rB_F;
        private System.Windows.Forms.GroupBox grB_Sexo;
        private System.Windows.Forms.Label label8;
    }
}