using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_BazyDanych
{
    class Reservation : AbstractTable
    {

        public int Price { get; set; }
        public int ReserverID { get; set; }
    }
}
