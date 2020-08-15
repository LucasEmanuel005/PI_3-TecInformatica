namespace PI
{
    partial class Selecao_Turma
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
            this.lbl_Apr = new System.Windows.Forms.Label();
            this.cb_S_Turma = new System.Windows.Forms.ComboBox();
            this.lbl_s_turma = new System.Windows.Forms.Label();
            this.bt_cont = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Apr
            // 
            this.lbl_Apr.AutoSize = true;
            this.lbl_Apr.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apr.Location = new System.Drawing.Point(12, 24);
            this.lbl_Apr.Name = "lbl_Apr";
            this.lbl_Apr.Size = new System.Drawing.Size(0, 23);
            this.lbl_Apr.TabIndex = 0;
            // 
            // cb_S_Turma
            // 
            this.cb_S_Turma.FormattingEnabled = true;
            this.cb_S_Turma.Location = new System.Drawing.Point(82, 69);
            this.cb_S_Turma.Name = "cb_S_Turma";
            this.cb_S_Turma.Size = new System.Drawing.Size(188, 21);
            this.cb_S_Turma.TabIndex = 1;
            this.cb_S_Turma.SelectedIndexChanged += new System.EventHandler(this.cb_S_Turma_SelectedIndexChanged);
            // 
            // lbl_s_turma
            // 
            this.lbl_s_turma.AutoSize = true;
            this.lbl_s_turma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_s_turma.Location = new System.Drawing.Point(13, 72);
            this.lbl_s_turma.Name = "lbl_s_turma";
            this.lbl_s_turma.Size = new System.Drawing.Size(51, 18);
            this.lbl_s_turma.TabIndex = 0;
            this.lbl_s_turma.Text = "Turma";
            // 
            // bt_cont
            // 
            this.bt_cont.Location = new System.Drawing.Point(195, 128);
            this.bt_cont.Name = "bt_cont";
            this.bt_cont.Size = new System.Drawing.Size(75, 23);
            this.bt_cont.TabIndex = 2;
            this.bt_cont.Text = "Continuar";
            this.bt_cont.UseVisualStyleBackColor = true;
            this.bt_cont.Click += new System.EventHandler(this.bt_cont_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(114, 128);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 23);
            this.bt_sair.TabIndex = 3;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.button2_Click);
            // 
            // Selecao_Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 234);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_cont);
            this.Controls.Add(this.lbl_s_turma);
            this.Controls.Add(this.cb_S_Turma);
            this.Controls.Add(this.lbl_Apr);
            this.Name = "Selecao_Turma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecao_Turma";
            this.Load += new System.EventHandler(this.Selecao_Turma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Apr;
        private System.Windows.Forms.ComboBox cb_S_Turma;
        private System.Windows.Forms.Label lbl_s_turma;
        private System.Windows.Forms.Button bt_cont;
        private System.Windows.Forms.Button bt_sair;
    }
}