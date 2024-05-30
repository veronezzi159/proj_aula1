using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_aula1B
{
    internal class BancoMongo
    {
        public string Connection;

        string DataBase;

        string Collection;

        public BancoMongo()
        {
            Connection = "mongodb://root:Mongo@2024#@localhost:27017/mydb";

            DataBase = "DBPenalidades";

            Collection = "PenalidadeAplicada";
        }

        public string GetConnection()
        {
            return Connection;
        }
        public string GetDataBase()
        {
            return DataBase;
        }

        public string GetCollection ()
        {
            return Collection;
        }


    }
}
