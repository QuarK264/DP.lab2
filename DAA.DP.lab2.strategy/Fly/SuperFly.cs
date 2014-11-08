namespace DAA.DP.lab2.strategy.Spaceships
{
    using DAA.DP.lab2.strategy.Fly;
    using System;

    class SuperFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("This spaceship also can fly to other planets");
        }
    }
}
