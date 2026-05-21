using System;

class Program
{
    static double LeerDoblePositivo()
    {
        double valor;

        while (true)
        {
            Console.Write("Ingresar un numero decimal positivo: ");

            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out valor) && valor > 0)
            {
                return valor;
            }

            Console.WriteLine("Error: debes ingresar un numero positivo valido.");
        }
    }

    static void Main()
    {
        double numero = LeerDoblePositivo();

        Console.WriteLine("Numero ingresado: " + numero);
    }
}