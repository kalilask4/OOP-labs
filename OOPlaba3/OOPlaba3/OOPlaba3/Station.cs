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
        public Car[] cars;

        public Station()//string name, string address, int capasity)
        {
            Name = "NonameStation";
            Address = "emptyAddress";
            Capasity = 1;
            cars = new Car[0];

        }
        public override string ToString()
        {
            string str = $"Станция технического обслуживания {Name} вместимостью {Capasity}";
            if (cars.Length < Capasity)
            {
                str += " примет авто на диагностику.";
            }
            else
                str += $" загружена. ";   //Загружена. Авто и % от готовности
            return str;
        }
    }

    }


