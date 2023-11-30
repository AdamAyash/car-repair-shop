using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairShop.DomainObjects
{
    public class Cars
    {
        public int ID { get; set; }

        public int RegistrationNumber { get; set; }

        public int BrandID { get; set; }

        public int ModelID { get; set; }

        public int ColordID { get; set; }

        public DateTime YearOfProdyction { get; set; }

        public int NumberOfSeats { get; set; }

        public int RepairPrice { get; set; }
    }
}
