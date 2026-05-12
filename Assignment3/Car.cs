namespace Assignment3
{
    internal class Car : Delivery
    {
        public Car(double distance) : base(distance)
        {
        }

        public override string deliver()
        {
            return $"The Car is on the way The Cost Of Your Delivery is {(base.Distance)*0.2}";
        }
    }
}
