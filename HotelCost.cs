using System;

class HotelCost
{
  static void Main()
  {
    Console.WriteLine("In what season are you booking a stay?");
    string season = Console.ReadLine();

    Console.WriteLine("On the weekend or a weeknight?");
    string dayOfWeek = Console.ReadLine();

    bool summer = season == "summer";
    bool weekend = dayOfWeek == "weekend";

    if (summer && weekend)
    {
      Console.WriteLine("Your stay may be espensive. Summer + Weekend = Lots of Cash");
    }
    else if (summer || weekend)
    {
      Console.WriteLine("Your stay might be more expensive than normal!");
    }
    else if (!(summer || weekend))
    {
      Console.WriteLine("Your stay will be as cheap as possible!");
    }
    else
    {
      Console.WriteLine("You may not be Gucci Mane, but you can probably afford this hotel");
    }
  }
}