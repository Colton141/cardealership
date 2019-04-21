using System;
using System.Collections.Generic;

namespace Dealership {

public class Program //basic boilerplate code ?
{
  public static void Main()
  {
    Car porsche = new Car("2014 Porsche 911", 114991, 7864);
    Car ford = new Car("2011 Ford F450", 55995, 14241);
    Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
    Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes
  };

    lexus.SetPrice(2000);

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>(0); //new list to hold all the Car object we find which are under the given price.

    foreach (Car automobile in Cars) //loop through all the Car objects which are stored in Cars list. each object in the list we store in teh variable automobile
    {
      if (automobile.WorthBuying(maxPrice)) //check to see if price is less than maxPrice
      {
        CarsMatchingSearch.Add(automobile); //if true, added to new list CarsMatchingSearch
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine("______________________");
      //writes each item in new list to console, GetMakeModel calls GetMakeModel in Car.cs(models folder) from outside the Car class
      Console.WriteLine(automobile.GetMakeModel());
      Console.WriteLine(automobile.GetMiles() + "miles");
      Console.WriteLine("$" + automobile.GetPrice());
      }
    }
  }
}
