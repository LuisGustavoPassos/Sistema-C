using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Financeiro
{
    class Conn
    {
        private static string server = "DESKTOP-FVE4V59";
        private static string dataBase = "sistema.financeiro";
        private static string user = "sa";
        private static string password = "teste123";

        public static string StrCon
        {
            get {return $"Data Source={server};Integrated Security=false;Initial Catalog={dataBase}; User ID={user}; Password={password}";}
        }
    }
}
