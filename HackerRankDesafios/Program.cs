using System.IO;

namespace HackerRankDesafios
{
    internal class Result
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! DESAFIOS");
            Environment.SetEnvironmentVariable("Output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\HackerRankDesafios.txt");

            #region Algorithms > Strings > CamelCase
            //Environment.SetEnvironmentVariable("Output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida30Days.txt");
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("output_path"), true);

            //string s = Console.ReadLine();

            //int result = Result.Camelcase(s);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            #endregion

            #region WarmupS > taircase (escalera)
            //int n = 4;
            //string caracter = "";


            //for (int i = 0; i < n; i++)
            //{
            //    string space = "";
            //    for (int j = 0; j < n - (i + 1); j++)
            //    {
            //        space = space + " ";
            //    }
            //    caracter = caracter + "#";
            //    Console.WriteLine(space + caracter);

            //}



            //for (int i = 1; i <= n; i++)
            //{
            //    // Crea una cadena con i '#' y la rellena a la izquierda hasta n
            //    string caracter1 = new string('#', i).PadLeft(n, ' ');
            //    Console.WriteLine(caracter1);
            //}


            #endregion

            #region Algorithms > ImplementationGrading > Students
            ////Environment.SetEnvironmentVariable("Output_path", "C:\\Users\\christian.quiroga\\OneDrive - WiseTech Global Pty Ltd\\Documents\\CURSOS CODERHOUSE\\HackerRank Exercises\\salida30Days.txt");
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("output_path"), true);

            ////int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> grades = new List<int>();

            ////for (int i = 0; i < gradesCount; i++)
            ////{
            ////    int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            ////    grades.Add(gradesItem);
            ////}
            //grades = new List<int>() {73, 67, 38, 33 };
            //Console.WriteLine(String.Join("\n", grades));
            //Console.WriteLine();

            //List<int> result = Result.GradingStudents(grades);

            //Console.WriteLine(String.Join("\n", result));
            //textWriter.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
            #endregion

            #region Algorithms > ImplementationNumber > Line Jumps (Saltos de linea numeríca)
            ///Sample Input 0
            //            0 3 4 2
            //Sample Output 0
            //             YES
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x1 = Convert.ToInt32(firstMultipleInput[0]);

            int v1 = Convert.ToInt32(firstMultipleInput[1]);

            int x2 = Convert.ToInt32(firstMultipleInput[2]);

            int v2 = Convert.ToInt32(firstMultipleInput[3]);

            string result = Result.kangaroo(x1, v1, x2, v2);

            textWriter.WriteLine("Algorithms > ImplementationNumber > Line Jumps (Saltos de linea numeríca)");
            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();

            #endregion
        }

        private static string kangaroo(int x1, int v1, int x2, int v2)
        {

            if (v1 > v2)
            {
                if ((x2 - x1) % (v1 - v2) == 0)
                {
                    return "YES";
                }
            }
                
            return "NO";


        }

        #region Methods 
        public static int Camelcase(string s)
        {
            bool esMayuscula = false;
            int cont = 1;
            foreach (var item in s)
            {
                if (char.IsUpper(item))
                {
                    cont++;
                    esMayuscula = true;
                    //break;
                }

            }

            return cont;
            //  Other form.
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (char.IsUpper(s[i]))
            //    {
            //        cont++;
            //    }
            //}
            //return 1;
        }

        public static List<int> GradingStudents(List<int> grades)
        {
            //List<int> listResult = new List<int>();

            ////int nNumberOfStudent = 0;
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    //if (i == 0)
            //    //{
            //    //    nNumberOfStudent = grades[i];
            //    //    continue;
            //    //}
            //    int val = grades[i];

            //    if (val < 38)
            //    {
            //        listResult.Add(val);
            //    }
            //    else if ((5 - (val % 5)) <= 2) // 73 -> 3 -> (5-3=2)
            //    {
            //        listResult.Add(val + (5 - (val % 5)));
            //    }
            //    else if ((5 - (val % 5)) >= 3) // 67 -> 2 -> (5-2= 3)
            //    {
            //        listResult.Add(val);
            //    }

            //}
            //return listResult;


            //
            //int[] finalgrade = grades.ToArray(); //  Convierte la list en int[] con ToArray()
            //int[] primos = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };

            List<int> finalgrade = new List<int>();
            List<int> primos = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
            //int[] numeroObjetivo = grades.First();


            // Usamos lINQ
            int numeroMasCercano; // = primos.OrderBy(n => Math.Abs(n - numeroObjetivo)).First();
            int num;

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    finalgrade.Add(grades[i]);
                }
                else
                {
                    //numeroMasCercano = primos.OrderBy(n => Math.Abs(n - finalgrade[i])).First();
                    numeroMasCercano = primos
                                        .Where(n => n > grades[i])
                                        .OrderBy(n => n)
                                        .FirstOrDefault();

                    //int[] x = primos.Where(n => n > grades[i])
                    //                    .OrderBy(n => n)
                    //                    .ToArray();
                                        

                    num = Math.Abs(numeroMasCercano - grades[i]);
                    if (num < 3)
                    {
                        finalgrade.Add(numeroMasCercano);
                    }
                    else
                    {
                        finalgrade.Add(grades[i]);
                    }
                }
            }
            //return finalgrade.ToList();  // de Array a List()
            return finalgrade;
        }
        #endregion
    }
}
