namespace PI
{
    partial class Sala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sala));
            this.ax_RepVid = new AxWMPLib.AxWindowsMediaPlayer();
            this.rtxt_com = new System.Windows.Forms.RichTextBox();
            this.bt_menu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_duv = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cb_prof = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ax_RepVid)).BeginInit();
            this.SuspendLayout();
            // 
            // ax_RepVid
            // 
            this.ax_RepVid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ax_RepVid.Enabled = true;
            this.ax_RepVid.Location = new System.Drawing.Point(12, 12);
            this.ax_RepVid.Name = "ax_RepVid";
            this.ax_RepVid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ax_RepVid.OcxState")));
            this.ax_RepVid.Size = new System.Drawing.Size(984, 436);
            this.ax_RepVid.TabIndex = 0;
            // 
            // rtxt_com
            // 
            this.rtxt_com.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_com.Location = new System.Drawing.Point(12, 501);
            this.rtxt_com.Name = "rtxt_com";
            this.rtxt_com.Size = new System.Drawing.Size(860, 85);
            this.rtxt_com.TabIndex = 1;
            this.rtxt_com.Text = "";
            // 
            // bt_menu
            // 
            this.bt_menu.AutoEllipsis = true;
            this.bt_menu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bt_menu.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.bt_menu.FlatAppearance.BorderSize = 4;
            this.bt_menu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_menu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_menu.Location = new System.Drawing.Point(454, 706);
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(95, 32);
            this.bt_menu.TabIndex = 2;
            this.bt_menu.Text = "Menu";
            this.bt_menu.UseVisualStyleBackColor = false;
            this.bt_menu.Click += new System.EventHandler(this.bt_menu_Click);
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(555, 706);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Próxima aula";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(312, 706);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Aula anterior";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // bt_duv
            // 
            this.bt_duv.AutoEllipsis = true;
            this.bt_duv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bt_duv.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.bt_duv.FlatAppearance.BorderSize = 4;
            this.bt_duv.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_duv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_duv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_duv.Location = new System.Drawing.Point(878, 526);
            this.bt_duv.Name = "bt_duv";
            this.bt_duv.Size = new System.Drawing.Size(105, 60);
            this.bt_duv.TabIndex = 5;
            this.bt_duv.Text = "Enviar ao professor";
            this.bt_duv.UseVisualStyleBackColor = false;
            this.bt_duv.Click += new System.EventHandler(this.bt_duv_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(555, 605);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(428, 94);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // cb_prof
            // 
            this.cb_prof.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_prof.FormattingEnabled = true;
            this.cb_prof.Location = new System.Drawing.Point(691, 470);
            this.cb_prof.Name = "cb_prof";
            this.cb_prof.Size = new System.Drawing.Size(181, 26);
            this.cb_prof.TabIndex = 8;
            this.cb_prof.SelectedIndexChanged += new System.EventHandler(this.cb_prof_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Professor";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 633);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(500, 66);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 602);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Registre abaixo observações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Envie ao seu professor sua dúvida";
            // 
            // Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 739);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_prof);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bt_duv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_menu);
            this.Controls.Add(this.rtxt_com);
            this.Controls.Add(this.ax_RepVid);
            this.Name = "Sala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ax_RepVid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer ax_RepVid;
        private System.Windows.Forms.RichTextBox rtxt_com;
        private System.Windows.Forms.Button bt_menu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_duv;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cb_prof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}