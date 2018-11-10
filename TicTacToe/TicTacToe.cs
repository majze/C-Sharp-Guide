using System;
 
namespace TicTacToe
{
    class Program
    {
        static int turns = 0;
        static char[,] initField = new char[,]
            {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'}
            };
        static char[,] field = new char[,]
            {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'}
            };

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = false;

            do
            {
                if (player == 2)
                {
                    player--;
                    mark(player, input);
                }
                else if (player == 1)
                {
                    player++;
                    mark(player, input);
                }

                draw();

                char[] playerSigns = { 'X', 'O' };
                foreach (char sign in playerSigns)
                {
                    if (
                        ((field[0,0] == sign) && (field[0,1] == sign) && (field[0,2] == sign))
                        || ((field[1, 0] == sign) && (field[1, 1] == sign) && (field[1, 2] == sign))
                        || ((field[2, 0] == sign) && (field[2, 1] == sign) && (field[2, 2] == sign))
                        || ((field[0, 0] == sign) && (field[1, 0] == sign) && (field[2, 0] == sign))
                        || ((field[0, 1] == sign) && (field[1, 1] == sign) && (field[2, 1] == sign))
                        || ((field[0, 2] == sign) && (field[1, 2] == sign) && (field[2, 2] == sign))
                        || ((field[0, 0] == sign) && (field[1, 1] == sign) && (field[2, 2] == sign))
                        || ((field[0, 2] == sign) && (field[1, 1] == sign) && (field[2, 0] == sign))
                        )
                    {
                        if (sign == 'X')
                            Console.WriteLine("Player 2 is the Winner!");
                        else
                            Console.WriteLine("Player 1 is the Winner!");

                        Console.WriteLine("Press any key to continue ");
                        Console.ReadKey();
                        reset();
                        
                        break;
                    } else if (turns == 10)
                    {
                        Console.WriteLine("DRAW!");
                        Console.WriteLine("Press any key to continue ");
                        Console.ReadKey();
                        reset();
                    }
                }

                do
                {
                    Console.Write("\nPlayer {0} turn, choose the field: ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number: ");
                    }
                    if ((input == 1) && (field[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (field[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (field[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (field[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (field[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (field[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (field[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (field[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (field[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\nThat space is already taken, choose another: ");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);

            } while (true);
        }

        public static void reset()
        {
            field = initField;
            turns = 0;
            draw();
        }

        public static void draw()
        {
            int x = 0, y = 0;
            Console.Clear();
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", field[x, y++], field[x, y++], field[x++, y]); y = 0;
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", field[x, y++], field[x, y++], field[x++, y]); y = 0;
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", field[x, y++], field[x, y++], field[x, y]);
            Console.WriteLine("   |   |   ");
            turns++;
        }

        public static void mark(int player, int input)
        {
            char sign = (player == 1) ? sign = 'X' : sign = 'O';
            switch (input)
            {
                case 1: field[0, 0] = sign; break;
                case 2: field[0, 1] = sign; break;
                case 3: field[0, 2] = sign; break;
                case 4: field[1, 0] = sign; break;
                case 5: field[1, 1] = sign; break;
                case 6: field[1, 2] = sign; break;
                case 7: field[2, 0] = sign; break;
                case 8: field[2, 1] = sign; break;
                case 9: field[2, 2] = sign; break;
            }
        }
    }
}
