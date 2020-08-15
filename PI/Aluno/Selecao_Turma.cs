using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PI
{
    public partial class Selecao_Turma : Form
    {
        
        controle control = new controle();
        Pessoa pess = new Pessoa();
        DataTable datT = new DataTable();
        int [] vetor = new int[100];
       
       
        public Selecao_Turma()
        {
            InitializeComponent();
        }
        public Selecao_Turma(Pessoa pessoa)
        {
            InitializeComponent();
            pess = pessoa;

        }

        private void Selecao_Turma_Load(object sender, EventArgs e)
        {
            pess.sel_query = 1;
            datT = control.pesquisa(pess);

            DataRow[] rows = datT.Select();
            pess.nome = rows[0]["nome"].ToString();
            lbl_Apr.Text = "Olá " + pess.nome + "!!! Selecione a turma para continuar.";
            for (int i = 0; i < rows.Length; i++)
            {
                cb_S_Turma.Items.Add(rows[i]["sigla"]);
                vetor[i] = Convert.ToInt32(rows[i]["id_turma"]) ;
             
            }
            pess.id_turma = vetor[0];
            pess.turma = rows[0]["sigla"].ToString();

            cb_S_Turma.SelectedIndex = 0;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pess.id_aluno = 0;
            Login frmLogin = new Login();
            this.Dispose();
            frmLogin.ShowDialog();
        }

        private void cb_S_Turma_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            pess.id_turma = vetor[Convert.ToInt32(cb_S_Turma.SelectedIndex)];
            pess.turma = cb_S_Turma.Text; 
          



        }

        private void bt_cont_Click(object sender, EventArgs e)
        {

            Menu frmMenu = new Menu(pess);
            this.Dispose();
         
            frmMenu.ShowDialog();
        }
    }
}
