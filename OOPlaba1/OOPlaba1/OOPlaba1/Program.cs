using System;

namespace OOPlaba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine(car1);
            Car car2 = new Car("Dodge");
            Console.WriteLine(car2);
            Car car3 = new Car("Alfa Romeo", "Alfa Romeo", 92.5, 80.0, 105, 7, 2.5, 2.5, 2.3, 1.4); //
            Console.WriteLine(car3);
            // в массив добавлено значение, не проходящее по условию, exeption
            //Car car4 = new Car("Jeep", "", 92.5, 80.0, 130, 7, 3, 3, 2.9, 9); //
            //Console.WriteLine(car4);
            Car carRick = new Car("Chevrolet", "Caprice", 95, 80.0, 120, 9, 2.9, 3, 2.9, 3.9);
            Console.WriteLine(carRick);
            //массив превышен, но все работает благодаря params
            Car carElon = new Car("BMW", "3", 95, 85.0, 140, 9, 3, 3, 2.9, 2.9); //
            Console.WriteLine(carElon);
            //массив заполнен не полностью, но все работает благодаря params
            Car carBat = new Car("Ford", "Lincoln Futura", 80, 50.0, 140, 2, 2, 2.9); //
            Console.WriteLine(carBat);
            Console.WriteLine("__________________________________________");
        }
    }
}
