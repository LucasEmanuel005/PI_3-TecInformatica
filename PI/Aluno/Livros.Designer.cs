namespace PI
{
    partial class Livros
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
            this.lbl_Disc = new System.Windows.Forms.Label();
            this.cb_dis = new System.Windows.Forms.ComboBox();
            this.dg_conteudo = new System.Windows.Forms.DataGridView();
            this.txt_pesq = new System.Windows.Forms.TextBox();
            this.lbl_Pesq = new System.Windows.Forms.Label();
            this.bt_Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_conteudo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Disc
            // 
            this.lbl_Disc.AutoSize = true;
            this.lbl_Disc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Disc.Location = new System.Drawing.Point(12, 40);
            this.lbl_Disc.Name = "lbl_Disc";
            this.lbl_Disc.Size = new System.Drawing.Size(99, 22);
            this.lbl_Disc.TabIndex = 0;
            this.lbl_Disc.Text = "Disciplina";
            // 
            // cb_dis
            // 
            this.cb_dis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dis.FormattingEnabled = true;
            this.cb_dis.Location = new System.Drawing.Point(129, 38);
            this.cb_dis.Name = "cb_dis";
            this.cb_dis.Size = new System.Drawing.Size(121, 24);
            this.cb_dis.TabIndex = 1;
            this.cb_dis.SelectedIndexChanged += new System.EventHandler(this.cb_dis_SelectedIndexChanged);
            // 
            // dg_conteudo
            // 
            this.dg_conteudo.AllowUserToAddRows = false;
            this.dg_conteudo.AllowUserToDeleteRows = false;
            this.dg_conteudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_conteudo.Location = new System.Drawing.Point(16, 146);
            this.dg_conteudo.Name = "dg_conteudo";
            this.dg_conteudo.ReadOnly = true;
            this.dg_conteudo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_conteudo.Size = new System.Drawing.Size(772, 253);
            this.dg_conteudo.TabIndex = 2;
            this.dg_conteudo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_conteudo_CellClick);
            // 
            // txt_pesq
            // 
            this.txt_pesq.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesq.Location = new System.Drawing.Point(129, 82);
            this.txt_pesq.Name = "txt_pesq";
            this.txt_pesq.Size = new System.Drawing.Size(100, 22);
            this.txt_pesq.TabIndex = 3;
            this.txt_pesq.TextChanged += new System.EventHandler(this.txt_pesq_TextChanged);
            // 
            // lbl_Pesq
            // 
            this.lbl_Pesq.AutoSize = true;
            this.lbl_Pesq.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pesq.Location = new System.Drawing.Point(12, 82);
            this.lbl_Pesq.Name = "lbl_Pesq";
            this.lbl_Pesq.Size = new System.Drawing.Size(101, 22);
            this.lbl_Pesq.TabIndex = 4;
            this.lbl_Pesq.Text = "Pesquisar";
            // 
            // bt_Menu
            // 
            this.bt_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Menu.Location = new System.Drawing.Point(316, 405);
            this.bt_Menu.Name = "bt_Menu";
            this.bt_Menu.Size = new System.Drawing.Size(132, 33);
            this.bt_Menu.TabIndex = 6;
            this.bt_Menu.Text = "Menu";
            this.bt_Menu.UseVisualStyleBackColor = true;
            this.bt_Menu.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Menu);
            this.Controls.Add(this.lbl_Pesq);
            this.Controls.Add(this.txt_pesq);
            this.Controls.Add(this.dg_conteudo);
            this.Controls.Add(this.cb_dis);
            this.Controls.Add(this.lbl_Disc);
            this.Name = "Livros";
            this.Text = "Livros";
            this.Load += new System.EventHandler(this.Pdfs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_conteudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Disc;
        private System.Windows.Forms.ComboBox cb_dis;
        private System.Windows.Forms.DataGridView dg_conteudo;
        private System.Windows.Forms.TextBox txt_pesq;
        private System.Windows.Forms.Label lbl_Pesq;
        private System.Windows.Forms.Button bt_Menu;
    }
}