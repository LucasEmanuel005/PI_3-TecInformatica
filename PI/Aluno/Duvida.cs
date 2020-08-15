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
    public partial class Duvida : Form
    {
        Pessoa pessoa = new Pessoa();
        controle control = new controle();
        DataTable datT = new DataTable();
        int[] vnProf = new int[100];


        public Duvida()
        {
            InitializeComponent();
        }
        public Duvida(Pessoa pess)
        {
            InitializeComponent();
            pessoa = pess;
        }
      
        private void Duvida_Load(object sender, EventArgs e)
        {
            pessoa.sel_query = 11;
            datT = control.pesquisa(pessoa);

            DataRow[] rows = datT.Select();

            for (int i = 0; i < rows.Length; i++)
            {
                cb_professor.Items.Add(rows[i]["nome"]);
                vnProf[i] = Convert.ToInt32(rows[i]["id_professor"]);              
            }
            cb_professor.SelectedIndex = -1;

        }


        private void bt_enviar_Click(object sender, EventArgs e)
        {
          
            
            //VERIFICACAO P CADASTRAMENTO
            pessoa.duv = rtxt_duv.Text; 
            if (String.IsNullOrWhiteSpace(rtxt_duv.Text) || cb_professor.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o professor e digite sua dúvida.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //CADASTRANDO DUVIDA
                pessoa.date = DateTime.Now;
                pessoa.sel_query = 1;
                pessoa = control.Insert_aula(pessoa);

                if (pessoa.add1 == "sucesso")
                {
                    MessageBox.Show("Sua dúvida foi cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pessoa.id_prof = -1;
                    rtxt_duv.Clear();
                    pessoa.duv = null;

                    Menu frmMenu = new Menu(pessoa);
                    this.Dispose();
                    frmMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Erro. Verifique sua conexão com a internet e tente novamente se o erro persistir entre em contato conosco pelo email contato@vestatm.com.br", "Falha na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }



        }

        private void cb_professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            pessoa.id_prof = vnProf[Convert.ToInt32(cb_professor.SelectedIndex)];
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            pessoa.id_prof = -1;
            rtxt_duv.Clear();
            pessoa.duv = null;
            Menu frmMenu = new Menu(pessoa);
            this.Dispose();            
            frmMenu.ShowDialog();
        }
    }
}
