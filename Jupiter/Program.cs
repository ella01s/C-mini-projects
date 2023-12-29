using System;

namespace PlanetCalculations
{
  class Program{

    static int userAge;
    static double jupiterYears = 11.86;
    static void Main(string[] args){ 
        getAge();
        jupiterAge();
        newAge();
    }

    public static void getAge(){
        Console.WriteLine("How old are you?");
        // Your Age
        string age = Console.ReadLine();
        if(int.TryParse(age, out userAge)){
            Console.WriteLine($"You are {userAge} on Earth but in Jupiter, your age would be different. Lets calculate it");
        }else{
            Console.WriteLine("Invalid input. please enter your age using a whole number");
            getAge();
        }
    }

    public static void jupiterAge(){
        // Length of years on Jupiter (in Earth years)
        //double jupiterYears = 11.86;
        // Age on Jupiter
        double jupiterAge = userAge/jupiterYears;
        Console.WriteLine($"Your age on jupiter would be {jupiterAge} years");


    }

    public static void newAge(){
        Console.WriteLine("Would you like to know how old you would be if after a journey from earth to jupiter?");
        string response = Console.ReadLine();
        if(response.ToLower() == "yes"){
            calculateNewAge();
        }else{
            Console.WriteLine("ok, thanks for participating");
            }
    }

    public static void calculateNewAge(){
        // Time to Jupiter
        double journeyToJupiter = 6.142466;

        // New Age on Earth
        double newEarthAge = userAge + journeyToJupiter;

        // New Age on Jupiter
        double newJupiterAge = newEarthAge/jupiterYears;

        Console.WriteLine("The journey to Jupiter takes 6.142466 years");
        Console.WriteLine($"After travelling to Jupiter your age in earth years would be {newEarthAge} and your age in jupiter years would be {newJupiterAge}");
    }

  }
}


