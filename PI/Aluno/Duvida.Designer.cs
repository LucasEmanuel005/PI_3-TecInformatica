namespace PI
{
    partial class Duvida
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
            this.rtxt_duv = new System.Windows.Forms.RichTextBox();
            this.cb_professor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_enviar = new System.Windows.Forms.Button();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt_duv
            // 
            this.rtxt_duv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_duv.Location = new System.Drawing.Point(47, 170);
            this.rtxt_duv.Name = "rtxt_duv";
            this.rtxt_duv.Size = new System.Drawing.Size(496, 216);
            this.rtxt_duv.TabIndex = 0;
            this.rtxt_duv.Text = "";
            // 
            // cb_professor
            // 
            this.cb_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_professor.FormattingEnabled = true;
            this.cb_professor.Location = new System.Drawing.Point(146, 67);
            this.cb_professor.Name = "cb_professor";
            this.cb_professor.Size = new System.Drawing.Size(121, 24);
            this.cb_professor.TabIndex = 1;
            this.cb_professor.SelectedIndexChanged += new System.EventHandler(this.cb_professor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tirar dúvida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Professor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dúvida:";
            // 
            // bt_enviar
            // 
            this.bt_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_enviar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enviar.Location = new System.Drawing.Point(382, 393);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(138, 30);
            this.bt_enviar.TabIndex = 5;
            this.bt_enviar.Text = "Enviar";
            this.bt_enviar.UseVisualStyleBackColor = true;
            this.bt_enviar.Click += new System.EventHandler(this.bt_enviar_Click);
            // 
            // bt_voltar
            // 
            this.bt_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_voltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltar.Location = new System.Drawing.Point(226, 393);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(138, 30);
            this.bt_voltar.TabIndex = 6;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // Duvida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 435);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.bt_enviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_professor);
            this.Controls.Add(this.rtxt_duv);
            this.Name = "Duvida";
            this.Text = "Duvida";
            this.Load += new System.EventHandler(this.Duvida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_duv;
        private System.Windows.Forms.ComboBox cb_professor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_enviar;
        private System.Windows.Forms.Button bt_voltar;
    }
}