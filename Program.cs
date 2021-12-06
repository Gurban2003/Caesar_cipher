using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Caesar_Cipher
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.Write("Enter a message: ");
            string message = Console.ReadLine();    //a message inputted by user
            Console.Write("Enter a key (from 1 to 25): ");
            int key = int.Parse(Console.ReadLine());   //key is a number by which we will shift letters
            Program encrypt = new Program();
            string encrypted = encrypt.Encrypting(alphabet, key, message);
            Console.WriteLine();
            Console.WriteLine("Encrypted word: " + encrypted);  //printing encrypted message
        }

        public string Encrypting(char[] alphabet, int key, string message)
        {
            char[] messageInChar = message.ToCharArray();   // converting the string to an array of characters
            int j;              //index of a letter in the alphabet
            int position;       //index of a letter in the message
            int newPosition;    //index of already shifted letter

            // loop for iterating over each character of the message
            for (int i = 0; i < messageInChar.Length; i++)
            {
                // looking for the index of letter
                for (j = 0; j < alphabet.Length; j++)
                {
                    if (messageInChar[i] == alphabet[j])
                    {
                        break;
                    }
                }

                if (j != 26) // if j equals 26, means symbol is not from the alphabet
                {
                    position = j; // letter index
                    newPosition = position + key; // perform shifting operation

                    // cheking for the index not to be outside the bounds of an array of alphabet
                    if (newPosition > 25)
                    {
                        newPosition = newPosition - 26;
                    }

                    messageInChar[i] = alphabet[newPosition]; // replacing the letter
                }
            }
            string encrypted;                       //final encrypted message
            encrypted = new string(messageInChar); // putting all the symbols back into string 
            return encrypted;
        }
    }
}