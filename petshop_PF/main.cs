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
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        public mainPage(string user) : this()
        {
            // Use o valor de "user" conforme necessário
        }

        private void btnNavegarTutor_Click(object sender, EventArgs e)
        {
            Form CadasterTutor = new cadastroTutor();
            CadasterTutor.Show();
        }

        private void btnNavegarAgenda_Click(object sender, EventArgs e)
        {
            Form schendule = new agendamento();
            schendule.Show();
        }

        private void btnNavegarPet_Click(object sender, EventArgs e)
        {
            Form CadasterPet = new cadastroPet();
            CadasterPet.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; port=3306; database=DB_DUMP_CAOAMIGO; uid=root; pwd=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT dt_servico as 'Data', tp_servico as 'Serviço', vl_servico as 'Valor', TB_TUTOR.nm_tutor AS Tutor, TB_PET.nm_pet AS Pet " +
               "FROM TB_AGENDAMENTO " +
               "JOIN TB_TUTOR ON TB_AGENDAMENTO.id_tutor = TB_TUTOR.id_tutor " +
               "JOIN TB_PET ON TB_AGENDAMENTO.id_pet = TB_PET.id_pet " +
               "ORDER BY dt_servico ASC";
                //DESC descrescente ASC crescente

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Vincular os dados ao DataGridView
                        DataGridView.DataSource = dataTable;

                        /*
                        Mapear as colunas aos campos correspondentes da tabela
                        DataGridView.Columns[0].DataPropertyName = "dt_servico";
                        DataGridView.Columns[1].DataPropertyName = "tp_servico";
                        DataGridView.Columns[2].DataPropertyName = "vl_servico";
                        DataGridView.Columns[3].DataPropertyName = "Tutor";
                        DataGridView.Columns[4].DataPropertyName = "Pet";
                         
                         */

                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
