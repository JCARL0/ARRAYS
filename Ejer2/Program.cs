using System;
class Program
{
    static void Main()
    {
        string[] nombres = new string[100];
        int contador = 0;
        while (contador < 100)
        {
            Console.Write("Introduce un nombre (o escribe 'stop' para finalizar): ");
            string nombre = Console.ReadLine();

            if (nombre.ToLower() == "stop") break;

            nombres[contador++] = nombre;
        }
        Console.WriteLine("\nNombres introducidos:");

        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine(nombres[i]);
        }
    }
}
