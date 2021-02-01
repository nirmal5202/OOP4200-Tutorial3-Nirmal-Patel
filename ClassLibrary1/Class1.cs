using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        /// <summary>
        /// An enum for 2 colors of chess
        /// </summary>
        public enum color
        {
            Black = 1,
            White = 2,
        }
        /// <summary>
        /// An enum for 16 pieces of chess
        /// </summary>
        public enum pieces
        {
            pawn1 = 1,
            pawn2 = 2,
            pawn3 = 3,
            pawn4 = 4,
            pawn5 = 5,
            pawn6 = 6,
            pawn7 = 7,
            pawn8 = 8,
            bishop1 = 9,
            bishop2 = 10,
            knight1 = 11,
            knight2 = 12,
            rook1 = 13,
            rook2 = 14,
            queen = 15,
            king = 16,
        }
    }
    /// <summary>
    /// A public class Piecewith with two data members & a output method
    /// </summary>
    public class Piece
    {
        public Class1.color color { get; set; }
        public Class1.pieces type { get; set; }

        /// <summary>
        /// Create and override ToString method to output color and type
        /// </summary>
        /// <returns>Color and Type</returns>
        public override string ToString()
        {
            return "Color: " + this.color
                + " Type: " + this.type;
        }
    }

    /// <summary>
    /// Create a public class called ChessPieces
    /// </summary>
    public class ChessPieces
    {
        /// <summary>
        /// Default Constructor that has a method named Reset
        /// </summary>
        public ChessPieces()
        {
            Reset();
        }

        public List<Piece> blackPieces { get; set; }
        public List<Piece> whitePieces { get; set; }

        /// <summary>
        /// Reset Method
        /// </summary>
        public void Reset()
        {
            blackPieces = Enumerable.Range(1, 2)
            .SelectMany(c => Enumerable.Range(1, 16)
                                .Select(t => new Piece()
                                {
                                    color = (Class1.color)c,
                                    type = (Class1.pieces)t,
                                }
                                        )
                        )
                .ToList();

            whitePieces = Enumerable.Range(1, 2)
            .SelectMany(c => Enumerable.Range(1, 16)
                                .Select(t => new Piece()
                                {
                                    color = (Class1.color)c,
                                    type = (Class1.pieces)t,
                                }
                                        )
                        )
                .ToList();
        }

        /// <summary>
        /// Get a new peice and remove one from Pieces
        /// </summary>
        /// <returns>pieces</returns>
        public Piece GetPiece()
        {
            var BlackPiece = blackPieces.FirstOrDefault();
            blackPieces.Remove(BlackPiece);

            return BlackPiece;

            var WhitePiece = whitePieces.FirstOrDefault();
            whitePieces.Remove(WhitePiece);

            return WhitePiece;
        }
    }
}
