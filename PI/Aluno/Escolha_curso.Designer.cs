namespace PI
{
    partial class Escolha_curso
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
            this.lbl_ap = new System.Windows.Forms.Label();
            this.cb_curso = new System.Windows.Forms.ComboBox();
            this.lbl_desc_esc_curso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_turma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dg_cont = new System.Windows.Forms.DataGridView();
            this.dg_disp = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_preco_desc = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bt_cont = new System.Windows.Forms.Button();
            this.pb_fundo = new System.Windows.Forms.PictureBox();
            this.lbl_vaga = new System.Windows.Forms.Label();
            this.lbl_vaga_desc = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_disp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ap
            // 
            this.lbl_ap.AutoSize = true;
            this.lbl_ap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ap.Location = new System.Drawing.Point(27, 189);
            this.lbl_ap.Name = "lbl_ap";
            this.lbl_ap.Size = new System.Drawing.Size(141, 25);
            this.lbl_ap.TabIndex = 0;
            this.lbl_ap.Text = "Boas vindas";
            // 
            // cb_curso
            // 
            this.cb_curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_curso.FormattingEnabled = true;
            this.cb_curso.Location = new System.Drawing.Point(106, 822);
            this.cb_curso.Name = "cb_curso";
            this.cb_curso.Size = new System.Drawing.Size(121, 24);
            this.cb_curso.TabIndex = 1;
            this.cb_curso.SelectedIndexChanged += new System.EventHandler(this.cb_curso_SelectedIndexChanged);
            // 
            // lbl_desc_esc_curso
            // 
            this.lbl_desc_esc_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc_esc_curso.Location = new System.Drawing.Point(28, 234);
            this.lbl_desc_esc_curso.Name = "lbl_desc_esc_curso";
            this.lbl_desc_esc_curso.Size = new System.Drawing.Size(749, 54);
            this.lbl_desc_esc_curso.TabIndex = 2;
            this.lbl_desc_esc_curso.Text = "Abaixo estão nossos cursos com as melhores aulas do mercado preparadas especialme" +
    "nte pensando em você, com: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 823);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cursos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 823);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Turma";
            // 
            // cb_turma
            // 
            this.cb_turma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_turma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_turma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_turma.FormattingEnabled = true;
            this.cb_turma.Location = new System.Drawing.Point(379, 822);
            this.cb_turma.Name = "cb_turma";
            this.cb_turma.Size = new System.Drawing.Size(121, 24);
            this.cb_turma.TabIndex = 4;
            this.cb_turma.SelectedIndexChanged += new System.EventHandler(this.cb_turma_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 922);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Disciplinas";
            // 
            // dg_cont
            // 
            this.dg_cont.AllowUserToAddRows = false;
            this.dg_cont.AllowUserToDeleteRows = false;
            this.dg_cont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cont.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_cont.Location = new System.Drawing.Point(416, 955);
            this.dg_cont.Name = "dg_cont";
            this.dg_cont.ReadOnly = true;
            this.dg_cont.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_cont.Size = new System.Drawing.Size(267, 150);
            this.dg_cont.TabIndex = 7;
            // 
            // dg_disp
            // 
            this.dg_disp.AllowUserToAddRows = false;
            this.dg_disp.AllowUserToDeleteRows = false;
            this.dg_disp.AllowUserToResizeColumns = false;
            this.dg_disp.AllowUserToResizeRows = false;
            this.dg_disp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_disp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_disp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dg_disp.ColumnHeadersHeight = 25;
            this.dg_disp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_disp.Location = new System.Drawing.Point(27, 955);
            this.dg_disp.Name = "dg_disp";
            this.dg_disp.ReadOnly = true;
            this.dg_disp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dg_disp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_disp.Size = new System.Drawing.Size(174, 150);
            this.dg_disp.TabIndex = 9;
            this.dg_disp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_disp_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(431, 922);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Conteúdos";
            // 
            // lbl_preco_desc
            // 
            this.lbl_preco_desc.AutoSize = true;
            this.lbl_preco_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco_desc.Location = new System.Drawing.Point(533, 823);
            this.lbl_preco_desc.Name = "lbl_preco_desc";
            this.lbl_preco_desc.Size = new System.Drawing.Size(55, 20);
            this.lbl_preco_desc.TabIndex = 5;
            this.lbl_preco_desc.Text = "Preço";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco.Location = new System.Drawing.Point(634, 828);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(44, 16);
            this.lbl_preco.TabIndex = 12;
            this.lbl_preco.Text = "Preço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Temos gratuitamente um curso do ensino médio visando nivelar todos independente d" +
    "o nivel social. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "> Vídeos (já gravados de todos os conteúdos).";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(65, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(308, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "> Mais de 10 exercícios de cada conteúdo.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(65, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(266, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "> Professores dispostos 18h por dia.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(65, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(295, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "> Uma aula com um monitor por semana";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(65, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(621, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "> Apostilas focada no conteúdo do vestibular, sem deixar lacunas em seu aprendiza" +
    "do.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(65, 424);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(316, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "> Indicação de livros (já visando seu futuro).";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(68, 727);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(314, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "> Indicação de livros para aprofundamento.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(68, 767);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "> Apostilas completas ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(68, 657);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(228, 20);
            this.label17.TabIndex = 25;
            this.label17.Text = "> Duas perguntas por semana.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(68, 625);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 20);
            this.label18.TabIndex = 24;
            this.label18.Text = "> Didatica sem igual.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(64, 696);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(308, 20);
            this.label19.TabIndex = 23;
            this.label19.Text = "> Mais de 10 exercícios de cada conteúdo.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(68, 591);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(456, 20);
            this.label20.TabIndex = 22;
            this.label20.Text = "> Vídeos (já gravados de todos os conteúdos do ensino médio).";
            // 
            // bt_cont
            // 
            this.bt_cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cont.Location = new System.Drawing.Point(638, 1111);
            this.bt_cont.Name = "bt_cont";
            this.bt_cont.Size = new System.Drawing.Size(134, 31);
            this.bt_cont.TabIndex = 28;
            this.bt_cont.Text = "Continuar";
            this.bt_cont.UseVisualStyleBackColor = true;
            this.bt_cont.Click += new System.EventHandler(this.bt_cont_Click);
            // 
            // pb_fundo
            // 
            this.pb_fundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_fundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_fundo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_fundo.Location = new System.Drawing.Point(0, 0);
            this.pb_fundo.Name = "pb_fundo";
            this.pb_fundo.Size = new System.Drawing.Size(834, 187);
            this.pb_fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_fundo.TabIndex = 29;
            this.pb_fundo.TabStop = false;
            // 
            // lbl_vaga
            // 
            this.lbl_vaga.AutoSize = true;
            this.lbl_vaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vaga.Location = new System.Drawing.Point(635, 883);
            this.lbl_vaga.Name = "lbl_vaga";
            this.lbl_vaga.Size = new System.Drawing.Size(48, 16);
            this.lbl_vaga.TabIndex = 31;
            this.lbl_vaga.Text = "Vagas";
            // 
            // lbl_vaga_desc
            // 
            this.lbl_vaga_desc.AutoSize = true;
            this.lbl_vaga_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vaga_desc.Location = new System.Drawing.Point(534, 879);
            this.lbl_vaga_desc.Name = "lbl_vaga_desc";
            this.lbl_vaga_desc.Size = new System.Drawing.Size(60, 20);
            this.lbl_vaga_desc.TabIndex = 30;
            this.lbl_vaga_desc.Text = "Vagas";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(65, 502);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(236, 20);
            this.label22.TabIndex = 32;
            this.label22.Text = "> Simulado todo fim de semana.";
            // 
            // Escolha_curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lbl_vaga);
            this.Controls.Add(this.lbl_vaga_desc);
            this.Controls.Add(this.pb_fundo);
            this.Controls.Add(this.bt_cont);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.dg_disp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dg_cont);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_preco_desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_turma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_desc_esc_curso);
            this.Controls.Add(this.cb_curso);
            this.Controls.Add(this.lbl_ap);
            this.Name = "Escolha_curso";
            this.Text = "Escolha_curso";
            this.Load += new System.EventHandler(this.Escolha_curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_disp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ap;
        private System.Windows.Forms.ComboBox cb_curso;
        private System.Windows.Forms.Label lbl_desc_esc_curso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_turma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dg_cont;
        private System.Windows.Forms.DataGridView dg_disp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_preco_desc;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button bt_cont;
        private System.Windows.Forms.PictureBox pb_fundo;
        private System.Windows.Forms.Label lbl_vaga;
        private System.Windows.Forms.Label lbl_vaga_desc;
        private System.Windows.Forms.Label label22;
    }
}