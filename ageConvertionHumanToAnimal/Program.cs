using System;

namespace Review
{
  class Program 
  {
    static double humanAge;
    static double catAge;

    static void Main(string[] args)
    {
      getAge();
    }

    public static void getAge(){
      Console.WriteLine("How old are you?");
      string userAge = Console.ReadLine();
      humanAge = Convert.ToDouble(userAge);

      Console.WriteLine("Would you like to convert your age into cat or dog years?");
      string response = Console.ReadLine();

      if(response.ToLower()=="cat"){
        convertAgeCat();
      }else{
        convertAgeDog();
      }
    }

    public static void convertAgeDog(){
      double dogAge = Math.Exp((humanAge-31.0)/16.0);
      Console.WriteLine($"you are {dogAge} years old in dog years");
        
    }

    public static void convertAgeCat(){
        if(humanAge <= 15){
            catAge = 1;
        }else if( humanAge>15 & humanAge<= 24){
            catAge = 2;
        }else{
            double catAge = ((humanAge - 24) / 4) + 2;
        }Console.WriteLine($"your are {catAge} years old in cat years");
    }
 }
  
}