using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Tela4 : Form
    {

        public Tela4()
        {
            InitializeComponent();
        }


        private void btnOpenInformations_Click(object sender, EventArgs e)
        {
            /*if (Arma0.Checked == true)
            {
                Tela5 t5 = new Tela5();
                t5.Show();
                {
                    SqlConnection conectar = new SqlConnection(acesso);
                    string pesquisar = "SELECT *FROM Pistolas WHERE Codigo = 9";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(pesquisar, conectar);
                        conectar.Open();
                        SqlDataReader ler = cmd.ExecuteReader();
                        if (ler.Read() == true)
                        {
                            txtDano.Text = ler["Dano"].ToString();
                            txtAlcance.Text = ler["Alcance"].ToString();
                            txtCadencia.Text = ler["Cadencia"].ToString();
                            txtPrecisaoC.Text = ler["Precisao com Mira"].ToString();
                            txtPrecisaoS.Text = ler["Precisao sem Mira"].ToString();
                            txtPente.Text = ler["Capacidade do Pente"].ToString();
                        }
                        conectar.Close();
                    }
                    catch (SqlException erro)
                    {
                        MessageBox.Show("Acesso negado!" + erro);
                    }
                }; 
            }

            if (Arma1.Checked == true)
            {Tela5 t5 = new Tela5();t5.Show();}

            if (Arma2.Checked == true)
            { Tela5 t5 = new Tela5(); t5.Show(); }

            if (Arma3.Checked == true)
            { Tela5 t5 = new Tela5(); t5.Show(); }

            if (Arma4.Checked == true)
            { Tela5 t5 = new Tela5(); t5.Show(); }

            if (Arma5.Checked == true)
            { Tela5 t5 = new Tela5(); t5.Show(); }

            if (Arma6.Checked == true)
            { Tela5 t5 = new Tela5(); t5.Show(); }

            if (Arma7.Checked == true)
            { Tela5 t5 = new Tela5(); t5.Show(); }

            if (Arma8.Checked == true)
            { Tela5 t5 = new Tela5(); t5.Show(); }

            if (Arma9.Checked == true)
            { Tela5 t5 = new Tela5(); t5.Show(); }

            if (Arma10.Checked == true)
            { Tela5 t5 = new Tela5(); t5.Show(); }
        } */
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Tela3>().Count() > 0)
            {
                Form Jogo = Application.OpenForms["Tela3"];
                Jogo.Show();
                this.Hide();

            }
            else
            {

                Form Jogo = new Tela3();
                Jogo.Show();
                this.Hide();

            }
        }

        private void Help4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Help4>().Count() > 0)
            {
                Form Help = Application.OpenForms["Help4"];
                Help.Show();
            }
            else
            {

                Form Help = new Help4();
                Help.Show();
            }
        }

    }
}
