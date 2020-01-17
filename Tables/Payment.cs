namespace Klasy_BazyDanych
{
    class Payment : AbstrarcIdentityTable
    {
        public int PaymentID { get; set; }
        public int ReservationID { get; set; }
        public float Amount { get; set; }
        public string DateRealised { get; set; }
        public int PaymentMethod { get; set; }
    }
}
