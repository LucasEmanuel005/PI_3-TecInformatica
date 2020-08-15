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
    public partial class Livros : Form
    {

        controle control = new controle();
        Pessoa pessoa = new Pessoa();
        DataTable datT = new DataTable();
        int[] vetor = new int[100];
        int[] v_turma = new int[100];
        public Livros()
        {
            InitializeComponent();
        }
        public Livros(Pessoa pess)
        {
            InitializeComponent();
            pessoa = pess;
        }

        private void Pdfs_Load(object sender, EventArgs e)
        {

            pessoa.sel_query = 5;
            datT = control.pesquisa(pessoa);

            DataRow[] rows = datT.Select();


            for (int i = 0; i < rows.Length; i++)
            {
                cb_dis.Items.Add(rows[i]["nome"]);
                vetor[i] = Convert.ToInt32(rows[i]["id_disciplina"]);
               
            }


            lbl_Pesq.Visible = false;
            txt_pesq.Visible = false;


        }

        private void cb_dis_SelectedIndexChanged(object sender, EventArgs e)
        {
            pessoa.id_disciplina = vetor[Convert.ToInt32(cb_dis.SelectedIndex)];
            pessoa.sel_query = 6;
            dg_conteudo.DataSource = control.pesquisa(pessoa);
            dg_conteudo.Columns[0].Visible = false;
            dg_conteudo.Columns[4].Visible = false;
            dg_conteudo.Columns[5].Visible = false;
            dg_conteudo.Columns[1].HeaderText = "Conteúdo";
            dg_conteudo.Columns[2].HeaderText = "Quantidade de exercícios";
            dg_conteudo.Columns[3].HeaderText = "Hora total";
            

           
            if (cb_dis.SelectedIndex != -1)
            {
                lbl_Pesq.Visible = true;
                txt_pesq.Visible = true;

            }

        }

        private void bt_Menu_Click(object sender, EventArgs e)
        {
            Menu frm_Menu = new Menu(pessoa);
            this.Dispose();
            frm_Menu.ShowDialog();
        }

        private void dg_conteudo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_pesq_TextChanged(object sender, EventArgs e)
        {
            pessoa.add2 = txt_pesq.Text;
            pessoa.sel_query = 7;
            dg_conteudo.DataSource = control.pesquisa(pessoa);
        }

        private void dg_conteudo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
