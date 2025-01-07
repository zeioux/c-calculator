using System;

class Program
{
    static void Main()
    {
        double num1, num2, result;
        char operation;

        Console.WriteLine("Bienvenue dans la calculatrice simple en C#!");
        Console.WriteLine("Les opérations disponibles sont :");
        Console.WriteLine("  + pour l'addition");
        Console.WriteLine("  - pour la soustraction");
        Console.WriteLine("  * pour la multiplication");
        Console.WriteLine("  / pour la division");

        Console.Write("Entrez l'opération (par exemple : +, -, *, /) : ");
        operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Entrez le premier nombre : ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Entrez le deuxième nombre : ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Résultat : {result:F2}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Résultat : {result:F2}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Résultat : {result:F2}");
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Résultat : {result:F2}");
                }
                else
                {
                    Console.WriteLine("Erreur : Division par zéro impossible.");
                }
                break;
            default:
                Console.WriteLine("Opération invalide.");
                break;
        }
    }
}
