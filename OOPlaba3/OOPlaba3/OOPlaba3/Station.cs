using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlaba3
{
    class Station
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Capasity { get; set; }
        //+cars array

        public Station()//string name, string address, int capasity)
        {
            Name = "NonameStation";
            Address = "emptyAddress";
            Capasity = 1;

        }
        public override string ToString()
        {

            string str = $"Станция технического обслуживания {Name} вместимостью {Capasity}";
            return str;
        }
    }

    }


