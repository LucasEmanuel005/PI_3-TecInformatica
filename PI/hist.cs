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
    public partial class hist : Form
    {
        Pessoa pessoa = new Pessoa();
        public hist()
        {
            InitializeComponent();
        }
        public hist(Pessoa pess)
        {
            InitializeComponent();
            pessoa = pess;
        }

        private void hist_Load(object sender, EventArgs e)
        {
           
            if (pessoa.id_aluno > 0 && pessoa.id_turma > 0)
            {
                bt_menu.Visible = true;
            }
            else
            {
                bt_frmProp.Visible = true;
            }
        }

        private void bt_frmProp_Click(object sender, EventArgs e)
        {
            FormProp frm_Prop = new FormProp();
            this.Dispose();
            frm_Prop.ShowDialog();

        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            Menu frm_Menu = new Menu(pessoa);
            this.Dispose();
            frm_Menu.ShowDialog();
        }
    }
}
