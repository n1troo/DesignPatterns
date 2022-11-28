using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Person
    {
        public string _perName;
        private readonly int _age;

        public Person(string perName, int age)
        {
            _perName = perName;
            _age = age;
        }

        public void SayHi()
        {
            Console.WriteLine($"Hello my name is {_perName} and my age is {_age}");
        }
    }
}
