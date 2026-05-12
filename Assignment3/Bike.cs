namespace Assignment3
{
    internal class Bike : Delivery
    {
        public Bike(double distance) : base(distance)
        {
        }

        public override string deliver()
        {
            return $"The Bike is on the way The Cost Of Your Delivery is {(base.Distance) * 0.11}";
        }
    }
}
