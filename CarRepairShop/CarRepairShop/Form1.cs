using Microsoft.Data.SqlClient;
using System.Data;

namespace CarRepairShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DatabaseConnection databaseConnection = DatabaseConnection.GetDatebaseConnectionInstance();
            databaseConnection.OpenConnection();


            SqlCommand command = new SqlCommand("SELECT * FROM MODELS", databaseConnection.Connection);
            SqlDataReader sqlReder = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlReder);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(dataGridView2, e.Location);
            }
        }


        //Spravki

        private void ShowClients24h_Click(object sender, EventArgs e)
        {
            //Vsichki klienti , koito sa ostavili prez poslednite 24h
            //svoite koli za remont , spisukut da e podreden
            //po marka i narastvasht reg.nomer na kolite
        }

        private void ShowMinAndMaxPrice_Click(object sender, EventArgs e)
        {
            //Izvejdane na min i max cena za naem , podredeno po marka na kolata
        }

        private void ShowUnpaidCars_Click(object sender, EventArgs e)
        {
            //Izvejdane na vs neplateni koli
        }

        private void ShowPaidCars_Click(object sender, EventArgs e)
        {
            //Izvejdane na vs plateni koli
        }

        private void ShowTop3MostRepairedBrands_Click(object sender, EventArgs e)
        {
            //Top 3 nai-remontirani koli podredeni po marka
        }

        private void ShowClientWithMostPays_Click(object sender, EventArgs e)
        {
            //Klienta , koito e napravil nai-golqm oborot ot remont na kola/koli
        }
        //Krai na spravkite




        //Load Data
        private void LoadDataCars_Click(object sender, EventArgs e)
        {

        }

        private void LoadDataClients_Click(object sender, EventArgs e)
        {

        }

        private void LoadDataRepairs_Click(object sender, EventArgs e)
        {

        }
        //Krai na Load Data


        //Context Menu (RMB)
        private void RMBInsert_Click(object sender, EventArgs e)
        {

        }

        private void RMBUpdate_Click(object sender, EventArgs e)
        {

        }

        private void RMBDelete_Click(object sender, EventArgs e)
        {

        }

        private void RMBPreview_Click(object sender, EventArgs e)
        {

        }
        //Krai na Context Menu (RMB)
    }
}