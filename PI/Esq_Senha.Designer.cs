namespace PI
{
    partial class Esq_Senha
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
            this.bt_Rec = new System.Windows.Forms.Button();
            this.bt_cad = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_conf_senha = new System.Windows.Forms.TextBox();
            this.lbl_conf_senha = new System.Windows.Forms.Label();
            this.lbl_msg_erro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para recumperar o acesso a sua conta siga os passos abaixo:";
            // 
            // bt_Rec
            // 
            this.bt_Rec.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_Rec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Rec.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Rec.Location = new System.Drawing.Point(16, 123);
            this.bt_Rec.Name = "bt_Rec";
            this.bt_Rec.Size = new System.Drawing.Size(96, 36);
            this.bt_Rec.TabIndex = 4;
            this.bt_Rec.Text = "Recumperar ";
            this.bt_Rec.UseVisualStyleBackColor = false;
            this.bt_Rec.Click += new System.EventHandler(this.bt_Rec_Click);
            // 
            // bt_cad
            // 
            this.bt_cad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_cad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cad.Location = new System.Drawing.Point(254, 351);
            this.bt_cad.Name = "bt_cad";
            this.bt_cad.Size = new System.Drawing.Size(93, 30);
            this.bt_cad.TabIndex = 5;
            this.bt_cad.Text = "Cadastrar";
            this.bt_cad.UseVisualStyleBackColor = false;
            this.bt_cad.Visible = false;
            this.bt_cad.Click += new System.EventHandler(this.bt_cad_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(16, 83);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(331, 22);
            this.txt_email.TabIndex = 6;
            // 
            // txt_cod
            // 
            this.txt_cod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod.Location = new System.Drawing.Point(16, 203);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(142, 22);
            this.txt_cod.TabIndex = 8;
            this.txt_cod.Visible = false;
            this.txt_cod.TextChanged += new System.EventHandler(this.txt_cod_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(426, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Digite o email cadastrado:";
            // 
            // lbl_cod
            // 
            this.lbl_cod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod.Location = new System.Drawing.Point(12, 181);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(276, 19);
            this.lbl_cod.TabIndex = 10;
            this.lbl_cod.Text = "Digite o código enviado para o email:";
            this.lbl_cod.Visible = false;
            // 
            // lbl_senha
            // 
            this.lbl_senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(13, 252);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(173, 19);
            this.lbl_senha.TabIndex = 11;
            this.lbl_senha.Text = "Digite sua nova senha:";
            this.lbl_senha.Visible = false;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(204, 251);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(143, 22);
            this.txt_senha.TabIndex = 12;
            this.txt_senha.Visible = false;
            // 
            // txt_conf_senha
            // 
            this.txt_conf_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conf_senha.Location = new System.Drawing.Point(204, 300);
            this.txt_conf_senha.Name = "txt_conf_senha";
            this.txt_conf_senha.PasswordChar = '*';
            this.txt_conf_senha.Size = new System.Drawing.Size(143, 22);
            this.txt_conf_senha.TabIndex = 13;
            this.txt_conf_senha.Visible = false;
            // 
            // lbl_conf_senha
            // 
            this.lbl_conf_senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conf_senha.Location = new System.Drawing.Point(13, 302);
            this.lbl_conf_senha.Name = "lbl_conf_senha";
            this.lbl_conf_senha.Size = new System.Drawing.Size(173, 19);
            this.lbl_conf_senha.TabIndex = 14;
            this.lbl_conf_senha.Text = "Digite novamente:";
            this.lbl_conf_senha.Visible = false;
            // 
            // lbl_msg_erro
            // 
            this.lbl_msg_erro.AutoSize = true;
            this.lbl_msg_erro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_msg_erro.Location = new System.Drawing.Point(16, 232);
            this.lbl_msg_erro.Name = "lbl_msg_erro";
            this.lbl_msg_erro.Size = new System.Drawing.Size(74, 14);
            this.lbl_msg_erro.TabIndex = 15;
            this.lbl_msg_erro.Text = "código errado";
            this.lbl_msg_erro.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(132, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Esq_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_msg_erro);
            this.Controls.Add(this.lbl_conf_senha);
            this.Controls.Add(this.txt_conf_senha);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.bt_cad);
            this.Controls.Add(this.bt_Rec);
            this.Controls.Add(this.label1);
            this.Name = "Esq_Senha";
            this.Text = "Recumperação de senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Rec;
        private System.Windows.Forms.Button bt_cad;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_conf_senha;
        private System.Windows.Forms.Label lbl_conf_senha;
        private System.Windows.Forms.Label lbl_msg_erro;
        private System.Windows.Forms.Button button1;
    }
}