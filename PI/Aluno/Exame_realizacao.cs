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
    public partial class Exame_realizacao : Form
    {
        controle control = new controle();
        Pessoa pessoa = new Pessoa();
        DataTable datT = new DataTable();
        String[] vresp = new String[20];
        int vresp_alu = 0;
        int temp;
        public Exame_realizacao()
        {
            InitializeComponent();
        }
        public Exame_realizacao(Pessoa pess)
        {
            InitializeComponent();
            pessoa = pess;
        }

        private void Exame_realizacao_Load(object sender, EventArgs e)
        {
            precquestoes(1);
            timer1.Start();
            timer1.Tick += Timer1_Tick; ;
            


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            temp++;
            lbl_Duracao.Text = temp.ToString() + "s";
        }

        
        private void bt_Enviar_Click(object sender, EventArgs e)
        {
            vresp_alu = 0;

            //Retorna a qtd de acerto
            ContAcer();
          

            pessoa.duracao = temp;
            pessoa.qtd_questao_correta = vresp_alu;
           
            var resp = MessageBox.Show("Deseja enviar?", "enviar", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == resp)
            {
                pessoa.sel_query = 4;
                pessoa = control.cadastrar(pessoa);                
                if (pessoa.add1 == "sucesso")
                {
                    MessageBox.Show("Simulado concluído com sucesso", "enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu frm_Menu = new Menu(pessoa);
                    this.Dispose();
                    frm_Menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Houve um erro tente de novo", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("Deseja cancelar?", "Cancelar", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == resp)
            {
                Menu frm_Menu = new Menu(pessoa);
                this.Dispose();
                frm_Menu.ShowDialog();
            }
        }


        private void precquestoes(int simulado)
        {
            pessoa.id_sim = simulado;
            pessoa.sel_query = 17;
            datT = control.pesquisa(pessoa);



            DataRow[] rows = datT.Select();

            lbl_Q1.Text = "1 - " + rows[0]["enunciado"].ToString();
            radioButton1.Text = rows[0]["alternativa1"].ToString();
            radioButton2.Text = rows[0]["alternativa2"].ToString();
            radioButton3.Text = rows[0]["alternativa3"].ToString();
            radioButton4.Text = rows[0]["alternativa4"].ToString();
            radioButton5.Text = rows[0]["alternativa5"].ToString();
            vresp[0] = rows[0]["resposta"].ToString();

            lbl_Q2.Text = "2 - " + rows[1]["enunciado"].ToString();
            radioButton6.Text = rows[1]["alternativa1"].ToString();
            radioButton7.Text = rows[1]["alternativa2"].ToString();
            radioButton8.Text = rows[1]["alternativa3"].ToString();
            radioButton9.Text = rows[1]["alternativa4"].ToString();
            radioButton10.Text = rows[1]["alternativa5"].ToString();
            vresp[1] = rows[1]["resposta"].ToString();

            lbl_Q3.Text = "3 - " + rows[2]["enunciado"].ToString();
            radioButton11.Text = rows[2]["alternativa1"].ToString();
            radioButton12.Text = rows[2]["alternativa2"].ToString();
            radioButton13.Text = rows[2]["alternativa3"].ToString();
            radioButton14.Text = rows[2]["alternativa4"].ToString();
            radioButton15.Text = rows[2]["alternativa5"].ToString();
            vresp[2] = rows[2]["resposta"].ToString();

            lbl_Q4.Text = "4 - " + rows[3]["enunciado"].ToString();
            radioButton16.Text = rows[3]["alternativa1"].ToString();
            radioButton17.Text = rows[3]["alternativa2"].ToString();
            radioButton18.Text = rows[3]["alternativa3"].ToString();
            radioButton19.Text = rows[3]["alternativa4"].ToString();
            radioButton20.Text = rows[3]["alternativa5"].ToString();
            vresp[3] = rows[3]["resposta"].ToString();

            lbl_Q5.Text = "5 - " + rows[4]["enunciado"].ToString();
            radioButton21.Text = rows[4]["alternativa1"].ToString();
            radioButton22.Text = rows[4]["alternativa2"].ToString();
            radioButton23.Text = rows[4]["alternativa3"].ToString();
            radioButton24.Text = rows[4]["alternativa4"].ToString();
            radioButton25.Text = rows[4]["alternativa5"].ToString();
            vresp[4] = rows[4]["resposta"].ToString();

            lbl_Q6.Text = "6 - " + rows[5]["enunciado"].ToString();
            radioButton26.Text = rows[5]["alternativa1"].ToString();
            radioButton27.Text = rows[5]["alternativa2"].ToString();
            radioButton28.Text = rows[5]["alternativa3"].ToString();
            radioButton29.Text = rows[5]["alternativa4"].ToString();
            radioButton30.Text = rows[5]["alternativa5"].ToString();
            vresp[5] = rows[5]["resposta"].ToString();

            lbl_Q7.Text = "7 - " + rows[6]["enunciado"].ToString();
            radioButton31.Text = rows[6]["alternativa1"].ToString();
            radioButton32.Text = rows[6]["alternativa2"].ToString();
            radioButton33.Text = rows[6]["alternativa3"].ToString();
            radioButton34.Text = rows[6]["alternativa4"].ToString();
            radioButton35.Text = rows[6]["alternativa5"].ToString();
            vresp[6] = rows[6]["resposta"].ToString();

            lbl_Q8.Text = "8 - " + rows[7]["enunciado"].ToString();
            radioButton36.Text = rows[7]["alternativa1"].ToString();
            radioButton37.Text = rows[7]["alternativa2"].ToString();
            radioButton38.Text = rows[7]["alternativa3"].ToString();
            radioButton39.Text = rows[7]["alternativa4"].ToString();
            radioButton40.Text = rows[7]["alternativa5"].ToString();
            vresp[7] = rows[7]["resposta"].ToString();

            lbl_Q9.Text = "9 - " + rows[8]["enunciado"].ToString();
            radioButton41.Text = rows[8]["alternativa1"].ToString();
            radioButton42.Text = rows[8]["alternativa2"].ToString();
            radioButton43.Text = rows[8]["alternativa3"].ToString();
            radioButton44.Text = rows[8]["alternativa4"].ToString();
            radioButton45.Text = rows[8]["alternativa5"].ToString();
            vresp[8] = rows[8]["resposta"].ToString();


            lbl_Q10.Text = "10 - " + rows[9]["enunciado"].ToString();
            radioButton46.Text = rows[9]["alternativa1"].ToString();
            radioButton47.Text = rows[9]["alternativa2"].ToString();
            radioButton48.Text = rows[9]["alternativa3"].ToString();
            radioButton49.Text = rows[9]["alternativa4"].ToString();
            radioButton50.Text = rows[9]["alternativa5"].ToString();
            vresp[9] = rows[9]["resposta"].ToString();

            lbl_Q11.Text = "11 - " + rows[10]["enunciado"].ToString();
            radioButton51.Text = rows[10]["alternativa1"].ToString();
            radioButton52.Text = rows[10]["alternativa2"].ToString();
            radioButton53.Text = rows[10]["alternativa3"].ToString();
            radioButton54.Text = rows[10]["alternativa4"].ToString();
            radioButton55.Text = rows[10]["alternativa5"].ToString();
            vresp[10] = rows[10]["resposta"].ToString();

            lbl_Q12.Text = "12 - " + rows[11]["enunciado"].ToString();
            radioButton56.Text = rows[11]["alternativa1"].ToString();
            radioButton57.Text = rows[11]["alternativa2"].ToString();
            radioButton58.Text = rows[11]["alternativa3"].ToString();
            radioButton59.Text = rows[11]["alternativa4"].ToString();
            radioButton60.Text = rows[11]["alternativa5"].ToString();
            vresp[11] = rows[11]["resposta"].ToString();

            lbl_Q13.Text = "13 - " + rows[12]["enunciado"].ToString();
            radioButton61.Text = rows[12]["alternativa1"].ToString();
            radioButton62.Text = rows[12]["alternativa2"].ToString();
            radioButton63.Text = rows[12]["alternativa3"].ToString();
            radioButton64.Text = rows[12]["alternativa4"].ToString();
            radioButton65.Text = rows[12]["alternativa5"].ToString();
            vresp[12] = rows[12]["resposta"].ToString();

            lbl_Q14.Text = "14 - " + rows[13]["enunciado"].ToString();
            radioButton66.Text = rows[13]["alternativa1"].ToString();
            radioButton67.Text = rows[13]["alternativa2"].ToString();
            radioButton68.Text = rows[13]["alternativa3"].ToString();
            radioButton69.Text = rows[13]["alternativa4"].ToString();
            radioButton70.Text = rows[13]["alternativa5"].ToString();
            vresp[13] = rows[13]["resposta"].ToString();

            lbl_Q15.Text = "15 - " + rows[14]["enunciado"].ToString();
            radioButton71.Text = rows[14]["alternativa1"].ToString();
            radioButton72.Text = rows[14]["alternativa2"].ToString();
            radioButton73.Text = rows[14]["alternativa3"].ToString();
            radioButton74.Text = rows[14]["alternativa4"].ToString();
            radioButton75.Text = rows[14]["alternativa5"].ToString();
            vresp[14] = rows[14]["resposta"].ToString();

            lbl_Q16.Text = "16 - " + rows[15]["enunciado"].ToString();
            radioButton76.Text = rows[15]["alternativa1"].ToString();
            radioButton77.Text = rows[15]["alternativa2"].ToString();
            radioButton78.Text = rows[15]["alternativa3"].ToString();
            radioButton79.Text = rows[15]["alternativa4"].ToString();
            radioButton80.Text = rows[15]["alternativa5"].ToString();
            vresp[15] = rows[15]["resposta"].ToString();

            lbl_Q17.Text = "17 - " + rows[16]["enunciado"].ToString();
            radioButton81.Text = rows[16]["alternativa1"].ToString();
            radioButton82.Text = rows[16]["alternativa2"].ToString();
            radioButton83.Text = rows[16]["alternativa3"].ToString();
            radioButton84.Text = rows[16]["alternativa4"].ToString();
            radioButton85.Text = rows[16]["alternativa5"].ToString();
            vresp[16] = rows[16]["resposta"].ToString();

            lbl_Q18.Text = "18 - " + rows[17]["enunciado"].ToString();
            radioButton86.Text = rows[17]["alternativa1"].ToString();
            radioButton87.Text = rows[17]["alternativa2"].ToString();
            radioButton88.Text = rows[17]["alternativa3"].ToString();
            radioButton89.Text = rows[17]["alternativa4"].ToString();
            radioButton90.Text = rows[17]["alternativa5"].ToString();
            vresp[17] = rows[17]["resposta"].ToString();

            lbl_Q19.Text = "19 - " + rows[18]["enunciado"].ToString();
            radioButton91.Text = rows[18]["alternativa1"].ToString();
            radioButton92.Text = rows[18]["alternativa2"].ToString();
            radioButton93.Text = rows[18]["alternativa3"].ToString();
            radioButton94.Text = rows[18]["alternativa4"].ToString();
            radioButton95.Text = rows[18]["alternativa5"].ToString();
            vresp[18] = rows[18]["resposta"].ToString();

            lbl_Q20.Text = "20 - " + rows[19]["enunciado"].ToString();
            radioButton96.Text = rows[19]["alternativa1"].ToString();
            radioButton97.Text = rows[19]["alternativa2"].ToString();
            radioButton98.Text = rows[19]["alternativa3"].ToString();
            radioButton99.Text = rows[19]["alternativa4"].ToString();
            radioButton100.Text = rows[19]["alternativa5"].ToString();
            vresp[19] = rows[19]["resposta"].ToString();





        }

        private void ContAcer()
        {
            if (radioButton1.Checked == true && radioButton1.Text == vresp[0])
            { vresp_alu++; }

            if (radioButton2.Checked == true && radioButton2.Text == vresp[0])
            { vresp_alu++; }

            if (radioButton3.Checked == true && radioButton3.Text == vresp[0])
            { vresp_alu++; }

            if (radioButton4.Checked == true && radioButton4.Text == vresp[0])
            { vresp_alu++; }

            if (radioButton5.Checked == true && radioButton5.Text == vresp[0])
            { vresp_alu++; }






            if (radioButton6.Checked == true && radioButton6.Text == vresp[1])
            { vresp_alu++; }

            if (radioButton7.Checked == true && radioButton7.Text == vresp[1])
            { vresp_alu++; }

            if (radioButton8.Checked == true && radioButton8.Text == vresp[1])
            { vresp_alu++; }

            if (radioButton9.Checked == true && radioButton9.Text == vresp[1])
            { vresp_alu++; }

            if (radioButton10.Checked == true && radioButton10.Text == vresp[1])
            { vresp_alu++; }



            if (radioButton11.Checked == true && radioButton11.Text == vresp[2])
            { vresp_alu++; }

            if (radioButton12.Checked == true && radioButton12.Text == vresp[2])
            { vresp_alu++; }

            if (radioButton13.Checked == true && radioButton13.Text == vresp[2])
            { vresp_alu++; }

            if (radioButton14.Checked == true && radioButton14.Text == vresp[2])
            { vresp_alu++; }

            if (radioButton15.Checked == true && radioButton15.Text == vresp[2])
            { vresp_alu++; }







            if (radioButton16.Checked == true && radioButton16.Text == vresp[3])
            { vresp_alu++; }

            if (radioButton17.Checked == true && radioButton17.Text == vresp[3])
            { vresp_alu++; }

            if (radioButton18.Checked == true && radioButton18.Text == vresp[3])
            { vresp_alu++; }

            if (radioButton19.Checked == true && radioButton19.Text == vresp[3])
            { vresp_alu++; }

            if (radioButton20.Checked == true && radioButton20.Text == vresp[3])
            { vresp_alu++; }









            if (radioButton21.Checked == true && radioButton21.Text == vresp[4])
            { vresp_alu++; }

            if (radioButton22.Checked == true && radioButton22.Text == vresp[4])
            { vresp_alu++; }

            if (radioButton23.Checked == true && radioButton23.Text == vresp[4])
            { vresp_alu++; }

            if (radioButton24.Checked == true && radioButton24.Text == vresp[4])
            { vresp_alu++; }

            if (radioButton25.Checked == true && radioButton25.Text == vresp[4])
            { vresp_alu++; }








            if (radioButton26.Checked == true && radioButton26.Text == vresp[5])
            { vresp_alu++; }

            if (radioButton27.Checked == true && radioButton27.Text == vresp[5])
            { vresp_alu++; }

            if (radioButton28.Checked == true && radioButton28.Text == vresp[5])
            { vresp_alu++; }

            if (radioButton29.Checked == true && radioButton29.Text == vresp[5])
            { vresp_alu++; }

            if (radioButton30.Checked == true && radioButton30.Text == vresp[5])
            { vresp_alu++; }














            if (radioButton31.Checked == true && radioButton31.Text == vresp[6])
            { vresp_alu++; }

            if (radioButton32.Checked == true && radioButton32.Text == vresp[6])
            { vresp_alu++; }

            if (radioButton33.Checked == true && radioButton33.Text == vresp[6])
            { vresp_alu++; }

            if (radioButton34.Checked == true && radioButton34.Text == vresp[6])
            { vresp_alu++; }

            if (radioButton35.Checked == true && radioButton35.Text == vresp[6])
            { vresp_alu++; }








            if (radioButton36.Checked == true && radioButton36.Text == vresp[7])
            { vresp_alu++; }

            if (radioButton37.Checked == true && radioButton37.Text == vresp[7])
            { vresp_alu++; }

            if (radioButton38.Checked == true && radioButton38.Text == vresp[7])
            { vresp_alu++; }

            if (radioButton39.Checked == true && radioButton39.Text == vresp[7])
            { vresp_alu++; }

            if (radioButton40.Checked == true && radioButton40.Text == vresp[7])
            { vresp_alu++; }















            if (radioButton41.Checked == true && radioButton41.Text == vresp[8])
            { vresp_alu++; }

            if (radioButton42.Checked == true && radioButton42.Text == vresp[8])
            { vresp_alu++; }

            if (radioButton43.Checked == true && radioButton43.Text == vresp[8])
            { vresp_alu++; }

            if (radioButton44.Checked == true && radioButton44.Text == vresp[8])
            { vresp_alu++; }

            if (radioButton45.Checked == true && radioButton45.Text == vresp[8])
            { vresp_alu++; }








            if (radioButton46.Checked == true && radioButton46.Text == vresp[9])
            { vresp_alu++; }

            if (radioButton47.Checked == true && radioButton47.Text == vresp[9])
            { vresp_alu++; }

            if (radioButton48.Checked == true && radioButton48.Text == vresp[9])
            { vresp_alu++; }

            if (radioButton49.Checked == true && radioButton49.Text == vresp[9])
            { vresp_alu++; }

            if (radioButton50.Checked == true && radioButton50.Text == vresp[9])
            { vresp_alu++; }















            if (radioButton51.Checked == true && radioButton51.Text == vresp[10])
            { vresp_alu++; }

            if (radioButton52.Checked == true && radioButton52.Text == vresp[10])
            { vresp_alu++; }

            if (radioButton53.Checked == true && radioButton53.Text == vresp[10])
            { vresp_alu++; }

            if (radioButton54.Checked == true && radioButton54.Text == vresp[10])
            { vresp_alu++; }

            if (radioButton55.Checked == true && radioButton55.Text == vresp[10])
            { vresp_alu++; }








            if (radioButton56.Checked == true && radioButton56.Text == vresp[11])
            { vresp_alu++; }

            if (radioButton57.Checked == true && radioButton57.Text == vresp[11])
            { vresp_alu++; }

            if (radioButton58.Checked == true && radioButton58.Text == vresp[11])
            { vresp_alu++; }

            if (radioButton59.Checked == true && radioButton59.Text == vresp[11])
            { vresp_alu++; }

            if (radioButton60.Checked == true && radioButton60.Text == vresp[11])
            { vresp_alu++; }
















            if (radioButton61.Checked == true && radioButton61.Text == vresp[12])
            { vresp_alu++; }

            if (radioButton62.Checked == true && radioButton62.Text == vresp[12])
            { vresp_alu++; }

            if (radioButton63.Checked == true && radioButton63.Text == vresp[12])
            { vresp_alu++; }

            if (radioButton64.Checked == true && radioButton64.Text == vresp[12])
            { vresp_alu++; }

            if (radioButton65.Checked == true && radioButton65.Text == vresp[12])
            { vresp_alu++; }








            if (radioButton66.Checked == true && radioButton66.Text == vresp[13])
            { vresp_alu++; }

            if (radioButton67.Checked == true && radioButton67.Text == vresp[13])
            { vresp_alu++; }

            if (radioButton68.Checked == true && radioButton68.Text == vresp[13])
            { vresp_alu++; }

            if (radioButton69.Checked == true && radioButton69.Text == vresp[13])
            { vresp_alu++; }

            if (radioButton70.Checked == true && radioButton70.Text == vresp[13])
            { vresp_alu++; }


















            if (radioButton71.Checked == true && radioButton71.Text == vresp[14])
            { vresp_alu++; }

            if (radioButton72.Checked == true && radioButton72.Text == vresp[14])
            { vresp_alu++; }

            if (radioButton73.Checked == true && radioButton73.Text == vresp[14])
            { vresp_alu++; }

            if (radioButton74.Checked == true && radioButton74.Text == vresp[14])
            { vresp_alu++; }

            if (radioButton75.Checked == true && radioButton75.Text == vresp[14])
            { vresp_alu++; }








            if (radioButton76.Checked == true && radioButton76.Text == vresp[15])
            { vresp_alu++; }

            if (radioButton77.Checked == true && radioButton77.Text == vresp[15])
            { vresp_alu++; }

            if (radioButton78.Checked == true && radioButton78.Text == vresp[15])
            { vresp_alu++; }

            if (radioButton79.Checked == true && radioButton79.Text == vresp[15])
            { vresp_alu++; }

            if (radioButton80.Checked == true && radioButton80.Text == vresp[15])
            { vresp_alu++; }
















            if (radioButton81.Checked == true && radioButton81.Text == vresp[16])
            { vresp_alu++; }

            if (radioButton82.Checked == true && radioButton82.Text == vresp[16])
            { vresp_alu++; }

            if (radioButton83.Checked == true && radioButton83.Text == vresp[16])
            { vresp_alu++; }

            if (radioButton84.Checked == true && radioButton84.Text == vresp[16])
            { vresp_alu++; }

            if (radioButton85.Checked == true && radioButton85.Text == vresp[16])
            { vresp_alu++; }








            if (radioButton86.Checked == true && radioButton86.Text == vresp[17])
            { vresp_alu++; }

            if (radioButton87.Checked == true && radioButton87.Text == vresp[17])
            { vresp_alu++; }

            if (radioButton88.Checked == true && radioButton88.Text == vresp[17])
            { vresp_alu++; }

            if (radioButton89.Checked == true && radioButton89.Text == vresp[17])
            { vresp_alu++; }

            if (radioButton90.Checked == true && radioButton90.Text == vresp[17])
            { vresp_alu++; }

















            if (radioButton91.Checked == true && radioButton91.Text == vresp[18])
            { vresp_alu++; }

            if (radioButton92.Checked == true && radioButton92.Text == vresp[18])
            { vresp_alu++; }

            if (radioButton93.Checked == true && radioButton93.Text == vresp[18])
            { vresp_alu++; }

            if (radioButton94.Checked == true && radioButton94.Text == vresp[18])
            { vresp_alu++; }

            if (radioButton95.Checked == true && radioButton95.Text == vresp[18])
            { vresp_alu++; }








            if (radioButton96.Checked == true && radioButton96.Text == vresp[19])
            { vresp_alu++; }

            if (radioButton97.Checked == true && radioButton97.Text == vresp[19])
            { vresp_alu++; }

            if (radioButton98.Checked == true && radioButton98.Text == vresp[19])
            { vresp_alu++; }

            if (radioButton99.Checked == true && radioButton99.Text == vresp[19])
            { vresp_alu++; }

            if (radioButton100.Checked == true && radioButton100.Text == vresp[19])
            { vresp_alu++; }




        }
    }
}
