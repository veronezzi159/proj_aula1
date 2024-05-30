using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_aula1
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }   
        public int Age { get; set; }

        //override public string ToString()
        //{
        //    return $"Id: {Id}, Name: {Name}, Age: {Age}, Phone: {Phone}";
        //}

        public override string ToString() => $"Id: {Id}, Name: {Name}, Age: {Age}, Phone: {Phone}";
        
    }
}
