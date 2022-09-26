// Christoffer Ottestig
//NET22

namespace ChessBoard
{
    internal class Program
    {
        static char[,] CreateBoard(int boardSize, char blackSquare, char whiteSquare)
        {
            // Creates the board using a 2D array, and places the "black and white squares" onto the board
            char[,] chessBoard = new char[boardSize, boardSize];

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        chessBoard[i, j] = blackSquare;
                    }
                    else
                    {
                        chessBoard[i, j] = whiteSquare;
                    }
                }
            }
            return chessBoard;
        }

        static char[,] PlacePiece(char[,] chessBoard, int row, int column, char piece)
        {
            // Places the users piece onto the board
            chessBoard[row - 1, column - 1] = piece;

            return chessBoard;
        }

        static void PrintBoard(char[,] chessBoard, int boardSize)
        {
            // Prints the board onto the console
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    Console.Write(chessBoard[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // Asks the user what size the board should be
            Console.WriteLine("Hur stort ska brädet vara?");
            int boardSize = Int32.Parse(Console.ReadLine());

            // Asks the user what the black and white squares and their piece should look like 
            // and where they want to place their piece
            Console.WriteLine("Hur ska de svarta rutorna se ut?");

            char blackSquare = char.Parse(Console.ReadLine());

            Console.WriteLine("Hur ska de vita rutorna se ut?");

            char whiteSquare = char.Parse(Console.ReadLine());

            Console.WriteLine("Hur ska pjäsen se ut?");

            char piece = char.Parse(Console.ReadLine());

            Console.WriteLine("Vilken kolumn vill du att pjäsen ska stå på? (1-" + boardSize + ")");
            int column = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Vilken rad vill du att pjäsen ska stå på? (1-" + boardSize + ")");
            int row = Int32.Parse(Console.ReadLine());

            // Calls the CreateBoard method and stores the returned 2D array in the main method
            char[,] chessBoard = CreateBoard(boardSize, blackSquare, whiteSquare);

            // Calls the PlacePiece method and stores the updated array in the main method
            chessBoard = PlacePiece(chessBoard, row, column, piece);

            // Calls the PrintBoard method which will print out the chessboard onto the console
            PrintBoard(chessBoard, boardSize);

        }
    }
}