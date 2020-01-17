using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_BazyDanych
{
    class ConferenceDay : AbstrarcIdentityTable
    {
        public int ConferenceDayID { get; set; }
        public int ConferenceID { get; set; }
        public String Date { get; set; }
        public float Price { get; set; }
        public int MaxParticipants { get; set; }
        public int NoInCurrentConference { get; set; }
    }
}
