namespace DAA.DP.lab2.strategy.Spaceships
{
    using DAA.DP.lab2.strategy.Fly;
    using DAA.DP.lab2.strategy.Land;
    using DAA.DP.lab2.strategy.Start;
    using System;

    class ToySpaceship : SpaceshipBase
    {
        public ToySpaceship()
        {
            StartBehaviour = new NoStart();
            FlyBehaviour = new NoFly();
            LandBehaviour = new NoLand();
        }
        public override void Display()
        {
            Console.WriteLine("This is spaceship toy");
        }
    }
}
