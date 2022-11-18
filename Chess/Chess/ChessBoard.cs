using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class ChessBoard
    {
        // array of arrays
        Base_Piece[][] chessBoard = new Base_Piece[8][];

        // Want to print out a chess board like so
        // [R][k][B][Q][K][R][k][B]
        // [p][p][p][p][p][p][p][p]
        // [ ][ ][ ][ ][ ][ ][ ][ ]
        // [ ][ ][ ][ ][ ][ ][ ][ ]
        // [ ][ ][ ][ ][ ][ ][ ][ ]
        // [p][p][p][p][p][p][p][p]
        // [R][k][B][Q][K][R][k][B]

      
        // add to array
        public void Add()
        {

        }

        // print out array
        public void Print()
        {
            for (int i = 0; i < chessBoard.Length; i++)
            {
                System.Console.Write(i);
            }

        }

    }
}
