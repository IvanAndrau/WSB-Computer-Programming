using System;

namespace Tic_Tac_Toe
{
    class Program
    {

        static bool IsDraw(char[] matrix)
        {
            for(int i=0; i<9;i++)
            {
                if (matrix[i] == ' ')
                    return false;
            }
            return true;
        }

        static bool IsWin(char[] matrix, char Player)
        {
            return ( // if true returns true
                (matrix[0] == matrix[1] && matrix[1] == matrix[2] && matrix[0] == Player) ||
                (matrix[3] == matrix[4] && matrix[4] == matrix[5] && matrix[3] == Player) ||
                (matrix[6] == matrix[7] && matrix[7] == matrix[8] && matrix[6] == Player) ||

                (matrix[0] == matrix[3] && matrix[3] == matrix[6] && matrix[0] == Player) ||
                (matrix[1] == matrix[4] && matrix[4] == matrix[7] && matrix[1] == Player) ||
                (matrix[2] == matrix[5] && matrix[5] == matrix[8] && matrix[2] == Player) ||

                (matrix[0] == matrix[4] && matrix[4] == matrix[8] && matrix[0] == Player) ||
                (matrix[2] == matrix[4] && matrix[4] == matrix[6] && matrix[2] == Player));
        }

        static int Step(int StepNumber, char[] matrix)
        {
            bool success;
            int index;

            do
            {
                char ch = (StepNumber % 2 != 0) ? 'X' : 'O'; //ask
                Console.WriteLine($" Player {ch} step >");
                success = int.TryParse(Console.ReadLine(), out index);              
            } while (!success || index > 9 || index < 1 || matrix[index-1] != ' ');
            return index;
        }

        static void Draw(char[] array)
        {
            Console.WriteLine(" " + array[0] + " | " + array[1] + " | " + array[2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + array[3] + " | " + array[4] + " | " + array[5]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + array[6] + " | " + array[7] + " | " + array[8]);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.New game \n2.About the Author \n3.Exit \n>");
                int MenuChoice = int.Parse(Console.ReadLine());



                switch (MenuChoice)
                {
                    case 1:

                        char[] matrix = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

                        int i = 0;
                        do
                        {
                            Draw(matrix);
                            int UserInput = Step(i + 1, matrix);
                            matrix[UserInput - 1] = (i % 2 == 0) ? 'X' : 'O';
                            i++;
                            Console.Clear();
                        } while (!IsWin(matrix, 'X') && !IsWin(matrix, 'O') && !IsDraw(matrix));
                        Draw(matrix);

                        if (IsDraw(matrix))
                        {
                            Console.WriteLine("---Draw!---");
                        }

                        if (IsWin(matrix, 'X'))
                        {
                            Console.WriteLine("Player X won!");
                        }

                        if (IsWin(matrix, 'O'))
                        {
                            Console.WriteLine("Player O won!");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Author: Ivan Andrau \n GitHub: https://github.com/IvanAndrau"); 
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
