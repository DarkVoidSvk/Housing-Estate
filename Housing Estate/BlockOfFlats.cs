using System;
using System.Collections.Generic;
using System.Text;

namespace Housing_Estate
{
    class BlockOfFlats
    {
        int numberOfEntrances = 12;
        int registerNumber; // supisne cislo
        string street;

        public BlockOfFlats(string setStreet, int setRegisterNumber, int setNumberOfEntrances)
        {
            numberOfEntrances = setNumberOfEntrances;
            registerNumber = setRegisterNumber;
            street = setStreet;
        }



    }
}
