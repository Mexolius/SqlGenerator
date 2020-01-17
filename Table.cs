using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_BazyDanych
{
    interface ITable
    {
        string ToString();
        string PreSQLInsert();
        string PostSQLInsert();
    }
}
