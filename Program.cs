using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Klasy_BazyDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            TableGenerator fr = new TableGenerator();
            List<Company> companies = fr.DeserialiseCompany(@"C:\Users\ernit\source\repos\Klasy-BazyDanych\Klasy-BazyDanych\Companies.json");
            WrtieFileInOutput("Companies.sql", ToFullSQLInsert(companies.ConvertAll<AbstractTable>(c => (AbstractTable)c)));
            Console.ReadLine();
        }

        static string ToFullSQLInsert(List<AbstractTable> at)
        {
            if (at.Count == 0) return "";
            else
            {
                string ret = "";
                ret += at[0].PreSQLInsert();
                ret += ','.MultipleToString(at) + "\n";
                ret += at[0].PostSQLInsert();
                return ret;
            }
        }

        static void WrtieFileInOutput(string filename, string text)
        {
            System.IO.File.WriteAllText(@"C:\Users\ernit\source\repos\Klasy-BazyDanych\Klasy-BazyDanych\Output\" + filename, text);
        }
    }
}
