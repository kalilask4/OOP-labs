using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlaba3
{
    class AutoService
    {
        public string Name { get; set; }
        public Station[] stations;
    
        public AutoService()
    {
        Name = "NonameAutoService";
        stations = new Station[1];
        stations[0] = new Station();
    }

    public AutoService(string name, Station[] stations)
    {
        Name = name;
        this.stations = stations;
    }

        public override string ToString()
        {

            string str = $"\nАвтосервис {Name}. Станций {stations.Length}.\n";
            foreach (Station station in stations) //Здесь можем воспользоваться foreach - данные только считываем
            {
                str += $"{station}\n";
            }
            return str;
        }

    }
}
