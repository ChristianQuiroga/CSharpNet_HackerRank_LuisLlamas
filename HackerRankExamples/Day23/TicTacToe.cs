using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExamples.Day23
{
    public class TicTacToe
    {
        // Picture of Game with Index:
        // For Storge:

        //    0   |   1   |   2
        //__________________________
        //    3   |   4   |   5
        //__________________________
        //    6   |   7   |   8

        //    WHAT THE USER THINKS:

        //    1   |   2   |   3
        //__________________________
        //    4   |   5   |   6
        //__________________________
        //    7   |   8   |   9

        //    UI PICTURE OF GAME:
        //    INIT:

        //    -   |   -   |   -
        //__________________________
        //    -   |   -   |   -
        //__________________________
        //    -   |   -   |   -

        //    GAMEPLAY:

        //    -   |   -   |   -
        //__________________________
        //    -   |   X   |   -
        //__________________________
        //    -   |   -   |   X

        public char[] board;
        public char userMarker;
        public char aiMarker;
        public char winner;
        public char currentMarker; //marcador actual

        //Constructor
        public TicTacToe(char playerToken, char aiMaker)
        {
            this.userMarker = playerToken;
            this.aiMarker = aiMaker;
            this.winner = '-';
            this.board = setBoard(); //invocamos al método.
            this.currentMarker = userMarker;
        }

        //method
        public char[] setBoard()
        {
            char[] board = new char[9]; //declaramos un array de 9 valores
            for (int i = 0; i < board.Length; i++) //lo cargamos todo con '-'
            {
                board[i] = '-';
            }
            return board;
        }
        public bool playTurn(int spot) //spot Punto
        {
            bool isValid = withinRange(spot) && !isSpotTaken(spot);
            if (isValid)
            {
                board[spot - 1] = currentMarker;
                currentMarker = (currentMarker == userMarker) ? aiMarker : userMarker;
            }
            return isValid;
        }
        // Check if our spot  is in range (Comprueba si nuestro punto está dentro del alcance.)
        public bool withinRange(int number)
        {
            return number > 0 && number < board.Length + 1;
        }
        // Check if the spot is taken.
        public bool isSpotTaken(int number)
        {
            return board[number - 1] != '-';
        }
        public void printBoard()
        {   //Attempting to create...
            //    -   |   -   |   -
            //__________________________
            //    -   |   -   |   -
            //__________________________
            //    -   |   -   |   -

            Console.WriteLine();
            for (int i = 0; i < board.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("______________");
                }
                Console.Write(" | " + board[i]);
            }
            Console.WriteLine();
        }

        // método static que no va a dibujar el Tablero o Board!
        public static void printIndexBoard()
        {
            Console.WriteLine();
            for (int i = 0; i < 9; i++) // recorre los 9 indices
            {
                if (i % 3 == 0 && i != 0) //Divisible entre 3 genera la línea
                {
                    Console.WriteLine();
                    Console.WriteLine("______________");
                }
                Console.Write(" | " + (i + 1));
            }
            Console.WriteLine();
        }

        //Método para ver si hay ganadores!
        public bool isThereAWinner()
        {
            bool diagonalsAndMiddles = (rightDi() || leftDi() || middleRow() || secondCol()) && board[4] != '-';
            bool topAndFirst = (topRow() || firstCol()) && board[0] != '-';
            bool bottomAndThird = (bottomRow() || thirdCol()) && board[8] != '-';
            if (diagonalsAndMiddles)
            {
                this.winner = board[4];
            } else if (topAndFirst)
            {
                this.winner = board[0];
            } else if (bottomAndThird)
            {
                this.winner = board[8];
            }
            return diagonalsAndMiddles || topAndFirst || bottomAndThird;   
            // La línea devuelve true si al menos una de las siguientes variables es true:                                                               
            // Evalúa las condiciones de izquierda a derecha
            // Se detiene en la primera condición que sea true(short - circuit evaluation)
            // Solo si todas son false, devuelve false
        }
        public bool topRow()
        {
            return board[0] == board[1] && board[1] == board[2];
        }
        public bool middleRow()
        {
            return board[3] == board[4] && board[4] == board[5];
        }
        public bool bottomRow()
        {
            return board[6] == board[7] && board[7] == board[8];
        }
        public bool firstCol()
        {
            return board[0] == board[3] && board[3] == board[6];
        }
        public bool secondCol()
        {
            return board[1] == board[4] && board[4] == board[7];
        }
        public bool thirdCol()
        {
            return board[2] == board[5] && board[5] == board[8];
        }
        public bool rightDi()
        {
            return board[0] == board[4] && board[4] == board[8];
        }
        public bool leftDi()
        {
            return board[2] == board[4] && board[4] == board[6];
        }

        // si el tablero esta lleno.
        public bool isTheBoardFilled()
        {
            for (int i = 0; i < board.Length; i++) // recorre el array de tamaño 9
            {
                if (board[i] == '-') // si encuentra un solo char '-' sale con retun false.
                {
                    return false;
                }
            }
            return true;
        }
        public string gameOver() // devuelve un texto.
        {
            bool didSomeOneWin = isThereAWinner();  // método devuelve true o false, si hay un ganador o no.
            if (didSomeOneWin)
            {
                return "We have a winner! The winner is " + this.winner + "'s";
            }
            else if (isTheBoardFilled()) // método para ver si quedo empatado. 
            {
                return "Draw: Game Over!"; // si el método devuelve true,  quedo empatado.
            }
            else
            {
                return "notOver";  // caso contrario No termino!. 
            }
        }
    }
}
