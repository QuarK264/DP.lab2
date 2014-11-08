namespace DAA.DP.lab2.strategy.Start
{
    using System;

    class NoStart : IStartable
    {
        public void Start()
        {
            Console.WriteLine("Spaceship cann't start");
        }
    }
}
