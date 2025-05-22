using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Financeiro
{
    class Conn
    {
        private static string server = "4.228.227.110,1433";
        private static string dataBase = "sistema.financeiro";
        private static string user = "sa";
        private static string password = "SistemaFinanceiro@01";

        public static string StrCon
        {
            get {return $"Data Source={server};Integrated Security=false;Initial Catalog={dataBase}; User ID={user}; Password={password}";}
        }
    }
}
