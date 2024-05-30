using System.Diagnostics;
namespace proj_aula1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\L.Veronezzi\AquivosJson\";
            string file = "motoristas-habilitados.json";

            Console.WriteLine("Inicio do processamento");

            var lst = ReadFile.GetData(path, file);

            //TestFilter.Print(lst);

            //Console.WriteLine(TestFilter.GetCountRecords(lst));

            Console.WriteLine("Listar registros que tenham o numero do cpf iniciando com 237");
            //var lstCpf = TestFilter.GetCpfStartsWith(lst);
            //TestFilter.Print(lstCpf);
            //Console.WriteLine("Numero de CPF's começados em 237: " + lstCpf.Count);

            Console.WriteLine("Listar registros que tenham o plano de vigencia em 2021");
            //var lstVigencia = TestFilter.GetVigenciaYear(lst,2021);
            //TestFilter.Print(lstVigencia);
            //Console.WriteLine("Numero de registros com vigencia em 2021: " + lstVigencia.Count);

            Console.WriteLine("Quantas empresas tem no nome da razao social a descricao LTDA");
            //var lstRazaoSocial = TestFilter.GetRazaoSocialLTDA(lst);
            //TestFilter.Print(lstRazaoSocial);

            Console.WriteLine("Ordenar a lista de registros pela razão social");
            //var lstOrder = TestFilter.OrderByRazaoSocial(lst);
            //TestFilter.Print(lstOrder);

            Console.WriteLine("Inserir todos os reistros no SQLSever");
            //Stopwatch stopwatch = Stopwatch.StartNew();
            //TestFilter.IntoBd(lst);
            //stopwatch.Stop();
            //long elapsed_time = stopwatch.ElapsedMilliseconds;
            //Console.WriteLine("Tempo de execução: " + elapsed_time/1000 + "s");

            //Console.WriteLine("Gerar Arquivo XML");
            //Console.WriteLine(TestFilter.GenerateXML(lst)); 

            //receber dados do SQL
            // enviar os dados recebidos pro Mongo
            // retornar  os meta dados da inserção para uma tabela no sql

           int records=  TestFilter.InsertMongo();

            TestFilter.InsertMetaDados(records);

        }
    }
}
