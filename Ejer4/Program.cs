using System;
class Program
{
    static void Main()
    {
        decimal[] valores = new decimal[7];
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Numero del valor {i + 1}: ");
            valores[i] = Convert.ToDecimal(Console.ReadLine());
        }
        Array.Sort(valores);
        Array.Reverse(valores);
        Console.WriteLine("\nValores ordenados de mayor a menor:");
        foreach (decimal valor in valores)
        {
            Console.WriteLine(valor);
        }
    }
}
