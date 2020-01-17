using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_BazyDanych
{
    class WorhshopInDay : AbstractTable
    {

        public int WorkshopID { get; set; }
        public int ConferenceDayID { get; set; }
        public String StartTime { get; set; }
        public String EndTime { get; set; }
        public int Roomnumber { get; set; }
        public int MaxParticipants { get; set; }
        public int PelegentID { get; set; }
    }
}
