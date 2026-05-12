
using Assignment3;

Console.WriteLine("Enter the Delivery Way ( 1- Car , 2- Bike , 3- Drone )?");
int deliveryWay;
deliveryWay = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the Distance?");
double distanceEntry = Convert.ToDouble(Console.ReadLine());
Delivery deliveryService;
switch (deliveryWay)
{
    case 1: 
        deliveryService = new Car(distanceEntry); break;
    case 2:
        deliveryService = new Bike(distanceEntry); break;
    case 3:
        deliveryService = new Drone(distanceEntry); break;
    default:
        throw new Exception("Invalid input...");
}
Console.WriteLine(deliveryService.deliver());
