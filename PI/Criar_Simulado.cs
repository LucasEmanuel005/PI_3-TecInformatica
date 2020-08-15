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
    public partial class Criar_Simulado : Form
    {
        int leftcontrol = 1;
        int i = 0;
        int x = 22;
        int noofcontrols = 0;
        TextBox[] t1 = new TextBox[25];
        TextBox[] t2 = new TextBox[25];
        Label[] l1 = new Label[25];
        string[] Stxt = new string[25];
     


        public Criar_Simulado()
        {
            InitializeComponent();
        }

        private void Criar_Simulado_Load(object sender, EventArgs e)
        {
            //int qtdparcela = 0;
            //if (qtdparcela < 10)
            //{
            //    qtdparcela += 1;
            //    CriaParcela(qtdparcela);

            //for (int i = 1; i < qtdparcela; i++)
            //{
            //    }

            //}
            //Label lbl = new System.Windows.Forms.Label();
            //    lbl.Location = new Point(10, i * 10 + 1);
            //    lbl.Text = "Parcela n° " + i;
            //    lbl.Name = "lbl" + i;
            //        // Exame_realizacao.Controls.Add(lbl);
            //        //this.Panel.Controls.Add(lbl);
            //        this.Controls.Add(lbl);

            //Label lbl = new Label();
            //lbl.Text = "Bora Bora Bora PENSAR";
            //lbl.Location = new Point(222, 90);
            //lbl.AutoSize = true;
            //lbl.Font = new Font("Calibri", 118);
            //lbl.ForeColor = Color.Blue;
            //lbl.Padding = new Padding(6);
            //this.Controls.Add(lbl);

            //lbl.Text = "Bora  PENSAR";
            //lbl.Location = new Point(422, 70);
            //lbl.AutoSize = true;
            //lbl.Font = new Font("Calibri", 42);
            //lbl.ForeColor = Color.Yellow;
            //lbl.Padding = new Padding(6);
            //this.Controls.Add(lbl);

            int a = 1;

            //Label[] labels = new Label[100];

            //if (a < 10)
            //{
            //    a += 1;
            //    labels[a] = new Label();
            //    labels[a].Text = ("label " + a).ToString();
            //    labels[a].Location = new Point(2*a, 5);
            //    labels[a].Font = new Font("Arial", 100);
            //    labels[a].ForeColor = Color.Blue;
            //   // labels[a].Padding = new Padding(6);
            //    labels[a].AutoSize = true;

            //    labels[a].BackColor = Color.Transparent;


            //}


            //a = 1;
            //if (a < 10)
            //{
            //    a = a + 1;
            //    this.Controls.Add(labels[a]);
            //}

            //a = 1;

            //TextBox[] txt = new TextBox[100];

            //if (a < 10)
            //{
            //    a += 1;
            //    txt[a] = new TextBox();
            //    txt[a].Text = ("label " + a).ToString();
            //    txt[a].Location = new Point(2 * a, 5);
            //    txt[a].Font = new Font("Arial", 100);
            //    txt[a].ForeColor = Color.Blue;
            //    // labels[a].Padding = new Padding(6);
            //    txt[a].AutoSize = true;

            //   // txt[a].BackColor = Color.Transparent;


            //}


            //a = 1;
            //if (a < 10)
            //{
            //    a = a + 1;
            //    this.Controls.Add(txt[a]);
            //}



            //Label[] labels = new Label[2];
            //labels[1] = new Label();
            //labels[1].Text = "lbl";
            //labels[1].Location = new Point(100, 5);
            //labels[1].Font = new Font("Arial", 12);
            //labels[1].ForeColor = Color.Blue;

            //this.Controls.Add(labels[1]);



            //Label[] labels = new Label[10];
            //labels[1] = new Label();
            //labels[1].Text = "lbl";
            //labels[1].Location = new Point(100, 5);
            //labels[1].Font = new Font("Arial", 12);
            //labels[1].ForeColor = Color.Blue;
            //labels[1].BackColor = Color.Transparent;
            //labels[1].AutoSize = true;

            //this.Controls.Add(labels[1]);

            //labels[2] = new Label();
            //labels[2].Text = "lbl 2";
            //labels[2].Location = new Point(100, 5);
            //labels[2].Font = new Font("Arial", 23);
            //labels[2].AutoSize = true;
            //labels[2].ForeColor = Color.Black;
            //labels[2].BackColor = Color.Transparent;

            //this.Controls.Add(labels[2]);


            //while (leftcontrol < 200)
            //{
            //    TextBox t1 = new TextBox();
            //    this.Controls.Add(t1);
            //    t1.Top = leftcontrol * 25;
            //    t1.Left = 100;
            //    t1.Text = "TextBox" + this.leftcontrol.ToString();
            //    leftcontrol = leftcontrol + 1;
            //}


            while (i < 10)
            {
                t1[i] = new TextBox();

                t1[i].Size = new System.Drawing.Size(244, 22);
                t1[i].Location = new System.Drawing.Point(85, x);


                l1[i] = new Label();
                l1[i].Location = new System.Drawing.Point(60, x);
                l1[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l1[i].Text = i.ToString() + ". ";

                // t[i].Name = drform[0].ToString();
                t1[i].TabIndex = i;
                t1[i].Name = "txt" + i;

                this.Controls.Add(t1[i]);
                this.Controls.Add(l1[i]);
                this.AutoSize = true;
                this.Show();
                this.Refresh();
                t1[i].Focus();

                i++;
                x = x + 30;
                noofcontrols++;
            }

            }
        private void CriaParcela(int qtdparcela)
        {


        }
       

    private void button1_Click(object sender, EventArgs e)
        {

            //leftcontrol = 0;

            //while (leftcontrol < 10)
            //{
            //    TextBox t2 = new TextBox();
            //    this.Controls.Add(t2);
            //    t2.Top = leftcontrol * 50;
            //    t2.Left = 100;
            //    t2.Text = "TextBox @@" + this.leftcontrol.ToString();
            //    leftcontrol = leftcontrol + 1;
            //}


            while (i < 10)
            {
                t1[i] = new TextBox();

                t1[i].Size = new System.Drawing.Size(244, 22);
                t1[i].Location = new System.Drawing.Point(85, x);


                l1[i] = new Label();
                l1[i].Location = new System.Drawing.Point(60, x);
                l1[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l1[i].Text = i.ToString() + ". ";

                // t[i].Name = drform[0].ToString();
                t1[i].TabIndex = i;
                t1[i].Name = "txt" + i;

                this.Controls.Add(t1[i]);
                this.Controls.Add(l1[i]);
                this.AutoSize = true;
                this.Show();
                this.Refresh();
                t1[i].Focus();
               
                i++;
                x = x + 30;
                noofcontrols++;               
               
            }
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
           
            while (a < 10)
            {
                a = a + 1;
                string b = (a * 10).ToString();
                label1.Text = b;
               // Stxt[a] = t1[a].Text.ToString();
                //MessageBox.Show(Stxt[a]);
                a = a - 1;

            }
            
         
        }
    }

}
