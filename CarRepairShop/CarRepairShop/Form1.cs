using CarRepairShop.DomainObjects;
using Microsoft.Data.SqlClient;
using System.Data;


namespace CarRepairShop
{
    public partial class Form1 : Form
    {
        private DatabaseConnection databaseConnection;

        private bool isCarsLoaded = false;
        private bool isClientsLoaded = false;
        private bool isRepairsLoaded = false;
        public Form1()
        {
            InitializeComponent();
            databaseConnection = DatabaseConnection.GetDatebaseConnectionInstance();
            databaseConnection.OpenConnection();




            Cars car = new Cars();
            car.NumberOfSeats = 0;
            car.YearOfProduction = DateTime.Now;
            car.RegistrationNumber = "2";
            car.RegistrationNumber = "123";
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


        private bool updateCarRecord(Cars record)
        {
            string query = "UPDATE CARS";
            query += " SET REGISTRATION_NUMBER = @REGISTRATION_NUMBER, BRAND_ID = @BRAND, MODEL_ID = @MODEL,  COLOR_ID = @COLOR," +
                " YEAR_OF_PRODUCTION = @PRODUCTION_DATE, NUMBER_OF_SEATS = @NUMBER_OF_SEATS, REPAIR_PRICE = @PRICE" +
                " WHERE ID =  " + record.ID.ToString();

            SqlCommand myCommand = new SqlCommand(query, databaseConnection.Connection);

            myCommand.Parameters.AddWithValue("@REGISTRATION_NUMBER", record.RegistrationNumber);
            myCommand.Parameters.AddWithValue("@BRAND", record.BrandID);
            myCommand.Parameters.AddWithValue("@MODEL", record.ModelID);
            myCommand.Parameters.AddWithValue("@COLOR", record.ColordID);
            myCommand.Parameters.AddWithValue("@PRODUCTION_DATE", record.YearOfProduction);
            myCommand.Parameters.AddWithValue("@NUMBER_OF_SEATS", record.NumberOfSeats);
            myCommand.Parameters.AddWithValue("@PRICE", record.RepairPrice);

            myCommand.ExecuteNonQuery();

            return true;
        }

        private bool updateClientRecord(Clients clientRecord)
        {
            string query = "UPDATE CLIENTS";
            query += " SET NAME = @NAME, IDENTITY_NUMBER = @IDENTITY_NUMBER, CITY_ID = @CITY_ID,  ADDRESS = @ADDRESS," +
                " TELEPHONE = @TELEPHONE " +
                " WHERE ID =  " + clientRecord.ID.ToString();

            SqlCommand myCommand = new SqlCommand(query, databaseConnection.Connection);

            myCommand.Parameters.AddWithValue("@NAME", clientRecord.Name);
            myCommand.Parameters.AddWithValue("@IDENTITY_NUMBER", clientRecord.IdentityNumber);
            myCommand.Parameters.AddWithValue("@CITY_ID", clientRecord.CityID);
            myCommand.Parameters.AddWithValue("@ADDRESS", clientRecord.Address);
            myCommand.Parameters.AddWithValue("@TELEPHONE", clientRecord.Telephone);

            myCommand.ExecuteNonQuery();

            return true;
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
            myCommand.Parameters.AddWithValue("@PRODUCTION_DATE", record.YearOfProduction);
            myCommand.Parameters.AddWithValue("@NUMBER_OF_SEATS", record.NumberOfSeats);
            myCommand.Parameters.AddWithValue("@PRICE", record.RepairPrice);

            myCommand.ExecuteNonQuery();
            return true;
        }

        private bool insertClient(Clients clientRecord)
        {
            string query = "INSERT INTO CLIENTS ";
            query += "VALUES(@NAME, @IDENTITY_NUMBER, @CITY_ID, @ADDRESS, @TELEPHONE)";
            SqlCommand myCommand = new SqlCommand(query, databaseConnection.Connection);

            myCommand.Parameters.AddWithValue("@NAME", clientRecord.Name);
            myCommand.Parameters.AddWithValue("@IDENTITY_NUMBER", clientRecord.IdentityNumber);
            myCommand.Parameters.AddWithValue("@CITY_ID", clientRecord.CityID);
            myCommand.Parameters.AddWithValue("@ADDRESS", clientRecord.Address);
            myCommand.Parameters.AddWithValue("@TELEPHONE", clientRecord.Telephone);

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

        private void LoadCar(Cars record)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CARS WHERE ID = " + record.ID.ToString(), databaseConnection.Connection);
            SqlDataReader sqlReder = command.ExecuteReader();
            record.BrandID = int.Parse(sqlReder["BRAND_ID"].ToString());
            record.ModelID = int.Parse(sqlReder["MODEL_ID"].ToString());
            record.RegistrationNumber = sqlReder["REGISTRATION_NUMBER"].ToString();
            record.NumberOfSeats = int.Parse(sqlReder["NUMBER_OF_SEATS"].ToString());
            record.ColordID = int.Parse(sqlReder["COLOR_ID"].ToString());
            //record.YearOfProduction. = sqlReder["YEAR_OF_PRODUCTION"].ToString();
            record.RepairPrice = double.Parse(sqlReder["REPAIR_PRICE"].ToString());
        }


        //Load Data
        private void LoadDataCars_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CARS", databaseConnection.Connection);
            SqlDataReader sqlReder = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlReder);
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
            isCarsLoaded = true;
            isClientsLoaded = false;
            isRepairsLoaded = false;
        }

        private void LoadDataClients_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CLIENTS", databaseConnection.Connection);
            SqlDataReader sqlReder = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlReder);
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
            isCarsLoaded = false;
            isClientsLoaded = true;
            isRepairsLoaded = false;
        }

        private void LoadDataRepairs_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM REPAIRS", databaseConnection.Connection);
            SqlDataReader sqlReder = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlReder);
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }
        //Krai na Load Data


        //Context Menu (RMB)
        private void RMBInsert_Click(object sender, EventArgs e)
        {
            if(isCarsLoaded)
                {

                try
                {
                    Cars car = new Cars();
                    CarsForm carsForm = new CarsForm(car);
                    carsForm.ShowDialog();

                    // if (carsForm.ShowDialog() != DialogResult.OK)
                    // return;

                    insertCarRecord(car);
                    LoadDataCars_Click(this, EventArgs.Empty);
                }
                catch
                {
                    return;
                }
            }
            else if (isClientsLoaded)
            {
                try
                {
                    Clients client = new Clients();
                    ClientsForm clientsForm = new ClientsForm(client);
                    clientsForm.ShowDialog();
                    insertClient(client);
                    LoadDataClients_Click(this, EventArgs.Empty);
                }
                catch
                {
                    return;
                }
            }

        }

        private void RMBUpdate_Click(object sender, EventArgs e)
        {
            if (isCarsLoaded)
            {
                try
                {
                    DataRow row = (dataGridView2.SelectedRows[0].DataBoundItem as DataRowView).Row;
                    Cars car = new Cars(row);
                    CarsForm carsForm = new CarsForm(car);
                    carsForm.ShowDialog();


                    updateCarRecord(car);
                    LoadDataCars_Click(this, EventArgs.Empty);
                }
                catch
                {
                    return;
                }
            }
            else if (isClientsLoaded)
            {
                try
                {
                    DataRow row = (dataGridView2.SelectedRows[0].DataBoundItem as DataRowView).Row;
                    Clients clientRecord = new Clients(row);
                    ClientsForm clientForm = new ClientsForm(clientRecord);
                    clientForm.ShowDialog();


                    updateClientRecord(clientRecord);
                    LoadDataClients_Click(this, EventArgs.Empty);
                }
                catch
                {
                    return;
                }
            }
        }

        private void RMBDelete_Click(object sender, EventArgs e)
        {
            if (isCarsLoaded)
            {
                try
                {
                    DataRow row = (dataGridView2.SelectedRows[0].DataBoundItem as DataRowView).Row;
                    Cars car = new Cars(row);

                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM CARS WHERE ID = " + car.ID, databaseConnection.Connection);
                    sqlCommand.ExecuteNonQuery();

                    LoadDataCars_Click(this, EventArgs.Empty);
                }

                catch
                {
                    return;
                }
            }
            else if (isClientsLoaded)
            {
                try
                {
                    DataRow row = (dataGridView2.SelectedRows[0].DataBoundItem as DataRowView).Row;
                    Clients clientRecord = new Clients(row);

                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM CLIENTS WHERE ID = " + clientRecord.ID, databaseConnection.Connection);
                    sqlCommand.ExecuteNonQuery();

                    LoadDataClients_Click(this, EventArgs.Empty);
                }
                catch
                {
                    return;
                }
            }
        }

        private void RMBPreview_Click(object sender, EventArgs e)
        {
            if (isCarsLoaded)
            {
                try
                {
                    DataRow row = (dataGridView2.SelectedRows[0].DataBoundItem as DataRowView).Row;
                    Cars car = new Cars(row);
                    CarsForm carsForm = new CarsForm(car);
                    carsForm.ShowDialog();
                }

                catch
                {
                    return;
                }
            }
            else if (isClientsLoaded)
            {
                try
                {
                    DataRow row = (dataGridView2.SelectedRows[0].DataBoundItem as DataRowView).Row;
                    Clients client = new Clients(row);
                    ClientsForm clientForm = new ClientsForm(client);
                    clientForm.ShowDialog();

                }
                catch
                {
                    return;
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        //Krai na Context Menu (RMB)
    }
}