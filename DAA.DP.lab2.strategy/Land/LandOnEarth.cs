namespace DAA.DP.lab2.strategy.Land
{
    using System;

    class LandOnEarth : ILandable
    {
        void ILandable.Land()
        {
            Console.WriteLine("Spaceship landed");
        }
    }
}
