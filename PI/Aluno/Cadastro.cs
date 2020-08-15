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
    
    public partial class Cadastro : Form
    {
        Pessoa pessoa = new Pessoa();
        controle control = new controle();
        DataTable datT = new DataTable();
        public Cadastro()
        {
            InitializeComponent();            
        }
       public Cadastro(Pessoa pess)
        {
            pessoa = pess;
            InitializeComponent();           
            
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            
            pb_prop.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\prop04.jpg");
            lbl_apre.Text = "BEM VINDO(A) "+ pessoa.nome + "!!! ";
            lbl_apre2.Text = " Seu cadastro já foi criado, siga os próximos passos para adquirir o de melhor da Vestatm e ser aprovado no vestibular. ";


            txt_nome.Text = pessoa.nome;
            txt_sobrenome.Text = pessoa.sobrenome;
            if (pessoa.sexo == "F")
            {
                rB_F.Checked = true;
            }
            else            
            {
                rB_M.Checked = true;
            }

            //ESTADOS
            pessoa.sel_query = 2;
            datT = control.pesquisa(pessoa);
            DataRow[] rows = datT.Select();
            for (int i = 0; i < rows.Length; i++)
            {             
                cb_est.Items.Add( rows[i]["nome"].ToString());
            }

        }

        private void bt_cont_Click(object sender, EventArgs e)
        {
            pessoa.nome = txt_nome.Text;
            pessoa.sobrenome = txt_sobrenome.Text;

            pessoa.d_nasc = mk_dat_n.Text;
            if (rB_M.Checked) { pessoa.sexo = "M"; }
            else { pessoa.sexo = "F"; }
            pessoa.rg = mk_rg.Text;
            pessoa.cpf = mk_cpf.Text;            
            pessoa.celular = mk_cel.Text;
            pessoa.Telefone = mk_tel.Text;      



            
            if (String.IsNullOrWhiteSpace(txt_nome.Text) || String.IsNullOrWhiteSpace(txt_sobrenome.Text) || rB_M.Checked == false && rB_F.Checked == false || String.IsNullOrWhiteSpace(mk_dat_n.Text) || String.IsNullOrWhiteSpace(mk_rg.Text) || String.IsNullOrWhiteSpace(mk_cpf.Text) || String.IsNullOrWhiteSpace(mk_tel.Text) || String.IsNullOrWhiteSpace(mk_cel.Text) || pessoa.estado == 0 || pessoa.id_login == 0 )
            {
                MessageBox.Show("Campos obrigatório.");
            }
            else
            {
                pessoa.nome = txt_nome.Text;
                pessoa.sobrenome = txt_sobrenome.Text;
                if (rB_M.Checked) { pessoa.sexo = "M"; }
                else { pessoa.sexo = "F"; }

                pessoa.sel_query = 3;
                pessoa = control.acessar(pessoa);
                if (pessoa.val == true)
                {

                    MessageBox.Show("Já temos este CPF em nossa base de dados, caso o erro persistir entre em contato por email", "CPF já cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    pessoa.sel_query = 2;

                    pessoa = control.cadastrar(pessoa);
                    if (pessoa.add1 == "sucesso")
                    {
                        MessageBox.Show("Cadastrado com sucesso", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Escolha_curso frm_Esc_Curso = new Escolha_curso(pessoa);
                        this.Dispose();
                        frm_Esc_Curso.ShowDialog();



                    }
                    else {
                        MessageBox.Show("Erro no cadastro", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                   
                    
        }

    
        }

        private void bt_can_Click(object sender, EventArgs e)
        {
           DialogResult resp = MessageBox.Show("Deseja cancelar o cadastro!? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
               
                pessoa.sel_query = 1;
                pessoa = control.deletar(pessoa);
                if (pessoa.val == true)
                {
                    Login frm_login = new Login();
                    this.Dispose();
                    frm_login.ShowDialog();

                }
                else 
                {
                    MessageBox.Show("Não houve conexão com a internet por favor conecte e tente novamente", "Não há conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cb_est_SelectedIndexChanged(object sender, EventArgs e)
        {
            pessoa.estado = (cb_est.SelectedIndex + 1);
        }
    }
}
