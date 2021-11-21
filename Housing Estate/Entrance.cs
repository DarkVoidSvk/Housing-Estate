using System;
using System.Collections.Generic;
using System.Text;

namespace Housing_Estate
{
    class Entrance
    {
        private int floors = 7;
        private int flatsPerFloor = 2;
        private int totalFlats = 14;
        private int orientationalNumber;
        public BlockOfFlats belongingBlockOfFlats;

        List<Flat> flatsList = new List<Flat>();

        

        public Entrance(int setOrientationalNumber)
        {
            orientationalNumber = setOrientationalNumber;
        }


    }
}
