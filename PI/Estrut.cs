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
    public partial class Estrut : Form
    {
        Pessoa pessoa = new Pessoa();
        public Estrut()
        {
            InitializeComponent();
        }
        public Estrut(Pessoa pess)
        {
            InitializeComponent();
            pessoa = pess;

        }

        private void Estrut_Load(object sender, EventArgs e)
        {
            if (pessoa.id_aluno > 0 && pessoa.id_turma > 0)
            {
                bt_menu.Visible = true;
            }
            else
            {
                bt_frmProp.Visible = true;
            }

           //CARREGAMENTO IMG PROPAGANDA
            CarImg();



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

        private void CarImg()
        {
            pt01.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\pb01.png");
            pt02.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\pb02.png");
            pt03.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\pb03.jpg");
            pt04.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\pb04.jpg");
        }
        
    }
}
