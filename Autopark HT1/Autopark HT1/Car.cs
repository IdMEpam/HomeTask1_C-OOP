using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark_HT1
{
    class Car 
    {
        public Manufacturer Manufacturer { set; get; }
        public Type Type { set; get; }
        public String Model { set; get; }

        public int Price { set; get; }
        public int Year { set; get; }
        public int Mileage { set; get; }
        public int MaximumSpeed { set; get; }
        public int SeatsNumber { set; get; }
        public float Acceleration { set; get; }
        public bool ManualTransmission { set; get; }
        public bool AirConditioning { set; get; }


        public Car (  Manufacturer manufacturer, Type type, string model, int price, int year, int mileage, int maximumSpeed, int seatsNumber, float acceleration, bool manualTransmission, bool airConditioning )
        {
            
            Manufacturer = manufacturer;
            Type = type;
            Model = model;

            Price = price;
            Year = year;
            Mileage = mileage;
            MaximumSpeed = maximumSpeed;
            SeatsNumber = seatsNumber;
            Acceleration = acceleration;
            ManualTransmission = manualTransmission;
            AirConditioning = airConditioning;
        }

        public override string ToString()
        {
            String InfoAboutCar = $"Manufacture: {Manufacturer}, Type: {Type}, Model: {Model}, Price: {Price}, Year: {Year}, Mileage: {Mileage}, Maximum Speed: {MaximumSpeed}, Seats Number: {SeatsNumber}, Acceleration: {Acceleration}";

            if (ManualTransmission == true)
            {
                InfoAboutCar = InfoAboutCar + ", Manual transmission";
            }
            else 
            {
                InfoAboutCar = InfoAboutCar + ", Auto transmission";
            }

            if (AirConditioning == true)
            {
                InfoAboutCar = InfoAboutCar + ", has air conditioning";
            }
            else
            {
                InfoAboutCar = InfoAboutCar + ", No air conditioning";
            }
            return InfoAboutCar;
        }

        

    }
}
