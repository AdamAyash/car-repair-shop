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
    }
}