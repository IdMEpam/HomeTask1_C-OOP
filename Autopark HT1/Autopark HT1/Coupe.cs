using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark_HT1
{
    class Coupe : BenzineCar, ITrailer, IPassenger
    {
        private double TrailerVolume = 0;
        private int TrailerID = 0;
        private int Passengers = 0;

        public Coupe(Manufacturer manufacturer, Type type, string model, int price, int year, int mileage, int maximumSpeed, int seatsNumber, float acceleration, bool manualTransmission, bool airConditioning, string fuelType, int fuelTankVolume, int fuelEconomy)
           : base(manufacturer, type, model, price, year, mileage, maximumSpeed, seatsNumber, acceleration, manualTransmission, airConditioning, fuelType, fuelTankVolume,fuelEconomy)
        {
            
        }

        public Coupe(Manufacturer manufacturer, Type type, string model, int price, int year, int mileage, int maximumSpeed, int seatsNumber, float acceleration, bool manualTransmission, bool airConditioning, string fuelType, int fuelTankVolume, int fuelEconomy, double trailerVolume, int trailerID, int passengers)
           : base(manufacturer, type, model, price, year, mileage, maximumSpeed, seatsNumber, acceleration, manualTransmission, airConditioning, fuelType, fuelTankVolume, fuelEconomy)
        {
            Passengers = passengers;
            TrailerVolume = trailerVolume;
            TrailerID = trailerID;
        }

        public double GetTrailerVolume()
        {
            if(TrailerVolume == 0)
            {
                Console.WriteLine("Trailer not assigned to this vehicle");
            }
            return TrailerVolume;
        }
        public int GetTrailerID()
        {
            if(TrailerID ==0)
            {
                Console.WriteLine("Trailer not assigned to this vehicle");
            }
            return TrailerID;
        }

        public int AddPassenger()
        {
            if(Passengers < SeatsNumber)
            {
                Passengers++;
                return Passengers;
            }
            else
            {
                return Passengers;
            }
        }
        public int GetPassengerCount()
        {
            return Passengers;
        }
    }
}
