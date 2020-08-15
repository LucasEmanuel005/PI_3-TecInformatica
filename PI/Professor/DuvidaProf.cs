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
    public partial class DuvidaProf : Form
    {
        Pessoa pessoa = new Pessoa();
        DataTable datT = new DataTable();
        controle control = new controle();

        public DuvidaProf()
        {
            InitializeComponent();
        }
        public DuvidaProf(Pessoa pess)
        {
            InitializeComponent();
            pessoa = pess;
        }


        private void DuvidaProf_Load(object sender, EventArgs e)
        {
            if (pessoa.id_duv > 0) 
            {
                lbl_aluno.Text = pessoa.nome;
                mtxtDat.Text = pessoa.date.ToString();
                rtxt_duv.Text = pessoa.duv;
                rtxt_resp.Text = pessoa.resp;
                rtxt_resp.Enabled = false;
                bt_Enviar.Visible = false;
                if (String.IsNullOrWhiteSpace(pessoa.resp))
                {
                    rtxt_resp.Enabled = true;
                    bt_Enviar.Visible = true;
                }

                
            }
        }
        

        private void bt_menu_Click(object sender, EventArgs e)
        {
            Menu_Prof frm_Menu_Prof = new Menu_Prof(pessoa);
            this.Dispose();
            frm_Menu_Prof.ShowDialog();
        }

        private void bt_Enviar_Click(object sender, EventArgs e)
        {            

            if (String.IsNullOrWhiteSpace(rtxt_resp.Text)) 
            {
                MessageBox.Show("Digite a resposta", "Digite a resposta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                //ENVIANDO P BANCO A RESPOSTA              
                pessoa.resp = rtxt_resp.Text;

                pessoa.sel_query = 2;               
                pessoa = control.Update(pessoa);
                if (pessoa.add1 == "sucesso")
                {
                    MessageBox.Show("Respondido com sucesso", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbl_aluno.Text = pessoa.nome = null;
                    mtxtDat.Text = null;                   
                    rtxt_duv.Text = pessoa.duv = null;
                    rtxt_resp.Text = pessoa.resp= null;                   
                    bt_Enviar.Visible = false;
                  
                }
                else
                {
                    MessageBox.Show("Houve um erro tente denovo", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        private void rb_50_CheckedChanged(object sender, EventArgs e)
        {
            preDatView_duv_p_resp(14);
            lbl_aluno.Text = null;
            mtxtDat.Text = null;
            rtxt_duv.Text = null;
            rtxt_resp.Text = null;
            bt_Enviar.Visible = false;
            rtxt_resp.Enabled = false;
        }

        private void rb_td_CheckedChanged(object sender, EventArgs e)
        {
            preDatView_duv_p_resp(16);
            lbl_aluno.Text = null;
            mtxtDat.Text = null;
            rtxt_duv.Text = null;
            rtxt_resp.Text = null;
            bt_Enviar.Visible = false;
            rtxt_resp.Enabled = false;
        }
        private void preDatView_duv_p_resp(int limit_pesq)
        {
            pessoa.sel_query = limit_pesq;
            datT = control.pesquisa(pessoa);
            dg_duv.DataSource = datT;

         
            dg_duv.Columns["id_duvida"].Visible = false;
            dg_duv.Columns["id_aluno"].Visible = false;
            dg_duv.Columns["dat"].HeaderText = "Data";
            dg_duv.Columns["pergunta"].HeaderText = "Pergunta";
            dg_duv.Columns["resposta"].HeaderText = "Resposta";
            dg_duv.Columns["nome"].HeaderText = "Aluno";
            dg_duv.Columns["dat"].Width = 200;


        }

        private void dg_duv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                pessoa.id_duv = Convert.ToInt32( dg_duv.Rows[e.RowIndex].Cells[0].Value.ToString());
                rtxt_duv.Text = dg_duv.Rows[e.RowIndex].Cells[1].Value.ToString();
                rtxt_resp.Text = dg_duv.Rows[e.RowIndex].Cells[2].Value.ToString();
                lbl_aluno.Text = dg_duv.Rows[e.RowIndex].Cells[4].Value.ToString();
                mtxtDat.Text = dg_duv.Rows[e.RowIndex].Cells[5].Value.ToString();

              

                if (String.IsNullOrWhiteSpace(rtxt_resp.Text = dg_duv.Rows[e.RowIndex].Cells[2].Value.ToString()))
                {
                    bt_Enviar.Visible = true;
                    rtxt_resp.Enabled = true;
                }
                else 
                {
                    bt_Enviar.Visible = false;
                    rtxt_resp.Enabled = false;
                }



            }
        }
    }
}
