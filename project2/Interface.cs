﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class View
    {
        public View() { }
        //Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow,
        //Gray, DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow, White
        public void Wordle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("          W O R D L E"); // 10 space-a
            Console.ResetColor();
        }
        public string Try(Gameplay gm)
        {
            Console.Write("Make your guess: ");
            string guess = Console.ReadLine().ToLower();
            int a = (int)guess[0]; // ASCII a-97 z-122
            int b = (int)guess[1];
            int c = (int)guess[2];
            int d = (int)guess[3];
            int e = (int)guess[4];
            while (guess.Length != 5 || a > 122 || a < 97 || b > 122 || b < 97 || c > 122 || c < 97 || d > 122 || d < 97 || e > 122 || e < 97)
            {
                Console.Write("  Your guess must contain only 5 LETTERS\nMake a valid guess: ");
                guess = Console.ReadLine().ToLower();
                a = (int)guess[0]; // ASCII a-97 z-122
                b = (int)guess[1];
                c = (int)guess[2];
                d = (int)guess[3];
                e = (int)guess[4];
            }
            return guess;
        }
        public void WriteWord(Gameplay gm, string guess)
        {
            //gm.Comparer(guess, gm.Choice);

            //purva bukva
            #region
            if (guess[0] == gm.Choice[0])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"          |{char.ToUpper(guess[0])}| ");
                Console.ResetColor();

            } else if (guess[0] == guess[1] || guess[0] == guess[2] || guess[0] == guess[3] || guess[0] == guess[4])
            {
                Console.Write($"          |{char.ToUpper(guess[0])}| ");

            } else if (gm.Choice.Contains(guess[0]))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"          |{char.ToUpper(guess[0])}| ");
                Console.ResetColor();

            }else
            {
                Console.Write($"          |{char.ToUpper(guess[0])}| ");
            }
            #endregion

            // vtora bukva
            #region
            if (guess[1] == gm.Choice[1])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"|{char.ToUpper(guess[1])}| ");
                Console.ResetColor();

            }
            else if (guess[1] == guess[2] || guess[1] == guess[3] || guess[1] == guess[4])
            {
                Console.Write($"|{char.ToUpper(guess[1])}| ");

            }
            else if (gm.Choice.Contains(guess[1]))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"|{char.ToUpper(guess[1])}| ");
                Console.ResetColor();

            }
            else
            {
                Console.Write($"|{char.ToUpper(guess[1])}| ");
            }
            #endregion

            // treta bukva
            #region
            if (guess[2] == gm.Choice[2])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"|{char.ToUpper(guess[2])}| ");
                Console.ResetColor();

            }
            else if (guess[2] == guess[3] || guess[2] == guess[4])
            {
                Console.Write($"|{char.ToUpper(guess[2])}| ");

            }
            else if (gm.Choice.Contains(guess[2]))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"|{char.ToUpper(guess[2])}| ");
                Console.ResetColor();

            }
            else
            {
                Console.Write($"|{char.ToUpper(guess[2])}| ");
            }
            #endregion

            // chetvurta bukva
            #region
            if (guess[3] == gm.Choice[3])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"|{char.ToUpper(guess[3])}| ");
                Console.ResetColor();

            }
            else if (guess[3] == guess[4])
            {
                Console.Write($"|{char.ToUpper(guess[3])}| ");

            }
            else if (gm.Choice.Contains(guess[3]))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"|{char.ToUpper(guess[3])}| ");
                Console.ResetColor();

            }
            else
            {
                Console.Write($"|{char.ToUpper(guess[3])}| ");
            }
            #endregion

            // peta bukva
            #region
            if (guess[4] == gm.Choice[4])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"|{char.ToUpper(guess[4])}| ");
                Console.ResetColor();

            }
            else if (gm.Choice.Contains(guess[4]))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"|{char.ToUpper(guess[4])}| ");
                Console.ResetColor();

            }
            else
            {
                Console.Write($"|{char.ToUpper(guess[4])}| ");
            }
            #endregion
        }
    }
}
