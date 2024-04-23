using System;

namespace csharp_calcolatrice
{
    
    class Program
    {
        static void Main()
        {
            // Test dei metodi della classe CalcoliHelper

            // Somma
            Console.WriteLine($"Somma (int): { CalcoliHelper.Somma(5, 3)}"); // Output: 8
            Console.WriteLine($"Somma (double): {CalcoliHelper.Somma(5.5,3.2)}"); // Output: 8.7

            // Differenza
            Console.WriteLine("Differenza (int): " + CalcoliHelper.Differenza(10, 3)); // Output: 7
            Console.WriteLine("Differenza (double): " + CalcoliHelper.Differenza(10.5, 3.2)); // Output: 7.3

            // Moltiplicazione
            Console.WriteLine("Moltiplicazione (int): " + CalcoliHelper.Moltiplicazione(5, 3)); // Output: 15
            Console.WriteLine("Moltiplicazione (double): " + CalcoliHelper.Moltiplicazione(5.5, 3.2)); // Output: 17.6

            // Valore assoluto
            Console.WriteLine("Valore assoluto (int): " + CalcoliHelper.ValoreAssoluto(-10)); // Output: 10
            Console.WriteLine("Valore assoluto (double): " + CalcoliHelper.ValoreAssoluto(-5.5)); // Output: 5.5

            // Minimo
            Console.WriteLine("Minimo (int): " + CalcoliHelper.Minimo(5, 3)); // Output: 3
            Console.WriteLine("Minimo (double): " + CalcoliHelper.Minimo(5.5, 3.2)); // Output: 3.2

            // Massimo
            Console.WriteLine("Massimo (int): " + CalcoliHelper.Massimo(5, 3)); // Output: 5
            Console.WriteLine("Massimo (double): " + CalcoliHelper.Massimo(5.5, 3.2)); // Output: 5.5

            // Potenza
            Console.WriteLine("Potenza: " + CalcoliHelper.Potenza(2, 3)); // Output: 8
        }
    }
}
