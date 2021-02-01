using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a new object
            var piece = new ChessPieces();

            // GetPiece 12 times
            var get1 = (Piece)piece.GetPiece();
            var get2 = (Piece)piece.GetPiece();
            var get3 = (Piece)piece.GetPiece();
            var get4 = (Piece)piece.GetPiece();
            var get5 = (Piece)piece.GetPiece();
            var get6 = (Piece)piece.GetPiece();
            var get7 = (Piece)piece.GetPiece();
            var get8 = (Piece)piece.GetPiece();
            var get9 = (Piece)piece.GetPiece();
            var get10 = (Piece)piece.GetPiece();
            var get11 = (Piece)piece.GetPiece();
            var get12 = (Piece)piece.GetPiece();
            
            // Output all 12 of the pieces using ToString method
            Console.WriteLine(get1.ToString());
            Console.WriteLine(get2.ToString());
            Console.WriteLine(get3.ToString());
            Console.WriteLine(get4.ToString());
            Console.WriteLine(get5.ToString());
            Console.WriteLine(get6.ToString());
            Console.WriteLine(get7.ToString());
            Console.WriteLine(get8.ToString());
            Console.WriteLine(get9.ToString());
            Console.WriteLine(get10.ToString());
            Console.WriteLine(get11.ToString());
            Console.WriteLine(get12.ToString());
        }
    }
}