/*This program takes a monetary amount from the user and converts it to the fewest possible coins*/
using System;

namespace ConvertToCoins
{
  class MainClass
  {
    static double gold = 10;
    static double silver = 5;
    static double userAmount;
    static double goldCoins;
    static double remainder;
    static double silverCoins;

    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Cash converter!");
      getAmount();
      findMaxGold();
      findMaxSilver();
      printResult();
      
    }

    public static void getAmount(){
      Console.WriteLine("how much would like to convert into coins?");
      string userInput = Console.ReadLine();

      try{
        userAmount = Math.Floor(Convert.ToDouble(userInput));
        Console.WriteLine($"you have chosen to convert {userAmount} into coins");
        Console.WriteLine($"{userAmount} is equal to ...");
      }catch(FormatException){
        Console.WriteLine("invalid input, please provide a valid input");
        getAmount();
      }
    }

    public static void findMaxGold(){
        goldCoins = Math.Floor(userAmount/gold);
        remainder = userAmount%gold;
      }

    public static void findMaxSilver(){
        silverCoins = Math.Floor(remainder/ silver);
        remainder = remainder%silver;
      }

    public static void printResult(){
      Console.WriteLine($"Gold coins: {goldCoins}\nSilver coins: {silverCoins}\nBronze coins: {remainder}");
    }
  }
}