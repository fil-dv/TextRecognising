using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetBuilder
{
    public static class Settings
    {
        static string _conectionString = "User ID = genka; password = genka;Data Source = CD_WORK";
        static public string ConectionString { get { return _conectionString; } }
    }
}
