using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autopark_HT1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> taxipark = new List<Car>
            {
                new BenzineCar( Manufacturer.Audi, Type.Coupe,"T9",  80000, 2017, 0, 155, 2, 5.3f, true, true, "gasBetter", 40, 16),
                new ElectroCar( Manufacturer.Tesla, Type.Coupe,"Model S", 55000, 2016,  405,241, 2, 2.5f, true, true, "Lighting", 470, 380),
                new BenzineCar( Manufacturer.Maserati, Type.Hatchback,"Colt", 20000, 2014, 50, 120,5, 6.3f, true, true, "gasBetter", 70, 10),
                new ElectroCar( Manufacturer.Nissan, Type.Hatchback,"Leaf",  17000, 2016,405, 241, 5, 2.5f, true, true, "Lighting", 200, 150),
            };


			Console.WriteLine("Calculating total taxi park cost ");
			int carsCost = TaxiPark.CarsCost(taxipark);
			Console.WriteLine($"Autopark total cost is ${carsCost}");

			Console.WriteLine();
			Console.WriteLine("Searching cars by speed");
			List<Car> carsBySpeed = TaxiPark.SearchBySpeed(taxipark, 150, 160);

			if (carsBySpeed.Count == 0)
			{
				Console.WriteLine("There are no cars with defined maximum speed");
			}
			else
			{
				foreach (Car car in carsBySpeed)
				{
					Console.WriteLine(car);
				}
			}

			Console.WriteLine();
			Console.WriteLine("Searching cars by year");
			List<Car> carsByYear = TaxiPark.SearchByYear(taxipark, 2015, 2016);

			if (carsByYear.Count == 0)
			{
				Console.WriteLine("There are no cars with defined years");
			}
			else
			{
				foreach (Car car in carsByYear)
				{
					Console.WriteLine(car);
				}
			}

			Console.WriteLine();
			Console.WriteLine("Searching cars by manufacture");
			List<Car> carsManufacture = TaxiPark.SearchManufacture(taxipark, Manufacturer.Audi);

			if (carsManufacture.Count == 0)
			{
				Console.WriteLine("There are no cars with defined manufacture");
			}
			else
			{
				foreach (Car car in carsManufacture)
				{
					Console.WriteLine(car);
				}
			}

			Console.WriteLine();
			Console.WriteLine("Sorting cars by fuel economy");
			List<Car> sortedListByFuelEconomy = TaxiPark.SortByFuelEconomy(taxipark);
			foreach (var car in sortedListByFuelEconomy)
			{
				Console.WriteLine(car);
			}

			Console.WriteLine();
			Console.WriteLine("Using interface implementation");
			Coupe coupe = new Coupe(Manufacturer.MercedesBenz, Type.Coupe, "GT 4-Door Coupe", 30000, 2013, 100, 220,  2, 2.3f,  true, true, "gasoline", 40, 16, 205.6, 5, 1);
			coupe.AddPassenger();
			coupe.AddPassenger();
			Console.WriteLine(coupe.ToString());
			Console.WriteLine("Trailer ID: "+ coupe.GetTrailerID());
			Console.WriteLine("Trailer Volume: " + coupe.GetTrailerVolume());
			Console.WriteLine("Passenger Count: " + coupe.GetPassengerCount());
		}

	}
}
