using System;
class Program
{
    static void Main()
    {
        int cantidadNumeros = 10;
        int numerosPares = 0;
        Console.WriteLine($"Introduce {cantidadNumeros} numeros:");
        for (int i = 0; i < cantidadNumeros; i++)
        {
            Console.Write($"Numero {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                numerosPares++;
            }
        }
        Console.WriteLine($"La cantidad de numeros pares son: {numerosPares}");
    }
}
