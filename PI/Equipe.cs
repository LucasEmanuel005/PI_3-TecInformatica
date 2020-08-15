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
    public partial class Equipe : Form
    {
        Pessoa pessoa = new Pessoa();
        public Equipe()
        {
            InitializeComponent();
        }
        public Equipe(Pessoa pess)
        {
            InitializeComponent();
            pessoa = pess;
        }

        private void Equipe_Load(object sender, EventArgs e)
        {
            
        }
    }
}
