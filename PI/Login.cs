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
    public partial class Login : Form
    {
        controle control = new controle();
        Pessoa pessoa = new Pessoa();
        Validacao val_cad = new Validacao();
        public Login()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txt_email.Text) || String.IsNullOrWhiteSpace(txt_senha.Text))
            {
                MessageBox.Show("Campos obrigatórios", "Digite os dados para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pessoa.email = txt_email.Text;
                pessoa.senha = txt_senha.Text;
                
                
                pessoa.sel_query = 1;
                pessoa = control.acessar(pessoa);
                //VERIFICACAO SE HÁ LOGIN, CONEXAO
                if (pessoa.val == true)
                {
                    //IDENTIFICAO PROF ALUNO
                    if (pessoa.id_ident == 1)
                    {
                        Menu_Prof formMenu = new Menu_Prof(pessoa);
                        txt_email.Text = null;
                        txt_senha.Text = null;
                        this.Dispose();
                        formMenu.ShowDialog();

                    }
                    else
                    {
                        Selecao_Turma frm_s_turm = new Selecao_Turma(pessoa);
                        txt_email.Text = null;
                        txt_senha.Text = null;

                        this.Dispose();
                        frm_s_turm.ShowDialog();


                    }

                }
                else if (pessoa.val == false)
                {
                    MessageBox.Show("Usuário não encontrado!");
                }
                else if (pessoa.add1 == "erro")
                {
                    MessageBox.Show("Não houve conexão com a internet por favor conecte e tente novamente", "Não há conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }





        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void Login_Load_1(object sender, EventArgs e)
        {
            ptb_comp.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\foto_Comp.jpg");
            ptb_prop.Image = Image.FromFile(@"F:\Estudos\Cursos_P\Tecnico_Informatica\SENAC_TI\Software\PI\Fotos\prop01.jpg");
        }

        private void bt_cadastrar_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_nome.Text) || String.IsNullOrWhiteSpace(txt_sobrenome.Text) || rB_M.Checked == false && rB_F.Checked == false || String.IsNullOrWhiteSpace(txt_senha_cad.Text) || String.IsNullOrWhiteSpace(txt_conf_senha_cad.Text))
            {
                MessageBox.Show("Campos obrigatório");
            }
            else
            {
                pessoa.nome = txt_nome.Text;
                pessoa.sobrenome = txt_sobrenome.Text;
                if (rB_M.Checked) { pessoa.sexo = "M"; }
                else { pessoa.sexo = "F"; }
                if (val_cad.email(txt_email_cad.Text) == true)
                {
                    pessoa.email = txt_email_cad.Text;                   
                    if (txt_conf_senha_cad.Text == txt_senha_cad.Text)
                    {
                        pessoa.senha = txt_senha_cad.Text;
                        //IDENTIFICADOR DE PROF ALUNO (1 PROF / 2 ALUNO)
                        pessoa.id_ident = 2;
                        //IDENTIFICADOR DE QUERY
                        pessoa.sel_query = 2;
                        pessoa = control.acessar(pessoa);
                       

                        if (pessoa.val == true)
                        {
                            MessageBox.Show("Email já cadastrado digite outro por favor e caso tenha esquecido a senha escolha 'Esqueci a senha'", "Email já existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            pessoa.sel_query = 1;
                            pessoa = control.cadastrar(pessoa);

                            
                            if (pessoa.add1 == "sucesso")
                            {
                                Cadastro frm_cadastro = new Cadastro(pessoa);
                                this.Dispose();
                                frm_cadastro.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Não houve conexão com a internet por favor conecte e tente novamente", "Não há conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Senhas incorretas", "Senhas incorretas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Digite um email válido");
                }



            }

         
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            FormProp frm_Prop = new FormProp();
            this.Dispose();            
            frm_Prop.ShowDialog();
        }

        private void llbl_esq_senha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Esq_Senha form_Esq_senha = new Esq_Senha();
            this.Dispose();
            form_Esq_senha.ShowDialog();
        }
    }
}

