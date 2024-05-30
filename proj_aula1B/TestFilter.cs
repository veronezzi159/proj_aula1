using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core.Configuration;

namespace proj_aula1B
{
    internal class TestFilter
    {
        public static int GetCountRecords(List<PenalidadesAplicadas> lst ) => lst.Count;

        public static void Print(List <PenalidadesAplicadas> lst)
        {
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }

        public static List <PenalidadesAplicadas> GetCpfStartsWith(List<PenalidadesAplicadas> lst) => lst.Where(pn => pn.Cpf.StartsWith("237")).ToList();
        
        public static List <PenalidadesAplicadas> GetVigenciaYear(List<PenalidadesAplicadas> lst, int year) => lst.Where(pn => pn.VigenciaCadastro.Year == year).ToList();

        public static List <PenalidadesAplicadas> GetRazaoSocialLTDA(List<PenalidadesAplicadas> lst) => lst.Where(pn => pn.RazaoSocial.Contains("LTDA", StringComparison.OrdinalIgnoreCase)).ToList();

        public static List <PenalidadesAplicadas> OrderByRazaoSocial (List <PenalidadesAplicadas> lst) => lst.OrderBy(pn => pn.RazaoSocial).ToList();
        
        public static void IntoBd(List <PenalidadesAplicadas> lst)
        {
            Banco banco = new Banco();
            SqlConnection sqlConnection = new SqlConnection(banco.Path());
            sqlConnection.Open();
            

            foreach (var item in lst)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO PenalidadeAplicada (RazaoSocial, Cnpj, NomeMotorista, Cpf, VigenciaCadastro)" +
                " VALUES (@RazaoSocial, @Cnpj, @NomeMotorista, @Cpf, @VigenciaCadastro )", sqlConnection);

                cmd.Connection = sqlConnection;            

                cmd.Parameters.Add(new SqlParameter("@RazaoSocial", System.Data.SqlDbType.VarChar, 50)).Value = item.RazaoSocial;
                cmd.Parameters.Add(new SqlParameter("@Cnpj", System.Data.SqlDbType.VarChar, 50)).Value = item.Cnpj;
                cmd.Parameters.Add("@NomeMotorista", System.Data.SqlDbType.VarChar, 50).Value = item.NomeMotorista;
                cmd.Parameters.Add(new SqlParameter ("@Cpf", System.Data.SqlDbType.VarChar, 50)).Value = item.Cpf;
                cmd.Parameters.Add(new SqlParameter("@VigenciaCadastro", System.Data.SqlDbType.DateTime)).Value = item.VigenciaCadastro;

                cmd.ExecuteNonQuery();
                
                
               
            }
            sqlConnection.Close();             
        }

        public static string GenerateXML(List <PenalidadesAplicadas> lst)
        {
            if (lst.Count > 0)
            {

                var penalidadesAplicada = new XElement("Root", from data in lst                                                               
                                                               select new XElement("motorista",
                                                               new XElement("RazaoSocial", data.RazaoSocial),
                                                               new XElement("Cnpj", data.Cnpj),
                                                               new XElement("NomeMotorista", data.NomeMotorista),
                                                               new XElement("Cpf", data.Cpf),
                                                               new XElement("VigenciaCadastro", data.VigenciaCadastro)
                                                               )
                                                            );
                return penalidadesAplicada.ToString();

            }
            else
            {
                return "Não Existe registros para gerar o XML";
            }
                
                
        }

        public static int InsertMongo()
        {
            int count = 0;  

            Banco banco = new Banco();
            SqlConnection sqlConnection = new SqlConnection(banco.Path());
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("[dbo].[selectDados]", sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Connection = sqlConnection;
            List <BsonDocument> list = new List <BsonDocument>();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int  Id = int.Parse(reader["id"].ToString());
                    string razaoSocial = reader["RazaoSocial"].ToString();
                    string cnpj = reader["Cnpj"].ToString();
                    string nomeMotorista = reader["NomeMotorista"].ToString() ;
                    string cpf = reader["Cpf"].ToString();
                    DateTime vigencia = DateTime.Parse(reader["VigenciaCadastro"].ToString());
                    

                    var document = new BsonDocument() {
                    { "Id", Id },
                    { "Razao_Social", razaoSocial },
                    { "Cnpj", cnpj },
                    { "Nome_Motorista", nomeMotorista },
                    {"Cpf", cpf },
                    {"Data_Vigencia", vigencia }
                    };

                    list.Add(document);
                    count++;

                }
            }

            BancoMongo dbMongo = new BancoMongo();
            var _server = new MongoClient(dbMongo.GetConnection());

            var client = new MongoClient(dbMongo.GetConnection());
            var dataBase = client.GetDatabase(dbMongo.GetDataBase());
            var collection = dataBase.GetCollection<BsonDocument>(dbMongo.GetCollection());

            collection.InsertMany(list);
            Console.WriteLine($"{count} registros inseridos com sucesso");

            return count;
        }

        public static void InsertMetaDados(int Records)
        {
            Banco banco = new Banco();
            SqlConnection sqlConnection = new SqlConnection(banco.Path());
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO MetaDados (Descricao, DataTempo, NumerosDeRegistros)" +
                " VALUES (@Description, @DateTim, @NumberOfRecords )", sqlConnection);

            cmd.Connection = sqlConnection;

            cmd.Parameters.Add(new SqlParameter("@Description", System.Data.SqlDbType.VarChar, 50)).Value = "Inserção de Dados";
            cmd.Parameters.Add(new SqlParameter("@DateTim", System.Data.SqlDbType.DateTime)).Value = DateTime.Now;
            cmd.Parameters.Add(new SqlParameter("@NumberOfRecords", System.Data.SqlDbType.Int)).Value = Records;
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        
    }
}
