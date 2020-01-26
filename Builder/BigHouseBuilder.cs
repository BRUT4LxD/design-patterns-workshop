using System;

namespace Builder
{
    public class BigHouseBuilder : IHouseBuilder
    {
        private readonly BigHouse _bigHouse;

        public BigHouseBuilder()
        {
            _bigHouse = new BigHouse();
        }

        public void BuildWalls()
        {
            _bigHouse.Walls = 5;
            Console.WriteLine("Im building the big walls!!");
        }
        public void BuildBackyard()
        {
            _bigHouse.Backyard = true;
            Console.WriteLine("Im building the big backyard!!");
        }
        public void BuildDoors()
        {
            _bigHouse.Doors = 22;
            Console.WriteLine("Im building the big doors!!");
        }
        public void BuildSwimmingPool()
        {
            _bigHouse.SwimmingPool = true;
            Console.WriteLine("Im building the big swimming pool!!");
        }

        public BigHouse GetBigHouse() => _bigHouse;
    }
}