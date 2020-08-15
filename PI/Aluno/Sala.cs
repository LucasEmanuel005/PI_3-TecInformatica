using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class Sala : Form
    {
        Pessoa pessoa = new Pessoa();
        DataTable datT = new DataTable();
        controle control = new controle();
        int[] vetor = new int[100];
        
        public Sala()
        {
            InitializeComponent();
        }
        public Sala(Pessoa pess)
        {
            InitializeComponent();
            pessoa = pess;
        }

        private void Sala_Load(object sender, EventArgs e)
        {

            pessoa.sel_query = 8;
            pessoa.id_aluno = 1;
            pessoa.id_disciplina = 5;
            pessoa.id_turma = 3;
            datT = control.pesquisa(pessoa);

            DataRow[] rows = datT.Select();
           
            for (int i = 0; i < rows.Length; i++)
            {
                cb_prof.Items.Add(rows[i]["nome"]);
                vetor[i] = Convert.ToInt32(rows[i]["id_professor"]);
               
            }
           
            

        }
        private void bt_duv_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(rtxt_com.Text) || cb_prof.SelectedIndex < 0)
            {
                MessageBox.Show("Preciso que você escolha um professor e digite sua dúvida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                pessoa.sel_query = 1;
                pessoa.duv = rtxt_com.Text;
                pessoa = control.Insert_aula(pessoa);
                if (pessoa.add1 == "sucesso")
                {
                    MessageBox.Show("Sua dúvida foi registrada com sucesso.");
                }
                else
                {
                    MessageBox.Show("Houve um erro por favor tente denovo.");
                }
            }
        }

        private void cb_prof_SelectedIndexChanged(object sender, EventArgs e)
        {
            pessoa.id_prof = vetor[Convert.ToInt32(cb_prof.SelectedIndex)];
            pessoa.professor = cb_prof.Text;

        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            Menu frm_Menu = new Menu(pessoa);
            this.Dispose();
            frm_Menu.ShowDialog();
        }
      
    }
}
