using HackerRank30Days.Day15LinkedList;
using HackerRank30Days.Day17_MoreExceptions;
using HackerRank30Days.Day18_QueuesStacks;
using HackerRank30Days.Day19_Interfaces;
using HackerRank30Days.Day22_BinarySearchTrees;
using HackerRank30Days.Day24_MoreLinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HackerRank30Days
{
    internal class Result
    {
        static void Main(string[] args)
        {
            #region day0 Hello, World.
            //// Declare a variable named 'inputString' to hold our input.
            //String inputString;

            //// Read a full line of input from stdin (cin) and save it to our variable, input_string.
            //inputString = Console.ReadLine();

            //// Print a string literal saying "Hello, World." to stdout using cout.
            //Console.WriteLine("Hello, World.");

            //// TODO: Write a line of code here that prints the contents of input_string to stdout.
            //Console.WriteLine($"{inputString}");
            #endregion

            #region day1  Data Types
            //int i = 4;
            //double d = 4.0;
            //string s = "HackerRank ";


            //// Declare second integer, double, and String variables.
            //int tipoInt = 0;
            //double tipoDoble;
            //string tipoString = "";
            //// Read and save an integer, double, and String to your variables.
            //string entrada = Console.ReadLine();
            //tipoInt = int.Parse(entrada);

            //string entradaDoble = Console.ReadLine();
            //tipoDoble = double.Parse(entradaDoble);
            ////double.TryParse(entradaDoble, out tipoDoble);
            ////tipoDoble = Convert.ToDouble(entradaDoble);

            //tipoString = Console.ReadLine();

            //// Print the sum of both integer variables on a new line.
            //Console.WriteLine(tipoInt + i);
            //// Print the sum of the double variables on a new line.
            //Console.WriteLine($"{tipoDoble + d:F1}");

            //// Concatenate and print the String variables on a new line
            //Console.WriteLine(s + tipoString);
            //// The 's' variable above should be printed first.
            #endregion

            #region day2 Operators
            //double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

            //int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            //int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            //Result.solve(meal_cost, tip_percent, tax_percent);
            #endregion

            #region day3 Intro  to Conditional Statements
            //int N = Convert.ToInt32(Console.ReadLine().Trim());

            //if (N % 2 == 0 && N <= 5) //es par
            //{
            //    Console.WriteLine("Not Weird");
            //}
            //else if (N % 2 == 0 && (N >= 6 && N <= 20))
            //{
            //    Console.WriteLine("Weird");
            //}
            //else if (N % 2 == 0 && (N >= 20))
            //{
            //    Console.WriteLine("Not Weird");
            //}
            //else //Impar
            //{
            //    Console.WriteLine("Weird");
            //}

            #endregion

            #region day4 Class vs Instance
            //int T = int.Parse(Console.In.ReadLine());
            //for (int i = 0; i < T; i++)
            //{
            //    int age = int.Parse(Console.In.ReadLine());
            //    Persona p = new Persona(age);
            //    p.amIOld();
            //    for (int j = 0; j < 3; j++)
            //    {
            //        p.yearPasses();
            //    }
            //    p.amIOld();
            //    Console.WriteLine();
            //}
            #endregion

            #region day5  Loops
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //practiceForLoop(n);
            //practiceWhileLoop(n);
            //practiceDoWhileLoop(n);

            #endregion

            #region day6 Let´s Review
            //int N = Convert.ToInt32(Console.ReadLine().Trim());
            //for (int i = 1; i <= N; i++)
            //{
            //    string texto = Console.ReadLine().Trim();
            //    Console.WriteLine(orderEvenOddIndex(texto));
            //}

            #endregion

            #region Day7: Arrays
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            //arr.Reverse();  //inverte una LIST/colección
            //Console.WriteLine(String.Join(" ", arr)); //se muestra en la console con String.Join.

            ////Array
            //// Declaring, Allocating and Initializing. (Declarar, Asignar, Inicializar)
            //int[] intArr;
            //int[] intArr1 = new int[4];
            //int[] intArr2 = { 1, 3, 4, 4, 99 };

            //string[] intArr3 = { "bananas", "orange", "pears" };

            #endregion

            #region day8 Dictionary and Maps
            //Add(dato), get(key), replace(key,dato)
            //Imprimir key(), value()
            //Size()
            //dictionary.ToString()
            //clear()
            //IsEmpty()
            //remove(key)
            //int N = int.Parse(Console.ReadLine().Trim());
            //Dictionary<string,string> phoneBook = new Dictionary<string,string>();

            //for (int i = 0; i < N; i++)
            //{
            //    string[] keyDatos = Console.ReadLine().Trim().Split(' ');
            //    phoneBook.Add(keyDatos[0], keyDatos[1]);
            //}

            //string query;
            //while ((query = Console.ReadLine()) != null)
            //{
            //    if (phoneBook.ContainsKey(query))  //método devuelve TRUE
            //    {
            //        Console.WriteLine($"{query}={phoneBook[query]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not found");
            //    }

            //}
            #endregion

            #region day9 Recursión 

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //Environment.SetEnvironmentVariable("Output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida30Days.txt");
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("output_path"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //int result = Result.Factorial(n);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            #endregion

            #region day10  Binary Numbers

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            ////primera forma .ToString(n, tipoBase)
            //string representacionBinaria = Convert.ToString(n, 2);
            //Console.WriteLine($"Representación binaria como cadena:  {representacionBinaria}");
            //Console.WriteLine(representacionBinaria.Max());

            //////segunda forma BitArray
            //BitArray bits = new BitArray(new int[] { n });
            //Console.Write("Representación binaria como BitArray: ");
            //for (int i = 0; i < bits.Count; i++)
            //{
            //    Console.WriteLine(bits[i] ? 1 : 0);
            //}
            //Console.WriteLine();

            ////Encontrar la secuencia más larga de 1s consecutivos
            //int maxConsecutiveOnes = 0;
            //int currentConsecutiveOnes = 0;
            //foreach (bool bit in bits)
            //{
            //    if (bit)
            //    {
            //        currentConsecutiveOnes++;
            //        maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentConsecutiveOnes);
            //    }
            //    else
            //    {
            //        currentConsecutiveOnes = 0;
            //    }
            //}
            //Console.WriteLine($"Máximo número de 1s consecutivos: {maxConsecutiveOnes}");

            ////
            //for (int i = 0; i < 32; i++) // Suponiendo un entero de 32 bits
            //{
            //    if ((n & (1 << i)) != 0)
            //    {
            //        currentConsecutiveOnes++;
            //        maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentConsecutiveOnes);
            //    }
            //    else
            //    {
            //        currentConsecutiveOnes = 0;
            //    }
            //}

            //Console.WriteLine($"Máximo número de 1s consecutivos: {maxConsecutiveOnes}");


            ////si necesitas una matriz de booleanos
            //bool[] boolBits = new bool[bits.Count];
            //bits.CopyTo(boolBits, 0);
            //Console.Write("Representación binaria como matriz de booleanos: ");
            //foreach (bool bit in boolBits)
            //{
            //    Console.WriteLine(bit ? 1 : 0);
            //}
            //Console.WriteLine();

            // Read input number from console


            //OTRA FORMA

            ////int n = Convert.ToInt32(Console.ReadLine());

            ////// Step 1: Convert to binary string
            ////string binary = Convert.ToString(n, 2);

            ////// Step 2: Split by '0' to find consecutive '1's
            ////string[] onesGroups = binary.Split('0');

            ////// Step 3: Find the maximum length of '1's group
            ////int maxConsecutiveOnes = 0;
            ////foreach (string group in onesGroups)
            ////{
            ////    if (group.Length > maxConsecutiveOnes)
            ////    {
            ////        maxConsecutiveOnes = group.Length;
            ////    }
            ////}

            ////// Print the result
            ////Console.WriteLine(maxConsecutiveOnes);


            #endregion

            #region day11  2D Arrays

            //List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < 6; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}

            //int maxHourglassSum = -63; //el mínimo posible (-9 * 7)

            ////Recorremos posibles posiciones de hourglass
            //for (int i = 0; i <= 3; i++) // filas
            //{
            //    for (int j = 0; j <= 3; j++) //columnas
            //    {
            //        // sum = a + b + c + d + e + f
            //        int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +  //fila superior
            //                                arr[i + 1][j + 1] +             //fila centro
            //                    arr[i + 2][j] + arr[i + 2][j+1] + arr[i+2][j+2]; // fila inferior

            //        if (sum > maxHourglassSum)
            //        {
            //            maxHourglassSum = sum;
            //        }
            //    }
            //}

            //Console.WriteLine(maxHourglassSum);

            #endregion

            #region Day12 Inheritance (Herencia)
            //string[] inputs = Console.ReadLine().Split();
            //string firstName = inputs[0];
            //string lastName = inputs[1];
            //int id = Convert.ToInt32(inputs[2]);
            //int numScores = Convert.ToInt32(Console.ReadLine());
            //inputs = Console.ReadLine().Split();
            //int[] scores = new int[numScores];
            //for (int i = 0; i < numScores; i++)
            //{
            //    scores[i] = Convert.ToInt32(inputs[i]);
            //}

            //Student s = new Student(firstName, lastName, id, scores);
            //s.printPerson();
            //Console.WriteLine("Grade: " + s.Calculate() + "\n");
            #endregion

            #region Day13: Abstract Classes
            // llamamos a una clase abstracta myBook.

            /* Imput:
             * Las venas abierta de America Latina
             * Eduardo Galeano
             * 32500
             */

            //String title = Console.ReadLine();
            //String author = Console.ReadLine();
            //int price = Int32.Parse(Console.ReadLine());
            //Book new_novel = new MyBook(title, author, price);
            //new_novel.display();
            #endregion

            #region Day14: Imports,Packeges & Scope (Ámbito)
            /*
             * STDIN   Function
                -----   --------
                3       __elements[] size N = 3
                1 2 5   __elements = [1, 2, 5]
            */


            //Convert.ToInt32(Console.ReadLine());

            //int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            //Difference d = new Difference(a);

            //d.computeDifference();

            //Console.Write(d.maximumDifference);
            #endregion

            #region Day15: LINKED LIST
            /*
             * STDIN   Function
                -----   --------
                4       T = 4
                2       first data = 2
                3
                4
                1       fourth data = 1
            */

            //Node head = null;
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    head = Solution.insert(head, data);
            //}
            //Solution.display(head);

            #endregion

            #region Day16: Exceptions - String to Integer
            /*
             * 3
             * 3
             * 
             * za
             * Output "Bad String"
             */

            //string S = Console.ReadLine();

            //try
            //{
            //    //int a = Convert.ToInt32(S);
            //    Console.WriteLine(Convert.ToInt32(S));
            //}
            //catch (Exception e)
            //{

            //    //Console.WriteLine($"{e.Message}");
            //    Console.WriteLine($"Bad String");
            //}


            #endregion

            #region Day17: More Exceptions
            /*
             *  4
                3 5
                2 4
                -1 -2
                -1 3

                Sample Output
                243
                16
                n and p should be non-negative
                n and p should be non-negative
            */

            //Calculator myCalculator = new Calculator();
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //    string[] num = Console.ReadLine().Split();
            //    int n = int.Parse(num[0]);
            //    int p = int.Parse(num[1]);
            //    try
            //    {
            //        int ans = myCalculator.power(n, p);
            //        Console.WriteLine(ans);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);

            //    }
            //}
            #endregion

            #region Day18: Queues & Stacks (Colas/FIFO y Pilas /LIFO)
            //Palíndromo
            /* sample Imput
             * racecar
             * 
             * The world, racecar, is a palindrome.
             */


            //// read the string s.
            //string s = Console.ReadLine();

            //// create the Solution class object p.
            //SolutionQue obj = new SolutionQue();

            //// push/enqueue all the characters of string s to stack.
            //foreach (char c in s)
            //{
            //    obj.pushCharacter(c);
            //    obj.enqueueCharacter(c);
            //}

            //bool isPalindrome = true;

            //// pop the top character from stack.
            //// dequeue the first character from queue.
            //// compare both the characters.
            //for (int i = 0; i < s.Length / 2 ; i++)
            //{
            //    if (obj.popCharacter() != obj.dequeueCharacter())
            //    {
            //        isPalindrome = false;

            //        break;
            //    }
            //}

            //// finally print whether string s is palindrome or not.
            //if (isPalindrome)
            //{
            //    Console.Write("The word, {0}, is a palindrome.", s);
            //}
            //else
            //{
            //    Console.Write("The word, {0}, is not a palindrome.", s);
            //}

            #endregion

            #region Day19: Interfaces
            //int n = Int32.Parse(Console.ReadLine()); //lee la linea y el valor de text lo convierte a Int32 con le método Parse. int.32.Parse().
            //AdvancedArithmetic myCalculator = new Calculator_I(); //Instancia o genera el Objet MyCalculator de la Clase Calculator que 
            //int sum = myCalculator.divisorSum(n);
            //Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
            #endregion

            #region Day20: Sorting
            //Imput
            //4
            // 4 3 1 2
            //

            //int n = Convert.ToInt32(Console.ReadLine().Trim()); //Trim elmina espacios vacios, y convert Int32, convierte de texto a número.

            //List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            // Write your code here

            // una forma usando el método SORT.
            //List<int> b = a;
            //b.Sort();
            // Otra forma de mostrar la lista, usando string.Join para crear una cadena con separadores
            //Console.WriteLine(string.Join(" ", b));

            //Usando el algoritmo Bubble Sort (ordenamiento burbuja)
            //bubbleSort(a);

            #endregion

            #region Day21: Generics
            ///Sumary:
            ///En c# es una caracteristica que nos permite Definir Clases, Interfaces y Métodos Independientes de un tipo de dato.
            ///Se especifica en tiempo de compilación (cuando se ejecuta T.C.) Simbolo <T> es un convecionalismo, heredado del Templating.
            ///List<T>, Dicctionary<TKey,TValue>, Queue<T>, Stack<T>
            ///Restriciones con Where T: Clase
            ///

            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] intArray = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    intArray[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //n = Convert.ToInt32(Console.ReadLine());
            //string[] stringArray = new string[n];
            //for (int i = 0; i < n; i++)
            //{
            //    stringArray[i] = Console.ReadLine();
            //}

            //PrintArray<Int32>(intArray); //Al ser generica el Método, acepta INT y STRING
            //PrintArray<String>(stringArray);
            #endregion

            #region Day22: Binary Search Trees
            /*
             * Imput
             * 7
                3
                5
                2
                1
                4
                6
                7

                Output
                3
            */
            //Node22 root = null;                             //root es NULO es un objeto nulo.
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0) // T se descontando T--  seria T = T - 1
            //{
            //    int data = Int32.Parse(Console.ReadLine()); //valor ingresador por pantalla
            //    root = Solution22.Insert(root, data);      //se invoca al método Insert, pasando "Nodo root" y valor "int."
            //}
            //int height = Solution22.getHeight(root);
            //Console.WriteLine(height);
            #endregion

            #region Day23:BST Level-Order Traversal
            /* Imput
             * Print the DATA value of each node in the tree's level-order traversal as a single line of N space-separated integers.
             *  N = 6
                3
                5
                4
                7
                2
                1

                Output
                3 2 5 1 4 7 
            */
            //Node22 root = null;
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    root = Solution22.Insert(root, data);
            //}
            //Solution22.LevelOrder(root);

            #endregion

            #region Day24: More Linked Lists
            ///Sample Imput
            ///N = 6
            ///1
            ///2
            ///2
            ///3
            ///3
            ///4
            ///Sample Output: 1 2 3 4

            //Node24 head = null;
            //int T = Int32.Parse(Console.ReadLine());
            //while (T-- > 0)
            //{
            //    int data = Int32.Parse(Console.ReadLine());
            //    head = Solution24.Insert(head, data);
            //}
            //head = Solution24.RemoveDuplicates(head);
            //Solution24.Display(head);

            #endregion

            #region Day25 Runnig Time and Complexity (tiempo de ejecucción y complejidad)
            /* Sample Imput
             * 3
             * 
             * 12
             * 5
             * 7
             * Sample Output
             * Not prime
             * Prime
             * Prime
             */

            //Console.WriteLine("Ingrese cantidad de números:");
            //int N = Int32.Parse(Console.ReadLine());
            ////List<int> list = new List<int>(); // una forma de declarar un LIST
            //int[] arr = new int[N];             // por un array
            //for (int i = 0; i < N; i++)
            //{
            //    int a = Int32.Parse(Console.ReadLine());
            //    arr[i] = (a);  // readline ingresa texto y lo convertimos a Int32
            //                   //arr[i] =Convert.ToInt32(Console.ReadLine());  // readline ingresa texto y lo convertimos a Int32               
            //                   //list.Add(a);
            //}

            //for (int i = 0; i < N; i++)
            //{
            //    if (EsNumeroPrimo(arr[i])) // Enviamos el valor al método
            //    {
            //        Console.WriteLine("Prime");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Prime");
            //    }
            //}

            #endregion

            #region Day26: Nested Logic (lógica anidada)
            /*
             * STDIN       Function
                -----       --------
                9 6 2015    day = 9, month = 6, year = 2015 (date returned)
                6 6 2015    day = 6, month = 6, year = 2015 (date due)
             * 
             * Output
             * 45
             * Why: Según la estructura de tarifas de la biblioteca, sabemos que nuestra multa será 15 Hackos x (#days late)
             * Luego imprimimos el resultado de 15 x (D1 - D2) = 15 x (9 - 6) = 45 como nuestra salida.
             */
            //Console.WriteLine("Imput Date Returned book");
            //////string dateReturned = Console.ReadLine();
            //string[] dateReturned = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ////// string.Split(' '): Divide la cadena en un array de subcadenas usando el espacio como delimitador.
            ////// Puedes usar StringSplitOptions.RemoveEmptyEntries para eliminar automáticamente las subcadenas vacías resultantes de espacios consecutivos.
            //Console.WriteLine("Imput Date Due book"); // vencimiento
            //string[] dateDue = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //int ano1 = Convert.ToInt32(dateReturned[2]) - Convert.ToInt32(dateDue[2]);
            //int mes1 = Convert.ToInt32(dateReturned[1]) - Convert.ToInt32(dateDue[1]);
            //int dia1 = Convert.ToInt32(dateReturned[0]) - Convert.ToInt32(dateDue[0]);

            //int multa = 0;
            //if (ano1 > 0)
            //{
            //    multa = 10000;

            //}
            //else if (ano1 == 0 && mes1 > 0)
            //{
            //    multa = 500 * mes1;

            //}
            //else if (dia1 > 0 && ano1 >= 0)
            //{
            //    multa = 15 * dia1;

            //}
            //Console.WriteLine(multa);


            // OTRA FORMA!!!


            //string[] dateReturned = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //string[] dateDue = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //string day = dateReturned[0].ToString().PadLeft(2, '0');
            //string mon = dateReturned[1].ToString().PadLeft(2, '0');
            //string dateRetunedString = day + mon + dateReturned[2];

            //string dayD = dateDue[0].ToString().PadLeft(2, '0');
            //string monD = dateDue[1].ToString().PadLeft(2, '0');
            //string dateDueString = dayD + monD + dateDue[2];

            //string formato = "ddMMyyyy";
            //DateTime fechaConvReturn, fechaConvDue;

            //fechaConvReturn = DateTime.ParseExact(dateRetunedString, formato, CultureInfo.CurrentCulture, DateTimeStyles.None);
            //fechaConvDue = DateTime.ParseExact(dateDueString, formato, CultureInfo.CurrentCulture, DateTimeStyles.None);
            //TimeSpan diferenciaDias = fechaConvReturn - fechaConvDue;

            //int years = diferenciaDias.Days / 365;
            //int meses = (diferenciaDias.Days % 365) / 30;
            //int dias = diferenciaDias.Days % 30;

            //Console.WriteLine($"Diferencia: {años} años, {meses} meses y {dias} días."); // Output: Diferencia: 1 años, 3 meses y 19 días.

            //int multa;
            //if (years > 0)
            //{
            //    multa = 10000;
            //    Console.WriteLine(multa);
            //}
            //else if (years == 0 && meses > 0)
            //{
            //    multa = 500 * meses;
            //    Console.WriteLine(multa);
            //}
            //else
            //{
            //    multa = 15 * diferenciaDias.Days;
            //    Console.WriteLine(multa);
            //}


            #endregion

            #region Day28: RegEx.
            /*
             * Sample Input
             * 6
                riya riya@gmail.com
                julia julia@julia.me
                julia sjulia@gmail.com
                julia julia@gmail.com
                samantha samantha@gmail.com
                tanya tanya@gmail.com
            *
            *Sample Output
                juli
                julia
                riya
                samantha
                tanya
            */
            int N = Convert.ToInt32(Console.ReadLine().Trim());

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                string firstName = firstMultipleInput[0];

                string emailID = firstMultipleInput[1];
                if (emailID.Contains("gmail.com"))
                {
                    Console.WriteLine(firstName);
                }
            }

            #endregion



            #region DESAFIOS 
            //Desafio.
            // mínimos y maxímos sum() 

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //Result.miniMaxSum(arr);

            /*
             * 
             */

            /*Compare triples
             * 6 6 7
             * 3 6 10
             * 
             * Now, let's compare each individual score:
                a > b so Alice receives 1 point.
                a = b so nobody receives a point.
                a < b so Bob receives 1 point.
             Alice's comparison score is 1, and Bob's comparison score is 1. Thus, we return the array[1,1] .
            */

            //Environment.SetEnvironmentVariable("Output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida30Days.txt");
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("output_path"), true);

            //List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            //List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            //List<int> result = Result.compareTriplets(a, b);

            //textWriter.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();

            /*
             * A VERY BIG SUM
            /// STDIN                                                   Function
            // -------------
            //            5                                             arr[] size n = 5
            //1000000001 1000000002 1000000003 1000000004 1000000005  arr[...]
            */

            //Environment.SetEnvironmentVariable("Output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida30Days.txt");
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("output_path"), true);

            //int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            //List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            //long result = Result.aVeryBigSum(ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();


            ///
            ///Diagonal Difference
            ///
            //Environment.SetEnvironmentVariable("Output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida30Days.txt");
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("output_path"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < n; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}

            //int result = Result.DiagonalDifference(arr);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();


            ///
            ///Plus Minus
            ///

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //Result.PlusMinus(arr);


            ///
            ///Birthday Cake Candles
            ///
            //int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            //int result = Result.BirthdayCakeCandles(candles);

            //Console.WriteLine(result);

            #endregion

            ////salida
            Console.ReadKey();
        }

        #region Métodos
        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            float totPorc = (float)(tip_percent + tax_percent) / 100; //Operador converions IMPLICITA (FLOAT)(INT) ETC.
            float totalImpuestos = (float)meal_cost * (totPorc + 1);
            Console.WriteLine(Math.Round(totalImpuestos));
            //Console.WriteLine($"{(int)(meal_cost) * (((float)(tip_percent + tax_percent)/100) + 1):F0}");  //F0 SIN DECIMALES.
        }

        private static void practiceWhileLoop(int n)
        {
            //WhileLopp
            int w = 0;
            while (w < 10)
            {
                Console.WriteLine($"\nWhile {n} x {w} = {n * w}");
                w++;
            }
        }

        private static void practiceForLoop(int n)
        {
            //ForLoop
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine($"For {n} x {x} = {n * x}");
            }
        }

        public static void practiceDoWhileLoop(int n)
        {
            //DoWhileLoop
            int w = 0;
            do
            {
                Console.WriteLine($"DoWhile {n} x {w} = {n * w}");
                w++;
            }
            while (w < 10);
        }

        private static string orderEvenOddIndex(string texto)
        {
            //int size = texto.Length;
            char[] chars = texto.ToCharArray();
            string par = "";  //guardamos los caracteres en un nuevo texto.
            string impar = "";

            for (int i = 0; i < texto.Length; i++)
            {
                if (i % 2 == 0)  //Par
                {
                    par = par + chars[i];
                }
                else //Impar
                {
                    impar = impar + chars[i];
                }
            }

            return par + " " + impar;
        }

        public static int Factorial(int n)
        {
            // n=3
            // 3 * 2 * 1 * 1 = 6

            //Base case
            if (n <= 1)
                return 1;
            else // Recursive case
            {
                return n * Factorial(n - 1);
            }
        }
        public static int Exponentiation(int n, int p)
        {   // 5^3 = 5 * 5 * 5
            // 5^3 = 5 * 5^2 = 5 * 5 * 5^1 = 5 * 5 * 5 * 5^0 =  5 * 5 * 5 * 1
            //Base case
            if (p <= 0)
            {
                return 1;
            }
            else //Recursive
            {
                // 5 * exponentiation(5 * 2)
                // 5 * 5 * exponentation(5 * 1)
                // 5 * 5 * 5 *exponentation(5 * 0)
                // 5 * 5 * 5 * 1
                return n * Exponentiation(n, p - 1);
            }
        }

        public static void bubbleSort(List<int> unSort) //day20
        {
            int cantidadValores = unSort.Count;
            int numeroDeIntercambios = 0;

            for (int i = 0; i < cantidadValores; i++)
            {
                //Track number of elements swapped during a simgle array traversal
                for (int j = 0; j < cantidadValores - 1; j++)
                {
                    //Swap adjcent elements if they are in decreasing order.
                    if (unSort[j] > unSort[j + 1])
                    {
                        int tmp = unSort[j];
                        unSort[j] = unSort[j + 1];
                        unSort[j + 1] = tmp;

                        numeroDeIntercambios++;
                    }
                }
                //If no elements were sawpped during a traversal, array is sorted.
                if (numeroDeIntercambios == 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Array is sorted in {numeroDeIntercambios} swaps");
            Console.WriteLine($"First Element: {unSort.First()}");
            Console.WriteLine($"Last Element: {unSort.Last().ToString()}");

        }

        public static void PrintArray<T>(T[] intArray) //day21 Generico.
        {
            /**
            *    Name: PrintArray
            *    Print each element of the generic array on a new line. Do not return anything.
            *    @param A generic array
            **/

            //
            Console.WriteLine(string.Join(" ", intArray));
            //otra forma
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }

        private static bool EsNumeroPrimo(int num)
        {
            //division de prueba
            if (num < 2)
            {
                return false;

            }
            // Iterar desde 2 hasta la raíz cuadrada del número
            for (int j = 2; j <= num / 2; j++)
            {
                if (num % j == 0)
                {
                    return false; // Si el número es divisible por 'i', no es primo
                }
            }

            return true; // Si no se encontraron divisores, el número es primo
        }


        #endregion



        #region Métodos DESAFIOS
        private static void miniMaxSum(List<int> arr)
        {
            long sumtotal = arr.Sum(x => (long)x);
            //int menor = arr.Min(x => x); 
            //int mayor = arr.Max(x => x);
            int menor = arr.Min();
            int mayor = arr.Max();

            long max = sumtotal - menor;
            long min = sumtotal - mayor;
            Console.WriteLine(min + " " + max);

        }

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int sumA = 0, sumB = 0;
            List<int> resultado = new List<int>();

            for (int j = 0; j <= b.Count() - 1; j++)
            {
                if (a[j] > b[j])
                {
                    sumA++;
                }
                else if (a[j] < b[j])
                {
                    sumB++;
                }
            }

            //Console.Write($"{sumA}{sumB}");
            //string numCadena = sumA.ToString() + sumB.ToString();
            //resultado1.Add(numCadena);
            resultado.Add(sumA);
            resultado.Add(sumB);

            return resultado.ToList();
        }

        public static long aVeryBigSum(List<long> ar)
        {
            return ar.Sum(x => (long)x);
        }

        private static int DiagonalDifference(List<List<int>> arr)
        {
            int dleft, dright;
            dleft = dright = 0; // con una sola línea asignamos a 0 dos variables.

            for (int a = 0; a < arr.Count; a++)
            {
                dleft += arr[a][a];
                dright += arr[a][arr.Count - 1 - a]; // 3 - 1 - 0 = 2  => [0][2], [1][1], [2][0]

            }
            return Math.Abs(dleft - dright);
        }
        private static void PlusMinus(List<int> arr)
        {
            int n = arr.Count;
            double posi, nega, zero;
            posi = nega = zero = 0;

            foreach (var item in arr)
            {
                if (item > 0)
                {
                    posi++;
                }
                else if (item < 0)
                {
                    nega++;
                }
                else
                {
                    zero++;
                }
            }
            zero = zero / n;

            Console.WriteLine($"{posi / n:F6}");
            Console.WriteLine(String.Format("{0:F6}", nega / n));  //OTra forma con String.Format
            Console.WriteLine(zero.ToString("F6"));              //Usando ToString()

        }
        private static int BirthdayCakeCandles(List<int> arr)
        {
            //Forma simplificada
            int max = arr.Max();
            return arr.Count(x => x == max);

            //Se puede usar LINQ con LAMBDA
            //LINQ con expresiones lambda
            //LINQ = Language Integrated Query

            //var resultado = arr
            //            .GroupBy(x => x)
            //            .OrderByDescending(g => g.Key)
            //            .First();

            //Alternativa: LINQ Query Syntax (modo SQL-like)
            //var resultado =
            //                (from x in arr
            //                 group x by x into g
            //                 orderby g.Key descending
            //                 select g).First();

            //return resultado.Count();

        }

        #endregion
    }
}
