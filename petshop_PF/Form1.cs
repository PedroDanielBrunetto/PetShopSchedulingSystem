using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace petshop_PF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms.OfType<cadastro>().Count() > 0)
            {
                Form cadastroOpen = Application.OpenForms["FrmCadastro"];
                cadastroOpen.Show(); // O formulario já está aberto
                this.Hide();
            }
            else
            {
                cadastro cadastro = new cadastro();
                cadastro.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // O botão "X" de fechar foi pressionado pelo usuário
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserLogin.Text) && !string.IsNullOrEmpty(txtPasswordLogin.Text))
            {
                MySqlConnection db_caoamigo = new MySqlConnection("server=localhost; port=3306; database=DB_DUMP_CAOAMIGO; uid=root; pwd=root");
                string user = txtUserLogin.Text;
                string PassUser = txtPasswordLogin.Text;
                string bdPass = "";

                string sql = "SELECT pw_funcionario FROM TB_FUNCIONARIO WHERE nm_user = @user";
                MySqlCommand logar = new MySqlCommand(sql, db_caoamigo);
                logar.Parameters.AddWithValue("@user", user);

                db_caoamigo.Open();
                MySqlDataReader dataRead;
                dataRead = logar.ExecuteReader();
                dataRead.Read();
                if (dataRead.HasRows)
                {
                    bdPass = dataRead["pw_funcionario"].ToString();
                    if(PassUser == bdPass)
                    {
                        Form main = new mainPage(user);
                        main.Show();
                        this.Hide();
                        txtUserLogin.Clear();
                        txtPasswordLogin.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Usuario inexistente!");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario inexistente!");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos!");
            }
        }
    }
}
