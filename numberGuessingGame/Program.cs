using System;

namespace Review
{
  class Program
  {
    static int userNumber;
    static int number;

    static void Main(string[] args){
      getUserNumber();
      generateRandomNumber();
      compareNumbers();

    }
    public static void getUserNumber(){
        Console.WriteLine("guest a number between 1 and 10");
        userNumber = Convert.ToInt32(Console.ReadLine());
    }

    public static void generateRandomNumber(){
            System.Random rand = new System.Random();// Generates a random number between 1 and 10
      number = rand.Next(1,11);
    }

    public static void compareNumbers(){
      if (number ==userNumber){
        Console.WriteLine("good guess");

      }else if (userNumber> number ){
        Console.WriteLine("too high");
        guessAgain();

      }else{
        Console.WriteLine("too low");
        guessAgain();

      }
        
    }
    public static void guessAgain(){
        Console.WriteLine("guest again");
        userNumber = Convert.ToInt32(Console.ReadLine());
        compareNumbers();
    }
  }
}