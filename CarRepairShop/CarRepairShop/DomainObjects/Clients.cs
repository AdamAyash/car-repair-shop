using System;
using System.Data;

namespace CarRepairShop.DomainObjects
{
    public class Clients
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string IdentityNumber { get; set; }

        public int CityID { get; set; }

        public string Address { get; set; }

        public string Telephone { get; set; }

        public Clients()
        {
        }

        public Clients(DataRow source)
        {
            ID = source.Field<int>("ID");
            Name = source.Field<string>("NAME");
            IdentityNumber = source.Field<string>("IDENTITY_NUMBER");
            CityID = source.Field<int>("CITY_ID");
            Address = source.Field<string>("ADDRESS");
            Telephone = source.Field<string>("TELEPHONE");
        }
    }
}
