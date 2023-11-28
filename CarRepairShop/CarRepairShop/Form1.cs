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
            SqlDataReader  sqlReder = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlReder);
            dataGridView1.DataSource = dt;

        }
    }
}