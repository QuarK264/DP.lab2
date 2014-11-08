namespace DAA.DP.lab2.strategy.Land
{
    using System;

    class NoLand : ILandable
    {
        public void Land()
        {
            Console.WriteLine("Spaceship couldn't land");
        }
    }
}
