using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Board
    {
        //the size of board 8x8
        public int Size { get; set; }
        //2d array of type cell
        public Cell[,] theGrid { get; set; }    

        //constructor
        public  Board (int s)
        {
            //inital size of the board is defined by s.
            Size = s;

            //create a new 2D array of type cell
            theGrid = new Cell[Size, Size];

            //fill the 2D array with new Cells
            for (int i=0; i<Size; i++)
            {
                for (int j=0; j < Size; j++)
                {
                    theGrid[i,j] = new Cell (i, j);
                }
            }
        }

        public void MarkNextLegalMoves( Cell currentCell, string chessPiece)
        {
            //step 1 - clear all previous legal moves
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i,j].CurrentlyOccupied = false;

                }
            }

            //step 2 find all legal moves and mark the cells as "legal"w
            switch (chessPiece)
            {
                default:
                    break;
            }
        }

    }
}
