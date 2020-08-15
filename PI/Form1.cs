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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

            this.tm_temp.Enabled = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            pb_Car.Enabled = true;
            pb_Car.Minimum = 0;
            pb_Car.Maximum = 100;
            pb_Car.Style = ProgressBarStyle.Blocks;
            pb_Car.Value = 0;


            tm_temp.Start();
            tm_temp.Tick += Tm_temp_Tick;
            
            CarImg();

        }

        private void Tm_temp_Tick(object sender, EventArgs e)
        {
            pb_Car.Value += 1;
            if (pb_Car.Value == pb_Car.Maximum)
            {

                FormProp frm_Prop = new FormProp();
                this.Hide();
                tm_temp.Stop();
                frm_Prop.ShowDialog();
            }
        }
       

        private void CarImg()
        {

            ptb_princ.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\ft01.jpg");
            ptb_prop01.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\prop01.jpg");
            ptb_prop02.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\prop02.jpg");
            ptb_prop03.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\prop03.jpg");
            ptb_logo.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\logo.jpg");
        }
    }

    
}
