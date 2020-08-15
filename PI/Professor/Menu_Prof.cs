using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class Menu_Prof : Form
    {      
        Pessoa pessoa = new Pessoa();
        controle control = new controle();
        DataTable datT = new DataTable();
        public Menu_Prof()
        {
            InitializeComponent();
        }
        public Menu_Prof(Pessoa pess)
        {
            InitializeComponent();
            pessoa = pess;
        }

        private void Menu_Prof_Load(object sender, EventArgs e)
        {
            pessoa.nome = null;
            pessoa.sel_query = 9;
            pessoa = control.acessar(pessoa);
            lbl_nome.Text = pessoa.nome;

            precDatGridView_duv();
            precDatGridView_evento();




        }

        private void llbl_sair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           var resp = MessageBox.Show("Deseja sair?", "logoff", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (DialogResult.Yes == resp) 
            {
                pessoa.id_aluno = 0;
                pessoa.id_turma = 0;
                lbl_nome.Text = null;
                Login frm_Login = new Login();
                this.Dispose();
                frm_Login.ShowDialog();
            }
        }


        private void precDatGridView_duv() 
        {
            pessoa.sel_query = 14;
            datT = control.pesquisa(pessoa);
            dg_duv.DataSource = datT;
            dg_duv.Columns["id_duvida"].Visible = false;
            dg_duv.Columns["id_aluno"].Visible = false;
        }

        private void precDatGridView_evento()
        {
            pessoa.sel_query = 15;
            datT = control.pesquisa(pessoa);
            dg_event.DataSource = datT;
        }

        private void gravarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LINK P TRANSMISSAO VIA WEB
        }

        private void verTodasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //LINK P TRANSMISSAO VIA WEB
        }
        private void enviarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LINK P UPLOAD VIA WEB
        }

        private void dg_duv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                pessoa.id_duv = Convert.ToInt32( dg_duv.Rows[e.RowIndex].Cells[0].Value.ToString());
                pessoa.duv = dg_duv.Rows[e.RowIndex].Cells[1].Value.ToString();
                pessoa.resp = dg_duv.Rows[e.RowIndex].Cells[2].Value.ToString();
                pessoa.nome = dg_duv.Rows[e.RowIndex].Cells[4].Value.ToString();
                pessoa.date = Convert.ToDateTime(dg_duv.Rows[e.RowIndex].Cells[5].Value);

             

                DuvidaProf frm_DuvidaProf = new DuvidaProf(pessoa);
                this.Dispose();
                frm_DuvidaProf.ShowDialog();

            }

            
        }

        private void provasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fazerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DuvidaProf frm_DuvidaProf = new DuvidaProf(pessoa);
            this.Dispose();
            frm_DuvidaProf.ShowDialog();
        }

        private void quemSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
