using System;

namespace Builder
{
    public class SmallHouseBuilder : IHouseBuilder
    {
        private readonly SmallHouse _smallHouse;

        public SmallHouseBuilder()
        {
            _smallHouse = new SmallHouse();
        }


        public void BuildWalls()
        {
            _smallHouse.Walls = 4;
            Console.WriteLine("Im building the small walls!!");
        }
        public void BuildBackyard()
        {
            _smallHouse.Backyard = false;
            Console.WriteLine("Im building the small backyard!!");
        }
        public void BuildDoors()
        {
            _smallHouse.Doors = 1;
            Console.WriteLine("Im building the small doors!!");
        }
        public void BuildSwimmingPool()
        {
            _smallHouse.SwimmingPool = false;
            Console.WriteLine("Im building the small swimming pool!!");
        }

        public SmallHouse GetSmallHouse() => _smallHouse;
    }
}