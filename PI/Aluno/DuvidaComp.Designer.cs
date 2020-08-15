namespace PI
{
    partial class DuvidaComp
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
            this.dg_duv = new System.Windows.Forms.DataGridView();
            this.rb_50 = new System.Windows.Forms.RadioButton();
            this.rb_td = new System.Windows.Forms.RadioButton();
            this.rtxt_duv = new System.Windows.Forms.RichTextBox();
            this.bt_menu = new System.Windows.Forms.Button();
            this.cb_prof = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxt_resp = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtDat = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_duv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dúvidas";
            // 
            // dg_duv
            // 
            this.dg_duv.AllowUserToAddRows = false;
            this.dg_duv.AllowUserToDeleteRows = false;
            this.dg_duv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_duv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_duv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_duv.Location = new System.Drawing.Point(35, 103);
            this.dg_duv.Name = "dg_duv";
            this.dg_duv.ReadOnly = true;
            this.dg_duv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_duv.Size = new System.Drawing.Size(727, 255);
            this.dg_duv.TabIndex = 1;
            this.dg_duv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_duv_CellClick);
            // 
            // rb_50
            // 
            this.rb_50.AutoSize = true;
            this.rb_50.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_50.Location = new System.Drawing.Point(35, 69);
            this.rb_50.Name = "rb_50";
            this.rb_50.Size = new System.Drawing.Size(211, 20);
            this.rb_50.TabIndex = 2;
            this.rb_50.TabStop = true;
            this.rb_50.Text = "Limitar a 50 ultimas questões";
            this.rb_50.UseVisualStyleBackColor = true;
            this.rb_50.CheckedChanged += new System.EventHandler(this.rb_50_CheckedChanged);
            // 
            // rb_td
            // 
            this.rb_td.AutoSize = true;
            this.rb_td.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_td.Location = new System.Drawing.Point(280, 69);
            this.rb_td.Name = "rb_td";
            this.rb_td.Size = new System.Drawing.Size(63, 20);
            this.rb_td.TabIndex = 4;
            this.rb_td.TabStop = true;
            this.rb_td.Text = "Todas";
            this.rb_td.UseVisualStyleBackColor = true;
            this.rb_td.CheckedChanged += new System.EventHandler(this.rb_td_CheckedChanged);
            // 
            // rtxt_duv
            // 
            this.rtxt_duv.Enabled = false;
            this.rtxt_duv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_duv.Location = new System.Drawing.Point(38, 480);
            this.rtxt_duv.Name = "rtxt_duv";
            this.rtxt_duv.Size = new System.Drawing.Size(700, 174);
            this.rtxt_duv.TabIndex = 5;
            this.rtxt_duv.Text = "";
            // 
            // bt_menu
            // 
            this.bt_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_menu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_menu.Location = new System.Drawing.Point(663, 911);
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(75, 36);
            this.bt_menu.TabIndex = 6;
            this.bt_menu.Text = "Menu";
            this.bt_menu.UseVisualStyleBackColor = true;
            this.bt_menu.Click += new System.EventHandler(this.bt_menu_Click);
            // 
            // cb_prof
            // 
            this.cb_prof.Enabled = false;
            this.cb_prof.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_prof.FormattingEnabled = true;
            this.cb_prof.Location = new System.Drawing.Point(162, 402);
            this.cb_prof.Name = "cb_prof";
            this.cb_prof.Size = new System.Drawing.Size(149, 26);
            this.cb_prof.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Professor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dúvida";
            // 
            // rtxt_resp
            // 
            this.rtxt_resp.Enabled = false;
            this.rtxt_resp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_resp.Location = new System.Drawing.Point(38, 717);
            this.rtxt_resp.Name = "rtxt_resp";
            this.rtxt_resp.Size = new System.Drawing.Size(700, 174);
            this.rtxt_resp.TabIndex = 10;
            this.rtxt_resp.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 692);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Resposta";
            // 
            // mtxtDat
            // 
            this.mtxtDat.Enabled = false;
            this.mtxtDat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDat.Location = new System.Drawing.Point(576, 402);
            this.mtxtDat.Mask = "00/00/0000";
            this.mtxtDat.Name = "mtxtDat";
            this.mtxtDat.ShortcutsEnabled = false;
            this.mtxtDat.Size = new System.Drawing.Size(89, 26);
            this.mtxtDat.TabIndex = 12;
            this.mtxtDat.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data";
            // 
            // DuvidaComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtDat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxt_resp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_prof);
            this.Controls.Add(this.bt_menu);
            this.Controls.Add(this.rtxt_duv);
            this.Controls.Add(this.rb_td);
            this.Controls.Add(this.rb_50);
            this.Controls.Add(this.dg_duv);
            this.Controls.Add(this.label1);
            this.Name = "DuvidaComp";
            this.Text = "DuvidaComp";
            this.Load += new System.EventHandler(this.DuvidaComp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_duv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_duv;
        private System.Windows.Forms.RadioButton rb_50;
        private System.Windows.Forms.RadioButton rb_td;
        private System.Windows.Forms.RichTextBox rtxt_duv;
        private System.Windows.Forms.Button bt_menu;
        private System.Windows.Forms.ComboBox cb_prof;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxt_resp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtDat;
        private System.Windows.Forms.Label label2;
    }
}