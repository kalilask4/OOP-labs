﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlaba1
{
    class Car
    {
        public string auto_brands;
        private string model;
        private double fuel_tank_capacity;
        private double fuel_quantity;
        private int current_speed;
        private double fuel_consumption;
        private double[] pressure_whells = new double[4];


        public Car() : this("Noname", "Noname")
        {
        }
        public Car(string auto_brands, string model) : this(auto_brands, model, 0.0, 0.0, 0, 0.0, 0.0, 0.0, 0.0, 0.0)
        {
        }

        public Car(string auto_brands) : this(auto_brands, "", 0.0, 0.0, 0, 0.0, 0.0, 0.0, 0.0, 0.0)
        {
        }

        public Car(string auto_brands, string model, double fuel_tank_capacity,
           double fuel_quantity, int current_speed, double fuel_consumption,
           params double[] pressure_whells)
        {
            this.auto_brands = auto_brands;
            Model = model;
            Fuel_tank_capacity = fuel_tank_capacity;
            Fuel_quantity = fuel_quantity;
            Current_speed = current_speed;
            Fuel_consumption = fuel_consumption;
            Pressure_whells = pressure_whells;
        }

        public string Model { get => model; set => model = value; }

        public double Fuel_tank_capacity
        {
            get
            {
                return fuel_tank_capacity;
            }

            set
            {
                if (value >= 0 & value <= 1000)
                    fuel_tank_capacity = value;
            }
        }

        public double Fuel_quantity
        {
            get
            {
                return fuel_quantity;
            }

            set
            {
                if (value >= 0 & value <= 1000)
                    fuel_quantity = value;
            }
        }

        public int Current_speed
        {
            get
            {
                return current_speed;
            }

            set
            {
                if (value >= 0 & value <= 447)
                    current_speed = value;
            }
        }

        public double Fuel_consumption
        {
            get
            {
                return fuel_consumption;
            }

            set
            {
                if (value >= 0 & value <= 40)
                    fuel_consumption = value;
            }
        }


        public double[] Pressure_whells
        {
            get
            {
                return pressure_whells;
            }

            set
            {
                pressure_whells.Initialize();
                int i = 0;
                foreach (double p in value)
                {
                    if (p >= 0 & p <= 4.5)
                        pressure_whells[i] = p;
                    else throw new Exception("Invalid value!");
                    i++;
                    if (i >= 4) break;
                }
            }
        }
        public double calc_remainder_mileage()
        {
            return ((this.Fuel_tank_capacity - this.Fuel_quantity) / this.Fuel_consumption);
        }

        public override string ToString()
        {
            //return base.ToString();
            return String.Format("The car make is {0}, model is {1}\n" +
                "fuel tank capacity is {2} L \n" +
                "fuel quantity is {3} L \n" +
                "current_speed is {4} km/h\n" +
                "fuel_consumption is {5} L/100km\n" +
                "pressure_whell is {6} - {7} - {8} - {9} Bar\n",
                auto_brands, Model, Fuel_tank_capacity, Fuel_quantity, Current_speed, Fuel_consumption,
                Pressure_whells[0], Pressure_whells[1], Pressure_whells[2], Pressure_whells[3]);
        }


    }
}
