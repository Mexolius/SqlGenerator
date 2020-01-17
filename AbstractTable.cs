using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_BazyDanych
{
    abstract class AbstractTable : ITable
    {
        public bool IdentityField = true;      

        public virtual string PreSQLInsert()
        {
            return "INSERT INTO " + GetTableName() + GetColumnNames() + "\nVALUES"; ;
        }

        public virtual string PostSQLInsert()
        {
            return ")";
        }

        protected string GetTableName()
        {
            string ret = GetType().ToString();
            return "Tb"+ret.Remove(0, ret.IndexOf('.')+1);
        }

        protected string GetColumnNames()
        {
            return ','.MultipleToString(GetType().GetMembers().Where(mi => mi.MemberType.HasFlag(System.Reflection.MemberTypes.Property) || mi.MemberType.HasFlag(System.Reflection.MemberTypes.Field)).Select(mi => mi.Name));
        }

        public override string ToString()
        {
            return  ','.MultipleToString(GetType().GetProperties().Select(fi => fi.GetValue(this)));

        }

    }
}
