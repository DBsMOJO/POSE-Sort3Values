/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 12.11.2023
 *--------------------------------------------------------------
 * Description:
 * Sort 3 Values
 *--------------------------------------------------------------
*/

using System;

namespace Sort3Values
{
    public class Program
    {
        public static void Main()
        {
            int x1,
                x2,
                x3;

            // Input
            Console.Write("Geben Sie die erste zu Sortierende Zahl ein: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben Sie die zweite zu Sortierende Zahl ein: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben Sie die dritte zu Sortierende Zahl ein: ");
            x3 = Convert.ToInt32(Console.ReadLine());

            // Process
            if (x2 > x1)
            {
                x1 += x2;
                x2 = x1 - x2;
                x1 -= x2;
            }
            if (x3 > x1)
            {
                x1 += x3;
                x3 = x1 - x3;
                x1 -= x3;
            }
            if (x3 > x2)
            {
                x2 += x3;
                x3 = x2 - x3;
                x2 -= x3;
            }

            // Output
            Console.WriteLine(
                $"Die Zahlen absteigend sortiert, ergibt sich folgende Reihenfolge: {x1}, {x2}, {x3}"
            );
        }
    }
}
