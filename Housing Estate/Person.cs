using System;
using System.Collections.Generic;
using System.Text;

namespace Housing_Estate
{
    class Person
    {
        private string name;
        private string surname;
        private int age;

        public Person(string setName, string setSurname, int setAge)
        {
            name = setName;
            surname = setSurname;
            age = setAge;
        }

        public void ToString()
        {
            Console.WriteLine("Name: " + name + " " + surname + " Age: " + age) ;
        }
    }


}
