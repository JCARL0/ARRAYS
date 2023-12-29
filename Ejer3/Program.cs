using System;
class Program
{
    static void Main()
    {
        int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Console.Write("Introduce el numero de mes (1=enero, 12=diciembre): ");
        int numeroMes;

        if (int.TryParse(Console.ReadLine(), out numeroMes) && numeroMes >= 1 && numeroMes <= 12)
        {
            int dias = diasPorMes[numeroMes - 1];
            Console.WriteLine($"El mes {numeroMes} tiene {dias} dias");
        }
        else
        {
            Console.WriteLine("Numero de mes invalido");
        }
    }
}
