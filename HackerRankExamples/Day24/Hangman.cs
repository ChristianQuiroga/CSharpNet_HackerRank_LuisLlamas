using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRankExamples.Day24
{
    internal class Hangman
    {
        //Propiedades / campos
        public string mysteryWord;                             // cadena misteriosa
        public StringBuilder currentGuess;                     // estado actual de adivinanza, StringBuilder permite realizar modificaciones (como concatenación, inserción o eliminación de caracteres) sin crear un nuevo objeto en memoria en cada operación, sino que expande dinámicamente su tamaño.
        private List<char> previusGuesses = new List<char>();   // letras ya usadas. List<char> para manipularla.
        //private List<char> previusGuesses = new();            // ???

        int maxTries = 6;   // Máximo de intentos
        int currentTry = 0; // Intento actual

        private List<string> dicctionary = new List<string>();  // lista de palabras, donde vamos a guardar las palabras del TXT como un temp. que se va a recorrer.
        private string filePath = "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\C#yNet LuisLlamas\\HackerRankExamples\\dictionary.txt"; // archivo del txt, Ruta.


        // Constructor
        public Hangman()
        {
            // Si da error al generar el constructor, salimos con el catch()
            try
            {
                InitializeStreams();                            // carga el diccionario
                mysteryWord = PickWord();                       // elige palabra al azar
                currentGuess = InitializeCurrentGuess();        // prepara la cadena oculta
            }
            catch (Exception e)
            {
                Console.WriteLine("Error initializing Hangman: " + e.Message);
            }

        }
        public void InitializeStreams()
        {
            // Si da error al generar el método, sale por el catch()
            try
            {
                using (StreamReader reader = new StreamReader(filePath))    // Crea un objeto que abre y permite leer un archivo de texto ubicado en filePath
                {
                    string currentLine;
                    while ((currentLine = reader.ReadLine()) != null)   // StreamReader.ReadLine() devuelve una línea de texto o null si terminó el archivo.
                                                                        // ReadLine() → lee una línea.
                                                                        // ReadToEnd() → lee todo el archivo.
                                                                        // Peek() → mira el siguiente carácter sin mover el cursor. 
                    {
                        dicctionary.Add(currentLine.Trim());            // la línea se addiere a la lista dicctionary con el método add()
                                                                        // 
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not init streams: " + e.Message);
            }
            //try
            //{
            //    File inFile = new File("dictionary.txt");
            //    fileReader = new FileReader(inFile);
            //    bufferedFileReader = new BufferedReader(fileReader);
            //    string currentLine = bufferedFileReader.ReadLine();
            //    while (currentLine != null)
            //    {
            //        dicctionary.Add(currentLine);
            //    }
            //    bufferedFileReader.Close();
            //    fileReader.Close();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Could not init streams");
            //}
        }

        // Elegir una palabra aleatoria del diccionario.
        private string PickWord()
        {
            if (dicctionary.Count == 0) // Si el dictionary esta Empty o igual a 0, sale con el THROW
                throw new InvalidOperationException("Dictionary is empty"); //  Si está vacío, lanza una excepción con el mensaje "Dictionary is empty"

            Random rand = new Random(); // Objeto instanciado rand
            //int wordIndex = Math.Abs(rand.Next()) % dicctionary.Count;  // Genera un índice aleatorio dentro del rango válido del diccionario.
            int wordIndex = rand.Next(dicctionary.Count); // Más eficiente y legible
            return dicctionary[wordIndex];
        }

        // 🔹 Inicializar el estado actual con guiones bajos
        // _ A _ _ _ _ _ _ _
        //private StringBuilder InitializeCurrentGuess()
        //{
        //    StringBuilder current = new StringBuilder(); // StringBuilder permite realizar modificaciones (como concatenación, inserción o eliminación de caracteres) sin crear un nuevo objeto en memoria en cada operación, sino que expande dinámicamente su tamaño.
        //    //for (int i = 0; i < mysteryWord.Length * 2; i++)
        //    for (int i = 0; i < mysteryWord.Length; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            current.Append("_");
        //        }
        //        else
        //        {
        //            current.Append(" ");
        //        }
        //    }
        //    return current;
        //}


        // 🔹 Inicializar el estado actual con guiones bajos
        // "__________"
        private StringBuilder InitializeCurrentGuess()
        {
            // 🔹 Inicializar el estado actual con guiones bajos
            // "__________"
            StringBuilder sb = new StringBuilder(); // StringBuilder permite realizar modificaciones (como concatenación, inserción o eliminación de caracteres) sin crear un nuevo objeto en memoria en cada operación, sino que expande dinámicamente su tamaño.
            for (int i = 0; i < mysteryWord.Length; i++)
            {
                sb.Append("_");
            }
            return sb;
        }

        // _ _ A _ _B
        public string GetFormalCurrentGuess()
        {
            return "Current Guess: " + currentGuess.ToString();
        }

        // Verifica si hay ganador o perdedor.
        public bool GameOver()
        {
            if (DidWeWin())
            {
                Console.WriteLine();
                Console.WriteLine("Congrats! You Won! You guessed the rigth word!");
                return true;
            }
            else if (DidWeLose())
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, you lost. You spent all of your 6 tries. The word was " + mysteryWord + ".");
                Console.WriteLine(DrawPicture());
                return true;
            }
            return false;
        }

        public bool DidWeLose()
        {
            return currentTry >= maxTries;
        }
        public bool DidWeWin()
        {
            string guess = GetCondensedCurrentGuess();  // Obtener la suposición actual condensada.
            return guess.Equals(mysteryWord);
        }

        public string GetCondensedCurrentGuess()
        {
            string guess = currentGuess.ToString();
            return guess.Replace(" ", "");

        }

        public bool IsGuessedAlready(char guess) // si la letra ya esta ingresada previamente.
        {
            return previusGuesses.Contains(guess);
        }
        public bool PlayGuess(char guess)
        {
            bool isItAGoodGuess = false;    // Es una buena supoción o adivinanza
            previusGuesses.Add(guess);

            for (int i = 0; i < mysteryWord.Length; i++)
            {
                if (mysteryWord[i] == guess) // en C# se accede por índice directamente, el String mysteryWord se puede manipular como char, tiene es funcionalidad para buscar caracteres o recorrerlos.
                {
                    // reemplazar el carácter oculto en la posición correspondiente
                    //currentGuess.SetCharAt(i * 2, guess);
                    currentGuess[i] = guess;    //asigna el char a StringBuilder currentGuess, se manipula como string con char
                    isItAGoodGuess = true;

                }
            }

            if (!isItAGoodGuess)    // Si es Falso ingresa y se incrementa. currentTry.
            {
                currentTry++;
            }

            return isItAGoodGuess;
        }



        //" _ _ _ _ _       \n" +
        //"|          |     \n" +
        //"|          O     \n" +
        //"|        / | \\  \n" +
        //"|          |     \n" +
        //"|         / \\   \n" +
        //"|                \n" +
        //"|                \n";
        public string DrawPicture()
        {
            switch (currentTry)
            {
                case 0: return NoPersonDraw();
                case 1: return AddHeadDraw();
                case 2: return AddBodyDraw();
                case 3: return AddOneArmDraw();
                case 4: return AddSecondArmDraw();
                case 5: return AddOneLegDraw();
                //case 6: return FullPersonDraw();
                default: return FullPersonDraw();
            }

        }

        private  string NoPersonDraw()
        {
            return " __________\n" +
                    "|          |\n" +
                    "|          \n" +
                    "|          \n" +
                    "|          \n" +
                    "|          \n" +
                    "|\n" +
                    "|\n";
        }
        private  string AddHeadDraw()
        {
            return " __________    \n" +
                    "|          |   \n" +
                    "|          O   \n" +
                    "|              \n" +
                    "|              \n" +
                    "|              \n" +
                    "|              \n" +
                    "|              \n";
        }
        private  string AddBodyDraw()
        {
            return " __________    \n" +
                   "|          |   \n" +
                   "|          O   \n" +
                   "|          |   \n" +
                   "|          |   \n" +
                   "|              \n" +
                   "|              \n" +
                   "|              \n";
        }
        private  string AddOneArmDraw()
        {
            return " __________    \n" +
                   "|          |   \n" +
                   "|          O   \n" +
                   "|         /|   \n" +
                   "|          |   \n" +
                   "|              \n" +
                   "|              \n" +
                   "|              \n";
        }
        private string AddSecondArmDraw()
        {
            return " __________    \n" +
                   "|          |   \n" +
                   "|          O   \n" +
                   "|         /|\\ \n" +
                   "|          |   \n" +
                   "|              \n" +
                   "|              \n" +
                   "|              \n";
        }
        private string AddOneLegDraw()
        {
            return " __________    \n" +
                    "|          |   \n" +
                    "|          O   \n" +
                    "|         /|\\ \n" +
                    "|          |   \n" +
                    "|         /    \n" +
                    "|              \n" +
                    "|              \n";
        }
        public string FullPersonDraw()
        {
            return " __________    \n" +
                    "|          |   \n" +
                    "|          O   \n" +
                    "|         /|\\ \n" +
                    "|          |   \n" +
                    "|         / \\ \n" +
                    "|              \n" +
                    "|              \n";
        }

        // 🔹 Ejemplo: mostrar estado actual
        public void PrintCurrentGuess()
        {
            Console.WriteLine(currentGuess.ToString());
        }


    }
}
