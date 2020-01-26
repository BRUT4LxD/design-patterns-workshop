using System;

namespace Factory
{
    internal class Car : ITransport
    {

        public string Mark { get; }
        public string Model { get; }
        public int ProductionYear { get; }
        public Car(int productionYear, string model, string mark)
        {
            ProductionYear = productionYear;
            Model = model;
            Mark = mark;
        }

        public void Move()
        {
            Console.WriteLine("BRUM BRUM... ehu ehu!!");
        }

        public void IntroduceYourself()
        {
            Console.WriteLine("Hello, I'm a car and who CARes which car I am");
        }
    }
}
