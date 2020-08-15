namespace PI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_Car = new System.Windows.Forms.ProgressBar();
            this.ptb_prop01 = new System.Windows.Forms.PictureBox();
            this.ptb_prop03 = new System.Windows.Forms.PictureBox();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.ptb_prop02 = new System.Windows.Forms.PictureBox();
            this.ptb_princ = new System.Windows.Forms.PictureBox();
            this.tm_temp = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_prop01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_prop03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_prop02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_princ)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Car
            // 
            this.pb_Car.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Car.Location = new System.Drawing.Point(0, 338);
            this.pb_Car.Name = "pb_Car";
            this.pb_Car.Size = new System.Drawing.Size(695, 42);
            this.pb_Car.TabIndex = 1;
            // 
            // ptb_prop01
            // 
            this.ptb_prop01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_prop01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_prop01.Location = new System.Drawing.Point(468, 12);
            this.ptb_prop01.Name = "ptb_prop01";
            this.ptb_prop01.Size = new System.Drawing.Size(215, 190);
            this.ptb_prop01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_prop01.TabIndex = 2;
            this.ptb_prop01.TabStop = false;
            // 
            // ptb_prop03
            // 
            this.ptb_prop03.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_prop03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_prop03.Location = new System.Drawing.Point(584, 208);
            this.ptb_prop03.Name = "ptb_prop03";
            this.ptb_prop03.Size = new System.Drawing.Size(103, 124);
            this.ptb_prop03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_prop03.TabIndex = 4;
            this.ptb_prop03.TabStop = false;
            // 
            // ptb_logo
            // 
            this.ptb_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_logo.Location = new System.Drawing.Point(12, 12);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(161, 44);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_logo.TabIndex = 5;
            this.ptb_logo.TabStop = false;
            // 
            // ptb_prop02
            // 
            this.ptb_prop02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_prop02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_prop02.Location = new System.Drawing.Point(468, 208);
            this.ptb_prop02.Name = "ptb_prop02";
            this.ptb_prop02.Size = new System.Drawing.Size(110, 124);
            this.ptb_prop02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_prop02.TabIndex = 7;
            this.ptb_prop02.TabStop = false;
            // 
            // ptb_princ
            // 
            this.ptb_princ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_princ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_princ.Location = new System.Drawing.Point(0, 0);
            this.ptb_princ.Name = "ptb_princ";
            this.ptb_princ.Size = new System.Drawing.Size(695, 420);
            this.ptb_princ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_princ.TabIndex = 8;
            this.ptb_princ.TabStop = false;
            // 
            // tm_temp
            // 
            this.tm_temp.Interval = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(695, 420);
            this.Controls.Add(this.ptb_prop02);
            this.Controls.Add(this.ptb_logo);
            this.Controls.Add(this.ptb_prop03);
            this.Controls.Add(this.ptb_prop01);
            this.Controls.Add(this.pb_Car);
            this.Controls.Add(this.ptb_princ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_prop01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_prop03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_prop02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_princ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar pb_Car;
        private System.Windows.Forms.PictureBox ptb_prop01;
        private System.Windows.Forms.PictureBox ptb_prop03;
        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.PictureBox ptb_prop02;
        private System.Windows.Forms.PictureBox ptb_princ;
        private System.Windows.Forms.Timer tm_temp;
    }
}

