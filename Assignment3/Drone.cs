namespace Assignment3
{
    internal class Drone : Delivery
    {
        public Drone(double distance) : base(distance)
        {
        }

        public override string deliver()
        {
            return $"The Drone is on the way The Cost Of Your Delivery is {(base.Distance) * 0.35}";
        }
    }
}
