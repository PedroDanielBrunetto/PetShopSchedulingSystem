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
    public partial class cadastroPet : Form
    {
        public cadastroPet()
        {
            InitializeComponent();
        }

        private void btnCadastrarPet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPullCpf.Text) && !string.IsNullOrEmpty(txtNomePet.Text) && cmbTipoPet.SelectedIndex != -1 && !string.IsNullOrEmpty(txtRacaAnimal.Text) && txtPullCpf.Text.Length == 11)
            {
                MySqlConnection db_caoamigo = new MySqlConnection("server=localhost; port=3306; database=DB_DUMP_CAOAMIGO; uid=root; pwd=root");
                string cpf = txtPullCpf.Text;
                string petName = txtNomePet.Text;
                string racaName = txtRacaAnimal.Text;
                string tipoPet = cmbTipoPet.SelectedItem.ToString();
                string sql = "SELECT cd_cpf FROM TB_TUTOR WHERE cd_cpf = @cpf";

                MySqlCommand logar = new MySqlCommand(sql, db_caoamigo);
                logar.Parameters.AddWithValue("@cpf", cpf);
                db_caoamigo.Open();
                MySqlDataReader dataRead;
                dataRead = logar.ExecuteReader();
                bool hasRows = dataRead.HasRows; // Verifica se há linhas de resultado

                if (hasRows)
                {
                    db_caoamigo.Close(); // Fecha a conexão anterior

                    db_caoamigo.Open();
                    MySqlCommand id = new MySqlCommand("SELECT id_tutor, nm_tutor FROM TB_TUTOR WHERE cd_cpf = @cpf", db_caoamigo);
                    id.Parameters.AddWithValue("@cpf", cpf);
                    MySqlDataReader dr;
                    dr = id.ExecuteReader();
                    bool hasIdTutor = dr.Read(); // Verifica se há linhas de resultado para o ID do tutor

                    if (hasIdTutor)
                    {
                        int idTutor = dr.GetInt32(0);
                        string nomeTutor = dr["nm_tutor"].ToString();
                        // Adicionar o nome do pet à ComboBox e a Label
                        lblNameTutor.Text = nomeTutor;
                        db_caoamigo.Close();

                        db_caoamigo.Open();
                        MySqlCommand insert = new MySqlCommand("INSERT INTO TB_PET (nm_pet, tp_animal, tp_raça, id_tutor) VALUES ('" + petName + "', '" + tipoPet + "', '" + racaName + "', '" + idTutor + "')", db_caoamigo);
                        insert.ExecuteNonQuery();

                        MessageBox.Show( "O cadastro do Pet "+petName+", de tutor cujo nome "+nomeTutor+", foi realizado com sucesso!");
                        txtPullCpf.Clear();
                        txtNomePet.Clear();
                        txtRacaAnimal.Clear();
                        cmbTipoPet.SelectedIndex = -1;
                        lblNameTutor.Text = "*";
                    }
                    else
                    {
                        MessageBox.Show("Tutor inexistente!");
                    }
                }
                else
                {
                    MessageBox.Show("Tutor inexistente!");
                }

                db_caoamigo.Close();
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!");
            }
        }

        private void txtPullCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ignora a entrada de teclado
                e.Handled = true;
            }
        }

        private void txtNomePet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ignora a entrada de teclado
                e.Handled = true;
            }
        }
    }
}
