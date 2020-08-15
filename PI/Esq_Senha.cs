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
    public partial class Esq_Senha : Form
    {
        Pessoa pessoa = new Pessoa();
        controle control = new controle();

        public Esq_Senha()
        {
            InitializeComponent();
        }

        private void bt_Rec_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Campos obrigatórios", "Digite os dados para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pessoa.email = txt_email.Text;               
                pessoa.sel_query = 5;
                pessoa = control.acessar(pessoa);

                if (pessoa.val == true)
                {
                    lbl_cod.Visible = true;
                    txt_cod.Visible = true;
                   

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

        private void txt_cod_TextChanged(object sender, EventArgs e)
        {
            lbl_msg_erro.Visible = false;
            lbl_senha.Visible = false;
            lbl_conf_senha.Visible = false;
            txt_senha.Visible = false;
            txt_conf_senha.Visible = false;
            bt_cad.Visible = false;
            //VALIDACAO CODIGO ENVIADO PARA EMAIL       


            
            if (txt_cod.Text.Length > 5)
            {
                pessoa.sel_query = 6;
                pessoa = control.acessar(pessoa);
                if (txt_cod.Text == pessoa.cod_verificacao)
                {
                    lbl_senha.Visible = true;
                    lbl_conf_senha.Visible = true;
                    txt_senha.Visible = true;
                    txt_conf_senha.Visible = true;
                    bt_cad.Visible = true;
                    txt_email.Enabled = false;

                }
                else
                {
                    lbl_msg_erro.Visible = true;

                }
            }


        }

        private void bt_cad_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_senha.Text)||String.IsNullOrWhiteSpace(txt_conf_senha.Text))
            {
                MessageBox.Show("Campos obrigatórios", "Digite os dados para continuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //  VALIDAR SENHAS 
                if (txt_senha.Text == txt_conf_senha.Text)
                {
                    pessoa.senha = txt_senha.Text;

                    //CADASTRAMENTO DE NOVA SENHA
                    pessoa.sel_query = 1;
                    pessoa = control.Update(pessoa);
                   
                    if (pessoa.add1 == "sucesso")
                    {
                        MessageBox.Show("Sua senha foi atualizada com sucesso!");

                        txt_senha.Text = null;
                        txt_conf_senha.Text = null;
                        txt_email.Text = null;
                        txt_cod.Text = null;


                        //FORMULARIO LOGIN
                        Login frm_login = new Login();
                        this.Dispose();
                        frm_login.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar sua senha. Tente mais tarde se o erro persistir entre em contato conosco pelo email contato@vestatm.com.br");
                    }


                }
                else
                {
                    MessageBox.Show("As senha não estão iguais!");
                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_email.Text = null;
            txt_cod.Text = null;
            txt_senha.Text = null;
            txt_conf_senha = null;

            Login frm_Login = new Login();
            this.Dispose();
            frm_Login.ShowDialog();

        }
    }
}
