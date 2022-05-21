using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Represent by?: ");
            string rep = Console.ReadLine();
            
            for (int i = 8; i >= 0; i--)
            {
                Console.WriteLine(i);
                for(int j = 0; j >=6; j++)
                {
                    Console.WriteLine(j);
                }
            }
            /**/

            var board = new Board();
            board.PlacePowerPieces();
            board.PlaceQuantomPieces();
            board.PlaceAtomPieces();
            board.DisplayBoard();

            /**
            Console.ReadKey();
            /**/
        }
    }
}
