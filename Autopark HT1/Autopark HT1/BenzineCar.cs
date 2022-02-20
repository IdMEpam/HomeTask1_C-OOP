using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark_HT1
{
    class BenzineCar : Car
    {
        public String FuelType { set; get; }
        public int FuelTankVolume { set; get; }
        public int FuelEconomy { set; get; }

        public BenzineCar( Manufacturer manufacturer, Type type, string model, int price, int year, int mileage, int maximumSpeed, int seatsNumber, float acceleration, bool manualTransmission, bool airConditioning, string fuelType, int fuelTankVolume, int fuelEconomy)
            : base( manufacturer, type, model, price, year, mileage, maximumSpeed, seatsNumber, acceleration, manualTransmission, airConditioning)
        {
            FuelType = fuelType;
            FuelTankVolume = fuelTankVolume;
            FuelEconomy = fuelEconomy;
        }

        public override string ToString()
        {
            return "Benzine car: " + base.ToString() + $", Fuel Type: {FuelType}, FuelTank Volume: {FuelTankVolume}, Fuel Economy: {FuelEconomy} ";
        }
    }
}

