namespace Builder
{
    public class Director
    {
        public IHouseBuilder HouseBuilder { get; private set; }

        public Director()
        {
        }

        public void SetBuilder(IHouseBuilder builder)
        {
            HouseBuilder = builder;
        }

        public void BuildHouse(IHouseBuilder builder)
        {
            builder.BuildBackyard();
            builder.BuildDoors();
            builder.BuildSwimmingPool();
            builder.BuildWalls();
        }
    }
}