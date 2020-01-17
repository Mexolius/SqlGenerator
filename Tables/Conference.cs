using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_BazyDanych
{
    class Conference : AbstrarcIdentityTable
    {
        public int ConferenceID { get; set; }
        public string ConferenceName { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
    }
}
