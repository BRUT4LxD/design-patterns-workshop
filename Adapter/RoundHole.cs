namespace Adapter
{
    public class RoundHole
    {
        public double Radius { get; set; }

        public RoundHole(double radius)
        {
            Radius = radius;
        }
        public bool Fits(RoundThing thing)
        {
            return Radius >= thing.Radius;
        }
    }
}