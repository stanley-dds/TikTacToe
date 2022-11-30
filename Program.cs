// A simple TicTacToe game is presented here. There are two players
// As input, users write numbers 1 to 9.

// The player wins as soon as he gets three crosses/zeros in a row/column or alternatively on the diagonal.

namespace TikTacToe
{
    internal class Program
    {
        static int player = 1;
        static int state = 0;

        // The method of printing out menu choices so that the player can more easily navigate the game
        private static string PrintMenu(bool gameHadStarted) 
        {
            string command;

            if(gameHadStarted)
            {
                if (player % 2 == 0) Console.Write("Spelaren O: ");
                else Console.Write("Spelaren X: ");
            }
            command = Console.ReadLine();

            if (command == "meny")
            {
                if (!gameHadStarted)
                {
                    Console.WriteLine("Lista över alla menyval: ");
                    Console.WriteLine("Tryck på 'S' för att sluta spelet");
                    Console.WriteLine("Tryck på 'N' för att starta ett nytt spel");
                }
                else Console.WriteLine("ERROR! Spelet pågår! Avsluta spelet med s först!");
            }
            else if((command == "S") || (command == "s"))
            {
                Console.WriteLine("Spelet avslutas! Skriv meny");
            }
            else if ((command == "N") || (command == "n"))
            {
                Console.Clear();
                if (player % 2 == 0)// If "player" is even, it is player 2's turn.
                {
                    Console.WriteLine("Spelare 2: Välj en siffra 1 till 9.");
                }
                else
                {
                    Console.WriteLine("Spelare 1: Välj en siffra 1 till 9.");
                }
            } 
            return command.Trim();
        }


        // Method for the gameboard. Array is just temporary name.
        private static void Board(char[] ticTacToeValues) 
        {
            Console.Clear();
            Console.WriteLine($"  {ticTacToeValues[1]}  |  {ticTacToeValues[2]}  |  {ticTacToeValues[3]}  ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"  {ticTacToeValues[4]}  |  {ticTacToeValues[5]}  |  {ticTacToeValues[6]}  ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"  {ticTacToeValues[7]}  |  {ticTacToeValues[8]}  |  {ticTacToeValues[9]}  ");
        }


        //Method populates the game board with the char values from 1 to 9
        static char[] setTicTacToeValues()
         {
            char[] ticTacToeValues = new char[10];
            for (int i = 0; i < ticTacToeValues.Length; i++)
            {
                ticTacToeValues[i] =  (char)(i + '0');      
            }

            // $char means that the game had started.
            ticTacToeValues[0] = '$'; 

            return ticTacToeValues;            
         }


        // Method checks if the input is a number between 1 and 9
        static bool correctInput(string command)
        {
            bool correctInput = false;
            try
            {
                int i = Int32.Parse(command);
                if ( (i>0) && (i<10) ) correctInput = true;
            }
            catch(FormatException) {}
            return correctInput;
        }


        // Method checks if the game has started.
        static bool checkIfTheGameHadStarted(char[] ticTacToeValues) 
        {
            if (ticTacToeValues[0] == '$') return true;
            else return false;
        }
        
        
        static void Main(string[] args)
        {
            bool gameHadStarted;
            char[] ticTacToeValue = new char[10];

            Console.WriteLine("Välkommen till luffarshack!\n");
            Console.WriteLine("Spelare 1 är X och Spelare 2 är O");
            Console.WriteLine("För att se tillgängliga menyval, skriv in 'meny'.");

            do
            {
                gameHadStarted = checkIfTheGameHadStarted(ticTacToeValue);
                string command = PrintMenu(gameHadStarted);

                if ((command == "S") || (command == "s"))
                {
                    ticTacToeValue[0] = '0'; // Cancels the game.                   
                }
                else if ((command == "N") || (command == "n"))
                {
                    ticTacToeValue = setTicTacToeValues();
                    Board(ticTacToeValue); // Displays the game board

                }
                else
                {
                    if (checkIfTheGameHadStarted(ticTacToeValue))
                    {
                        if (correctInput(command))
                        {
                            int position = Int32.Parse(command);
                            if ((ticTacToeValue[position] != 'X') && (ticTacToeValue[position] != 'O'))
                            {
                                if (player % 2 == 0) // player 2
                                {
                                    ticTacToeValue[position] = 'O'; player++; Board(ticTacToeValue);
                                }
                                else // player 1
                                {
                                    ticTacToeValue[position] = 'X'; player++; Board(ticTacToeValue);
                                }
                            }
                            else Console.WriteLine($"ERROR! Rutan {position} var redan använd!\n" +
                                $"Välj en annan ruta");
                        }
                        else
                        {
                            if (command != "meny") Console.WriteLine("ERROR! För att kunna spela," +
                                " ge mig ett värde 1 till 9, annars skriv meny :)");
                        }
                    }
                    else
                    {
                        if (command != "meny") Console.WriteLine("ERROR! Starta först spelet med n kommando");
                    }
                   state = checkWinner();
                }
            } while (state != 1 && state != -1);

            if (state == 1)
            {
                Console.WriteLine("Spelare {0} har vunnit", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Oavgjort!");
            }
            Console.ReadLine();
        }
            private static int checkWinner()
            {
                // Rader
                if (ticTacToeValue[1] == ticTacToeValue[2] && ticTacToeValue[2] == ticTacToeValue[3]) { return 1; }
                if (ticTacToeValue[4] == ticTacToeValue[5] && ticTacToeValue[5] == ticTacToeValue[6]) { return 1; }
                if (ticTacToeValue[7] == ticTacToeValue[8] && ticTacToeValue[8] == ticTacToeValue[9]) { return 1; }

                // Kolumner
                if (ticTacToeValue[1] == ticTacToeValue[4] && ticTacToeValue[4] == ticTacToeValue[7]) { return 1; }
                if (ticTacToeValue[2] == ticTacToeValue[5] && ticTacToeValue[5] == ticTacToeValue[8]) { return 1; }
                if (ticTacToeValue[3] == ticTacToeValue[6] && ticTacToeValue[6] == ticTacToeValue[9]) { return 1; }

                // Diagonalt
                if (ticTacToeValue[1] == ticTacToeValue[5] && ticTacToeValue[5] == ticTacToeValue[9]) { return 1; }
                if (ticTacToeValue[3] == ticTacToeValue[5] && ticTacToeValue[5] == ticTacToeValue[7]) { return 1; }


                if (ticTacToeValue[1] != '1' && ticTacToeValue[2] != '2' && ticTacToeValue[3] != '3' && ticTacToeValue[4] != '4' && ticTacToeValue[5] != '5' && ticTacToeValue[6] != '6' && ticTacToeValue[7] != '7' && ticTacToeValue[8] != '8' && ticTacToeValue[9] != '9') { return -1; }
        
                else
                {
                return 0;
            }
        }
    }
}
