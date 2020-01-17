namespace Klasy_BazyDanych
{
    class Participant : AbstractTable
    {
        public int IndividualID { get; set; }
        public int WorkshopInDayID { get; set; }
        public int ConferenceDayID { get; set; }
        public int ReservationID { get; set; }
        public bool Present { get; set; }
    }
}
