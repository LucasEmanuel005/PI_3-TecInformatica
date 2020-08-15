namespace PI
{
    partial class DuvidaProf
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
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtDat = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxt_resp = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_menu = new System.Windows.Forms.Button();
            this.rtxt_duv = new System.Windows.Forms.RichTextBox();
            this.rb_td = new System.Windows.Forms.RadioButton();
            this.rb_50 = new System.Windows.Forms.RadioButton();
            this.dg_duv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_aluno = new System.Windows.Forms.Label();
            this.bt_Enviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_duv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Data";
            // 
            // mtxtDat
            // 
            this.mtxtDat.Enabled = false;
            this.mtxtDat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDat.Location = new System.Drawing.Point(577, 385);
            this.mtxtDat.Mask = "00/00/0000";
            this.mtxtDat.Name = "mtxtDat";
            this.mtxtDat.ShortcutsEnabled = false;
            this.mtxtDat.Size = new System.Drawing.Size(89, 26);
            this.mtxtDat.TabIndex = 26;
            this.mtxtDat.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 680);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Resposta";
            // 
            // rtxt_resp
            // 
            this.rtxt_resp.Enabled = false;
            this.rtxt_resp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_resp.Location = new System.Drawing.Point(39, 705);
            this.rtxt_resp.Name = "rtxt_resp";
            this.rtxt_resp.Size = new System.Drawing.Size(700, 174);
            this.rtxt_resp.TabIndex = 24;
            this.rtxt_resp.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dúvida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Professor";
            // 
            // bt_menu
            // 
            this.bt_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_menu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_menu.Location = new System.Drawing.Point(578, 903);
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(75, 36);
            this.bt_menu.TabIndex = 20;
            this.bt_menu.Text = "Menu";
            this.bt_menu.UseVisualStyleBackColor = true;
            this.bt_menu.Click += new System.EventHandler(this.bt_menu_Click);
            // 
            // rtxt_duv
            // 
            this.rtxt_duv.Enabled = false;
            this.rtxt_duv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_duv.Location = new System.Drawing.Point(39, 468);
            this.rtxt_duv.Name = "rtxt_duv";
            this.rtxt_duv.Size = new System.Drawing.Size(700, 174);
            this.rtxt_duv.TabIndex = 19;
            this.rtxt_duv.Text = "";
            // 
            // rb_td
            // 
            this.rb_td.AutoSize = true;
            this.rb_td.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_td.Location = new System.Drawing.Point(281, 57);
            this.rb_td.Name = "rb_td";
            this.rb_td.Size = new System.Drawing.Size(63, 20);
            this.rb_td.TabIndex = 18;
            this.rb_td.TabStop = true;
            this.rb_td.Text = "Todas";
            this.rb_td.UseVisualStyleBackColor = true;
            this.rb_td.CheckedChanged += new System.EventHandler(this.rb_td_CheckedChanged);
            // 
            // rb_50
            // 
            this.rb_50.AutoSize = true;
            this.rb_50.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_50.Location = new System.Drawing.Point(36, 57);
            this.rb_50.Name = "rb_50";
            this.rb_50.Size = new System.Drawing.Size(211, 20);
            this.rb_50.TabIndex = 17;
            this.rb_50.TabStop = true;
            this.rb_50.Text = "Limitar a 50 ultimas questões";
            this.rb_50.UseVisualStyleBackColor = true;
            this.rb_50.CheckedChanged += new System.EventHandler(this.rb_50_CheckedChanged);
            // 
            // dg_duv
            // 
            this.dg_duv.AllowUserToAddRows = false;
            this.dg_duv.AllowUserToDeleteRows = false;
            this.dg_duv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_duv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_duv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_duv.Location = new System.Drawing.Point(36, 91);
            this.dg_duv.Name = "dg_duv";
            this.dg_duv.ReadOnly = true;
            this.dg_duv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_duv.Size = new System.Drawing.Size(727, 255);
            this.dg_duv.TabIndex = 16;
            this.dg_duv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_duv_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dúvidas";
            // 
            // lbl_aluno
            // 
            this.lbl_aluno.AutoSize = true;
            this.lbl_aluno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aluno.Location = new System.Drawing.Point(158, 393);
            this.lbl_aluno.Name = "lbl_aluno";
            this.lbl_aluno.Size = new System.Drawing.Size(47, 18);
            this.lbl_aluno.TabIndex = 28;
            this.lbl_aluno.Text = "Aluno";
            // 
            // bt_Enviar
            // 
            this.bt_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Enviar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Enviar.Location = new System.Drawing.Point(664, 903);
            this.bt_Enviar.Name = "bt_Enviar";
            this.bt_Enviar.Size = new System.Drawing.Size(75, 36);
            this.bt_Enviar.TabIndex = 29;
            this.bt_Enviar.Text = "Enviar";
            this.bt_Enviar.UseVisualStyleBackColor = true;
            this.bt_Enviar.Visible = false;
            this.bt_Enviar.Click += new System.EventHandler(this.bt_Enviar_Click);
            // 
            // DuvidaProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Enviar);
            this.Controls.Add(this.lbl_aluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtDat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxt_resp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_menu);
            this.Controls.Add(this.rtxt_duv);
            this.Controls.Add(this.rb_td);
            this.Controls.Add(this.rb_50);
            this.Controls.Add(this.dg_duv);
            this.Controls.Add(this.label1);
            this.Name = "DuvidaProf";
            this.Text = "DuvidaProf";
            this.Load += new System.EventHandler(this.DuvidaProf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_duv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtDat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxt_resp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_menu;
        private System.Windows.Forms.RichTextBox rtxt_duv;
        private System.Windows.Forms.RadioButton rb_td;
        private System.Windows.Forms.RadioButton rb_50;
        private System.Windows.Forms.DataGridView dg_duv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_aluno;
        private System.Windows.Forms.Button bt_Enviar;
    }
}