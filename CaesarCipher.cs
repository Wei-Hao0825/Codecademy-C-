using System;
using System.Linq;
using System.Net.Security;

namespace CaesarCipher
{
    class Program
    {
        
        static char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        
        
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a word to encrypte: ");
            Console.WriteLine($"============================================");
            string userInput = Console.ReadLine().ToLower();
            Console.WriteLine($"============================================");
            Console.WriteLine($"Your input word is: {userInput}.");
            Console.WriteLine($"============================================");
            Console.WriteLine($"Choose what do you want to do with your secret message: Encryption or Decryption?");
            string userChoice = Console.ReadLine().ToLower();
            Console.WriteLine($"============================================");
            Console.WriteLine($"Give your secrete message a key: from 1 -- 26");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"============================================");


            if (userChoice == "encryption")
            {
                Console.WriteLine(Encrypte(userInput, key));
            }
            else if (userChoice == "decryption")
            {
                Console.WriteLine(Decrypte(userInput, key));
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }

        }

        public static string Encrypte(string message, int key)
        {
            char[] secretMessage = message.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length]
      
                ;
            for(int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i]; // access the letter of each index in the input char Array from the user input.
                
                // Finding the encrypted letter position in the alphabet letters.
                // If the original index plus the key is larger than 26.
                // The index should move over starting from the first letter of the alphabet by the remaining numbers.
                int letterPosition = (Array.IndexOf(alphabet, letter) + key) % 26;
                encryptedMessage[i] = alphabet[letterPosition];
            }

            string encrypted = String.Join("", encryptedMessage);
                
            return encrypted;
        }
        public static string Decrypte(string message, int key)
        {
            char[] secretMessage = message.ToCharArray();
            char[] decryptedMessage = new char[secretMessage.Length]
      
                ;
            for(int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i]; // access the letter of each index in the input char Array from the user input.
                
                // Finding the encrypted letter position in the alphabet letters.
                // If the original index plus the key is larger than 26.
                // The index should move over starting from the first letter of the alphabet by the remaining numbers.
                int letterPosition = (Array.IndexOf(alphabet, letter) - key) % 26;
                decryptedMessage[i] = alphabet[letterPosition];
            }

            string decrypted = String.Join("", decryptedMessage);
                
            return decrypted;
        }
    }
}
