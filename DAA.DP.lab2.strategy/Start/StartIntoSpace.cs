namespace DAA.DP.lab2.strategy.Start
{
    using System;

    class StartIntoSpace : IStartable
    {
        void IStartable.Start()
        {
            Console.WriteLine("Spaceship started");
        }
    }
}
