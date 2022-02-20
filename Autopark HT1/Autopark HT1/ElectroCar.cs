using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark_HT1
{
    class ElectroCar : Car
    {

        public String BatteryType { set; get; }
        public int ChargingTime { set; get; }
        public int LifetimeBattery { set; get; }

        public ElectroCar( Manufacturer manufacturer, Type type, string model, int price, int year, int mileage, int maximumSpeed, int seatsNumber, float acceleration, bool manualTransmission, bool airConditioning, string batteryType, int chargingTime, int lifetimeBattery)
            : base( manufacturer, type, model, price, year, mileage, maximumSpeed, seatsNumber, acceleration, manualTransmission, airConditioning)
        {
            BatteryType = batteryType;
            ChargingTime = chargingTime;
            LifetimeBattery = lifetimeBattery;
        }

        public override string ToString()
        {
            return "Electro car: " + base.ToString() + $", Battery Type: {BatteryType}, Charging Time: {ChargingTime}, Lifetime Battery: {LifetimeBattery} ";
        }
    }
}
