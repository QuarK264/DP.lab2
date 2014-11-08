namespace DAA.DP.lab2.strategy.Fly
{
    using System;

    class NoFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Spaceship cann't fly");
        }
    }
}
