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
    public partial class Tela1 : Form
    {
        public Tela1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help1_Click(object sender, EventArgs e)
        {
            {
                if (Application.OpenForms.OfType<Help1>().Count() > 0)
                {
                    Form Help = Application.OpenForms["Help1"];
                    Help.Show();
                    
                }
                else
                {

                    Form Help = new Help1();
                    Help.Show();
                    
                }

            }

        }

        private void btnVermelho_Click(object sender, EventArgs e)
        {
            {
                if (Application.OpenForms.OfType<Tela2>().Count() > 0)
                {
                    Form Jogo = Application.OpenForms["Tela2"];
                    Jogo.Show();
                    this.Hide();
                }
                else
                {

                    Form Jogo = new Tela2();
                    Jogo.Show();
                    this.Hide();
                }

            }

        }
        private void Tela1_Load(object sender, EventArgs e)
        {

        }

        private void Tela1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
