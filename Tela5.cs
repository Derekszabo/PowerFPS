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
    public partial class Tela5 : Form
    {
        string acesso = @"Data Source=FERNANDO\SQLEXPRESS;Initial Catalog=bd_jogo1;Integrated Security=True";

        public Tela5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenInformations_Click(object sender, EventArgs e)
        {
            if (Arma0.Checked == true)
            {
                {
                    SqlConnection conectar = new SqlConnection(acesso);
                    string pesquisar = "SELECT *FROM Pistolas WHERE Codigo = 1";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(pesquisar, conectar);
                        conectar.Open();
                        SqlDataReader ler = cmd.ExecuteReader();
                        if (ler.Read() == true)
                        {
                            txtDanoMax.Text = ler["Dano"].ToString();
                            txtDanoMin.Text = ler["Alcance"].ToString();
                            txtTempoRecarga.Text = ler["Cadencia"].ToString();
                            txtPrecisaoC.Text = ler["Precisao com Mira"].ToString();
                            txtRecuo.Text = ler["Precisao sem Mira"].ToString();
                            txtPente.Text = ler["Capacidade do Pente"].ToString();
                        }
                        conectar.Close();
                    }
                    catch (SqlException erro)
                    {
                        MessageBox.Show("Acesso negado!" + erro);
                    }
                }
            }

            if (Arma1.Checked == true)
            {
                {
                    SqlConnection conectar = new SqlConnection(acesso);
                    string pesquisar = "SELECT *FROM Pistolas WHERE Codigo = 2";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(pesquisar, conectar);
                        conectar.Open();
                        SqlDataReader ler = cmd.ExecuteReader();
                        if (ler.Read() == true)
                        {
                            txtDanoMax.Text = ler["Dano"].ToString();
                            txtDanoMin.Text = ler["Alcance"].ToString();
                            txtTempoRecarga.Text = ler["Cadencia"].ToString();
                            txtPrecisaoC.Text = ler["Precisao com Mira"].ToString();
                            txtRecuo.Text = ler["Precisao sem Mira"].ToString();
                            txtPente.Text = ler["Capacidade do Pente"].ToString();
                        }
                        conectar.Close();
                    }
                    catch (SqlException erro)
                    {
                        MessageBox.Show("Acesso negado!" + erro);
                    }
                }
            }

            if (Arma2.Checked == true)
            {
                {
                    SqlConnection conectar = new SqlConnection(acesso);
                    string pesquisar = "SELECT *FROM Pistolas WHERE Codigo = 3";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(pesquisar, conectar);
                        conectar.Open();
                        SqlDataReader ler = cmd.ExecuteReader();
                        if (ler.Read() == true)
                        {
                            txtDanoMax.Text = ler["Dano"].ToString();
                            txtDanoMin.Text = ler["Alcance"].ToString();
                            txtTempoRecarga.Text = ler["Cadencia"].ToString();
                            txtPrecisaoC.Text = ler["Precisao com Mira"].ToString();
                            txtRecuo.Text = ler["Precisao sem Mira"].ToString();
                            txtPente.Text = ler["Capacidade do Pente"].ToString();
                        }
                        conectar.Close();
                    }
                    catch (SqlException erro)
                    {
                        MessageBox.Show("Acesso negado!" + erro);
                    }
                }
            }

            if (Arma3.Checked == true)
            {
                {
                    SqlConnection conectar = new SqlConnection(acesso);
                    string pesquisar = "SELECT *FROM Pistolas WHERE Codigo = 4";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(pesquisar, conectar);
                        conectar.Open();
                        SqlDataReader ler = cmd.ExecuteReader();
                        if (ler.Read() == true)
                        {
                            txtDanoMax.Text = ler["Dano"].ToString();
                            txtDanoMin.Text = ler["Alcance"].ToString();
                            txtTempoRecarga.Text = ler["Cadencia"].ToString();
                            txtPrecisaoC.Text = ler["Precisao com Mira"].ToString();
                            txtRecuo.Text = ler["Precisao sem Mira"].ToString();
                            txtPente.Text = ler["Capacidade do Pente"].ToString();
                        }
                        conectar.Close();
                    }
                    catch (SqlException erro)
                    {
                        MessageBox.Show("Acesso negado!" + erro);
                    }
                }
            }

            if (Arma4.Checked == true)
            {
                {
                    SqlConnection conectar = new SqlConnection(acesso);
                    string pesquisar = "SELECT *FROM Pistolas WHERE Codigo = 5";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(pesquisar, conectar);
                        conectar.Open();
                        SqlDataReader ler = cmd.ExecuteReader();
                        if (ler.Read() == true)
                        {
                            txtDanoMax.Text = ler["Dano"].ToString();
                            txtDanoMin.Text = ler["Alcance"].ToString();
                            txtTempoRecarga.Text = ler["Cadencia"].ToString();
                            txtPrecisaoC.Text = ler["Precisao com Mira"].ToString();
                            txtRecuo.Text = ler["Precisao sem Mira"].ToString();
                            txtPente.Text = ler["Capacidade do Pente"].ToString();
                        }
                        conectar.Close();
                    }
                    catch (SqlException erro)
                    {
                        MessageBox.Show("Acesso negado!" + erro);
                    }
                }
            }

            if (Arma5.Checked == true)
            {
                {
                    SqlConnection conectar = new SqlConnection(acesso);
                    string pesquisar = "SELECT *FROM Pistolas WHERE Codigo = 6";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(pesquisar, conectar);
                        conectar.Open();
                        SqlDataReader ler = cmd.ExecuteReader();
                        if (ler.Read() == true)
                        {
                            txtDanoMax.Text = ler["Dano"].ToString();
                            txtDanoMin.Text = ler["Alcance"].ToString();
                            txtTempoRecarga.Text = ler["Cadencia"].ToString();
                            txtPrecisaoC.Text = ler["Precisao com Mira"].ToString();
                            txtRecuo.Text = ler["Precisao sem Mira"].ToString();
                            txtPente.Text = ler["Capacidade do Pente"].ToString();
                        }
                        conectar.Close();
                    }
                    catch (SqlException erro)
                    {
                        MessageBox.Show("Acesso negado!" + erro);
                    }
                }
            }

            if (Arma6.Checked == true)
            {
                {
                    SqlConnection conectar = new SqlConnection(acesso);
                    string pesquisar = "SELECT *FROM Pistolas WHERE Codigo = 7";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(pesquisar, conectar);
                        conectar.Open();
                        SqlDataReader ler = cmd.ExecuteReader();
                        if (ler.Read() == true)
                        {
                            txtDanoMax.Text = ler["Dano"].ToString();
                            txtDanoMin.Text = ler["Alcance"].ToString();
                            txtTempoRecarga.Text = ler["Cadencia"].ToString();
                            txtPrecisaoC.Text = ler["Precisao com Mira"].ToString();
                            txtRecuo.Text = ler["Precisao sem Mira"].ToString();
                            txtPente.Text = ler["Capacidade do Pente"].ToString();
                        }
                        conectar.Close();
                    }
                    catch (SqlException erro)
                    {
                        MessageBox.Show("Acesso negado!" + erro);
                    }
                }
            }

            if (Arma7.Checked == true)
            {
                {
                    SqlConnection conectar = new SqlConnection(acesso);
                    string pesquisar = "SELECT *FROM Pistolas WHERE Codigo = 8";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(pesquisar, conectar);
                        conectar.Open();
                        SqlDataReader ler = cmd.ExecuteReader();
                        if (ler.Read() == true)
                        {
                            txtDanoMax.Text = ler["Dano"].ToString();
                            txtDanoMin.Text = ler["Alcance"].ToString();
                            txtTempoRecarga.Text = ler["Cadencia"].ToString();
                            txtPrecisaoC.Text = ler["Precisao com Mira"].ToString();
                            txtRecuo.Text = ler["Precisao sem Mira"].ToString();
                            txtPente.Text = ler["Capacidade do Pente"].ToString();
                        }
                        conectar.Close();
                    }
                    catch (SqlException erro)
                    {
                        MessageBox.Show("Acesso negado!" + erro);
                    }
                }
            }

            if (Arma8.Checked == true)
            {
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
                            txtDanoMax.Text = ler["Dano"].ToString();
                            txtDanoMin.Text = ler["Alcance"].ToString();
                            txtTempoRecarga.Text = ler["Cadencia"].ToString();
                            txtPrecisaoC.Text = ler["Precisao com Mira"].ToString();
                            txtRecuo.Text = ler["Precisao sem Mira"].ToString();
                            txtPente.Text = ler["Capacidade do Pente"].ToString();
                        }
                        conectar.Close();
                    }
                    catch (SqlException erro)
                    {
                        MessageBox.Show("Acesso negado!" + erro);
                    }
                }
            }

            if (Arma9.Checked == true)
            { Tela5 t5 = new Tela5(); t5.Show(); }

            if (Arma10.Checked == true)
            { Tela5 t5 = new Tela5(); t5.Show(); }
        }

    }
}
