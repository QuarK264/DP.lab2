namespace DAA.DP.lab2.strategy.Spaceships
{
    using DAA.DP.lab2.strategy.Fly;
    using DAA.DP.lab2.strategy.Land;
    using DAA.DP.lab2.strategy.Start;
    using System;

    public abstract class SpaceshipBase
    {
        protected IStartable StartBehaviour;
        protected IFlyable FlyBehaviour;        
        protected ILandable LandBehaviour;

        public SpaceshipBase()
        {
            StartBehaviour = new StartIntoSpace();
            FlyBehaviour = new FlyInSpace();
            LandBehaviour = new LandOnEarth();
        }

        public void SetStartBehaviour(IStartable newStartBehaviour)
        {
            StartBehaviour = newStartBehaviour;
        }

        public void SetFlyBehaviour(IFlyable newFlyBehaviour)
        {
            FlyBehaviour = newFlyBehaviour;
        }

        public void SetLandBehavior(ILandable newLandBehaviour)
        {
            LandBehaviour = newLandBehaviour;
        }

        public void Start()
        {
            StartBehaviour.Start();
        }

        public void Fly()
        {
            FlyBehaviour.Fly();
        }

        public void Land()
        {
            LandBehaviour.Land();
        }
        public abstract void Display();
    }
}
