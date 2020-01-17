using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_BazyDanych
{
    class Company : AbstrarcIdentityTable
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }
        public int ReserverID { get; set; }
        public String CountryName { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
    }
}
