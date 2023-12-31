﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairShop.DomainObjects
{
    public class Cars
    {
        public int ID { get; set; }

        public string RegistrationNumber { get; set; }

        public int BrandID { get; set; }

        public int ModelID { get; set; }

        public int ColordID { get; set; }

        public DateTime YearOfProduction{ get; set; }

        public int NumberOfSeats { get; set; }

        public double RepairPrice { get; set; }

        public Cars()
        {
        }

        public Cars(DataRow source)
        {
            ID = source.Field<int>("ID");
            RegistrationNumber = source.Field<string>("REGISTRATION_NUMBER");
            BrandID = source.Field<int>("BRAND_ID");
            ModelID = source.Field<int>("MODEL_ID");
            ColordID = source.Field<int>("COLOR_ID");
            NumberOfSeats = source.Field<int>("NUMBER_OF_SEATS");
            RepairPrice = source.Field<double>("REPAIR_PRICE");
            YearOfProduction = source.Field<DateTime>("YEAR_OF_PRODUCTION");
        }
    }
  
}
