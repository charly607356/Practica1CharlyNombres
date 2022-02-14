using System;

namespace Practica1CharlyNombres
{
    class Program
    {
        static int[] numeros = new int[] { 8, 4, 6, 2 };

        static void Main(string[] args)
        {
            double mayor, menor;
            mayor = 0;
            menor = 0;
            int temp;
            int[] edad = new int[4];
            string[] nombre = new string[4];
            for (int i = 0; i < edad.Length; i++)
            {
                Console.Write("Ingrese el nombre posicion " + (i + 0) + ": ");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("dame su edad:");
                edad[i] = Convert.ToInt32(Console.ReadLine());

                //El que tiene  mayor y menor edad

                    if (i == 1 || mayor < edad[i])
                mayor = edad[i];

                if (i == 1 || menor > edad[i])
                menor = edad[i];
               
            Console.WriteLine();
        }
        Console.WriteLine("**El que tiene menor edad es:** " + menor + " carlos");

            Console.WriteLine("**El que tiene mayor edad es:** " + mayor + " valeria");
            string seudo;
            //METODO BURBUJA
            for (int i = 0; i < (edad.Length - 1); i++)
            {
                for (int j = 0; j < (edad.Length - 1); j++)
                {
                    if (edad[j] > edad[j + 1])
                    {
                        temp = edad[j];
                        seudo = nombre[j];
                        edad[j] = edad[j + 1];
                        nombre[j] = nombre[j + 1];
                        edad[j + 1] = temp;
                        nombre[j + 1] = seudo;

                    }
                }
            }
           
            // EDAD DE MENOR A MAYOR
            Console.WriteLine("**Edades ordenadas de menor a mayor**");
            for (int p = 0; p < edad.Length; p++)
            {
                Console.WriteLine(nombre[p + 0] + "][" + edad[p]);

            }
            for (int k = 0; k < 3; k++)
            {
                for (int f = 0; f < 3 - k; f++)
                {
                    if (nombre[f].CompareTo(nombre[f + 1]) > 0)
                    {
                        string aux;
                        aux = nombre[f];
                        nombre[f] = nombre[f + 1];
                        nombre[f + 1] = aux;
                    }
                }
            }
            {
                // NOMBRES ORDENADOS ALFABETICAMENTE

                Console.WriteLine("**Los nombres ordenados en forma alfabéticamente**");
                for (int f = 0; f < nombre.Length; f++)
                {
                    Console.WriteLine(nombre[f]);
                }
            }               
               // NUMEROS ORDENADOS METODO BURBUJA

            Console.WriteLine("**Inicio ordenamiento de numeros metodo burbuja**");
            Show();


            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
            }
            Show();
        }
        public static void Show()
        {
            foreach (var number in numeros)
            {
                Console.Write(number + ",");
            }
            Console.WriteLine("\n");
            Console.ReadKey();

        }
    }
}
