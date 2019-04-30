using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    private string _description;
    private static List<Car> _instances = new List<Car> {};


    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public Car (string description)
    {
      _description = description;
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}













// using System;
// using System.Collections.Generic;
//
// namespace CarDealership
// {
//
// class Car //Car class with 3 properties
// {
//   private string MakeModel;
//   // private int Price;
//   // private int Miles;
//   // private string Message;
//
//   public void SetPrice(int newPrice) //'sets' as public so we can access outside of Car class. use void as the return type
//   //since SetPrice() will be setting a value, not returning anything
//   {
//     Price = newPrice; //sets a private Member variable equal to the new value that we passes into SetPrice()
//   }
//
// //access modifyer: public
//   public Car(string makeModel, int price, int miles ) //constructor that takes multiple parameters
//   {
//   //object's properties = constructor method's parameters
//     MakeModel = makeModel;
//     Price = price;
//     Miles = miles;
//   }
//
//   public Car(string makeModel, int price, int miles, string message ) //constructor that takes multiple parameters
//   {
//   //object's properties = constructor method's parameters
//     MakeModel = makeModel;
//     Price = price;
//     Miles = miles;
//     Message = message;
//   }
//
//   public string GetMakeModel() //getter method in Car class for the MakeModel property
//   {
//     return MakeModel; // 'gets' MakeModel
//   }
//
//   public int GetPrice()
//   {
//     return Price;
//   }
//
//   public void SetMessage(string message)
//   {
//     Message = message;
//   }
//
//   public int GetMiles()
//   {
//     return Miles;
//   }
//
//   // public bool WorthBuying(int maxPrice, int maxMiles)//define a WorthBuying method in the Car class. can only be called on Car
//   //objects bc defined in the Car class. WorthBuying takes one argument: maxPrice, and this argument is an int.
//   {
//     // return ((Price < maxPrice)&&(Miles < maxMiles)); //return true or false based on whether price is less than maxPrice
//     }
//   }
// }
