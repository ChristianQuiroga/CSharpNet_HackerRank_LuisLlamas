using AprendamosAProgramarEnCSharp.EjePolimorfismoHerencia;
using AprendamosAProgramarEnCSharp.Tipos_Genericos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AprendamosAProgramarEnCSharp
{


    public class Program
    {
        #region Enum y clases varias
        enum MesesAño
        {
            January, February, March, April, May, June, July, August, September, October, November, December
        }
        //Sobre carga de operadores +, -. *, /
        public struct Vector2D
        {
            public double X { get; }
            public double Y { get; }

            public Vector2D(double x, double y)
            {
                X = x;
                Y = y;
            }

            public static Vector2D operator +(Vector2D v1, Vector2D v2)
            {
                return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
            }
            public static bool operator ==(Vector2D v1, Vector2D v2)
            {
                return v1.X == v2.X && v1.Y == v2.Y;
            }
            public static bool operator !=(Vector2D v1, Vector2D v2)
            {
                return !(v1 == v2);
            }

            public override bool Equals(object obj)
            {
                if (obj is Vector2D)
                {
                    Vector2D v = (Vector2D)obj;
                    return X == v.X && Y == v.Y;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return X.GetHashCode() ^ Y.GetHashCode();
            }
        }

        //CONVERSION DEFINIDA POR EL USUARIO IMPLICITA Y EXPLICITA
        public class Celsius
        {
            public float Grados { get; set; }

            public Celsius(float grados)
            {
                Grados = grados;
            }

            public static implicit operator Fahrenheit(Celsius c)
            {
                return new Fahrenheit((c.Grados * 9 / 5) + 32);
            }
            public static explicit operator FahrenheitExpl(Celsius c)
            {
                return new FahrenheitExpl((c.Grados * 9 / 5) + 32);
            }
        }

        public class Fahrenheit
        {
            public float Grados { get; set; }

            public Fahrenheit(float grados)
            {
                Grados = grados;
            }
        }
        public class FahrenheitExpl
        {
            public float Grados { get; set; }

            public FahrenheitExpl(float grados)
            {
                Grados = grados;
            }
        }
        //\\CONVERSION DEFINIDA POR EL USUARIO IMPLICITA Y EXPLICITA
        #endregion
        static void Main(string[] args)
        {
            PrintWithTitle("FUNDAMENTOS", true);
            Console.WriteLine("\n¡Hola, Mundo!");
            Console.WriteLine("\n //Comentarios de una sola línea! \n /* Multiples líneas */" + Environment.NewLine + "///Comentarios XML Class, Properties, Methods");
            Console.ReadKey();


            //Usando Ensamblado externo.
            PrintWithTitle("Ensamblado Externo DLL (Suma)");
            var c = new Calc.Calculadora();
            Console.WriteLine(c.Sumar(3, 2));

            //
            var c1 = new MiEspacioDeNombres.Calculadora();
            var c2 = new MiEspacioDeNombres.Calculadora();

            Console.WriteLine($"MiEspaciodeNombres Calcu.: {c1.sumar(5, 5)}");
            Console.WriteLine($"MiEspaciodeNombres Calcu.: {c2.sumar(5, 5)}");

            #region Sobre carga de operadores
            PrintWithTitle("Sobre carga de operadores");
            Vector2D v1 = new Vector2D(1.0, 2.0);
            Vector2D v2 = new Vector2D(3.0, 4.0);
            Vector2D result = v1 + v2;

            Console.WriteLine($"Resultado: ({result.X}, {result.Y})");

            Vector2D v1_ = new Vector2D(1.0, 2.0);
            Vector2D v2_ = new Vector2D(1.0, 2.0);
            Vector2D v3_ = new Vector2D(3.0, 4.0);

            Console.WriteLine(v1_ == v2_); // True
            Console.WriteLine(v1_ != v3_); // True
            #endregion

            #region Casting
            //Console.WriteLine("\nCASTING");
            PrintWithTitle("CASTING", true);
            double numeroDecimal = 3.1416;
            int numeroEntero = (int)numeroDecimal;
            Console.WriteLine($"Decimal: {numeroDecimal} y Número Entero: {numeroEntero} que fue CAST");

            #endregion

            #region IS o AS
            object obj = "Hola, Mundo!";
            if (obj is string)
            {
                PrintWithTitle("Operador Is / As", true);
                Console.WriteLine("obj es una cadena");
            }

            object obj1 = "Hola, Mundo!";
            string cadena = obj1 as string;

            if (cadena != null)
            {
                Console.WriteLine("La conversión fue exitosa: " + cadena);
            }
            else
            {
                Console.WriteLine("La conversión falló");
            }
            #endregion

            #region CONVERSION DEFINIDA POR EL USUARIO IMPLICITA Y EXPLICITA
            PrintWithTitle("CONVERSION DEFINIDA POR EL USUARIO IMPLICITA Y EXPLICITA", true);
            Celsius celsius = new Celsius(25);
            Fahrenheit fahrenheit = celsius; // Conversión implícita
            PrintWithTitle("Conversión IMPLICITA");
            Console.WriteLine(fahrenheit.Grados); // Salida: 77

            Celsius celsiusExpl = new Celsius(25);
            FahrenheitExpl fahrenheitExpl = (FahrenheitExpl)celsiusExpl; // Conversión explícita
            PrintWithTitle("Conversión EXPLICITA");
            Console.WriteLine(fahrenheitExpl.Grados); // Salida: 77
            #endregion

            #region Iteración ENUN
            PrintWithTitle("Iteración ENUN");
            foreach (MesesAño mes in Enum.GetValues(typeof(MesesAño)))
            {
                Console.WriteLine(mes);
            }
            #endregion

            #region TUPLAS
            // Uso TUPLAS
            PrintWithTitle("TUPLAS");
            var resultado = Calcular(3, 4); // Llamar al método y almacenar el resultado en una tupla
            Console.WriteLine($"Suma: {resultado.suma}, Producto: {resultado.producto}"); // Imprimir los resultados

            // Uso
            var persona = (nombre: "Luis", edad: 30); // Crear una tupla con el nombre y la edad
            MostrarInformacion(persona); // Llamar al método con la tupla como argumento

            // Crear tuplas para comparar
            var tupla1 = (1, "Hola");
            var tupla2 = (1, "Hola");
            var tupla3 = (2, "Adiós");

            // Comparar tuplas
            bool sonIguales = tupla1 == tupla2; // true
            bool sonDiferentes = tupla1 != tupla3; // true

            // Imprimir resultados de la comparación
            Console.WriteLine($"tupla1 == tupla2: {sonIguales}");
            Console.WriteLine($"tupla1 != tupla3: {sonDiferentes}");

            // Crear una lista de tuplas que representan personas
            var personas = new List<(string nombre, int edad)>
            {
                ("Luis", 25),
                ("María", 30),
                ("Pedro", 28)
            };

            // Filtrar y seleccionar personas mayores de 25 años usando LINQ
            var mayoresDe25 = personas
                .Where(p => p.edad > 25)
                .Select(p => (p.nombre, p.edad));

            // Imprimir las personas filtradas
            foreach (var persona1 in mayoresDe25)
            {
                Console.WriteLine($"Nombre: {persona1.nombre}, Edad: {persona1.edad}");
            }

            //DICCIONARIO
            // Crear un diccionario con tuplas como claves y strings como valores
            var empleados = new Dictionary<(string departamento, int id), string>();

            // Añadir elementos al diccionario
            empleados.Add(("Ventas", 101), "Luis Pérez");
            empleados.Add(("Marketing", 102), "María López");
            empleados.Add(("TI", 103), "Pedro González");

            // Buscar empleados en el diccionario usando tuplas como claves
            var empleadoVentas = empleados[("Ventas", 101)];
            var empleadoMarketing = empleados[("Marketing", 102)];

            // Imprimir los resultados de la búsqueda
            Console.WriteLine($"Empleado en Ventas con ID 101: {empleadoVentas}");
            Console.WriteLine($"Empleado en Marketing con ID 102: {empleadoMarketing}");

            #endregion


            #region FOR
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue; // Saltar los números pares
            //    }
            //    Console.WriteLine(i);
            //}
            ////
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //
            int? i = 0;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Valor de i después del bucle: {i}");
            //
            for (int ii = 0, j = 10; ii < j; ii++, j--)
            {
                Console.WriteLine($"i: {ii}, j: {j}");
            }

            #endregion

            #region DO WHILE
            //string respuesta;

            //do
            //{
            //    Console.WriteLine("¿Desea continuar? (s/n): ");
            //    respuesta = Console.ReadLine().ToLower();
            //} while (respuesta != "s" && respuesta != "n");

            //Console.WriteLine("Programa terminado.");
            #endregion


            #region FOREACH

            #endregion

            #region SOBRECARGA FUNCIONES OVERLOAD
            // Uso
            double areaRectangulo = CalcularArea(5.0, 3.0); // Llamar a la función con dos parámetros
            double areaCuadrado = CalcularArea(4.0); // Llamar a la función con un parámetro

            // Imprimir los resultados
            Console.WriteLine($"Área del rectángulo: {areaRectangulo}");
            Console.WriteLine($"Área del cuadrado: {areaCuadrado}");


            #endregion


            #region ARRAYS
            PrintWithTitle("ARRAYS", true);
            PrintWithTitle("Calcular la media de un array de enteros");
            //1
            int[] numeros = { 1, 2, 3, 4, 5 }; // Declaramos el array con los números
            int suma = 0; // Variable para almacenar la suma de los elementos

            for (int ar_i = 0; ar_i < numeros.Length; ar_i++)
            {
                suma += numeros[ar_i]; // Suma cada elemento del array a 'suma'
            }

            double media = (double)suma / numeros.Length; // Calcula la media
            Console.WriteLine($"La media es: {media}");

            //2
            PrintWithTitle("Buscar el valor máximo en un array");
            int[] numeros1 = { 1, 2, 9, 4, 5 }; // Declaramos el array con los números
            int maximo = numeros1[0]; // Inicializa 'maximo' con el primer elemento del array

            for (int ia = 1; ia < numeros1.Length; ia++)
            {
                if (numeros1[ia] > maximo) // Compara cada elemento con 'maximo'
                {
                    maximo = numeros1[ia]; // Actualiza 'maximo' si se encuentra un valor mayor
                }
            }

            Console.WriteLine($"El valor máximo es: {maximo}");

            //3
            PrintWithTitle("Contar cuántos elementos son mayores que un valor dado");
            int[] numeros3 = { 1, 2, 3, 4, 5 }; // Declaramos el array con los números
            int valor = 3; // Valor de referencia
            int contador = 0; // Variable para contar los elementos

            for (int i3 = 0; i3 < numeros3.Length; i3++)
            {
                if (numeros[i3] > valor) // Verifica si el elemento es mayor que 'valor'
                {
                    contador++; // Incrementa el contador si la condición es verdadera
                }
            }

            Console.WriteLine($"Hay {contador} elementos mayores que {valor}");

            //4
            PrintWithTitle("Encontrar la posición de un elemento en un array");
            int[] numeros4 = { 1, 2, 3, 4, 5 }; // Declaramos el array con los números
            int buscar = 4; // Elemento a buscar
            int posicion = -1; // Inicializa la posición en -1 (valor que indica no encontrado)

            for (int i4 = 0; i4 < numeros4.Length; i4++)
            {
                if (numeros4[i4] == buscar) // Compara cada elemento con 'buscar'
                {
                    posicion = i4; // Actualiza 'posicion' con el índice del elemento encontrado
                    break; // Sale del bucle
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"El número {buscar} se encuentra en la posición {posicion}");
            }
            else
            {
                Console.WriteLine($"El número {buscar} no se encuentra en el array");
            }
            #endregion


            #region LISTAS
            //1)
            PrintWithTitle("LISTAS", true);
            PrintWithTitle("Calcular la suma de los elementos de una suma");
            List<int> numerosList = new List<int> { 1, 2, 3, 4, 5 }; // Declaramos la lista con los números
            int sumaList = 0; // Variable para almacenar la suma de los elementos

            foreach (int numeroList in numeros)
            {
                sumaList += numeroList; // Suma cada elemento de la lista a 'suma'
            }

            Console.WriteLine($"La suma de los elementos es: {suma}");

            //2)
            PrintWithTitle("Filtrar elementos de una lista");
            List<int> numerosList1 = new List<int> { 1, 2, 3, 4, 5 }; // Declaramos la lista con los números
            List<int> numerosPares = numerosList1.FindAll(numero => numero % 2 == 0); // Filtra los números pares

            Console.WriteLine("Números pares:");
            foreach (int numero in numerosPares)
            {
                Console.WriteLine(numero); // Imprime cada número par
            }


            //3)
            PrintWithTitle("Encontrar el valor máximo en una lista");
            List<int> numerosList2 = new List<int> { 1, 2, 3, 4, 5 }; // Declaramos la lista con los números
            int maximo2 = numerosList2.Max(); // Encuentra el valor máximo Método MAX

            Console.WriteLine($"El valor máximo es: {maximo2}");


            //4)
            PrintWithTitle("Ordenar los elementos de una lista");

            List<int> numerosList3 = new List<int> { 5, 3, 1, 4, 2 }; // Declaramos la lista con los números desordenados
            numerosList3.Sort(); // Ordena la lista en orden ascendente, Método SORT

            Console.WriteLine("Números ordenados:");
            foreach (int numero in numerosList3)
            {
                Console.WriteLine(numero); // Imprime cada número en orden 
            }

            //5)
            PrintWithTitle("Contar cuántos elementos cumplen una condición");
            List<int> numerosList4 = new List<int> { 1, 2, 3, 4, 5 }; // Declaramos la lista con los números
            int contador4 = numerosList4.Count(numero => numero > 3); // Cuenta los elementos mayores que 3, Método COUNT, LAMBDA =>

            Console.WriteLine($"Hay {contador4} elementos mayores que 3");


            //6)
            PrintWithTitle("Eliminar elementos de una lista");
            List<int> numerosList5 = new List<int> { 1, 2, 3, 4, 5 }; // Declaramos la lista con los números
            numerosList5.RemoveAll(numero => numero % 2 != 0); // Elimina todos los números impares, Método REMOVEALL, Lambda =>

            Console.WriteLine("Números restantes:");
            foreach (int numero in numerosList5)
            {
                Console.WriteLine(numero); // Imprime los números restantes
            }
            #endregion

            #region DICCIONARIOS
            PrintWithTitle("DICTIONARY", true);
            PrintWithTitle("Almacenar información de estudiantes y sus calificaciones");
            //1)
            // Crear un diccionario para almacenar las calificaciones de los estudiantes
            var calificacionesEstudiantes = new Dictionary<string, List<int>>();

            // Agregar calificaciones para cada estudiante
            calificacionesEstudiantes["Luis"] = new List<int> { 90, 85, 88 };
            calificacionesEstudiantes["María"] = new List<int> { 95, 92, 89 };
            calificacionesEstudiantes["Pedro"] = new List<int> { 78, 84, 80 };

            // Iterar sobre el diccionario y calcular el promedio de cada estudiante
            foreach (var alumno in calificacionesEstudiantes)
            {
                string nombre = alumno.Key; // Nombre del estudiante
                var calificaciones = alumno.Value; // Lista de calificaciones del estudiante
                double promedio = calificaciones.Average(); // Calcular el promedio

                Console.WriteLine($"Estudiante: {nombre}, Promedio: {promedio}");
            }

            //2)
            PrintWithTitle("Buscar el precio de un producto específico");
            // Crear un diccionario para almacenar los precios de los productos
            var preciosProductos = new Dictionary<string, double>();

            // Agregar precios para cada producto
            preciosProductos["Manzana"] = 1.2;
            preciosProductos["Banana"] = 0.5;
            preciosProductos["Naranja"] = 0.8;

            // Buscar el precio de un producto específico
            string productoBuscar = "Banana";
            if (preciosProductos.TryGetValue(productoBuscar, out double precio))
            {
                Console.WriteLine($"Producto: {productoBuscar}, Precio: {precio}");
            }
            else
            {
                Console.WriteLine($"El producto {productoBuscar} no se encuentra en el diccionario.");
            }

            //3)
            PrintWithTitle("Buscar el departamento de una lista de empleados");
            // Crear un diccionario para almacenar los departamentos de los empleados
            // Suponemos que 'departamentosEmpleados' ya está poblado con miles de entradas
            var departamentosEmpleados = new Dictionary<string, string>();
            // Agregar precios para cada producto
            departamentosEmpleados["Chris"] = "A1";
            departamentosEmpleados["Ana"] = "A1";
            departamentosEmpleados["Cris"] = "A2";
            departamentosEmpleados["Pedro"] = "A3";
            departamentosEmpleados["María"] = "A1";
            // Lista de empleados a buscar
            // En el ejemplo hay 5 personas, pero supongamos que esta lista sea muy muy grande
            List<string> empleadosABuscar = new List<string> { "Ana", "Luis", "Carlos", "Pedro", "María" };

            // Realizar búsquedas rápidas usando el diccionario
            foreach (string empleadoBuscar in empleadosABuscar)
            {
                if (departamentosEmpleados.TryGetValue(empleadoBuscar, out string departamento))
                {
                    Console.WriteLine($"Empleado: {empleadoBuscar}, Departamento: {departamento}");
                }
                else
                {
                    Console.WriteLine($"El empleado {empleadoBuscar} no se encuentra en el diccionario.");
                }
            }

            #endregion

            #region  ENUMERABLE OR IENUMERABLE<T>
            //1)Las consultas LINQ funcionan con cualquier colección que implemente IEnumerable<T>.
            List<int> numerosIE = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numerosParesIE = from numero in numeros
                                 where numero % 2 == 0
                                 select numero;

            foreach (int numero in numerosPares)
            {
                Console.WriteLine(numero);
            }

            //2)Evitar modificar colecciones durante la iteración
            List<int> numerosIE1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> numerosDuplicados = new List<int>();

            foreach (int numero in numeros)
            {
                numerosDuplicados.Add(numero * 2);
            }

            //3Comprender la evaluación diferida
            List<int> numerosIE3 = new List<int> { 1, 2, 3, 4, 5 };
            var filtrado = numerosIE3.Where(n => n > 3);
            Console.WriteLine(filtrado.Sum());  // 9

            numerosIE3.Add(6);

            Console.WriteLine(filtrado.Sum());  // 15
            #endregion

            #region LINQ

            #endregion

            #region DECLARACION DE CLASES
            PrintWithTitle("OBJETOS Y CLASES", true);
            //clase Persona/ Producto

            #endregion

            #region MÉTODOS Y CAMPOS ESTATICOS
            //Creamos la clase Cálculadora por afuera del main.
            //No hace falta instanciar la clase Cálculadora con Static
            PrintWithTitle("MÉTODOS Y CAMPOS ESTATICOS");

            int suma1 = Calculadora.Sumar(10, 5);
            int resta = Calculadora.Restar(10, 5);
            int multiplicacion = Calculadora.Multiplicar(10, 5);
            int division = Calculadora.Dividir(10, 5);

            Console.WriteLine($"Suma: {suma1}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicación: {multiplicacion}");
            Console.WriteLine($"División: {division}");
            Console.WriteLine($"Total de operaciones: {Calculadora.TotalOperaciones}");
            #endregion


            #region Modificador de Acceso
            PrintWithTitle("Modificador de Acceso");
            Console.WriteLine("PUBLIC: Desde cualquier lugar del código, sin restricciones.");
            Console.WriteLine("PROTECTED: Desde la clase base y las clases Derivadas.");
            Console.WriteLine("INTERNAL: Dentro de el mismo ensablado.(es decir, el mismo proyecto o biblioteca)");
            Console.WriteLine("PROTECTED INTERNAL: para permitir el acceso dentro del mismo ensamblado y en clases derivadas.");
            Console.WriteLine("PRIVATE: Solo dentro de la Clase o estructura que los define.");
            #endregion

            #region HERENCIA ENTRE CLASES
            PrintWithTitle("HERENCIA ENTRE CLASES");

            Console.WriteLine("\nEjemplo Básico:");
            //Uso
            Perro miPerro = new Perro();
            miPerro.Comer();  // Heredado de Animal
            miPerro.Ladrar(); // Definido en Perro

            //miPerro = null;
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            Console.WriteLine("\nSobrescritura de métodos:");
            // Uso
            //Animal miAnimal = new Animal(); //NO SE PUEDE INSTANCIAR DEL TIPO ABSTRACTO! 
            //miAnimal.HacerSonido(); // Salida: El animal hace un sonido.

            //Perro miPerro = new Perro();
            miPerro.HacerSonido(); // Salida: El perro ladra.

            Console.WriteLine("\nPalabra clase Base:");
            // Uso
            Perro miPerro1 = new Perro("Fido");
            miPerro1.HacerSonido();

            Console.WriteLine("\nConstructores en clases Derivadas:");
            // Uso
            Perro miPerro4 = new Perro("Fido", "Labrador");
            Console.WriteLine($"Nombre: {miPerro4.Nombre}, Raza: {miPerro4.Raza}");
            // Salida: Nombre: Fido, Raza: Labrador


            Console.WriteLine("\nHerencia y Polimorfismo");
            // Uso
            Animal miAnimal_poli;

            miAnimal_poli = new Perro("Fido");
            miAnimal_poli.HacerSonido(); // Salida: El perro ladra.

            miAnimal_poli = new Gato("Mishi");
            miAnimal_poli.HacerSonido(); // Salida: El gato maúlla.
            #endregion

            #region POLIMORFISMO
            PrintWithTitle("POLIMORFISMO");
            Animal miAnimalPoli = new Perro();
            miAnimalPoli.HacerSonido(); // Salida: El perro ladra.


            miAnimalPoli = new Gato();
            miAnimalPoli.HacerSonido(); // Salida: El gato maúlla.

            // Ocultación NEW
            // Polimorfismo con Interface
            IConducible vehiculo;

            vehiculo = new Coche();
            vehiculo.Conducir(); // Salida: El coche ha arrancado.
            vehiculo.Frenar();  // Salida: El coche se ha detenido.

            vehiculo = new Bicicleta();
            vehiculo.Conducir(); // Salida: La bicicleta ha comenzado a moverse.
            vehiculo.Frenar();  // Salida: La bicicleta se ha detenido.

            #endregion

            #region Interfaces
            #endregion

            #region CLASES ABSTRACTAS
            PrintWithTitle("CLASES ABSTRACTAS");

            Animal miPerroAbstracto = new Perro();
            miPerroAbstracto.Comer(); //
            miPerroAbstracto.HacerSonido();
            miPerroAbstracto.Dormir();

            Animal miGatoAbs = new Gato();
            miGatoAbs.Comer();
            miGatoAbs.HacerSonido();
            miGatoAbs.Dormir();
            #endregion

            #region CLASES SELLADAS
            #endregion

            #region IDISPOSABLES
            #endregion

            #region Ejemplos Polimorfimo y Herencia
            PrintWithTitle("Ejemplos Polimorfimo y Herencia");
            List<Vehiculo> vehiculos = new List<Vehiculo>
            {
                new Auto{ Marca = "Toyota", Modelo = "Corolla"},
                new Moto { Marca = "Yamaha", Modelo = "R1"},
                new Auto{Marca = "Ford", Modelo = "Focus"}
            };

            foreach (Vehiculo v in vehiculos)
            {
                v.Conducir();  // Polimorfismo

                // Métodos específicos con coincidencia de patrones
                if (v is Auto auto)
                {
                    auto.EncenderRadio();
                }
                else if (v is Moto moto)
                {
                    moto.HacerCaballito();
                }

                Console.WriteLine();
            }
            #endregion

            #region TIPOS DE DATOS AVANZADOS
            PrintWithTitle("TIPOS DE DATOS AVANZADOS", true);
            //Genericos
            PrintWithTitle("Genericos");
            Contenedor<int> contenedorInt = new Contenedor<int>();
            Type ContenedorType = contenedorInt.GetType();
            contenedorInt.Guardar(100);
            Console.WriteLine($"El tipo es   {ContenedorType.Name}:  contenedorInt.Obtener()"); // 100

            Contenedor<string> contenedorStr = new Contenedor<string>();
            Type ContenedorType2 = contenedorStr.GetType();
            contenedorStr.Guardar("CIEN");
            Console.WriteLine($"El tipo es {ContenedorType2.Name}:  {contenedorStr.Obtener()}"); // CIEN



            //Tipos Anonimos
            PrintWithTitle("Tipos Anonimos");
            var aux = new { Nombre = "Luis", Edad = 30 };
            Console.WriteLine($"Nombre: {aux.Nombre}, Edad: {aux.Edad}");

            var AnonimoPer = new[]
            {
                new { Nombre = "Lucía", Edad = 25 },
                new { Nombre = "Marta", Edad = 28 }
            };

            var nombres = AnonimoPer.Select(p => new { p.Nombre }); //lambda => en el contexto LINQ

            foreach (var nombre in nombres)
            {
                Console.WriteLine(nombre.Nombre);
            }

            ////Tipos anónimos con métodos
            //var resultadoAnonimo = CrearTipoAnonimo(); //invocamos al método anonimo (temporal, auxiliar)
            //Console.WriteLine($"Nombre: {resultadoAnonimo.Nombre}, Edad: {resultadoAnonimo.Edad}");

            //var CrearTipoAnonimo() => new { Nombre = "Carlos", Edad = 28 };

            //Tipos anónimos anidados
            var empresa = new
            {
                Nombre = "TechCorp",
                Empleado = new { Nombre = "Ana", Edad = 29 }
            };

            Console.WriteLine($"Empresa: {empresa.Nombre}, Empleado: {empresa.Empleado.Nombre}, Edad: {empresa.Empleado.Edad}");


            //Tipos Dynamics
            PrintWithTitle("Tipo Dynamics");
            Console.WriteLine("Dynamics puede tomar cualquier valor Dinamico, omite la verificación estática de tipos, Nos permite resolver tipos y miembreos en tiempo de ejecución.");
            dynamic variable = 10;
            variable = "Hello, World!";
            variable = new List<int> { 1, 2, 3 };
            foreach (var nombre in variable)
            {
                Console.WriteLine(nombre);
            }
            Console.WriteLine();
            dynamic valor1 = 10;
            Console.WriteLine(valor1 + 5); // Operación válida, salida: 15

            valor1 = "Hello";
            Console.WriteLine(valor1 + " World!"); // Operación válida, salida: Hello World!

            //Tipo Expando
            PrintWithTitle("ExpandoObjects");
            // Crear una lista de ExpandoObjects
            var productos = new List<ExpandoObject>();

            // Agregar productos a la lista
            dynamic producto1 = new ExpandoObject();
            producto1.Nombre = "Tablet";
            producto1.Precio = 300;
            productos.Add(producto1);

            dynamic producto2 = new ExpandoObject();
            producto2.Nombre = "Smartphone";
            producto2.Precio = 500;
            productos.Add(producto2);

            // Mostrar información de los productos
            foreach (dynamic producto in productos)
            {
                Console.WriteLine($"{producto.Nombre}: ${producto.Precio}");
            }

            Console.WriteLine();
            // Crear una instancia de ExpandoObject
            dynamic personaExpObj = new ExpandoObject();

            // Agregar propiedades
            personaExpObj.Nombre = "Luis";
            personaExpObj.Edad = 30;

            // Agregar un método
            personaExpObj.Saludar = new Action(() => Console.WriteLine($"Hola, mi nombre es {personaExpObj.Nombre} y tengo {personaExpObj.Edad} años."));

            // Usar las propiedades y el método
            Console.WriteLine($"Nombre: {personaExpObj.Nombre}");
            Console.WriteLine($"Edad: {personaExpObj.Edad}");
            personaExpObj.Saludar();

            //Reflexión
            //
            PrintWithTitle("Tipo Reflexión");
            int numeroReflex = 10;
            Type tipoNumeroReflex = numeroReflex.GetType();
            Console.WriteLine(tipoNumeroReflex.ToString());
            ///

            //
            PrintWithTitle("\n       Ejemplo de la Clase Persona");
            Type tipo = typeof(Perro);
            Console.WriteLine("Nombre del tipo: " + tipo.Name);

            FieldInfo[] campos = tipo.GetFields();
            foreach (var campo in campos)
            {
                Console.WriteLine("Campo: " + campo.Name);
            }

            MethodInfo[] metodos = tipo.GetMethods();
            foreach (var metodo in metodos)
            {
                Console.WriteLine("Método: " + metodo.Name);
            }
            ///

            //
            PrintWithTitle("\n        Ejemplo PropertyInfo");
            Persona personaReflex = new Persona();
            Type tipoPersona = personaReflex.GetType();

            Console.WriteLine("Clase: " + tipoPersona.Name);

            PropertyInfo propiedadNombre = tipoPersona.GetProperty("Nombre");
            propiedadNombre.SetValue(personaReflex, "Luis");

            Console.WriteLine("Nombre: " + personaReflex.Nombre);
            ///
            //
            PrintWithTitle("\n        Ejemplo Invoke métodos");
            Type type = typeof(Calculadora);
            object instancia = Activator.CreateInstance(type);
            MethodInfo metodoSumar = type.GetMethod("Sumar");
            object resultadoInvoke = metodoSumar.Invoke(instancia, new object[] { 100, 45000 });

            Console.WriteLine("Resultado de Sumar: " + resultadoInvoke.ToString());
            ///


            //
            PrintWithTitle("\n        Ejemplo Cargar ensamblados en tiempo de ejecución");
            Assembly ensamblado = Assembly.Load("mscorlib");
            Type[] tipos = ensamblado.GetTypes();

            foreach (var tipoEns in tipos)
            {
                Console.WriteLine("Tipo: " + tipoEns.Name);
            }
            ///

            //
            PrintWithTitle("\n        Ejemplo Uso de atributos personalizados");

            ///

            //
            PrintWithTitle("TIPOS DE DATOS ATRIBUTOS");




            //Atributos
            #endregion

            #region GESTION DE ERRORES

            int a = Sumar(9, 38);

            PrintWithTitle("GESTION DE ERRORES", true);
            //
            PrintWithTitle("Bloque try-catch");
            try
            {
                // Abrimos el archivo 'archivo.txt' para lectura utilizando StreamReader.
                using (StreamReader reader = new StreamReader("archivo.txt"))
                {
                    // Leemos todo el contenido del archivo.
                    string contenido = reader.ReadToEnd();
                    // Mostramos el contenido en la consola.
                    Console.WriteLine(contenido);
                } // El bloque 'using' asegura que el StreamReader se cierre y libere correctamente.
            }
            catch (FileNotFoundException ex)
            {
                // Captura y maneja la excepción si el archivo no se encuentra.
                Console.WriteLine("Error: El archivo no se encontró.");
            }
            catch (IOException ex)
            {
                // Captura y maneja otros errores de I/O, como problemas de lectura.
                Console.WriteLine("Error de I/O: Problema al leer el archivo.");
            }
            ///

            //Exception
            PrintWithTitle("Exception");
            using (StreamWriter writer = new StreamWriter("archivo.txt"))
            {
                writer.WriteLine("Hola Mundo");  // Lanzará IOException si hay un problema con el archivo
            }
            ///

            //
            PrintWithTitle("MiExcepción");
            try
            {
                // Código que puede generar una excepción
                throw new MiExcepcion("Error en mi aplicación");
            }
            catch (MiExcepcion ex)
            {
                // Manejo de la excepción  personalizada
            }
            #endregion

            #region ASINCRONIA
            //Threads
            PrintWithTitle("ASINCRONIA THREADS/HILOS", true);
            PrintWithTitle("Sincronización de hilos");
            CuentaBancariaThread cuenta = new CuentaBancariaThread();

            //Crear varios hilos para simular depósitos simultaneos
            Thread hilo1 = new Thread(() => cuenta.Depositar(100));
            Thread hilo2 = new Thread(() => cuenta.Depositar(200));

            hilo1.Start();
            hilo2.Start();

            hilo1.Join();
            hilo2.Join();
            ///

            //TASK
            PrintWithTitle("TASKS", true);
            PrintWithTitle("Creación y uso básico de Tasks");
            Task t = Task.Run(() =>
            {
                int resultask = 1 + 2;

                Task.Delay(2000).Wait(); //Espera 2 segundos

                Console.WriteLine("Resultado task: " + resultask);
            });

            PrintWithTitle("Esperar la finalización de una Task");
            Task t1 = Task.Run(() =>
            {
                int resultask1 = 1 + 2;
                Console.WriteLine("Resultado Wait: " + resultask1);
            });
            t1.Wait();
            ///

            //Async y Await
            // 



            ///

            //ASYNC / AWAIT
            PrintWithTitle("ASYNC / AWAIT");

            ///

            #endregion
            Console.ReadKey();

        }


        #region MÉTODOS
        /// <summary>
        /// Calcula la suma de dos números enteros.
        /// </summary>
        /// <param name="a">El primer número.</param>
        /// <param name="b">El segundo número.</param>
        /// <returns>La suma de a y b.</returns>
        private static int Sumar(int a, int b)
        {
            return a + b;
        }

        private static double CalcularArea(double lado)
        {
            return lado * lado; //Retornar el área del rectangulo
        }

        private static double CalcularArea(double longitud, double ancho)
        {
            return longitud * ancho; //Retornar el área del rectangulo
        }

        /*Métodos para imprimir con tìtulo*/
        /// <summary>
        /// Métodos para imprimir con título.
        /// </summary>
        /// <param name="title">Descripción del título.</param>
        /// <param name="tema">True es Tema y False Subtema.</param>
        /// <returns>La bordea con astericos si Tema o solo subrraya si es Subtema.</returns>
        static void PrintWithTitle(string title = "//** --- **//", bool tema = false)
        {
            if (tema == true)
            {
                string str = "";
                int countChar = title.Length + 2;
                Console.WriteLine("\n" + str.PadRight(countChar, '*'));
                Console.WriteLine(title + " *");
                //Console.WriteLine("\n"+title);
                //var encabezado = string.Format("{0,-40}", "*****************");
                Console.WriteLine(str.PadRight(countChar, '*'));
            }
            else
            {
                string str = "";
                int countChar = title.Length;
                //Console.WriteLine("\n" + str.PadRight(countChar, '*'));
                Console.WriteLine("\n" + title);
                //Console.WriteLine("\n"+title);
                //var encabezado = string.Format("{0,-40}", "*****************");
                Console.WriteLine(str.PadRight(countChar, '-'));
            }
        }

        #region MÉTODOS TUPLAS
        // Método que calcula la suma y el producto de dos números
        public static (int suma, int producto) Calcular(int a, int b)
        {
            int suma = a + b; // Calcular la suma
            int producto = a * b; // Calcular el producto
            return (suma, producto); // Retornar una tupla con los resultados
        }


        // Método que muestra información de una persona usando una tupla como parámetro
        public static void MostrarInformacion((string nombre, int edad) persona)
        {
            Console.WriteLine($"Nombre: {persona.nombre}, Edad: {persona.edad}"); // Imprimir el nombre y la edad
        }


        #endregion Tuplas

        #region Task Exceptions
        public static async Task Main()
        {
            try
            {
                await Task.Run(() => { throw new InvalidOperationException("Error en el Task"); });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción capturada: {ex.Message}");
            }
        }
        #endregion
        #region Multiples Tasks
        public static async Task MainWhenAll()
        {
            Task task1 = Task.Delay(2000);
            Task task2 = Task.Delay(3000);

            await Task.WhenAll(task1, task2); // Espera a que ambas tareas terminen
            Console.WriteLine("Ambas tareas completadas.");
        }
        public static async Task MainWhenAny()
        {
            Task task1 = Task.Delay(2000);
            Task task2 = Task.Delay(3000);

            await Task.WhenAny(task1, task2); // Continúa cuando una tarea termine
            Console.WriteLine("Al menos una tarea completada.");
        }
        #endregion

        #endregion
    }
}
