namespace PI
{
    partial class Simulado
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
            this.dg_simulados = new System.Windows.Forms.DataGridView();
            this.bt_Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_simulados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulados";
            // 
            // dg_simulados
            // 
            this.dg_simulados.AllowUserToAddRows = false;
            this.dg_simulados.AllowUserToDeleteRows = false;
            this.dg_simulados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_simulados.Location = new System.Drawing.Point(16, 78);
            this.dg_simulados.Name = "dg_simulados";
            this.dg_simulados.ReadOnly = true;
            this.dg_simulados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_simulados.Size = new System.Drawing.Size(758, 327);
            this.dg_simulados.TabIndex = 2;
            this.dg_simulados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_simulados_CellDoubleClick);
            // 
            // bt_Menu
            // 
            this.bt_Menu.Location = new System.Drawing.Point(660, 412);
            this.bt_Menu.Name = "bt_Menu";
            this.bt_Menu.Size = new System.Drawing.Size(75, 23);
            this.bt_Menu.TabIndex = 3;
            this.bt_Menu.Text = "Menu";
            this.bt_Menu.UseVisualStyleBackColor = true;
            this.bt_Menu.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // Simulado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Menu);
            this.Controls.Add(this.dg_simulados);
            this.Controls.Add(this.label1);
            this.Name = "Simulado";
            this.Text = "Simulado";
            this.Load += new System.EventHandler(this.Simulado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_simulados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_simulados;
        private System.Windows.Forms.Button bt_Menu;
    }
}