using HackerRankExamples.Day23;
using HackerRankExamples.Day24;
using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace HackerRankExamples
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Day22
            Tree<int> tree = new EmptyBST<int>(); // Arbol binario de busqueda.
            //tree = tree.Add(10);
            //tree = tree.Add(5);
            //tree = tree.Add(15);
            //tree = tree.Add(7);

            tree = tree.Add(8);
            tree = tree.Add(7);
            tree = tree.Add(9);
            tree = tree.Add(5);

            Console.WriteLine("Árbol BST: " + tree);
            Console.WriteLine("Cardinalidad: " + tree.Cardinality());
            Console.WriteLine("¿Contiene 7?: " + tree.Member(7));
            Console.WriteLine("¿Contiene 3?: " + tree.Member(3));
            #endregion

            #region Day23
            //Getting imput
            //Allows for cont. games
            //bool doYouWantToPlay = true;

            //while (doYouWantToPlay)
            //{
            //    Console.WriteLine("Welcome to Tic Tac Toe! Your are about to go against "
            //        + "the master of Tic Tac Toe. Are you ready? I hope so!\nBUT FIRST, you"
            //        + " must pick what character you want to be and which character I will be. ");
            //    Console.WriteLine();
            //    Console.WriteLine("Enter a single character that will represent you on the board");
            //    char playerToken = Console.ReadLine().ToUpper()[0];
            //    Console.WriteLine("Enter a single character that will represent your opponent on the board");
            //    char opponentToken = Console.ReadLine().ToUpper()[0];

            //    TicTacToe game = new TicTacToe(playerToken, opponentToken);// Instanciamos el objeto game.
            //    AI ai = new AI(); // Instanciamos el objeto ai. vacio

            //    // Set up the game
            //    Console.WriteLine();
            //    Console.WriteLine("Now we can start the game. To play, enter a number and your token shall be put " +
            //        "in its place.\nThe numbers go from 1-9, left to right. We shall see who will win this round.");

            //    TicTacToe.printIndexBoard();// Al ser Método Static no hace falta instanciar la clase TicTacToe.
            //    Console.WriteLine();

            //    //Let's play!
            //    while (game.gameOver().Equals("notOver")) // llamamos al método gameOver. y retorna un Texto y compara el resultaod con Equals()
            //    {
            //        if (game.currentMarker == game.userMarker)  //
            //        {
            //            //USER TURN
            //            Console.WriteLine("It's your turn!  Enter a sport for your token");
            //            int spot = int.Parse(Console.ReadLine());

            //            while (!game.playTurn(spot))
            //            {
            //                Console.WriteLine("Try again. " + spot + " is invalid. This spot is already taken or it is out of range");
            //                //int.TryParse(Console.ReadLine(), out int spot1); //
            //                spot = int.Parse(Console.ReadLine());

            //            }
            //            Console.WriteLine("You picked " + spot + "!");
            //        }else
            //        {
            //            // AI turn
            //            Console.WriteLine("It's my turn!");
            //            // Pick spot
            //            int aiSpot = ai.PickSpot(game);
            //            game.playTurn(aiSpot);
            //            Console.WriteLine("I picked " +  aiSpot + "!");
            //        }
            //        // Print out new board
            //        Console.WriteLine();
            //        game.printBoard();
            //    }
            //    Console.WriteLine(game.gameOver());
            //    Console.WriteLine();
            //    // Set up a new game...or not depending on the response
            //    Console.WriteLine("Do you want to play again? Enter Y if you do. " +
            //        "Enter anything else if you are tired of me.");
            //    char response = Console.ReadLine().ToUpper()[0];
            //    doYouWantToPlay = (response == 'Y');
            //    Console.WriteLine();
            //    Console.WriteLine();

            //}
            #endregion

            #region Day24 HANGMAN
            /// We are Making Hangman (Ahorcado)
            /// How do we play the game

            //            Console.WriteLine("Welcome to hangman! I will pick a word and you will try to guess it character by character.\n"
            //                + "If you guess wrong 6 times, then I win. If you can guess it before then, you win.\n"
            //                + "Are you ready? I hope so because I am.");
            //            Console.WriteLine();
            //            Console.WriteLine("I have picked my word. Below is a picture, and below " +
            //                " that is your current guess, wich starts off as noting. \nEvery time you " +
            //                "guess incorrectly. I add a body part to the picture. \nWhen there is a full person, you lose.");

            //            // Allows for multiple games
            //            bool doYouWantToPlay = true;
            //            while (doYouWantToPlay) // Con el While ingresa por lo menos una vez.
            //            {
            //                // Setting up the game
            //                Console.WriteLine() ;
            //                Console.WriteLine("\nAlright! Let's play!");
            //                Hangman game = new Hangman(); // Instanciamos game de la Clase Hangman


            //                do
            //                {
            //                    // Draw the things...
            //                    Console.WriteLine();
            //                    Console.WriteLine(game.DrawPicture());
            //                    Console.WriteLine();
            //                    Console.WriteLine(game.GetFormalCurrentGuess());
            //                    Console.WriteLine(game.mysteryWord);
            //                    Console.WriteLine();

            //                    // Get the guess
            //                    Console.WriteLine("Enter a characer that you think is in the word");
            //                    char guess = Console.ReadLine()[0];
            //                    Console.WriteLine();

            //                    // Check if the character is guessed already (Comprueba si el carácter ya se ha adivinado o ingresado)
            //                    while (game.IsGuessedAlready(guess))
            //                    //if (game.IsGuessedAlready(guess))
            //                    {
            //                        Console.WriteLine("Try again! You've already guessed that character.");
            //                        guess = Console.ReadLine().ToLower()[0];
            //                    }

            //                    // Play the guess, verifica si el char ingresado esta en la cadena de adivinanza. +		currentGuess	{___n____n_}	System.Text.StringBuilder /		game.mysteryWord	"turnaround"	string
            //                    if (game.PlayGuess(guess))
            //                    {
            //                        Console.WriteLine("Great guess! That character is in the word!");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Unfortunatly that character isn't in the word");
            //                    }

            //                } while (!game.GameOver()); // Keep playing until the game is over (Sigue jugando hasta que termine el juego.), ingresa al método GameOver()
            //                {

            //                    // Play again or no?
            ////                    game.DrawPicture(); 
            //                    Console.WriteLine();
            //                    Console.WriteLine("Do you want to play another game? Enter Y if you do.");
            //                    char response = Console.ReadLine()[0];
            //                    doYouWantToPlay = (response == 'Y');

            //}
            #endregion

            #region Day25 RUNNING TIME & COMPLEXITY
            // All code application logic here
            //long startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            //Console.WriteLine(FindNumsOfRepetitions("abca;lksdjf", 'a'));
            //long endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            //long duration = endTime - startTime;
            //Console.WriteLine("Test " + duration + "ms");

            //char[] a = { 'a', 'b' };

            //Console.WriteLine();
            //Console.WriteLine();
            //startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            //Console.WriteLine(FindNumsOfRepetitionsV1("abca;lksdjf'abca;lksdjf'abca;lksdjf'abca;lksdjfabca;lksdjf'abca;lksdjfabca;lksdjf'abca;lksdjf", a));


            //endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            //duration = endTime - startTime;
            //Console.WriteLine("Test " + duration + "ms");

            //Console.WriteLine();
            //Console.WriteLine();
            //startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            //Console.WriteLine(FindNumsOfRepetitionsV2("abca;lksdjf'abca;lksdjf'abca;lksdjf'abca;lksdjfabca;lksdjf'abca;lksdjfabca;lksdjf'abca;lksdjf", a));
            //endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            //duration = endTime - startTime;
            //Console.WriteLine("Test " + duration + "ms");


            #endregion
        }

        #region Métodos
        public static int FindNumsOfRepetitions(string s, char c)
        {
            // Linear timer; 0(n) time
            int sum = 0;
            for (int i = 0; i < s.Length; i++) // 1, n+1, n
            {
                if (s[i] == c) // n
                {
                    sum++; // n
                }
            }
            return sum;
        }
        public static int[] FindNumsOfRepetitionsV1(string s, char[] c)
        {
            // Quad time: 0(n* m) time
            int[] sums = new int[c.Length]; // 1
            for (int i = 0; i < s.Length; i++) // 1, n + 1, n
            {
                for (int j = 0; j < c.Length; j++) // n+1, n*m + 1, n*m
                {
                    if (s[i] == c[j])   // n*m
                    {
                        sums[j] = sums[j] + 1; //n*m
                    }
                }
            }
            //string resul = string.Join("-", sums);
            return sums; // 1
        }
        public static int[] FindNumsOfRepetitionsV2(string s, char[] c)
        {
            // Optional time: 0(n+m)
            int[] sums = new int[c.Length];    // 1
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < c.Length; i++)
            {
                if (!map.ContainsKey(c[i]))
                {
                    map.Add(c[i], 1);
                }
                else
                {
                    int sum = map[c[i]]; //??
                    map.Add(s[i], sum + 1);
                }
            }

            for (int j = 0; j < sums.Length; j++)
            {
                //int sum;
                if (!map.ContainsKey(c[j]))
                {
                    sums[j] = 0;
                }
                else
                {
                    sums[j] = map[c[j]];
                }
            }
            return sums;
        }

        #endregion
    }
}
