using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seleccion;

            do
            {
                Console.WriteLine("\nMenu de seleccion:");
                Console.WriteLine("1. Realizar mediante un for, una función que sume los números pares hasta el 75:");
                Console.WriteLine("2. Realizar mediante un foreach el recorrido de una lista de 9 números enteros y que encuentre el número más grande");
                Console.WriteLine("3. Realizar un programa mediante un for, la representación de una tabla de multiplicar de un numero n, del 1 al 12 y que al valor de “n x i” le sume 2.:");
                Console.WriteLine("4. Salir de la seleccion:");
                Console.WriteLine("\nSeleccione una opcion (1-4): ");

                if (int.TryParse(Console.ReadLine(), out seleccion))
                {
                    switch (seleccion)
                    {
                        case 1:
                            int suma = 0;

                            for (int i = 2; i <= 75; i += 2)
                            {
                                suma += i;
                            }

                            Console.WriteLine($"\nLa suma de todos los numeros pares es: {suma}");

                            break;

                        case 2:

                            List<int> numeros = new List<int> { 10, 45, 35, 14, 10, 45, 84, 36, 78, };

                            int max = numeros[0];



                            foreach (int num in numeros)
                            {
                                if (num > max)
                                {
                                    max = num;
                                }

                            }

                            Console.WriteLine("\nEl numero maximo de la lista es > " + max);



                            break;

                        case 3:

                            Console.WriteLine("\nIngrese un numero para elaborar la tabala de multiplicar");
                            int numero = Convert.ToInt32(Console.ReadLine());

                            for (int i = 1; i <= 12; i++)
                            {
                                int multiplicacion = numero * i;

                                Console.WriteLine($"{numero} x {i} = {multiplicacion} + {2} = {multiplicacion + 2}");

                            }

                            break;

                        case 4:

                            break;

                        default:
                            Console.WriteLine("\nOpcion no valida. Por favor ingrese una opcion valida");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("\nEntrada no valida. Debe ingresar un numero (1-4) ");

                }

            } while (seleccion != 4);



            // NOMBRE: PEDRO ANTONIO ALVAREZ HERNANDEZ
            // CODIGO: U20230697


        }
    }
}