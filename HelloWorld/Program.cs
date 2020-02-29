using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var dialects = new string[] { "Southern", "Cockney", "Cali", };

            Console.WriteLine("Pick A Dialect:");
            foreach (var dialect in dialects)
            {
                Console.WriteLine(dialect);
            }

            var userEntry = Console.ReadLine();

            static string Accents(string userEntry)
            {
                string greeting;
            if (userEntry == "Southern")
            {
                greeting = "Howdy Y'all!!";
            }
            else if (userEntry == "Cockney")
            {
                greeting = "Ello!!";
            }
            else if (userEntry == "Cali")
            {
                greeting = "Sup";
            }
            else
            {
                greeting = "Hey!!";
            }
                return greeting;
            }

            //Console.ReadLine(); // What happens if you run the app without this line?

            Console.WriteLine(Accents(userEntry));


            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Dog", "Coyote" };

            int CountSyllables(string word)
            {
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
                string currentWord = word;
                int numVowels = 0;
                bool lastWasVowel = false;
                foreach (char wc in currentWord)
                {
                    bool foundVowel = false;
                    foreach (char v in vowels)
                    {
                        //don't count diphthongs
                        if (v == wc && lastWasVowel)
                        {
                            foundVowel = true;
                            lastWasVowel = true;
                            break;
                        }
                        else if (v == wc && !lastWasVowel)
                        {
                            numVowels++;
                            foundVowel = true;
                            lastWasVowel = true;
                            break;
                        }
                    }

                    //if full cycle and no vowel found, set lastWasVowel to false;
                    if (!foundVowel)
                        lastWasVowel = false;
                }
                //remove es, it's _usually? silent
                if (currentWord.Length > 2 &&
                    currentWord.Substring(currentWord.Length - 2) == "es")
                    numVowels--;
                // remove silent e
                else if (currentWord.Length > 1 &&
                    currentWord.Substring(currentWord.Length - 1) == "e")
                    numVowels--;

                return numVowels;
            }

            foreach (var animal in animals)
            {
                if (CountSyllables(animal) > 1)
                {
                    Console.WriteLine(animal);
                }
                else
                {
                    continue;
                }
            }
            
            Console.ReadKey();
        }
    }
}
