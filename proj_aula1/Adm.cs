using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_aula1
{
    internal class Adm
    {
        public static void PrintData(List<Person> people)
        {
            foreach (var p in people)
            {
                Console.WriteLine(p);
            }
        }

        public static List<Person> ParseData()
        {
            var people = new List<Person>();

            people.Add(new Person() { Id = 2, Name = "Lucas Veronezzi", Age = 20, Phone = "16 994541247" });
            people.Add(new Person() { Id = 3, Name = "Beatriz Veronezzi", Age = 18, Phone = "16 994541247" });
            people.Add(new Person() { Id = 4, Name = "Alessandra Veronezzi", Age = 43, Phone = "16 994541247" });
            people.Add(new Person() { Id = 5, Name = "Vera Veronezzi", Age = 72, Phone = "16 994541247" });
            people.Add(new Person() { Id = 6, Name = "Manu Veronezzi", Age = 12, Phone = "16 994541247" });
            people.Add(new Person() { Id = 7, Name = "Levin Veronezzi", Age = 490, Phone = "16 994541247" });
            people.Add(new Person() { Id = 8, Name = "Ig Veronezzi", Age = 27, Phone = "16 994541247" });
            people.Add(new Person() { Id = 9, Name = "Kevin Veronezzi", Age = 23, Phone = "16 994541247" });
            people.Add(new Person() { Id = 10, Name = "Kevin Veronezzi", Age = 01, Phone = "16 994541247" });
            people.Add(new Person() { Id = 11, Name = "Allen Iverson", Age = 48, Phone = "16 994541247" });
            people.Add(new Person() { Id = 12, Name = "Michael Jordan", Age = 58, Phone = "16 994541248" });
            people.Add(new Person() { Id = 13, Name = "Kobe Bryant", Age = 42, Phone = "16 994541249" });
            people.Add(new Person() { Id = 14, Name = "LeBron James", Age = 36, Phone = "16 994541250" });
            people.Add(new Person() { Id = 15, Name = "Stephen Curry", Age = 33, Phone = "16 994541251" });
            people.Add(new Person() { Id = 16, Name = "Kevin Durant", Age = 32, Phone = "16 994541252" });
            people.Add(new Person() { Id = 17, Name = "James Harden", Age = 31, Phone = "16 994541253" });
            people.Add(new Person() { Id = 18, Name = "Giannis Antetokounmpo", Age = 26, Phone = "16 994541254" });
            people.Add(new Person() { Id = 19, Name = "Anthony Davis", Age = 28, Phone = "16 994541255" });
            people.Add(new Person() { Id = 20, Name = "Damian Lillard", Age = 31, Phone = "16 994541256" });
            people.Add(new Person() { Id = 21, Name = "Luka Dončić", Age = 22, Phone = "16 994541257" });
            people.Add(new Person() { Id = 22, Name = "Kawhi Leonard", Age = 30, Phone = "16 994541258" });
            people.Add(new Person() { Id = 23, Name = "Russell Westbrook", Age = 32, Phone = "16 994541259" });
            people.Add(new Person() { Id = 24, Name = "Chris Paul", Age = 36, Phone = "16 994541260" });
            people.Add(new Person() { Id = 25, Name = "Paul George", Age = 31, Phone = "16 994541261" });
            people.Add(new Person() { Id = 26, Name = "Joel Embiid", Age = 27, Phone = "16 994541262" });
            people.Add(new Person() { Id = 27, Name = "Kyrie Irving", Age = 29, Phone = "16 994541263" });
            people.Add(new Person() { Id = 28, Name = "Jimmy Butler", Age = 31, Phone = "16 994541264" });
            people.Add(new Person() { Id = 29, Name = "Klay Thompson", Age = 31, Phone = "16 994541265" });
            people.Add(new Person() { Id = 30, Name = "Devin Booker", Age = 24, Phone = "16 994541266" });
            people.Add(new Person() { Id = 31, Name = "Jayson Tatum", Age = 23, Phone = "16 994541267" });
            people.Add(new Person() { Id = 32, Name = "Ben Simmons", Age = 25, Phone = "16 994541268" });
            people.Add(new Person() { Id = 33, Name = "Trae Young", Age = 22, Phone = "16 994541269" });
            people.Add(new Person() { Id = 34, Name = "De'Aaron Fox", Age = 23, Phone = "16 994541270" });
            people.Add(new Person() { Id = 35, Name = "Zion Williamson", Age = 21, Phone = "16 994541271" });
            people.Add(new Person() { Id = 36, Name = "Donovan Mitchell", Age = 24, Phone = "16 994541272" });
            people.Add(new Person() { Id = 37, Name = "Ja Morant", Age = 21, Phone = "16 994541273" });
            people.Add(new Person() { Id = 38, Name = "Brandon Ingram", Age = 24, Phone = "16 994541274" });
            people.Add(new Person() { Id = 39, Name = "DeMar DeRozan", Age = 31, Phone = "16 994541275" });
            people.Add(new Person() { Id = 40, Name = "Nikola Jokić", Age = 26, Phone = "16 994541276" });
            people.Add(new Person() { Id = 41, Name = "Rudy Gobert", Age = 28, Phone = "16 994541277" });
            people.Add(new Person() { Id = 42, Name = "Bam Adebayo", Age = 23, Phone = "16 994541278" });
            people.Add(new Person() { Id = 43, Name = "Deandre Ayton", Age = 23, Phone = "16 994541279" });
            people.Add(new Person() { Id = 44, Name = "CJ McCollum", Age = 29, Phone = "16 994541280" });
            people.Add(new Person() { Id = 45, Name = "Jaren Jackson Jr.", Age = 21, Phone = "16 994541281" });
            people.Add(new Person() { Id = 46, Name = "Shai Gilgeous-Alexander", Age = 23, Phone = "16 994541282" });
            people.Add(new Person() { Id = 47, Name = "Kyle Lowry", Age = 35, Phone = "16 994541283" });
            people.Add(new Person() { Id = 48, Name = "Tobias Harris", Age = 29, Phone = "16 994541284" });
            people.Add(new Person() { Id = 49, Name = "Jerami Grant", Age = 27, Phone = "16 994541285" });
            people.Add(new Person() { Id = 50, Name = "Gordon Hayward", Age = 31, Phone = "16 994541286" });
            people.Add(new Person() { Id = 51, Name = "D'Angelo Russell", Age = 25, Phone = "16 994541287" });
            people.Add(new Person() { Id = 52, Name = "Zach LaVine", Age = 26, Phone = "16 994541288" });
            people.Add(new Person() { Id = 53, Name = "Kristaps Porziņģis", Age = 25, Phone = "16 994541289" });
            people.Add(new Person() { Id = 54, Name = "Andre Drummond", Age = 28, Phone = "16 994541290" });
            people.Add(new Person() { Id = 55, Name = "Draymond Green", Age = 31, Phone = "16 994541291" });            


            return people;
        }

        public static List <Person> FilterByAge(List < Person> people, int age)
        {           
            var peopleFiltered = new List<Person>();

            foreach (var p in people)
            {
                if (p.Age >= age)
                {
                    peopleFiltered.Add(p);
                }
            }
            return peopleFiltered;
        }

        public static List <Person> FilterByAgeUseLinq(List<Person> people, int age) => people.Where(p => p.Age >= age).ToList();

        public static List<Person> FilterByWordUseLinq(List<Person> people, char word) => people.Where(p => p.Name[0] == word ).ToList();
        public static List<Person> OrderByName(List<Person> people) => people.OrderBy(p=> p.Name).ToList();
        public static List<Person> OrderByNameDescending(List<Person> people) => people.OrderByDescending(p=> p.Name).ToList();
        public static List<Person> ListNamesWithA(List<Person> people) => people.Where(p => p.Name.Contains("A",StringComparison.OrdinalIgnoreCase) && p.Name.Length > 3).ToList();
    }
}