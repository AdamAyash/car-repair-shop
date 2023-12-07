using CarRepairShop.DomainObjects;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarRepairShop
{
    public partial class CarsForm : Form
    {
        private Cars _carRecord;
        private List<Brands> brands;
        private List<Models> models;
        

        public CarsForm(Cars carRecord)
        {
            InitializeComponent();
            _carRecord = carRecord;
            brands = new List<Brands>();
            models = new List<Models>();
            Load();
        }

        private void Load()
        {
            //Зареждаме комбото с брандовете
            DatabaseConnection databaseConnection = DatabaseConnection.GetDatebaseConnectionInstance();
            SqlCommand command = new SqlCommand("SELECT * FROM BRANDS", databaseConnection.Connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Brands currentBrand = new Brands();
                currentBrand.ID = int.Parse(reader["ID"].ToString());
                currentBrand.Name = reader["NAME"].ToString();

                brands.Add(currentBrand);
            }

            foreach (Brands brand in brands)
            {
                comboBox1.Items.Add(brand.Name);
            }


            reader.Close();
            command.Clone();

            command = new SqlCommand("SELECT * FROM MODELS", databaseConnection.Connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Models currentModel = new Models();
                currentModel.ID = int.Parse(reader["ID"].ToString());
                currentModel.Name = reader["NAME"].ToString();

                models.Add(currentModel);
            }

            foreach (Models model in models)
            {
                comboBox2.Items.Add(model.Name);
            }

            command.Clone();
            reader.Close();

            if (_carRecord.ID == 0)
                return;

            List<Models> modelsList = models.Where(m => m.ID == _carRecord.ModelID).ToList();
            comboBox2.SelectedItem = modelsList[0].Name;


            List<Brands> brandsList = brands.Where(b => b.ID == _carRecord.BrandID).ToList();

            comboBox1.SelectedItem = brandsList[0].Name;

            dateTimePicker1.Value = _carRecord.YearOfProduction;
            textBox2.Text = _carRecord.NumberOfSeats.ToString();
            textBox3.Text = _carRecord.RepairPrice.ToString();
            textBox1.Text = _carRecord.RegistrationNumber;
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
            var result1 =  brands.Where(b => b.Name.Equals( comboBox1.SelectedItem)).ToList();
            _carRecord.BrandID = result1[0].ID;

            var result2 = models.Where(m => m.Name.Equals(comboBox2.SelectedItem)).ToList();
            _carRecord.ModelID = result2[0].ID;

            _carRecord.ColordID = 0;
            _carRecord.RegistrationNumber = textBox1.Text;
            _carRecord.NumberOfSeats = int.Parse(textBox2.Text);
            _carRecord.RepairPrice = double.Parse(textBox3.Text);
            _carRecord.YearOfProduction = dateTimePicker1.Value;
        }
    }
}
