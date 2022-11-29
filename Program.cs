namespace TikTacToe
{
    internal class Program
    {
        
        // int spelaren = 1;
        static int player = 1;
        
        
        
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
            
            Console.Clear();// När ett nytt spel börjar så rensas konsolen.
            Console.WriteLine("Välommen till luffarshack!\n");
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
            








        }
    }
}
