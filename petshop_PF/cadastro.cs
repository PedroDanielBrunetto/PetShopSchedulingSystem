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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }



        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                Form1 login = new Form1();
                login.Show();
                this.Close();
        }

        private void btnCadaster_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNameCadaster.Text) && !string.IsNullOrEmpty(txtUserCadaster.Text) && !string.IsNullOrEmpty(txtEmailCadaster.Text) && !string.IsNullOrEmpty(txtPasswordCadaster.Text))
            {
                MySqlConnection db_caoamigo = new MySqlConnection("server=localhost; port=3306; database=DB_DUMP_CAOAMIGO; uid=root; pwd=root");
                string nameUser = txtNameCadaster.Text;
                string user = txtUserCadaster.Text;
                string emailUser = txtEmailCadaster.Text;
                string passUser = txtPasswordCadaster.Text;

                string sql = "SELECT nm_user FROM TB_FUNCIONARIO WHERE nm_user = @user";
                MySqlCommand logar = new MySqlCommand(sql, db_caoamigo);
                logar.Parameters.AddWithValue("@user", user);

                db_caoamigo.Open();
                MySqlDataReader dataRead;
                dataRead = logar.ExecuteReader();
                dataRead.Read();
                if (!dataRead.HasRows)
                {

                    db_caoamigo.Close();

                    db_caoamigo.Open();
                    MySqlCommand insert = new MySqlCommand("INSERT INTO tb_funcionario (nm_funcionario, nm_user, nm_email, pw_funcionario) VALUES ('" + nameUser + "', '"+ user +"', '"+ emailUser +"', '"+ passUser +"')", db_caoamigo);
                    insert.BeginExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com Sucesso!");
                    txtNameCadaster.Clear();
                    txtUserCadaster.Clear();
                    txtEmailCadaster.Clear();
                    txtPasswordCadaster.Clear();
                }
                else
                {
                    MessageBox.Show("Usuario existente!");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos!");
            }
        }

        private void txtNameCadaster_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ignora a entrada de teclado
                e.Handled = true;
            }
        }

        private void txtEmailCadaster_Validating(object sender, CancelEventArgs e)
        {
            string text = txtEmailCadaster.Text;

            if (!text.Contains("@"))
            {
                MessageBox.Show("A caixa de texto deve conter o caractere '@'.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Cancela a mudança de foco para a caixa de texto
            }
        }
    }
}
