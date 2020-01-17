namespace Klasy_BazyDanych
{
    class Individual : AbstrarcIdentityTable
    {
        public int IndividualID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CountryName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int CompanyID { get; set; }
    }
}
