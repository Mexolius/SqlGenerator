using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_BazyDanych
{
    class AbstrarcIdentityTable : AbstractTable
    {
        public override string PreSQLInsert()
        {
            return SetIdentityInsertON() + base.PostSQLInsert();
        }

        public override string PostSQLInsert()
        {
            return SetIdentityInsertOFF() + ")";
        }

        private string SetIdentityInsertON()
        {
            return IdentityField ? "SET IDENTITY_INSERT " + GetTableName() + " ON\n" : "";
        }

        private string SetIdentityInsertOFF()
        {
            return IdentityField ? "SET IDENTITY_INSERT " + GetTableName() + " ON\n" : "";
        }
    }
}
