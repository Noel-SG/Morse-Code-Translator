using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_Code_Translator {
    public class Program {

        private static Dictionary<char, string> morseDictionary;


        static void Main() {

            InitializeDictionary();

            Console.WriteLine("Please enter the sentence to be translated.");
            string input = Console.ReadLine(); //Reads the input sentence of the user

            Console.WriteLine(Translate(input)); //Print the output (translated input)
            Console.ReadKey();
        }

        private static void InitializeDictionary() {

            morseDictionary = new Dictionary<char, string>() //Dictionary
            {
                { 'a', ".-"},
                { 'b', "-..."},
                { 'c', "-.-."},
                { 'd', "-.."},
                { 'e', "."},
                { 'f', "..-."},
                { 'g', "--."},
                { 'h', "...."},
                { 'i', ".."},
                { 'j', ".---"},
                { 'k', "-.-"},
                { 'l', ".-.."},
                { 'm', "--"},
                { 'n', "-."},
                { 'o', "---"},
                { 'p', ".--."},
                { 'q', "--.-"},
                { 'r', ".-."},
                { 's', "..."},
                { 't', "-"},
                { 'u', "..-"},
                { 'v', "...-"},
                { 'w', ".--"},
                { 'x', "-..-"},
                { 'y', "-.--"},
                { 'z', "--.."},
                { 'A', ".-"},
                { 'B', "-..."},
                { 'C', "-.-."},
                { 'D', "-.."},
                { 'E', "."},
                { 'F', "..-."},
                { 'G', "--."},
                { 'H', "...."},
                { 'I', ".."},
                { 'J', ".---"},
                { 'K', "-.-"},
                { 'L', ".-.."},
                { 'M', "--"},
                { 'N', "-."},
                { 'O', "---"},
                { 'P', ".--."},
                { 'Q', "--.-"},
                { 'R', ".-."},
                { 'S', "..."},
                { 'T', "-"},
                { 'U', "..-"},
                { 'V', "...-"},
                { 'W', ".--"},
                { 'X', "-..-"},
                { 'Y', "-.--"},
                { 'Z', "--.."},

                //Does not support numbers

            };

        }

        private static string GetUserInput() { 

            string input = Console.ReadLine(); //Reads input sentance

            return input;
        }

        private static string Translate(string input) { //Actual translation fucntion

            StringBuilder stringBuilder = new StringBuilder();
            
            foreach (char character in input) {

                if (morseDictionary.ContainsKey(character)) { //Check if character is in dictionary
                    stringBuilder.Append(morseDictionary[character] + " ");
                }
                else if (character == ' ') { //Check if character is space
                    stringBuilder.Append("/ ");
                }
                else {
                    stringBuilder.Append(character + " "); 
                }
            }

            return stringBuilder.ToString();


        }

        

    }
}
