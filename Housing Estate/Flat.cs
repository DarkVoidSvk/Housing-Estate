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
        public int capacity = 4;


        public Flat(int setFlatNumber, double setArea, int setRooms)
        {
            flatNumber = setFlatNumber;
            area = setArea;
            rooms = setRooms;
        }

        List<Person> habitantsList = new List<Person>();

        public void AddHabitant(Habitant habitant)
        {
            if (capacity > 0)
            {
                habitantsList.Add(habitant);
                habitant.habitantsFlat = this;
                capacity--;
            }
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
