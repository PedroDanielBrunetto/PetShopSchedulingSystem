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
using System.Globalization;
using MySql.Data.MySqlClient;

namespace petshop_PF
{
    public partial class agendamento : Form
    {
        public agendamento()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCpfTutor.Text != "" && txtCpfTutor.Text.Length == 11)
            {
                string cpf = txtCpfTutor.Text;
                string connectionString = "server=localhost; port=3306; database=DB_DUMP_CAOAMIGO; uid=root; pwd=root";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para buscar o nome do pet do tutor com base no CPF
                    string query = @"SELECT p.nm_pet, t.nm_tutor
                         FROM TB_TUTOR t
                         LEFT JOIN TB_PET p ON t.id_tutor = p.id_tutor
                         WHERE t.cd_cpf = @cpf";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cpf", cpf);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Limpar a ComboBox antes de preenchê-la
                                cmbPet.Items.Clear();


                                while (reader.Read())
                                {
                                    string nomePet = reader["nm_pet"].ToString();
                                    string nomeTutor = reader["nm_tutor"].ToString();
                                    // Adicionar o nome do pet à ComboBox e a Label
                                    lblNameTutor.Text = nomeTutor;
                                    cmbPet.Items.Add(nomePet);
                                }

                                // Selecionar o primeiro item da ComboBox
                                cmbPet.SelectedIndex = 0;
                            }
                            else
                            {
                                // Não há pet associado ao tutor com o CPF informado
                                MessageBox.Show("Não existe pet registrado com esse tutor.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (cmbPet.SelectedItem != null && cmbData.SelectedItem != null && cmbMes.SelectedItem != null &&
               cmbAno.SelectedItem != null && cmbHora.SelectedItem != null && cmbMinuto.SelectedItem != null &&
               cmbServico.SelectedItem != null && !string.IsNullOrEmpty(txtValue.Text))
            {
                string petSelecionado = cmbPet.SelectedItem.ToString();

                int dia, mes, ano;
                if (int.TryParse(cmbData.SelectedItem.ToString(), out dia) &&
                    int.TryParse(cmbMes.SelectedItem.ToString(), out mes) &&
                    int.TryParse(cmbAno.SelectedItem.ToString(), out ano))
                {
                    int hora = Convert.ToInt32(cmbHora.SelectedItem);
                    int minuto = Convert.ToInt32(cmbMinuto.SelectedItem);

                    string tipoServico = cmbServico.SelectedItem.ToString();
                    string valorServico = txtValue.Text;

                    string connectionString = "server=localhost; port=3306; database=DB_DUMP_CAOAMIGO; uid=root; pwd=root";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Obter o ID do tutor com base no CPF
                            string cpf = txtCpfTutor.Text;
                            string queryTutor = "SELECT id_tutor FROM TB_TUTOR WHERE cd_cpf = @cpf";
                            using (MySqlCommand commandTutor = new MySqlCommand(queryTutor, connection))
                            {
                                commandTutor.Parameters.AddWithValue("@cpf", cpf);
                                object tutorId = commandTutor.ExecuteScalar();

                                if (tutorId != null)
                                {
                                    int idTutor = Convert.ToInt32(tutorId);

                                    // Obter o ID do pet com base no nome do pet e ID do tutor
                                    string queryPet = "SELECT id_pet FROM TB_PET WHERE nm_pet = @pet AND id_tutor = @tutor";
                                    using (MySqlCommand commandPet = new MySqlCommand(queryPet, connection))
                                    {
                                        commandPet.Parameters.AddWithValue("@pet", petSelecionado);
                                        commandPet.Parameters.AddWithValue("@tutor", idTutor);
                                        object petId = commandPet.ExecuteScalar();

                                        if (petId != null)
                                        {
                                            int idPet = Convert.ToInt32(petId);

                                            // Verificar se já existe um agendamento para a data e hora selecionadas
                                            string queryVerificarAgendamento = "SELECT id_servico FROM TB_AGENDAMENTO WHERE dt_servico = @dataServico";

                                            using (MySqlCommand commandVerificarAgendamento = new MySqlCommand(queryVerificarAgendamento, connection))
                                            {
                                                DateTime dataServico = new DateTime(ano, mes, dia, hora, minuto, 0);
                                                commandVerificarAgendamento.Parameters.AddWithValue("@dataServico", dataServico);
                                                object existingAgendamentoId = commandVerificarAgendamento.ExecuteScalar();

                                                if (existingAgendamentoId == null)
                                                {
                                                    // Inserir o agendamento na tabela TB_AGENDAMENTO
                                                    string queryAgendamento = "INSERT INTO TB_AGENDAMENTO (dt_servico, tp_servico, vl_servico, id_tutor, id_pet) " +
                                                        "VALUES (@dataServico, @tipoServico, @valorServico, @idTutor, @idPet)";
                                                    using (MySqlCommand commandAgendamento = new MySqlCommand(queryAgendamento, connection))
                                                    {
                                                        commandAgendamento.Parameters.AddWithValue("@dataServico", dataServico);
                                                        commandAgendamento.Parameters.AddWithValue("@tipoServico", tipoServico);
                                                        commandAgendamento.Parameters.AddWithValue("@valorServico", valorServico);
                                                        commandAgendamento.Parameters.AddWithValue("@idTutor", idTutor);
                                                        commandAgendamento.Parameters.AddWithValue("@idPet", idPet);

                                                        commandAgendamento.ExecuteNonQuery();

                                                        MessageBox.Show("Agendamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        cmbPet.SelectedIndex = -1;
                                                        cmbData.SelectedIndex = -1;
                                                        cmbMes.SelectedIndex = -1;
                                                        cmbAno.SelectedIndex = -1;
                                                        cmbHora.SelectedIndex = -1;
                                                        cmbMinuto.SelectedIndex = -1;
                                                        cmbServico.SelectedIndex = -1;
                                                        txtValue.Text = "";
                                                        txtCpfTutor.Text = "";
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Já existe um agendamento para a data e hora selecionadas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Não foi possível encontrar o ID do pet.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Não foi possível encontrar o ID do tutor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Ocorreu um erro ao agendar o serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma data válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ignora a entrada de teclado
                e.Handled = true;
            }
        }
    }
}

