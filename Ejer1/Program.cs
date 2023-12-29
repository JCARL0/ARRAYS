using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[6];
        for (int i = 0; i < 6; i++)
        {
            Console.Write("Introduce el numero {0}: ", i + 1);
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\nNumeros en orden inverso:");
        for (int i = 5; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
        Console.ReadLine();
    }
}
