using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace Klasy_BazyDanych
{
    class TableGenerator
    {
        Random r = new Random();
        public List<Company> DeserialiseCompany(string fileName)
        {
            List<Company> ret = new List<Company>();
            string text = System.IO.File.ReadAllText(fileName);
            text = text.Remove(0, 1);
            text = text.Remove(text.Length-1, 1);
            while(text.IndexOf('}')!=-1)
            {
                int limit = text.IndexOf("}")+1;
                string line = text.Substring(0, limit);
                dynamic d = JObject.Parse(line);
                ret.Add(new Company
                {
                    CompanyID = ret.Count,
                    Name = d.Name,
                    Discount = Math.Round(r.NextDouble() / 2,2),
                    ReserverID = 1,
                    CountryName = d.CountryName,
                    City = d.City,
                    Street = d.Street
                });
                int comma = (text.IndexOf(',',limit) != -1) ? 1 : 0;
                text=text.Remove(0, limit + comma);
            }
            return ret;
        }
    }
}
