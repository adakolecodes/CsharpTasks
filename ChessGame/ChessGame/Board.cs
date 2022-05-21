using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Board
    {
        //Create a list to represent all fields in rows and columns
        public List<List<string>> myboard;

        //Constructor
        public Board()
        {
            myboard = new List<List<string>>();
            for (int x = 0; x <= 8; x++)
            {
                //Assign "-" sign to all empty spaces
                var row = new List<string>();
                for (int y = 0; y <= 8; y++)
                {
                    row.Add("-");
                }
                myboard.Add(row);
            }
        }



        //Set letter P for all columns where row index is 0
        public void PlacePowerPieces()
        {
            for (int y = 0; y <= 8; y++)
            {
                //[0] specifies the row at index of 0, [y] specifies all the column going through looping
                myboard[0][y] = "P";
            }
        }



        //Set letter Q for all columns where row index is 7
        public void PlaceQuantomPieces()
        {
            for (int y = 0; y <= 8; y++)
            {
                //[7] specifies the row at index of 7, [y] specifies all the column going through looping
                myboard[8][y] = "Q";
            }
        }



        //Set letter A for all columns where row index is 4
        public void PlaceAtomPieces()
        {
            for (int y = 0; y <= 8; y++)
            {
                //[4] specifies the row at index of 4, [y] specifies all the column going through looping
                myboard[4][y] = "A";
            }
        }



        public void DisplayBoard()
        {
            //Specifies amount of row
            for (int x = 8; x >= 0; x--)
            {
                var row = $"{x}:";
                //Specifies amount of column
                for (int y = 0; y <= 8; y++)
                {
                    row = row + $" {myboard[x][y]}";
                }

                Console.WriteLine(row);
            }
            Console.ReadKey();
        }
    }
}
