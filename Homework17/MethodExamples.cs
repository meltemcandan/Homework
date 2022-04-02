using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17
{
    public class MethodExamples
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private string School { get; set; }

        public MethodExamples(string name, string surname)
        {
            Name = name;
            Surname = surname;
            School = "";
        }

        public MethodExamples(string name, string surname, string school)
        {
            Name = name;
            Surname = surname;
            School = school;
        }

        public string GetFullName()
        {
            return Name + " " + Surname + " " + School;
        }

        
        public Person GetPerson(string name, string surname, string tc)
        {
            return new Person
            {
                Name = name,
                Surname = surname,
                TC = tc,
            };
        }


    }
    


    
}
