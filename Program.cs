namespace TikTacToe
{
    internal class Program
    {
        
        // int spelaren = 1;
        static int player = 1;
        
         private static string PrintMenu() // metod för att skriva ut menyval så att spelaren lättare kan navigera i spelet
        {
            string command;
            do
            {
                command = Console.ReadLine();
                if (command == "meny")
                {
                    Console.WriteLine("Lista över alla menyval: ");
                    Console.WriteLine("Tryck på 'S' för att sluta spelet");
                    Console.WriteLine("Tryck på 'N' för att starta ett nytt spel");
                }
                else if (command == "S")
                {
                    Console.WriteLine("Hej då och hoppas vi ses igen!");
                }
                else if (command == "N")
                {
                    Console.Clear();
                }
            }
            while (command != "S");
            return command;
        }
        
        private static void Board() // metod för spelbräde array är bara tillfälligt namn.
        {
            Console.WriteLine($"  {array[1]}  |  {array[2]}  |  {array[3]}  ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"  {array[4]}  |  {array[5]}  |  {array[6]}  ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"  {array[7]}  |  {array[8]}  |  {array[9]}  ");
        }
        static void Main(string[] args)
        {
            // Ett simpelt TicTacToe spel presenteras här. Två spelare finns det.
            // Som input skriver användare siffra 1 till 9.

            // Spelaren vinner så fort hen fått tre kryss/nollor på rad/i kolumn alternativt på diagonalen.


            // skapa relevanta variabler:
            // int spelaren = 1;
            // int valet;
            // bool endTheGame;
            // etc.
            // char[] rutan för att förvara värdena från spelets rutor (rutor #1 till #9, exkluderad 0)


            // Sprint backlogg #1, spelaren1 alltid kör med X, spelaren2 - med O
            
            string command;
            Console.Clear();// När ett nytt spel börjar så rensas konsolen.
            Console.WriteLine("Välommen till luffarshack!\n");
            Console.WriteLine("För att se tillgängliga menyval, skriv in 'meny'.");
            Console.WriteLine();
            PrintMenu();
            Console.WriteLine("Spelare 1 är X och Spelare 2 är O");
            Console.WriteLine("\n");

            if (player % 2 == 0)// Om spelaren är jämn så är det spelare 2 som spelar.
            {
                Console.WriteLine("Spelare 2: Välj en siffra 1 till 9.");
            }
            else
            {
                Console.WriteLine("Spelare 1: Välj en siffra 1 till 9.");
            }
            
            
            // Sprint backlogg #2 TBD 

            // #3 TBD ...


            // #4 TBD 

            // #5 Är input korrekt && den berörda rutan ej upptagen - sätt X eller O. Växla mellan spelarna.
            // Kodmässigt: 
            //
            // if( (input == korrekt) && (rutan[position] != 'X') && (rutan[position] != 'O') ) 
            // {
            //      if(spelaren % 2 == 0) { rutan[position] == 'O'; spelaren++; }
            //      else { rutan[position] == 'X'; spelaren++; }
            // else
            // Console.WriteLine($"ERROR! Rutan #{rutan[position]} upptagen. Välj en annan rutan!"); 
            // }
            
            //private bool checkWinner(int player)
            //   {
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
            //    }








        }
    }
}
