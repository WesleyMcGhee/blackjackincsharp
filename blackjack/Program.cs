using System;

namespace blackjack
{
    class Program
    {
        
       static int deck()
        {
            Random random = new Random();
            int card = random.Next(1, 14);

            if (card >= 10)
            {
                return 10;
            }
            else
            {
                return card;
            }

        }
        
        static void Main(string[] args)
        {
            // int dealerSum = 0;
            // int playerSum = 0;
            //int[] dealerDeck = { };
            //int[] playerDeck = { };
            //  bool gamestatus = true;

            Console.WriteLine(deck());
        }
    }
}
