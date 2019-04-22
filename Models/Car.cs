using System;

namespace Dealership
{

class Car //Car class with 3 properties
{
  private string MakeModel;
  private int Price;
  private int Miles;

  public void SetPrice(int newPrice) //'sets' as public so we can access outside of Car class. use void as the return type
  //since SetPrice() will be setting a value, not returning anything
  {
    Price = newPrice; //sets a private Member variable equal to the new value that we passes into SetPrice()
  }

//access modifyer: public
  public Car(string makeModel, int price, int miles) //constructor that takes multiple parameters
  {
  //object's properties = constructor method's parameters
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
  }

  public string GetMakeModel() //getter method in Car class for the MakeModel property
  {
    return MakeModel; // 'gets' MakeModel
  }

  public int GetPrice()
  {
    return Price;
  }

  public int GetMiles()
  {
    return Miles;
  }

  public bool WorthBuying(int maxPrice)//define a WorthBuying method in the Car class. can only be called on Car
  //objects bc defined in the Car class. WorthBuying takes one argument: maxPrice, and this argument is an int.
  {
    return (Price < maxPrice); //return true or false based on whether price is less than maxPrice
    }
  }
}
