using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_BazyDanych
{
    static class GeneralMthods
    {
        static public String MultipleToString(this char separator, params Object[] a)
        {
            String ret = "(";
            foreach (Object b in a) ret += b.ToString() + separator;
            ret = ret.Remove(ret.Length - 1);
            return ret + ")";
        }

        static public string MultipleToString(this char separator, IEnumerable a)
        {
            String ret = "(";
            foreach (Object b in a) ret += b.ToString() + separator;
            ret = ret.Remove(ret.Length - 1);
            return ret + ")";
        }
    }
}
