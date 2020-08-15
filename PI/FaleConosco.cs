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
    public partial class FaleConosco : Form
    {
        Pessoa pessoa = new Pessoa();
        public FaleConosco()
        {
            InitializeComponent();
        }
        public FaleConosco(Pessoa pess)
        {
            InitializeComponent();
            pessoa = pess;
        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {

            if (pessoa.id_aluno > 0 && pessoa.id_turma > 0)
            {
                Menu frm_Menu = new Menu(pessoa);
                this.Dispose();
                frm_Menu.ShowDialog();
            }
            else
            {
                FormProp frm_Prop = new FormProp();
                this.Dispose();
                frm_Prop.ShowDialog();
            }
        }
    }
}
