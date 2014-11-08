namespace DAA.DP.lab2.strategy
{
    using DAA.DP.lab2.strategy.Spaceships;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<SpaceshipBase> spaceships = new List<SpaceshipBase>();
            spaceships.Add(new NormalSpaceship());
            spaceships.Add(new ToySpaceship());
            spaceships.Add(new SuperSpaceship());

            foreach (var spaceship in spaceships)
            {
                spaceship.Display();
                spaceship.Start();
                spaceship.Fly();
                spaceship.Land();

                Console.WriteLine();
            }

            SpaceshipBase configurableSpaceship = new 
        }
    }
}
