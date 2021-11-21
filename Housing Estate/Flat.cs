using System;
using System.Collections.Generic;
using System.Text;

namespace Housing_Estate
{
    class Flat
    {
        public int flatNumber;
        public double area;
        public int rooms;

        public Flat(int setFlatNumber, double setArea, int setRooms)
        {
            flatNumber = setFlatNumber;
            area = setArea;
            rooms = setRooms;
        }

        List<Person> habitantsList = new List<Person>();

        public void AddHabitant(Habitant habitant)
        {
            habitantsList.Add(habitant);
            habitant.habitantsFlat = this;
        }

        public void GetInfoAboutAllHabitants()
        {
            foreach (var habitant in habitantsList)
            {
                habitant.ToString();
            }
        }

        public void ToString()
        {
            Console.WriteLine("Flat Number: " + flatNumber + " Area: " + area + " Rooms: " + rooms );
        }

       

    }
}
