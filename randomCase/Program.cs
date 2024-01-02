using System;

namespace Review
{
  class Program{
    static string userSentence;
    static void Main(string[] args)
    {
      getString();
      randomCase();
    }

    public static void getString(){
      Console.WriteLine("Please provide a sentence to be used for the random case effect");
      userSentence = Console.ReadLine().ToLower();
    }

    public static void randomCase(){
        char [] sentenceChars = userSentence.ToCharArray();
        Random random = new Random();
        for( int i = 0; i < sentenceChars.Length; i++){
            if (random.Next(2)==0){                               //Next(2) generates a random integer that is either 0 or 1. if its 0, the follwoing code will execute. 
                sentenceChars[i]= char.ToUpper(sentenceChars[i]); //changes index i of sentenceChar to upper case
            }
        }string result = new string(sentenceChars);
        Console.WriteLine(result);
    }

  }
}
