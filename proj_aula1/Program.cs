using proj_aula1;
using System.Numerics;
using System.Xml.Linq;
namespace proj_aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio do Processamento");           
            var people = Adm.ParseData();

            Adm.PrintData(people);

            Console.WriteLine("\nListar todas as pessoas que tem mais de 18 anos\n");

            var peopleFiltered = Adm.FilterByAge(people, 18);
            Adm.PrintData(peopleFiltered);

            Console.WriteLine("Novo metodo");
            var peopleFiltered2 = Adm.FilterByAgeUseLinq(people, 18);
            Adm.PrintData(peopleFiltered2);

            Console.WriteLine("\nPessoas com a letra A");
            var peopleFiltered3 = Adm.FilterByWordUseLinq(people, 'A');
            Adm.PrintData(peopleFiltered3);

            Console.WriteLine("\n Ordenar por Nome");
            var peopleFiltered4 = Adm.OrderByName(people);
            Adm.PrintData(peopleFiltered4);

            Console.WriteLine("\nOrdem Desc.");
            var peopleFiltered5 = Adm.OrderByNameDescending(people);
            Adm.PrintData(peopleFiltered5);

            Console.WriteLine("\nListar todas as pessoas que tenham a letra a no nome e o nome tem q ter mais de 3 caracteres");
            var peopleFiltered6 = Adm.ListNamesWithA(people);
            Adm.PrintData(peopleFiltered6);
        }
    }
}
