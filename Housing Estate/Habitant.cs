using System;
using System.Collections.Generic;
using System.Text;

namespace Housing_Estate
{
    class Habitant : Person
    {
        public Flat habitantsFlat;

        public Habitant(string setName, string setSurname, int setAge) : base(setName, setSurname, setAge) {}

        public void GetInfoAboutFlat()
        {
            Console.WriteLine("Flat Number: " + habitantsFlat.flatNumber + " Area: " + habitantsFlat.area + " Rooms: " + habitantsFlat.rooms);
        }

    }
}
