using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_BazyDanych
{
    class WorkshopReservation : AbstractTable
    {

        public int WorkshopInDayID { get; set; }
        public int ReservationID { get; set; }
        public int Participants { get; set; }
    }
}
