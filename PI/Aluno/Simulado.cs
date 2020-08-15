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
    public partial class Simulado : Form
    {
        controle control = new controle();
        Pessoa pessoa = new Pessoa();
        DataTable datT = new DataTable();
        String[] vresp = new String[20];
        int vresp_alu = 0;
        int temp;
        public Simulado()
        {
            InitializeComponent();
        }
        public Simulado(Pessoa pess)
        {
            InitializeComponent();
            pessoa = pess;
        }
        private void Simulado_Load(object sender, EventArgs e)
        {
            pessoa.sel_query = 18;
            datT = control.pesquisa(pessoa);

            dg_simulados.DataSource = datT;
        }

        private void dg_simulados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
              
                pessoa.date = Convert.ToDateTime(dg_simulados.Rows[e.RowIndex].Cells[2].Value);
                DateTime dat = new DateTime();
                dat = DateTime.Today;


                if (pessoa.date == dat) 
                {
                    pessoa.id_sim = Convert.ToInt32(dg_simulados.Rows[e.RowIndex].Cells[0].Value);
                    Exame_realizacao frm_Exame_realizacao = new Exame_realizacao(pessoa);
                    this.Dispose();
                    frm_Exame_realizacao.ShowDialog();
                }
               
            }
        }

        private void bt_Menu_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu(pessoa);
            this.Dispose();            
            frmMenu.ShowDialog();
        }
    }
}
