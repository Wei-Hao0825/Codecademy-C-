using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins:");
      string total = Console.ReadLine();

      // converting the user input string to a number
      double totalNumber = Convert.ToDouble(total);

      Console.WriteLine($"{total} cents is equal to...");

      // bronze coins to gold or silver coins
      int goldValue = 10;
      int silverValue = 5;

      double goldCoins = Math.Floor(totalNumber / goldValue);
      double leftOver = totalNumber % goldValue;

      double silverCoins = Math.Floor(leftOver / silverValue);
      double bronzeCoins = leftOver % silverValue;

      Console.WriteLine("Gold coins: " + goldCoins);
      Console.WriteLine("Silver coins: " + silverCoins);
      Console.WriteLine("Bronze coins: " + bronzeCoins);
    }
  }
}
