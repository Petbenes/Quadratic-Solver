using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        // vytváření koeficientu
        double A, B, C;

        // vytváření zápisu vzorové rovnice
        Console.WriteLine("Zapište koeficienty kvadratické rovnice (pro vzorec Axˇ2 + Bx + C = 0):");

        // vytváření zápisu hodnot koeficientu A
        Console.Write("Zadejte A: ");
        if (!double.TryParse(Console.ReadLine(), out A) || A == 0)
        {
            Console.WriteLine("A nelze takto zadat.");
            return;
        }

        // vytváření zápisu hodnot koeficientu B
        Console.Write("Zadejte B: ");
        if (!double.TryParse(Console.ReadLine(), out B))
        {
            Console.WriteLine("B nelze takto zadat.");
            return;
        }

        // vytváření zápisu hodnot koeficientu C
        Console.Write("Zadejte C: ");
        if (!double.TryParse(Console.ReadLine(), out C))
        {
            Console.WriteLine("C takto nelze zadat.");
            return;
        }

        // vytváření a výpočet diskriminantu
        double Diskriminant = B * B - 4 * A * C;

        // výpočet rovnice, která má dvě řešení
        if (Diskriminant > 0)
        {
            double Reseni1 = (-B + Math.Sqrt(Diskriminant)) / (2 * A); // Math.Sqrt = Square rooot / druhá odmocnina
            double Reseni2 = (-B - Math.Sqrt(Diskriminant)) / (2 * A);
            Console.WriteLine($"Rovnice má dvě řešení => {Reseni1} a {Reseni2}");
        }

        // výpočet rovnice, která má jedno řešení
        else if (Diskriminant == 0) 
        {
            double Reseni1 = (-B) / (2 * A);
            Console.WriteLine($"Rovnice má pouze jedno řešení => {Reseni1}");
        }

        // výpočet rovnice, která nemá řešení v R
        else
        {
            Console.WriteLine("Zařízení nenalezlo řešení v R.");
        }
    }
}