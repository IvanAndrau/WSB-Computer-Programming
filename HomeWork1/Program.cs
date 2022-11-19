using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static char GetState(string position)
        {
            //comment #1
            char a1;
            do
            {
                Console.WriteLine($" What's the state of the {position} field: ");
                a1 = Char.Parse(Console.ReadLine());
            }
            while (a1 != 'X' && a1 != 'O' && a1 != ' ');
            return a1;
        }


        static void Draw(char a1, char a2, char a3, char b1, char b2, char b3, char c1, char c2, char c3)
        {
            Console.WriteLine(" " + a1 + " | " + a2 + " | " + a3);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + b1 + " | " + b2 + " | " + b3);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + c1 + " | " + c2 + " | " + c3);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe Game!");
            char a1 = ' ', a2 = ' ', a3 = ' ', b1 = ' ', b2 = ' ', b3 = ' ', c1 = ' ', c2 = ' ', c3 = ' ';


            a1 = GetState("row1 column1");
            Draw(a1, a2, a3, b1, b2, b3, c1, c2, c3);

            a2 = GetState("row1 column2");
            Draw(a1, a2, a3, b1, b2, b3, c1, c2, c3);

            a3 = GetState("row1 column3");
            Draw(a1, a2, a3, b1, b2, b3, c1, c2, c3);

            b1 = GetState("row2 column1");
            Draw(a1, a2, a3, b1, b2, b3, c1, c2, c3);

            b2 = GetState("row2 column2");
            Draw(a1, a2, a3, b1, b2, b3, c1, c2, c3);

            b3 = GetState("row2 column3");
            Draw(a1, a2, a3, b1, b2, b3, c1, c2, c3);

            c1 = GetState("row3 column1");
            Draw(a1, a2, a3, b1, b2, b3, c1, c2, c3);

            c2 = GetState("row3 column2");
            Draw(a1, a2, a3, b1, b2, b3, c1, c2, c3);

            c3 = GetState("row3 column3");
            Draw(a1, a2, a3, b1, b2, b3, c1, c2, c3);


            Console.WriteLine("Game Over!");
        }
    }
}