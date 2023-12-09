using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairShop.DomainObjects
{
    public class Repairs
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int CarID { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsPayed { get; set; }
        public bool IsReturned { get; set; }

        public Repairs(DataRow source)
        {
            ID = source.Field<int>("ID");
            ClientID = source.Field<int>("CLIENT_ID");
            CarID = source.Field<int>("CAR_ID");
            BeginDate = source.Field<DateTime>("BEGIN_DATE");
            EndDate = source.Field<DateTime>("END_DATE");
            IsPayed = source.Field<bool>("IS_PAYED");
            IsReturned = source.Field<bool>("IS_RETURNED");
        }

        public Repairs() { }
    }
}
