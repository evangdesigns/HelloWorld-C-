using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dialects = new string[] { "Southern", "Cockney", "Cali", };

            //Console.WriteLine("Elige un dialecto:");
            //foreach (var dialect in dialects)
            //{
            //    Console.WriteLine(dialect);
            //}

            //var userEntry = Console.ReadLine();
            //static string Accents(string userEntry)
            //{
            //    string greeting;
            //if (userEntry == "Southern")
            //{
            //    greeting = "Howdy Y'all!!";
            //}
            //else if (userEntry == "Cockney")
            //{
            //    greeting = "Ello!!";
            //}
            //else if (userEntry == "Cali")
            //{
            //    greeting = "Sup";
            //}
            //else
            //{
            //    greeting = "Hey!!";
            //}
            //    return greeting;
            //}
            //Console.WriteLine(Accents(userEntry));

            //////////////////Hello Name
            //Console.WriteLine("Tu Nombre?");
            //var userName = Console.ReadLine();
            //Console.WriteLine($"Holla {userName}");

            //Console.WriteLine("Cuál es tu color favorito?");
            //var favColor = Console.ReadLine();

            /////////Animals and Sylybles
            //var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Dog", "Coyote" };

            //// Create a Random object  
            //Random rand = new Random();
            //// Generate a random index less than the size of the array.  
            //int index = rand.Next(animals.Length);
            //// Display the result.  
            //Console.WriteLine($"Te gustaria un {favColor} {animals[index]}");


            /////Syllables
            //int CountSyllables(string word)
            //{
            //    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            //    string currentWord = word;
            //    int numVowels = 0;
            //    bool lastWasVowel = false;
            //    foreach (char wc in currentWord)
            //    {
            //        bool foundVowel = false;
            //        foreach (char v in vowels)
            //        {
            //            //don't count diphthongs
            //            if (v == wc && lastWasVowel)
            //            {
            //                foundVowel = true;
            //                lastWasVowel = true;
            //                break;
            //            }
            //            else if (v == wc && !lastWasVowel)
            //            {
            //                numVowels++;
            //                foundVowel = true;
            //                lastWasVowel = true;
            //                break;
            //            }
            //        }

            //        //if full cycle and no vowel found, set lastWasVowel to false;
            //        if (!foundVowel)
            //            lastWasVowel = false;
            //    }
            //    //remove es, it's _usually? silent
            //    if (currentWord.Length > 2 &&
            //        currentWord.Substring(currentWord.Length - 2) == "es")
            //        numVowels--;
            //    // remove silent e
            //    else if (currentWord.Length > 1 &&
            //        currentWord.Substring(currentWord.Length - 1) == "e")
            //        numVowels--;

            //    return numVowels;
            //}

            //foreach (var animal in animals)
            //{
            //    if (CountSyllables(animal) > 1)
            //    {
            //        Console.WriteLine(animal);
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}


            ///Calculations
            Console.WriteLine("Enter how to equate and then what numbers to equate");
            var numbInput = Console.ReadLine();

            var numbs = numbInput.Split(",");
            List<string> numbList = new List<string>();
            var expo = "";
            var sum = 1;
            if (numbInput.Contains("*"))
            {
                foreach (var n in numbs.Skip(1))
                {
                    var finalInt = int.Parse(n);
                    sum *= finalInt;
                }
                Console.WriteLine(sum);
            }
            else if (numbInput.Contains("+"))
            {
                foreach (var n in numbs.Skip(1))
                {
                    var finalInt = int.Parse(n);
                    sum += finalInt;
                }
                Console.WriteLine(sum);
            }
            //else if (numbInput.Contains("/"))
            //{
            //    sum = Convert.ToDecimal(sum);
            //    foreach (var n in numbs.Skip(1))
            //    {
            //        var finalInt = decimal.Parse(n);
            //        sum /= finalInt;
            //    }
            //    Console.WriteLine(sum);
            //}
            else if (numbInput.Contains("^"))
            {
                foreach (var n in numbs.Skip(1))
                {
                    var finalInt = int.Parse(n);
                    var math = finalInt *= finalInt;
                    var mathString = math.ToString();
                    numbList.Add(mathString);
                    expo = string.Join(',', numbList);
                }
                Console.WriteLine(expo);
            }
            else Console.WriteLine("Error");

            Console.ReadKey();
        }
    }
}
