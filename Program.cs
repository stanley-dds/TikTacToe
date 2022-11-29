// Ett simpelt TicTacToe spel presenteras här. Två spelare finns det.
// Som input skriver användare siffra 1 till 9.

// Spelaren vinner så fort hen fått tre kryss/nollor på rad/i kolumn alternativt på diagonalen.

namespace TikTacToe
{
    internal class Program
    {
        static int player = 1;

        // metoden för att skriva ut menyval så att spelaren lättare kan navigera i spelet
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
                if (player % 2 == 0)// Om spelaren är jämn så är det spelare 2 som spelar.
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


        // metod för spelbräde array är bara tillfälligt namn.
        private static void Board(char[] ticTacToeValues) 
        {
            Console.Clear();
            Console.WriteLine($"  {ticTacToeValues[1]}  |  {ticTacToeValues[2]}  |  {ticTacToeValues[3]}  ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"  {ticTacToeValues[4]}  |  {ticTacToeValues[5]}  |  {ticTacToeValues[6]}  ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"  {ticTacToeValues[7]}  |  {ticTacToeValues[8]}  |  {ticTacToeValues[9]}  ");
        }


        //metoden fyller på spelbordet med charVärdena från 1 till 9
        static char[] setTicTacToeValues()
         {
            char[] ticTacToeValues = new char[10];
            for (int i = 0; i < ticTacToeValues.Length; i++)
            {
                ticTacToeValues[i] =  (char)(i + '0');      
            }

            // $char innebär att spelet hade påbörjats. Är det '0' char istället, spelet ej påbörjades!
            ticTacToeValues[0] = '$'; 

            return ticTacToeValues;            
         }


        // metoden kontroller om input är en siffra mellan 1 och 9
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


        // metoden kontroller om spelet är påbörjad.
        static bool checkIfTheGameHadStarted(char[] ticTacToeValues) 
        {
            if (ticTacToeValues[0] == '$') return true;
            else return false;
        }
        
        
        static void Main(string[] args)
        {
            bool gameHadStarted = false;
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
                    gameHadStarted = false;
                    ticTacToeValue[0] = '0';
                    PrintMenu(gameHadStarted);
                    
                }
                else if ((command == "N") || (command == "n"))
                {
                    ticTacToeValue = setTicTacToeValues();
                    Board(ticTacToeValue); // visar spelbordet

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
                    else Console.WriteLine("ERROR! Starta först spelet med n kommando");

                }

            } while (true);


            static bool checkWinner(int player)
             {
                return true;
                // Rader
            //  if (array[0, 0] == player && array[0, 1] == player && array[0, 2] == player) { return true; }
            //  if (array[1, 0] == player && array[1, 1] == player && array[1, 2] == player) { return true; }
            //  if (array[2, 0] == player && array[2, 1] == player && array[2, 2] == player) { return true; }

                // Kolumner
            //  if (array[0, 0] == player && array[1, 0] == player && array[2, 0] == player) { return true; }
            //  if (array[0, 1] == player && array[1, 1] == player && array[2, 1] == player) { return true; }
            //  if (array[0, 2] == player && array[1, 2] == player && array[2, 2] == player) { return true; }

                // Diagonalt
            //  if (array[0, 0] == player && array[1, 1] == player && array[2, 2] == player) { return true; }
            //  if (array[0, 2] == player && array[1, 1] == player && array[2, 0] == player) { return true; }

            //  return false;
             }
        }
    }
}
