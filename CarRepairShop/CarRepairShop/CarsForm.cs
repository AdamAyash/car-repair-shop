using CarRepairShop.DomainObjects;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<Colors> colors;


        public CarsForm(Cars carRecord)
        {
            InitializeComponent();
            _carRecord = carRecord;
            brands = new List<Brands>();
            models = new List<Models>();
            colors = new List<Colors>();
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


            command.Clone();
            reader.Close();

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

            /////////////////////////////////////////////////////////////////////////////////////

            command = new SqlCommand("SELECT * FROM COLORS", databaseConnection.Connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Colors currentColor = new Colors();
                currentColor.ID = int.Parse(reader["ID"].ToString());
                currentColor.Name = reader["NAME"].ToString();

                colors.Add(currentColor);
            }

            foreach (Colors color in colors)
            {
                comboBox3.Items.Add(color.Name);
            }

            command.Clone();
            reader.Close();

            ////////////////////////////////////////////////////////////////////////////////////


            if (_carRecord.ID == 0)
                return;

            List<Models> modelsList = models.Where(m => m.ID == _carRecord.ModelID).ToList();
            comboBox2.SelectedItem = modelsList[0].Name;


            List<Brands> brandsList = brands.Where(b => b.ID == _carRecord.BrandID).ToList();

            comboBox1.SelectedItem = brandsList[0].Name;

            List<Colors> colorsList = colors.Where(b => b.ID == _carRecord.ID).ToList();
            comboBox3.SelectedItem = colorsList[0].Name;


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
            var result1 = brands.Where(b => b.Name.Equals(comboBox1.SelectedItem)).ToList();
            _carRecord.BrandID = result1[0].ID;

            var result2 = models.Where(m => m.Name.Equals(comboBox2.SelectedItem)).ToList();
            _carRecord.ModelID = result2[0].ID;

            var result3 = colors.Where(c => c.Name.Equals(comboBox3.SelectedItem)).ToList();
            _carRecord.ColordID = result3[0].ID;

            _carRecord.RegistrationNumber = textBox1.Text;
            _carRecord.NumberOfSeats = int.Parse(textBox2.Text);
            _carRecord.RepairPrice = double.Parse(textBox3.Text);
            _carRecord.YearOfProduction = dateTimePicker1.Value;
        }
    }
}
