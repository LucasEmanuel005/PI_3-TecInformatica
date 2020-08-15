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
    public partial class Menu : Form
    {
       
        controle control = new controle();
        Pessoa pessoa = new Pessoa();
        DataTable datT = new DataTable();
        
       

        public Menu()
        {
            InitializeComponent();

        }
        public Menu(Pessoa pess)
        {
            InitializeComponent();
            pessoa = pess;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

            lbl_nome.Text = pessoa.nome;
            lbl_turma.Text = pessoa.turma;
            lbl_frase.Text = Convert.ToString(control.pesq_frase());

            pessoa.sel_query = 19;
            datT = control.pesquisa(pessoa);
            dg_Eventos.DataSource =  datT;
           
            pessoa.sel_query = 7;
            pessoa = control.acessar(pessoa);
            if (pessoa.val == true)
            {
               
                lbl_duv.Text = pessoa.duv;
                lbl_resp.Text = pessoa.resp;
                lbl_prof.Text = pessoa.professor;
            }
            else if (pessoa.val == false) 
            {
                lbl_duv.Text = "Nenhuma dúvida";
            }
            else if (pessoa.add1 == "erro")
            {
                lbl_duv.Text = "Houve erro. Verifique sua conexão com a Internet e tente novamente.";
            }

        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var resp = MessageBox.Show("Deseja sair", "Logoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                pessoa.id_aluno = 0;
                pessoa.id_turma = 0;
                lbl_nome.Text = null;

                Login frm_Login = new Login();
                this.Dispose();
                frm_Login.ShowDialog();
              
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sala formSala = new Sala();
            this.Dispose();
            formSala.ShowDialog();
        }



    
        private void vídeosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Videos frm_Video = new Videos(pessoa);
            this.Dispose();
            frm_Video.ShowDialog();
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pdfs frm_pdf = new Pdfs(pessoa);
            this.Dispose();
            frm_pdf.ShowDialog();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Livros frm_livro = new Livros(pessoa);
            this.Dispose();
            frm_livro.ShowDialog();
        }

        private void bancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pessoa.add1 = "banca";
            Exames frm_Exames = new Exames(pessoa);
            this.Dispose();
            frm_Exames.ShowDialog();
        }

        private void aprimoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pessoa.add1 = "aprimoramento";
            Exames frm_Exames = new Exames(pessoa);
            this.Dispose();
            frm_Exames.ShowDialog();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exame_realizacao frm_exame_Realizacao = new Exame_realizacao(pessoa);
            this.Dispose();
            frm_exame_Realizacao.ShowDialog();
        }

        private void quemSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuemSomos frm_QuemSomos = new QuemSomos(pessoa);
            this.Dispose();
            frm_QuemSomos.ShowDialog();
        }

        private void históriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hist frm_hist = new hist(pessoa);
            this.Dispose();
            frm_hist.ShowDialog();
        }

        private void estruturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estrut frm_estrutura = new Estrut(pessoa);
            this.Dispose();
            frm_estrutura.ShowDialog();
        }

        private void doarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doar frm_doar = new Doar(pessoa);
            this.Dispose();
            frm_doar.ShowDialog();
        }

     
        private void faleConoscoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaleConosco frm_faleConosco = new FaleConosco(pessoa);
            this.Dispose();
            frm_faleConosco.ShowDialog();
        }

   

        private void fazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Duvida frm_duvida = new Duvida(pessoa);
            this.Dispose();
            frm_duvida.ShowDialog();
        }

        private void verTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DuvidaComp frm_duvidaComp = new DuvidaComp(pessoa);
            this.Dispose();
            frm_duvidaComp.ShowDialog();
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            Simulado frm_Simulado = new Simulado(pessoa);
            this.Dispose();
            frm_Simulado.ShowDialog();

        }

     
    }
}
