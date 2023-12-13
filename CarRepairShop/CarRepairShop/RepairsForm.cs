using CarRepairShop.DomainObjects;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRepairShop
{
    public partial class RepairsForm : Form
    {
        private Repairs _repairRecord;

        private List<Clients> _clientsList;
        private List<Cars> _carsList;

        public RepairsForm(Repairs repairRecord)
        {
            InitializeComponent();
            _repairRecord = repairRecord;
            _clientsList = new List<Clients>();
            _carsList = new List<Cars>();
            Load();

        }

        private void Load()
        {
            DatabaseConnection databaseConnection = DatabaseConnection.GetDatebaseConnectionInstance();
            SqlCommand command = new SqlCommand("SELECT * FROM CLIENTS", databaseConnection.Connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Clients currentClient = new Clients();
                currentClient.ID = int.Parse(reader["ID"].ToString());
                currentClient.Name = reader["NAME"].ToString();

                _clientsList.Add(currentClient);
            }

            foreach (Clients client in _clientsList)
            {
                comboBox1.Items.Add(client.Name);
            }

            command.Clone();
            reader.Close();

            command = new SqlCommand("SELECT * FROM CARS", databaseConnection.Connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Cars currentCar = new Cars();
                currentCar.ID = int.Parse(reader["ID"].ToString());
                currentCar.RegistrationNumber = reader["REGISTRATION_NUMBER"].ToString();

                _carsList.Add(currentCar);
            }

            foreach (Cars car in _carsList)
            {
                comboBox2.Items.Add(car.RegistrationNumber);
            }

            command.Clone();
            reader.Close();


            if (_repairRecord.ID == 0)
                return;

            List<Clients> clients = _clientsList.Where(c => c.ID == _repairRecord.ClientID).ToList();
            comboBox1.SelectedItem = clients[0].Name;

            List<Cars> cars = _carsList.Where(c => c.ID == _repairRecord.CarID).ToList();
            comboBox2.SelectedItem = cars[0].RegistrationNumber;
            dateTimePicker1.Value = _repairRecord.BeginDate;
            dateTimePicker1.Value = _repairRecord.EndDate;

            checkBox1.Checked = _repairRecord.IsPayed;
            checkBox2.Checked = _repairRecord.IsReturned;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            LoadControlsToData();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadControlsToData()
        {
            var result1 = _clientsList.Where(b => b.Name.Equals(comboBox1.SelectedItem)).ToList();
            _repairRecord.ClientID = result1[0].ID;

            var result2 = _carsList.Where(m => m.RegistrationNumber.Equals(comboBox2.SelectedItem)).ToList();
            _repairRecord.CarID = result2[0].ID;

            _repairRecord.BeginDate = dateTimePicker1.Value;
            _repairRecord.EndDate = dateTimePicker2.Value;

            _repairRecord.IsReturned = checkBox2.Checked;
            _repairRecord.IsPayed = checkBox1.Checked;
        }

    }
}
