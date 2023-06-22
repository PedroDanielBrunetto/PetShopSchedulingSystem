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
    public partial class cadastroTutor : Form
    {
        public cadastroTutor()
        {
            InitializeComponent();
        }

        private void btnCadastrarTutor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomeTutor.Text) && !string.IsNullOrEmpty(txtCpfTutor.Text) && !string.IsNullOrEmpty(txtEmailTutor.Text) && !string.IsNullOrEmpty(txtTelefoneTutor.Text) && txtCpfTutor.Text.Length == 11 && txtTelefoneTutor.Text.Length == 12)
            {
                /*
                 * if (txtCpfTutor.Text.Length == 11)
                {
                    // Limpa o texto se não tiver exatamente 11 dígitos
                    MessageBox.Show("Digite seu cpf corretamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCpfTutor.Clear();
                }
                */
                MySqlConnection db_caoamigo = new MySqlConnection("server=localhost; port=3306; database=DB_DUMP_CAOAMIGO; uid=root; pwd=root");
                string nameTutor = txtNomeTutor.Text;
                string cpfTutor = txtCpfTutor.Text;
                string emailTutor = txtEmailTutor.Text;
                string telefoneTutor = txtTelefoneTutor.Text;

                string sql = "SELECT cd_cpf FROM TB_TUTOR WHERE cd_cpf = @cpf";
                MySqlCommand logar = new MySqlCommand(sql, db_caoamigo);
                logar.Parameters.AddWithValue("@cpf", cpfTutor);

                db_caoamigo.Open();
                MySqlDataReader dataRead;
                dataRead = logar.ExecuteReader();
                dataRead.Read();
                if (!dataRead.HasRows)
                {

                    db_caoamigo.Close();

                    db_caoamigo.Open();
                    MySqlCommand insert = new MySqlCommand("INSERT INTO TB_TUTOR (nm_tutor, cd_cpf, nm_email, tl_tutor) VALUES ('" + nameTutor + "', '" + cpfTutor + "', '" + emailTutor + "', '" + telefoneTutor + "')", db_caoamigo);
                    insert.BeginExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com Sucesso!");
                    txtNomeTutor.Clear();
                    txtCpfTutor.Clear();
                    txtEmailTutor.Clear();
                    txtTelefoneTutor.Clear();
                }
                else
                {
                    MessageBox.Show("Usuario existente!");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!");
            }
        }

        private void txtNomeTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ignora a entrada de teclado
                e.Handled = true;
            }
        }

        private void txtCpfTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ignora a entrada de teclado
                e.Handled = true;
            }

        }

        private void txtEmailTutor_Validating(object sender, CancelEventArgs e)
        {
            string text = txtEmailTutor.Text;

            if (!text.Contains("@"))
            {
                MessageBox.Show("A caixa de texto deve conter o caractere '@'.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Cancela a mudança de foco para a caixa de texto
            }
        }

        private void txtTelefoneTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ignora a entrada de teclado
                e.Handled = true;
            }
        }
    }
}
