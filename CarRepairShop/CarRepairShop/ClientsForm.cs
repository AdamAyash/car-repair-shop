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
    public partial class ClientsForm : Form
    {
        private Clients clientRecord;

        private List<Cities> _citiesList;
        public ClientsForm(Clients client)
        {
            InitializeComponent();
            clientRecord = client;
            _citiesList = new List<Cities>();
            Load();
        }

        private void Load()
        {
            DatabaseConnection databaseConnection = DatabaseConnection.GetDatebaseConnectionInstance();
            SqlCommand command = new SqlCommand("SELECT * FROM CITIES", databaseConnection.Connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Cities currentCity = new Cities();
                currentCity.ID = int.Parse(reader["ID"].ToString());
                currentCity.Name = reader["NAME"].ToString();

                _citiesList.Add(currentCity);
            }

            foreach (Cities city in _citiesList)
            {
                comboBox1.Items.Add(city.Name);
            }

            command.Clone();
            reader.Close();

            if (clientRecord.ID == 0)
                return;

            List<Cities> citiesList = _citiesList.Where(m => m.ID == clientRecord.CityID).ToList();
            comboBox1.SelectedItem = citiesList[0].Name;

            textBox1.Text = clientRecord.Name;
            textBox2.Text = clientRecord.IdentityNumber;
            textBox3.Text = clientRecord.Address;
            textBox4.Text = clientRecord.Telephone;
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
            var result1 = _citiesList.Where(b => b.Name.Equals(comboBox1.SelectedItem)).ToList();
            clientRecord.CityID = result1[0].ID;


            clientRecord.Name = textBox1.Text;
            clientRecord.IdentityNumber = textBox2.Text;
            clientRecord.Address = textBox3.Text;
            clientRecord.Telephone = textBox4.Text;
        }
    }
}
