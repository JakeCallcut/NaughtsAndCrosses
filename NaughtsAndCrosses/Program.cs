﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaughtsAndCrosses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Naughts & Crosses";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            int turnNumber = 0;
            string input;
            bool won = false;
            do
            {
                Console.Clear();
                if (turnNumber % 2 == 0)
                {
                    Console.WriteLine("Crosses turn");
                    DisplayBoard();
                    Console.WriteLine(" ");
                    Console.WriteLine("Please enter the coordinate where you would like to put your mark (e.g A1)");
                    input = Console.ReadLine();

                    char x = Convert.ToChar(input.Substring(0, 1));
                    char y = Convert.ToChar(input.Substring(1, 1));
                    AddToBoard(x, y, 'X');
                }
                else if (turnNumber % 2 == 1)
                {
                    Console.WriteLine("Naughts turn");
                    DisplayBoard();
                    Console.WriteLine(" ");
                    Console.WriteLine("Please enter the coordinate where you would like to put your mark (e.g A1)");
                    input = Console.ReadLine();

                    char x = Convert.ToChar(input.Substring(0, 1));
                    char y = Convert.ToChar(input.Substring(1, 1));
                    AddToBoard(x, y, 'O');
                }
                turnNumber++;
            } while (won == false);
        }

        

        public static void DisplayBoard()
        {
            Console.WriteLine(" |A|B|C|");
            Console.WriteLine("1|{0}|{1}|{2}|", A1, B1, C1);
            Console.WriteLine("=|=|=|=|");
            Console.WriteLine("2|{0}|{1}|{2}|", A2, B2, C2);
            Console.WriteLine("=|=|=|=|");
            Console.WriteLine("3|{0}|{1}|{2}|", A3, B3, C3);
        }

        public static char A1 = ' ';
        public static char A2 = ' ';
        public static char A3 = ' ';
        public static char B1 = ' ';
        public static char B2 = ' ';
        public static char B3 = ' ';
        public static char C1 = ' ';
        public static char C2 = ' ';
        public static char C3 = ' ';

        //public static bool WinCheck(char _player)
        //{
        //    if (_player == 'X')
        //    {
        //        if (A1 == ) { }
        //    }
        //}

        public static void AddToBoard(char _x, char _y, char _player)
        {
            if (Char.ToUpper(_x) == 'A')
            {
                if (_y == '1')
                {
                    A1 = _player;
                }
                if (_y == '2')
                {
                    A2 = _player;
                }
                if (_y == '3')
                {
                    A3 = _player;
                }
            }
            if (Char.ToUpper(_x) == 'B')
            {
                if (_y == '1')
                {
                    B1 = _player;
                }
                if (_y == '2')
                {
                    B2 = _player;
                }
                if (_y == '3')
                {
                    B3 = _player;
                }
            }
            if (Char.ToUpper(_x) == 'C')
            {
                if (_y == '1')
                {
                    C1 = _player;
                }
                if (_y == '2')
                {
                    C2 = _player;
                }
                if (_y == '3')
                {
                    C3 = _player;
                }
            }
        }
    }
}