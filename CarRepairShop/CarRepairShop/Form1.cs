using CarRepairShop.DomainObjects;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace CarRepairShop
{
    public partial class Form1 : Form
    {
        private DatabaseConnection databaseConnection;
        public Form1()
        {
            InitializeComponent();
            databaseConnection = DatabaseConnection.GetDatebaseConnectionInstance();
            databaseConnection.OpenConnection();


            SqlCommand command = new SqlCommand("SELECT * FROM CARS", databaseConnection.Connection);
            SqlDataReader sqlReder = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlReder);
            dataGridView2.DataSource = dt;

            Cars car = new Cars();
            car.NumberOfSeats = 0;
            car.YearOfProdyction = DateTime.Now;
            car.RegistrationNumber =2;
            car.BrandID = 1;
            car.ModelID = 1;
            car.ColordID = 0;
            car.RepairPrice = 1;
            //insertCarRecord(car);

        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(dataGridView2, e.Location);
            }
        }


        private bool insertCarRecord(Cars record)
        {
            string query = "INSERT INTO CARS";
            query += " VALUES(@REGISTRATION_NUMBER, @BRAND, @MODEL, @COLOR, @PRODUCTION_DATE, @NUMBER_OF_SEATS, @PRICE)";

            SqlCommand myCommand = new SqlCommand(query, databaseConnection.Connection);

            myCommand.Parameters.AddWithValue("@REGISTRATION_NUMBER", record.RegistrationNumber);
            myCommand.Parameters.AddWithValue("@BRAND", record.BrandID);
            myCommand.Parameters.AddWithValue("@MODEL", record.ModelID);
            myCommand.Parameters.AddWithValue("@COLOR", record.ColordID);
            myCommand.Parameters.AddWithValue("@PRODUCTION_DATE", record.YearOfProdyction);
            myCommand.Parameters.AddWithValue("@NUMBER_OF_SEATS", record.NumberOfSeats);
            myCommand.Parameters.AddWithValue("@PRICE", record.RepairPrice);

            myCommand.ExecuteNonQuery();
            return true;
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