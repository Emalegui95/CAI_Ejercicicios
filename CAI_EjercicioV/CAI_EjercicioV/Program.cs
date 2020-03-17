using System;


namespace CAI_EjercicioV
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, residuo, numero_inv;

            Console.WriteLine("Ingrese un número de 5 cifras: ");
            numero = int.Parse(Console.ReadLine());

            residuo = numero % 10;
            numero = numero / 10;
            numero_inv = residuo * 10;

            residuo = numero % 10;
            numero = numero / 10;
            numero_inv = (numero_inv + residuo) * 10;

            residuo = numero % 10;
            numero = numero / 10;
            numero_inv = (numero_inv + residuo) * 10;

            residuo = numero % 10;
            numero = numero / 10;
            numero_inv = (numero_inv + residuo) * 10;

            numero_inv = numero_inv + numero;

            Console.WriteLine("Su número invertido es: " + numero_inv);

            Console.ReadKey();
        }
    }
}
