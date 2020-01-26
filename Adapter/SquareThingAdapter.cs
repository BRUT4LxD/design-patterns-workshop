namespace Adapter
{
    public class SquareThingAdapter : RoundThing
    {
        private readonly SquareThing _squareThing;

        public SquareThingAdapter(SquareThing squareThing)
        {
            _squareThing = squareThing;
        }

        public double GetRadius()
        {
            return _squareThing.Width / 2;
        }
    }
}