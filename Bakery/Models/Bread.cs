using System;

namespace Bakery.Models
{
  public class Bread : BakedGood
  {
    public Bread()
    {
      UnitPrice = 5;
    }
    public override double Discount => Math.Floor(Count / 3.0) * UnitPrice;
  }
}