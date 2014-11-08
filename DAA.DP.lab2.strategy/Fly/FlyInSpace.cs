namespace DAA.DP.lab2.strategy.Fly
{
    using System;

    class FlyInSpace : IFlyable
    {
        void IFlyable.Fly()
        {
            Console.WriteLine("Spaceship fly");
        }
    }
}
