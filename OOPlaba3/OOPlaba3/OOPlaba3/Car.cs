using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlaba3
{
    class Car
    {
      
        public string Model { get; set; }
        public string Number { get; set; }
        public string Vin { get; set; } //Vehicle Identification Number
        public bool Is_varning { get; set; }
        public bool Is_Sto_registed { get; set; }
        //+ class Engine engine;
        //+ class Driver driver;

        public Car()
        {
            Model = "NoModel";
            Number = "NoNumber";
        }



    }
}
