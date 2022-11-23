namespace Exercice_Echiquier
{
    internal class Program
    {

        // enum for chess pieces
        public enum ChessPiece
        {
            vide,
            BDame,
            BFou,
            BCavalier,
            BTour,
            BPion,
            BRoi,
            NDame,
            NFou,
            NCavalier,
            NTour,
            NPion,
            NRoi
        }

        static void Main(string[] args)
        {
            Array chessBoard = Array.CreateInstance(typeof(ChessPiece), 8, 8);

            fillChessboard(chessBoard);
            displayChessboard(chessBoard);

            Console.ReadLine();


        }


        // Display chessboard to console
        public static void displayChessboard(Array chessBoard)
        {
            Console.Write("|   ");
            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                for (int j = 0; j < chessBoard.GetLength(1); j++)
                {
                    Console.Write(chessBoard.GetValue(i, j).ToString().Substring(0, 2) + "   |   ");
                }
                Console.WriteLine("\n-------------------------------------------------------------------------\n");
                if (i < chessBoard.GetLength(0) - 1)
                {

                    Console.Write("|   ");
                }

            }
        }

        static public void fillChessboard(Array chessBoard)
        {
            // fill the chessboard with pieces
            chessBoard.SetValue(ChessPiece.BRoi, 0, 4);  // black king
            chessBoard.SetValue(ChessPiece.NRoi, 7, 4);  // white king
            chessBoard.SetValue(ChessPiece.BDame, 0, 3); // black queen
            chessBoard.SetValue(ChessPiece.NDame, 7, 3); // white queen
            chessBoard.SetValue(ChessPiece.BFou, 0, 2);  // black bishop
            chessBoard.SetValue(ChessPiece.BFou, 0, 5);  // black bishop
            chessBoard.SetValue(ChessPiece.NFou, 7, 2);  // white bishop
            chessBoard.SetValue(ChessPiece.NFou, 7, 5);  // white bishop
            chessBoard.SetValue(ChessPiece.BCavalier, 0, 1); // black knight
            chessBoard.SetValue(ChessPiece.BCavalier, 0, 6); // black knight
            chessBoard.SetValue(ChessPiece.NCavalier, 7, 1); // white knight
            chessBoard.SetValue(ChessPiece.NCavalier, 7, 6); // white knight
            chessBoard.SetValue(ChessPiece.BTour, 0, 0); // black rook
            chessBoard.SetValue(ChessPiece.BTour, 0, 7); // black rook
            chessBoard.SetValue(ChessPiece.NTour, 7, 0); // white rook
            chessBoard.SetValue(ChessPiece.NTour, 7, 7); // white rook
            
            // fill the chessboard with pawns
            for (int i = 0; i < 8; i++)
            {
                chessBoard.SetValue(ChessPiece.BPion, 1, i); // black pawn
                chessBoard.SetValue(ChessPiece.NPion, 6, i); // white pawn
            }

            // fill the chessboard with empty squares
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (chessBoard.GetValue(i, j) == null)
                    {
                        chessBoard.SetValue(ChessPiece.vide, i, j);
                    }
                }
            }
        }
    }
}
