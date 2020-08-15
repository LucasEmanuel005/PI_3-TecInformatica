namespace PI
{
    partial class QuemSomos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuemSomos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_menu = new System.Windows.Forms.Button();
            this.bt_frmProp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "VestATM";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(765, 146);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI.Properties.Resources.ft_inicio_ori;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bt_menu
            // 
            this.bt_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_menu.Location = new System.Drawing.Point(310, 414);
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(101, 27);
            this.bt_menu.TabIndex = 3;
            this.bt_menu.Text = "Menu";
            this.bt_menu.UseVisualStyleBackColor = true;
            this.bt_menu.Visible = false;
            this.bt_menu.Click += new System.EventHandler(this.bt_menu_Click);
            // 
            // bt_frmProp
            // 
            this.bt_frmProp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_frmProp.Location = new System.Drawing.Point(417, 414);
            this.bt_frmProp.Name = "bt_frmProp";
            this.bt_frmProp.Size = new System.Drawing.Size(101, 27);
            this.bt_frmProp.TabIndex = 4;
            this.bt_frmProp.Text = "Menu";
            this.bt_frmProp.UseVisualStyleBackColor = true;
            this.bt_frmProp.Visible = false;
            this.bt_frmProp.Click += new System.EventHandler(this.bt_frmProp_Click);
            // 
            // QuemSomos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_frmProp);
            this.Controls.Add(this.bt_menu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "QuemSomos";
            this.Text = "QuemSomos";
            this.Load += new System.EventHandler(this.QuemSomos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_menu;
        private System.Windows.Forms.Button bt_frmProp;
    }
}