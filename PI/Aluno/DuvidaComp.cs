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
    public partial class DuvidaComp : Form
    {
        DataTable datT = new DataTable();
        controle control = new controle();
        Pessoa pessoa = new Pessoa();
       
        public DuvidaComp()
        {
            InitializeComponent();
        }
        public DuvidaComp(Pessoa pess)
        {
            InitializeComponent();
            pessoa = pess;
        }
        private void rb_50_CheckedChanged(object sender, EventArgs e)
        {            
            precDatGridView(12);
        }

        private void rb_td_CheckedChanged(object sender, EventArgs e)
        {         
            precDatGridView(13);
        }

        private void precDatGridView(int limite_pesq)         
        {
            // PARAMETRO: 12 Limitar a 50. 13 mostrar tudo.
            pessoa.sel_query = limite_pesq;
            datT = control.pesquisa(pessoa);
            dg_duv.DataSource = datT;          
            dg_duv.Columns["dat"].HeaderText = "Data";
            dg_duv.Columns["pergunta"].HeaderText = "Pergunta";
            dg_duv.Columns["resposta"].HeaderText = "Resposta";
            dg_duv.Columns["nome"].HeaderText = "Professor";
            dg_duv.Columns["dat"].Width = 200;

        }

        private void dg_duv_CellClick(object sender, DataGridViewCellEventArgs e)
        {                       
            if (e.RowIndex > -1)
            {               
                rtxt_duv.Text = dg_duv.Rows[e.RowIndex].Cells[0].Value.ToString();
                rtxt_resp.Text = dg_duv.Rows[e.RowIndex].Cells[1].Value.ToString();
                cb_prof.Text = dg_duv.Rows[e.RowIndex].Cells[2].Value.ToString();
                mtxtDat.Text = dg_duv.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            Menu frm_Menu = new Menu(pessoa);
            this.Dispose();
            frm_Menu.ShowDialog();
        }

        private void DuvidaComp_Load(object sender, EventArgs e)
        {

        }
    }
}
