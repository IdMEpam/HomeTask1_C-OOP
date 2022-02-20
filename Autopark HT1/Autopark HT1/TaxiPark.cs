using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark_HT1
{
    class TaxiPark
    {

        public static int CarsCost(List<Car> cars)
        {
            int sum = 0;
            foreach(Car car in cars)
            {
                sum += car.Price;
            }
            return sum;
        }

        public static List<Car> SearchBySpeed(List<Car> cars, int min, int max)
        {
            List<Car> SelectedCars = new List<Car>();

            foreach(Car car in cars)
            {
                if(car.MaximumSpeed >= min && car.MaximumSpeed <=max)
                {
                    SelectedCars.Add(car);

                }
            }

            return SelectedCars;
        }

        public static List<Car> SearchByYear(List<Car> cars, int min_year, int max_year)
        {
            List<Car> SelectedCars = new List<Car>();

            foreach(Car car in cars)
            {
                if(car.Year >= min_year && car.Year <= max_year)
                {
                    SelectedCars.Add(car);
                }
            }

            return SelectedCars;
        }

        public static List<Car> SearchManufacture(List<Car> cars, Manufacturer manufacturer)
        {
            List<Car> SelectedCars = new List<Car>();

            foreach(Car car in cars)
            {
                if(car.Manufacturer == manufacturer)
                {
                    SelectedCars.Add(car);
                }
            }
            return SelectedCars;
        }

        public static List<Car> SortByFuelEconomy(List<Car> cars)
        {
            List<BenzineCar> benzineCars = new List<BenzineCar>();
            List<ElectroCar> electroCars = new List<ElectroCar>();

            if(cars.Count ==0)
            {
                Console.WriteLine("0 cars");
            }

            foreach (Car car in cars)
            {
                if (car is BenzineCar)
                {
                    benzineCars.Add(car as BenzineCar);
                }
                else if (car is ElectroCar)
                {
                    electroCars.Add(car as ElectroCar);
                }
            }

            benzineCars.Sort((car1, car2) => car1.FuelEconomy.CompareTo(car2.FuelEconomy));
            electroCars.Sort((car1, car2) => car1.LifetimeBattery.CompareTo(car2.LifetimeBattery));

            List<Car> sortedResult = new List<Car>();
            sortedResult.AddRange(benzineCars);
            sortedResult.AddRange(electroCars);

            return sortedResult;


        }
    }
}
