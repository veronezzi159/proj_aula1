using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_aula1B
{
    internal class Banco
    {
        private string Conection;

        public Banco()
        {
            Conection += "Data Source=127.0.0.1;"; // Server
            Conection += "Initial Catalog=DBPenalidades_Aplicadas;"; //DataBase
            Conection += " User Id=sa; Password=SqlServer2019!;";//User and Password
            Conection += "TrustServerCertificate=Yes;";//certificate
        }
        public string Path()
        {
            return Conection;
        }
    }
}
