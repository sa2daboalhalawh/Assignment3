namespace Assignment3
{
    public abstract class Delivery : Idelivery
    {
        private double distance;

        protected Delivery(double distance)
        {
            this.distance = distance <= 0 ? throw new Exception("Not valied Entry") : distance;
        }

        public double Distance 
        {
            get 
            { 
                return distance; 
            }
            set 
            {

                this.distance = distance <= 0 ? throw new Exception("Not valied Entry") : distance;
            } 
        }

        public abstract string deliver();
            
    }
}
