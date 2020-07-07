using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szubienica
{
    static class Wisielec
    {
        public static void gra()
        {
            while (true)
            {
                string[] powieszony =
                {
                    "  _________",
                    "  |   |   |",
                    "  |   O   |",
                    "  |  /|\\  |",
                    "  |   |   |",
                    "  |  / \\  |",
                    " /|\\     /|\\",
                    "/ | \\   / | \\"
                }; 
                string[] words =
                {
                    "telefon",
                    "komputer",
                    "rewolwer",
                    "autostrada",
                    "programowanie",
                    "huragan",
                    "kompresja",
                    "kasztan",
                    "helikopter"
                }; 
                Random rand = new Random(); 
                string word; 
                int wordsLen = words.Length; 
                int random = rand.Next(wordsLen); 
                word = words[random]; 
                int wordLen = word.Length;
                char[] userWord = new char[wordLen]; 
                for (int i = 0; i < wordLen; i++)
                {
                    userWord[i] = '-';
                }
                int errCount = powieszony.Length; 
                int err = 0; 
                char[] errChars = new char[errCount]; 
                bool game = true; 
                for (int i = 0; i < errCount; i++) 
                {
                    Console.WriteLine(powieszony[i]);
                }
                Console.WriteLine("\nNie daj się powiesić!\n");
                

            }
        }
    }
}
