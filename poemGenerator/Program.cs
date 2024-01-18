using System;
using System.Reflection;
using System.Reflection.Metadata;

namespace poemGen{
    class Program{
        static string userText;
        static string letter;
        static void Main (string[]args){
            getText();
            findWord();

        }

        static void getText(){
            Console.WriteLine("Let's write a poem. Please copy a block of text into the terminal. provide a minimum of one paragraph. we will use the words in this text to make poem");
            userText=Console.ReadLine();
            Console.WriteLine("choose one letter of the alphabet and type it to the console");
            letter=Console.ReadLine();
        }

        static void wordFound(string word){
            Console.WriteLine(word);
        }
        
        static void findWord(){
            string[] words = userText.Split(' ', StringSplitOptions.RemoveEmptyEntries); //.Split to split the string into an array
            Console.WriteLine("Your peom:");

            foreach(string word in words){
                if (word.StartsWith(letter, StringComparison.OrdinalIgnoreCase)){
                    wordFound(word);
                }

            }Console.WriteLine("THE END");

        }



    }
}
