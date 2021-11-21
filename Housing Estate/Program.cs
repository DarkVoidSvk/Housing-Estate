using System;

namespace Housing_Estate
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Name", "Surname", 16);
            var person2 = new Person("Name1", "Surname1", 16);
            var habitant = new Habitant("Name2", "Surname2", 17);

            

            var flat = new Flat(125, 248.4, 984);
            flat.AddHabitant(habitant);


           
            flat.ToString();
            flat.GetInfoAboutAllHabitants();

            Console.WriteLine();

            person1.ToString();
            person2.ToString();

            Console.WriteLine();

            habitant.GetInfoAboutFlat();

            Console.WriteLine();

            habitant.ToString();
        }
    }
}
