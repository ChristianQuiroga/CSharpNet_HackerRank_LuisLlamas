using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;

namespace HackerRank
{

    internal class Result
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! HackerRank Training");
            #region 1.1 plusMinus
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();


            //Result.plusMinus(arr);
            #endregion
            #region 1.2 miniMaxSum
            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //Result.miniMaxSum(arr);
            #endregion
            #region 1.3 timeConversion
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string s = Console.ReadLine();

            //string result = Result.timeConversion(s);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            #endregion

            #region TEST 1 Find the Median 

            //Console.WriteLine("Find the Median TEST1");
            //List<int> arr = [1, 5, 6, 3, 4, 9, 2];
            //Console.WriteLine("[" + string.Join(", ", arr) + "]"); //Como no se puede imprimir una lista directamente con Console.WriteLine(arr);, necesitás convertirla a un string:
            ////Result.findMedian(arr);
            //Console.WriteLine($"La Media es: {Result.findMedian(arr)}");
            #endregion

            #region 2.1 LonelyInteger
            ////TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //Environment.SetEnvironmentVariable("Output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida.txt");  // Creamos un TXT
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());  //ingresamos cantidas de numeros a ingresar ejemplo 7.

            //List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList(); // Ejemplo 1 2 3 5 3 2 1

            //int result = Result.lonelyinteger(a);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();

            #endregion
            #region 2.2 DiagonalDifference
            ////TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //Environment.SetEnvironmentVariable("Output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida.txt");
            //TextWriter textWriter1 = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            ////textWriter.WriteLine("Prueba local");
            ////textWriter.Close();

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < n; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}

            //int result1 = Result.diagonalDifference(arr);

            //foreach (var interval in arr)
            //{
            //    Console.WriteLine($"[{string.Join(", ", interval)}]");
            //}
            //textWriter1.WriteLine($"La sumatoria de las diagonales es: {result1}");

            //textWriter1.Flush();
            //textWriter1.Close();
            #endregion
            #region 2.3. Comparasion Sorting
            /*
            100
            63 25 73 1 98 73 56 84 86 57 16 83 8 25 81 56 9 53 98 67 99 12 83 89 80 91 39 86 76 85 74 39 25 90 59 10 94 32 44 3 89 30 27 79 46 96 27 32 18 21 92 69 81 40 40 34 68 78 24 87 42 69 23 41 78 22 6 90 99 89 50 30 20 1 43 3 70 95 33 46 44 9 69 48 33 60 65 16 82 67 61 32 21 79 75 75 13 87 70 33
            0 2 0 2 0 0 1 0 1 2 1 0 1 1 0 0 2 0 1 0 1 2 1 1 1 3 0 2 0 0 2 0 3 3 1 0 0 0 0 2 2 1 1 1 2 0 2 0 1 0 1 0 0 1 0 0 2 1 0 1 1 1 0 1 0 1 0 2 1 3 2 0 0 2 1 2 1 0 2 2 1 2 1 2 1 1 2 2 0 3 2 1 1 0 1 1 1 0 2 2 
            */
            //Environment.SetEnvironmentVariable("output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida.txt");  // Creamos un TXT)
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("output_path"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //List<int> result = Result.countingSort(arr);

            //textWriter.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();

            #endregion

            #region TEST 2  FlippingMatrix
            /* valores a ingresar en el cmd.
             * 1
             * 2
             * 112 42 83 119
             * 56 125 56 49
             * 15 78 101 43
             * 62 98 114 108
             * 
             * Salida 414
             */

            //// Creamos un TXT
            //Environment.SetEnvironmentVariable("output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida.txt");  
            ////
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true); //intruccion crear el objeto TextWriter.

            //int q = Convert.ToInt32(Console.ReadLine().Trim()); 

            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine().Trim());

            //    List<List<int>> matrix = new List<List<int>>();

            //    for (int i = 0; i < 2 * n; i++)
            //    {
            //        matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            //    }

            //    int result = Result.flippingMatrix(matrix);

            //    textWriter.WriteLine(result);
            //}

            //textWriter.Flush();
            //textWriter.Close();
            #endregion

            #region 3.2 Tower Breakers
            /*Usa el método estático SetEnvironmentVariable de la clase Environment para crear o modificar una variable de entorno del sistema operativo.
              En este caso, está creando o actualizando una variable de entorno llamada:
            */
            Environment.SetEnvironmentVariable("output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida.txt");
            //
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int t = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //    int n = Convert.ToInt32(firstMultipleInput[0]);

            //    int m = Convert.ToInt32(firstMultipleInput[1]);

            //    int result = Result.towerBreakers(n, m);

            //    textWriter.WriteLine(result);
            //}

            //textWriter.Flush();
            //textWriter.Close();

            #endregion
            #region 3.3  CaesarCipher
            //Environment.SetEnvironmentVariable("output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida.txt");  // Creamos un TXT)
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("output_path"), true);
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //string s = Console.ReadLine();

            //int k = Convert.ToInt32(Console.ReadLine().Trim());

            //string result = Result.caesarCipher(s, k);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            #endregion

            #region TEST DAY 3 Palindrome Index
            //Environment.SetEnvironmentVariable("output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida.txt");  // Creamos un TXT)
            //TextWriter textWriterTest3 = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //int q = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    string s_3test = Console.ReadLine();

            //    int result_3test = Result.palindromeIndex(s_3test);

            //    textWriterTest3.WriteLine(result_3test);
            //}

            //textWriterTest3.Flush();
            //textWriterTest3.Close();
            #endregion

            #region 4.1 GridChallenge
            //Environment.SetEnvironmentVariable("output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida.txt");  // Creamos un TXT)
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int t = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine().Trim());

            //    List<string> grid = new List<string>();

            //    for (int i = 0; i < n; i++)
            //    {
            //        string gridItem = Console.ReadLine();
            //        grid.Add(gridItem);
            //    }

            //    string result = Result.gridChallenge(grid);

            //    textWriter.WriteLine(result);
            //}

            //textWriter.Flush();
            //textWriter.Close();
            #endregion
            #region 4.2 SuperDigit
            //Environment.SetEnvironmentVariable("output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida.txt");  // Creamos un TXT)
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //string n = firstMultipleInput[0];

            //int k = 3; // 100000; //Convert.ToInt32(firstMultipleInput[1]);

            //int result = Result.superDigit(n, k);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            #endregion
            #region 4.3 Too Chaotic - mininumBrides
            //int t = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine().Trim());

            //    List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            //    Result.minimumBribes(q);
            //}
            #endregion

            #region Test 4
            //Environment.SetEnvironmentVariable("output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida.txt");  // Creamos un TXT)
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<List<int>> petrolpumps = new List<List<int>>();

            //for (int i = 0; i < n; i++)
            //{
            //    petrolpumps.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(petrolpumpsTemp => Convert.ToInt32(petrolpumpsTemp)).ToList());
            //}

            //int result = Result.truckTour(petrolpumps);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            #endregion

            #region 5.2 Queue, Enqueue, Dequeue 
            int q = int.Parse(Console.ReadLine());
            var queue = new QueueWithTwoStacks();

            for (int i = 0; i < q; i++)
            {
                string[] parts = Console.ReadLine().Split(' ');
                int type = int.Parse(parts[0]);

                switch (type)
                {
                    case 1: // enqueue
                        int x = int.Parse(parts[1]);
                        queue.Enqueue(x);
                        break;
                    case 2: // dequeue
                        queue.Dequeue();
                        break;
                    case 3: // print front
                        Console.WriteLine(queue.Peek());
                        break;
                }
            }




            #endregion

            #region FizzBuzz

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //Result.fizzBuzz(n);

            #endregion

            #region TEST FINAL
            //1


            //2 FindSchedules
            /*
             * crear un horario de horas trabajadas en C# devolver un list<string>, del siguiente metodo Public  list<string> Findschedules(int wokhours, int dayhour, string pattern).  7 dias laborables total 56 hrs.
             */
            /*
             * Leeremos el patrón fijo.
             * Para cada ? probaremos de 0 a dayHours.
             * Usaremos bucles anidados hasta el séptimo día.
             * Si el día no tiene ?, solo usamos el valor fijo.
             */

            //var solution = new Result();
            //var schedules = solution.FindSchedules(10, 8, "?2??0??");

            //foreach (var s in schedules)
            //{
            //    Console.WriteLine(s);
            //}

            //3 Torniquete o Molinete de Universidad.
            /*
             * 
             */

            //var time = new List<int> { 0, 0, 1, 5 };
            //var direction = new List<int> { 0, 1, 1, 0 };

            //var output = Torniquete(time, direction);
            //Console.WriteLine(string.Join(", ", output));

            #endregion

            #region ChatGpt Ejercicio de práctica: "Agrupador de intervalos
            ////Ejercicio de práctica: "Agrupador de intervalos"
            //Console.WriteLine($"\nEjercicio de práctica: \"Agrupador de intervalos\"");
            //int[][] intervals = new int[][] {
            //    new int[] {1, 3},
            //    new int[] {2, 6},
            //    new int[] {8, 10},
            //    new int[] {15, 18}
            //};
            //foreach (var interval in intervals)
            //{
            //    Console.WriteLine($"[{string.Join(", ", interval)}]");
            //}

            //int[][] fucionados = Result.MergeIntervals(intervals);
            //Console.WriteLine("\nIntervalos Fucionados:");
            //foreach (var interval in fucionados)
            //{
            //    Console.WriteLine($"[{string.Join(", ", interval)}]");
            //}
            #endregion
        }






        #region Métodos dia 1
        public static void plusMinus(List<int> arr)
        {
            int pos = 0, neg = 0, cero = 0;


            foreach (int num in arr)
            {
                if (num > 0)
                    pos++;
                else if (num < 0)
                    neg++;
                else
                    cero++;
            }


            Console.WriteLine($"Positivo: {(float)pos / arr.Count:F6}");
            Console.WriteLine($"Negativo: {(float)neg / arr.Count:F6}");
            Console.WriteLine($"Cero: {(float)cero / arr.Count:F6}");
            //float ceroCociente = (float)cero / arr.Count;

            ////Console.WriteLine(posCociente.ToString("F6"));
            //Console.WriteLine(negCociente.ToString("F6"));
            //Console.WriteLine(ceroCociente.ToString("F6"));
        }
        public static void miniMaxSum(List<int> arr)
        {
            //int valmin = arr.Min(), valmax = arr.Max();

            //foreach (int num in arr)
            //{
            //    if (num > valmin)
            //        valmin = num;
            //    else if ()


            //            }
            long totalSum = arr.Sum(x => (long)x);

            long min = totalSum - arr.Max();
            long max = totalSum - arr.Min();

            Console.WriteLine($"{min} {max}");


        }
        public static string timeConversion(string s)
        {
            DateTime horaMilitar = DateTime.ParseExact(s, "hh:mm:sstt", null);
            return horaMilitar.ToString("HH:mm:ss");

        }

        public static int findMedian(List<int> arr)
        {
            /*
               * Complete the 'findMedian' function below.
               *
               * The function is expected to return an INTEGER.
               * The function accepts INTEGER_ARRAY arr as parameter.
            */
            arr.Sort(); // Ordenamos la lista

            int n = arr.Count;
            int mid = n / 2; // el count se divide entre 2 para sacar la mitad.

            return arr[mid]; // Como es impar, este es el valor del medio arr[mid] es la posición arr[4] va desde 0 a n.
        }
        #endregion

        #region Métodos día 2
        //1
        public static int lonelyinteger(List<int> a)
        {
            /*
            *Complete the 'lonelyinteger' function below.
             *
             *The function is expected to return an INTEGER.
             * The function accepts INTEGER_ARRAY a as parameter.
             */
            return a.GroupBy(x => x)
                  .Where(g => g.Count() == 1)
                  .Select(g => g.Key)
                  .First();
        }

        //2
        public static int diagonalDifference(List<List<int>> arr)
        {
            int n = arr.Count;
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                primaryDiagonal += arr[i][i];                // Elemento [i][i]
                secondaryDiagonal += arr[i][n - 1 - i];       // Elemento [i][n-1-i]
            }

            return Math.Abs(primaryDiagonal - secondaryDiagonal);
        }
        //3
        public static List<int> countingSort(List<int> arr)
        {
            List<int> frecuencia = new List<int>(new int[100]);
            foreach (int i in arr)
            {
                frecuencia[i]++;
                //arr.ForEach(x => Console.WriteLine(arr[i]));
            }
            //            arr.ForEach(x =>  frecuencia)
            return frecuencia;
        }

        //TEST DAY 2 - FlippingMatrix 
        public static int flippingMatrix(List<List<int>> matrix)
        {
            int n = matrix.Count / 2;
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Buscar el máximo de los 4 posibles valores que pueden terminar en [i][j]
                    int val1 = matrix[i][j];
                    int val2 = matrix[i][2 * n - 1 - j];
                    int val3 = matrix[2 * n - 1 - i][j];
                    int val4 = matrix[2 * n - 1 - i][2 * n - 1 - j];

                    total += Math.Max(Math.Max(val1, val2), Math.Max(val3, val4));
                }
            }

            return total;
        }

        #endregion

        #region Métodos día 3
  

        public static int towerBreakers(int n, int m)
        {
            /*
            * Complete the 'towerBreakers' function below.
            *
            * The function is expected to return an INTEGER.
            * The function accepts following parameters:
            *  1. INTEGER n
            *  2. INTEGER m
            */
            
            if (m == 1 || n % 2 == 0)
                return 2; // Jugador 2 gana
            else
                return 1; // Jugador 1 gana

            

        }
        public static string caesarCipher(string s, int k)
        {
            string alphabet = "abcdefghijklmnñopqrstuvwxyz"; //Declaro mi alfabeto
            int longitudAlf = alphabet.Length;
            k = k % longitudAlf;

            char[] result = new char[s.Length]; //creamos un array del tamaño del texto ingresado

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                bool Mayusc = char.IsUpper(c);
                char Minisc = char.ToLower(c);

                int indice = alphabet.IndexOf(Minisc); //Buscamos el indice del texto ingresado en el Abecedario va de 0 a N.

                if (indice == -1)
                {
                    //Si no esta en nuestro alphabet, dejamos igual
                    result[i] = c;
                }
                else
                {
                    int nuevoIndice = (indice + k) % longitudAlf; //al indice le sumamos el número ingresado para correr la letra en el abecedario.
                    char nuevaLetra = alphabet[nuevoIndice];

                    result[i] = Mayusc ? char.ToUpper(nuevaLetra) : nuevaLetra;
                }

            }

            return new string(result);
        }
        //Test DAY 3 palindromeIndex
        public static int palindromeIndex(string s)
        {
            // s = "aaab";
            int izquierda = 0;
            int derecha = s.Length - 1; //esta instruccion muestra el último Caracter "hola" => a

            while (izquierda < derecha)
            {
                if (s[izquierda] != s[derecha])
                {
                    //Verificamos  si removiendo izquierda o derecha da palíndromo.
                    if (IsPalindromo(s, izquierda + 1, derecha))
                        return izquierda;
                    if (IsPalindromo(s, izquierda, derecha - 1))
                        return derecha;
                    return -1; //no hay forma de hacerlo palíndromo con un solo cambio.
                }
                izquierda++;
                derecha--;
            }
            return -1;  //ya es palíndromo
        }

        // Función auxiliar que verifica si una subcadena es palíndromo
        private static bool IsPalindromo(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] != s[end])
                    return false;
                start++;
                end--;
            }
            return true;
        }

        #endregion

        #region Métodos día 4
        //1 Grid Challenge
        private static string gridChallenge(List<string> grid)
        {
            int n = grid.Count;

            // Paso 1: ordenar cada fila alfabéticamente
            for (int i = 0; i < n; i++)
            {
                char[] rowChars = grid[i].ToCharArray();
                Array.Sort(rowChars);
                grid[i] = new string(rowChars);
            }

            // Paso 2: verificar que las columnas estén ordenadas
            for (int col = 0; col < grid[0].Length; col++)
            {
                for (int row = 0; row < n - 1; row++)
                {
                    if (grid[row][col] > grid[row + 1][col])
                    {
                        return "NO";
                    }
                }
            }

            return "YES";
        }


        /* //2 Recursive Digit Sum
       * Complete the 'superDigit' function below.
       *
       * The function is expected to return an INTEGER.
       * The function accepts following parameters:
       *  1. STRING n
       *  2. INTEGER k
       *  
       *  Da Error con varios TESTS
       */
        public static int superDigit(string n, int k)
        {
            // Sumamos los dígitos del string n
            long sum = n.Select(c => c - '0').Sum();  //c - '0' para convertir el char numérico a su valor entero.
            long sum1 = n.ToString().Sum(c=>c- '0');  //Otra forma.

            // Multiplicamos por k según el problema
            long total = sum * k;

            //Calculamos el super digit del total
            return recursiveSuperDigit(total);

            //if (n.Length ==1)
            //    return int.Parse(n);


            //string repetidos = "";
            ////for (long i = 0; i < k; i++)
            ////{
            ////    repetidos += n;
            ////}

            //foreach (char c in n)
            //{
            //    repetidos += n;   
            //}

            ////char[] digitos = n.ToCharArray();
            //// Convertir a int[] usando LINQ
            //int[] numeros = repetidos.Select(c => c - '0').ToArray();
            ////sumar
            //long sum = numeros.Sum();

            //return esUnSoloDigito(sum);

        }
        public static int recursiveSuperDigit(long num)
        {
            if (num < 10)
                return (int)num;

            long nextSum = 0;
            while (num > 0)
            {
                nextSum += num % 10; //Para obtener el último dígito decimal
                num /= 10;          //   /= 10 elimina el último dígito.
            }

            return recursiveSuperDigit(nextSum);  
            //     MOD Cuándo usarlo
            //% 10    Para obtener el último dígito decimal
            //% 100   Para últimos dos dígitos
            //% 2 Para saber si es par o impar
            //% 3, % 7, % 9   Para divisibilidad o restos específicos(puzzles, teoría de números)
            //% base  Para dígitos en otras bases(hexadecimal, octal)
            //% ciclo Para manejar ciclos(por ejemplo % 7 para días de la semana, % 60 para minutos)
        }
        private static int esUnSoloDigito(long sum)
        {
            if (sum < 10)
            {
                return (int)sum;
            }
            else
            {
                //string m = sum.ToString();
                return superDigit(sum.ToString(), 1);
            }
            //if (sum < 10)
            //{
            //    return (int)sum;
            //}

            //long nextSum = 0;
            //while (sum > 0)
            //{
            //    nextSum += sum % 10;
            //    sum /= 10;
            //}

            //return esUnSoloDigito(nextSum);
        }

        //3 New Year Chaos
        public static void minimumBribes(List<int> q)
        {
            int soborno = 0;

            for (int i = 0; i < q.Count; i++)
            {
                // Si alguien está más de dos posiciones adelante de donde debería, es caótico
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                // Revisamos desde dos posiciones detrás de q[i] hasta la posición actual
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if (q[j] > q[i])
                    {
                        soborno++;
                    }
                }
            }

            Console.WriteLine(soborno);
        }

        // TEST DAY 4 truckTour
        public static int truckTour(List<List<int>> petrolpumps)
        {
            int start = 0;   // índice desde donde intentaremos empezar
            int fuel = 0;    // nafta actual
            int deficit = 0; // nafta que nos faltó cuando nos quedamos sin fuel

            for (int i = 0; i < petrolpumps.Count; i++)
            {
                int petrol = petrolpumps[i][0];
                int distance = petrolpumps[i][1];

                fuel += petrol - distance;

                if (fuel < 0)
                {
                    // Si no podemos llegar al siguiente pump,
                    // significa que ningún punto entre start y i puede ser la solución.
                    start = i + 1;
                    deficit += fuel; // acumulamos la deuda
                    fuel = 0;         // reiniciamos fuel
                }
            }

            return (fuel + deficit >= 0) ? start : -1;
        }
        #endregion



        #region TEST FizzBuzz
        public static void fizzBuzz(int n)
        {
            for (int num = 1; num <= n; num++)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine($"FizzBuzz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine($"Buzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine($"Fizz");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }
        #endregion
        #region Test ChatGpt
        public static int[][] MergeIntervals(int[][] intervals)
        {
            if (intervals.Length <= 1)
                return intervals;

            // Ordenamos por inicio
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            var merged = new List<int[]>();
            int[] current = intervals[0];

            foreach (var next in intervals.Skip(1))
            {
                if (current[1] >= next[0])
                {
                    // Se superponen
                    current[1] = Math.Max(current[1], next[1]);
                }
                else
                {
                    // No se superponen, guardamos el actual
                    merged.Add(current);
                    current = next;
                }
            }

            merged.Add(current); // Agregamos el último intervalo

            return merged.ToArray();
        }
        #endregion

        #region TEST FINAL HACKERRANK
        //1


        //2
        public List<string> FindSchedules(int workHours, int dayHours, string pattern)
        {
            List<string> results = new List<string>();
            char[] days = pattern.ToCharArray();

            for (int d0 = (days[0] == '?' ? 0 : days[0] - '0');
                        d0 <= (days[0] == '?' ? dayHours : days[0] - '0'); d0++)
            for (int d1 = (days[1] == '?' ? 0 : days[1] - '0');
                        d1 <= (days[1] == '?' ? dayHours : days[1] - '0'); d1++)
            for (int d2 = (days[2] == '?' ? 0 : days[2] - '0');
                        d2 <= (days[2] == '?' ? dayHours : days[2] - '0'); d2++)
            for (int d3 = (days[3] == '?' ? 0 : days[3] - '0');
                        d3 <= (days[3] == '?' ? dayHours : days[3] - '0'); d3++)
            for (int d4 = (days[4] == '?' ? 0 : days[4] - '0');
                        d4 <= (days[4] == '?' ? dayHours : days[4] - '0'); d4++)
            for (int d5 = (days[5] == '?' ? 0 : days[5] - '0');
                        d5 <= (days[5] == '?' ? dayHours : days[5] - '0'); d5++)
            for (int d6 = (days[6] == '?' ? 0 : days[6] - '0');
                        d6 <= (days[6] == '?' ? dayHours : days[6] - '0'); d6++)
            {
                int total = d0 + d1 + d2 + d3 + d4 + d5 + d6;
                if (total == workHours)
                {
                    results.Add($"{d0}{d1}{d2}{d3}{d4}{d5}{d6}");
                }
            }

            return results;
        }
        //3
        public static List<int> Torniquete(List<int> time, List<int> direction)
        {
            int n = time.Count;
            List<int> result = new List<int>(new int[n]);  //crea una lista de tamaño 4 => n.
            bool[] processed = new bool[n];                //crea un array boleano de tamaño 4 => n. todo false por defecto.
            int processedCount = 0;
            int currentTime = 0;

            while (processedCount < n)
            {
                int chosen = -1; //crea una variable unicamente en este "Ambito".

                // Buscar salida en este tiempo
                for (int i = 0; i < n; i++)
                {
                    if (!processed[i] && time[i] <= currentTime && direction[i] == 1)
                    {
                        chosen = i;
                        break;
                    }
                }

                // Si no hay salida, buscar entrada
                if (chosen == -1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (!processed[i] && time[i] <= currentTime && direction[i] == 0)
                        {
                            chosen = i;
                            break;
                        }
                    }
                }

                if (chosen != -1)
                {
                    result[chosen] = currentTime;
                    processed[chosen] = true;
                    processedCount++;
                }

                currentTime++;
            }

            return result;
        }

        #endregion

    }
}
