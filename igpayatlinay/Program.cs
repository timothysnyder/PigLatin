using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igpayatlinay
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Welcome to the Pig Latin Translator!");
                Console.WriteLine("\nPlease Enter an English Word to Translate:");
                string input = Console.ReadLine();
                Console.WriteLine(TranslatePigLatin(input));

                //Continue y/n

                Console.Write("\nWould you like to Enter Another Word? Y/N; ");
                input = Console.ReadLine();

                    if (input.ToLower() == "n")
                     {
                        break;
                     }

            }
        }
        static string TranslatePigLatin(string word)

        {
            //const string vowels = "AEIOUaeio";


            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            
                int index = word.IndexOfAny(vowels);


                string beginingOfWord = word.Substring(0, index );
                string restOfWord = word.Substring(index);
                

                    if (index > 0)
                    { 
                        return restOfWord + beginingOfWord + "ay";
                       
                    }
                        else
                        {
                            return word + "way";
            }

            

        }
    }
}
