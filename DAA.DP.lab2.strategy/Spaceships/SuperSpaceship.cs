namespace DAA.DP.lab2.strategy.Spaceships
{
    using System;

    class SuperSpaceship : SpaceshipBase
    {
        public SuperSpaceship()
        {
            FlyBehaviour = new SuperFly();
        }
        public override void Display()
        {
            Console.WriteLine("This is super spaceship");
        }
    }
}
