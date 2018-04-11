using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Tela2 : Form
    {
        public Tela2()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tela2_Load(object sender, EventArgs e)
        {

        }

        private void btnNextel_Click(object sender, EventArgs e)
        {
            if (cbJogo1.Checked == true)
            {

                Tela3 t3 = new Tela3();
                t3.Show();
                this.Hide();
            }

            if (cbJogo2.Checked == true)
            {

                Tela3 t3 = new Tela3();
                t3.Show();
                this.Hide();
            }
            if (cbJogo3.Checked == true)
            {

                Tela3 t3 = new Tela3();
                t3.Show();

            }
            if (cbJogo4.Checked == true)
            {

                Tela3 t3 = new Tela3();
                t3.Show();

            }


                }

        private void Help2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Help2>().Count() > 0)
            {
                Form Help = Application.OpenForms["Help2"];
                Help.Show();
                this.Hide();
            }
            else
            {

                Form Help = new Help2();
                Help.Show();
                this.Hide();
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Tela1>().Count() > 0)
            {
                Form Jogo = Application.OpenForms["Tela1"];
                Jogo.Show();
                this.Hide();

            }
            else
            {

                Form Jogo = new Tela1();
                Jogo.Show();
                this.Hide();

            }
        }

            }
        }
    

