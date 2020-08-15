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
    public partial class Escolha_curso : Form
    {
        
        controle control = new controle();
        Pessoa pess = new Pessoa();
        DataTable datT = new DataTable();
        int[] vetor = new int[100];
        int[] v_turma = new int[100];
        int[] v_preco = new int[100];
        int[] v_vaga = new int[100];

        public Escolha_curso()
        {
            InitializeComponent();
        }

        public Escolha_curso(Pessoa pessoa)
        {
            InitializeComponent();
            pess = pessoa;
        }
        private void Escolha_curso_Load(object sender, EventArgs e)
        {
            pb_fundo.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\ft_fundo14.png");
            lbl_vaga.Visible = false;
            lbl_preco.Visible = false;
            lbl_preco_desc.Visible = false;
            lbl_vaga_desc.Visible = false;


            pess.sel_query = 4;
            datT = control.pesquisa(pess);

            DataRow[] rows = datT.Select();


            for (int i = 0; i < rows.Length; i++)
            {
                cb_curso.Items.Add(rows[i]["nome"]);
                vetor[i] = Convert.ToInt32(rows[i]["id_curso"]);
  
            }
           
           
        }

        private void cb_curso_SelectedIndexChanged(object sender, EventArgs e)
        {

            pess.id_curso = vetor[Convert.ToInt32(cb_curso.SelectedIndex)];
            pess.curso = cb_curso.Text;
            lbl_vaga.Visible = false;
            lbl_preco.Visible = false;
            lbl_preco_desc.Visible = false;
            lbl_vaga_desc.Visible = false;
            cb_turma.Items.Clear();
            lbl_preco.Text = null;
            lbl_vaga.Text = null;

            pess.sel_query = 3;
           
            datT = control.pesquisa(pess);
            DataRow[] rows = datT.Select();
            for (int i = 0; i < rows.Length; i++)
            {
                cb_turma.Items.Add(rows[i]["sigla"]);
                v_turma[i] = Convert.ToInt32(rows[i]["id_turma"]);
                v_preco[i]= Convert.ToInt32(rows[i]["preco"]);
                v_vaga[i] = Convert.ToInt32(rows[i]["vaga"]);
              
            }

          

            pess.sel_query = 9;
            datT = control.pesquisa(pess);
            dg_disp.DataSource = datT;

            this.dg_disp.Columns["id_disciplina"].Visible = false;
            this.dg_disp.Columns["nome"].HeaderText = "Disciplina";
           

        }

        private void cb_turma_SelectedIndexChanged(object sender, EventArgs e)
        {
            pess.id_turma = v_turma[Convert.ToInt32(cb_turma.SelectedIndex)];
            lbl_preco.Text = Convert.ToString(v_preco[Convert.ToInt32(cb_turma.SelectedIndex)]);
            lbl_vaga.Text = Convert.ToString(v_vaga[Convert.ToInt32(cb_turma.SelectedIndex)]);
            pess.turma = cb_turma.Text;


            if (cb_curso.Text != "ENSINO MEDIO")
            {
                lbl_vaga.Visible = true;
                lbl_preco.Visible = true;
                lbl_preco_desc.Visible = true;
                lbl_vaga_desc.Visible = true;
            }            
        }

        private void bt_cont_Click(object sender, EventArgs e)
        {
            if (pess.id_turma < 1 || pess.id_turma < 1)
            {
                MessageBox.Show("Por favor! Selecione um curso e uma turma para concluir sua matrícula");
            }
            else 
            { 
                //CRIACAO DA MATRICULA
                DateTime data = DateTime.Now;
                pess.date = data;

                pess.sel_query = 3;
                pess = control.cadastrar(pess);
                if (pess.add1 == "sucesso")
                {
                    if (pess.id_turma != 4)
                    {
                        MessageBox.Show("Forma de pagamento");
                    }

                    Menu frm_Menu = new Menu(pess);
                    this.Dispose();
                    frm_Menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não foi possível completar sua matricula. Verifique sua conexão com a internet. Se o erro persistir entre em contato conosco pelo email contato@vestatm.com.br");
                }
            }
                        
       
        }

        private void dg_disp_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            pess.sel_query = 10;
            
            if (e.RowIndex > -1)
            {
              pess.id_disciplina = Convert.ToInt32( dg_disp.Rows[e.RowIndex].Cells[1].Value.ToString());
               
            }

            datT = control.pesquisa(pess);
            dg_cont.DataSource = datT;
            dg_cont.Columns["h_total"].HeaderText = "Hora total (h)";
            dg_cont.Columns["nome"].HeaderText = "Conteúdo";

        }
    }
}
