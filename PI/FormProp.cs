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
    public partial class FormProp : Form
    {
        public FormProp()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hist frm_hist = new hist();
            this.Dispose();
            frm_hist.ShowDialog();
        }

        private void llbl_entrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login frm_login = new Login();
            this.Dispose();
            frm_login.ShowDialog();
        }

        private void llbl_paceiras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llbl_estrutura_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Estrut frm_estrutura = new Estrut();
            this.Dispose();
            frm_estrutura.ShowDialog();

        }

        private void FormProp_Load(object sender, EventArgs e)
        {
            pb_logo.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\logo.jpg");
            pt01.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\prop01.jpg");
            pt02.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\prop02.jpg");
            pt03.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\prop03.jpg");
            pt04.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\prop05.jpg");
        }
    }
}
