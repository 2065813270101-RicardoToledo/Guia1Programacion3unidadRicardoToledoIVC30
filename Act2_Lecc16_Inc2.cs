using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int[] numeros = new int[8];

        Console.WriteLine("--- BUSCADOR DEL NÚMERO MAYOR ---");

        
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Ingrese el entero " + (i + 1) + ": ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        int numeroMayor = numeros[0];
        int posicionMayor = 0;

        
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > numeroMayor)
            {
                numeroMayor = numeros[i]; 
                posicionMayor = i;        
            }
        }

       
        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine("El número mayor del arreglo es: " + numeroMayor);

         
        Console.WriteLine("Se encuentra en el índice: " + posicionMayor);
        Console.WriteLine("(Es decir, fue el número " + (posicionMayor + 1) + " que ingresaste)");
    }
}
