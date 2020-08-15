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
    public partial class Aulas_Dia : Form
    {
        public Aulas_Dia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu formMenu = new Menu();
            this.Dispose();
            formMenu.ShowDialog();
        }
    }
}
