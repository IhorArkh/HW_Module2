using HW_2_3_vehicle.AirPlanes;
using HW_2_3_vehicle.Trains;

namespace HW_2_3_vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane(300, 10000, 1000);
            PassengerPlane passengerPlane = new PassengerPlane(270, 20000, 980, 75);
            PrivateJet businessJet = new PrivateJet(350, 5000, 500, 14, "Bill Gates");
            RegularPlane boeing737 = new RegularPlane(290, 22110, 777, 111, true);
            WarPlane warPlane = new WarPlane(450, 3000, 300, "Missles");
            Car infinityQ50 = new Car(240, 1500, "Infinity", 4);
            F1Car f1Car = new F1Car(380, 900, "Renault", 1, false, "RedBull");
            FamilyCar citroenC5 = new FamilyCar(160, 2000, "Citroen", 5, 9);
            RallyCar subaruImpreza = new RallyCar(270, 1300, "Subaru", 4, true, "Toyo");
            SportCar porsche911 = new SportCar(312, 1050, "Porsche", 2, true);
            CargoTrain cargoTrain = new CargoTrain(90, 150000, 20, "Oil");
            PassengerTrain intercity = new PassengerTrain(180, 30000, 12, 2);
            Train train = new Train(130, 90000, 15);
        }
    }
}   