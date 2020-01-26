namespace Factory
{
    internal static class TransportFactory
    {
        internal static ITransport CreateTransport(bool isCar)
        {
            if (isCar)
            {
                return new Car(1111, "Predkosci", "Demon");
            }

            return new Ship();
        }
    }
}