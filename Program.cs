using System.Threading.Tasks.Dataflow;
using Spectre.Console;

namespace kalkulator;

class Program
{
    static void Main(string[] args)
    {
        Kalkulator calc = new Kalkulator();

        int inputFirstNumberInt;
        double inputFirstNumberDouble;

        int inputSecondNumberInt;
        double inputSecondNumberDouble;

        while (true)
        {
            Console.Write("Skriv første tall: ");
            string? inputFirstNumber = Console.ReadLine();

            if (int.TryParse(inputFirstNumber, out inputFirstNumberInt))
            {
                break;
            }
            if (double.TryParse(inputFirstNumber, out inputFirstNumberDouble))
            {
                break;
            }
            else
            {
                Console.WriteLine("Bare tall, prøv igjen.");
            }
        }

        while (true)
        {
            Console.Write("Skriv andre tall: ");
            string? inputSecondNumber = Console.ReadLine();

            if (int.TryParse(inputSecondNumber, out inputSecondNumberInt))
            {
                break;
            }
            if (double.TryParse(inputSecondNumber, out inputSecondNumberDouble))
            {
                break;
            }
            else
            {
                Console.WriteLine("Bare tall, prøv igjen.");
            }
        }

        Console.WriteLine("Hva slags formel vil du bruke?\n1:  +\n2:  -\n3:  *");

        while (true)
        {
            string? input3 = Console.ReadLine();
            if (input3 == "1")
            {
                Console.WriteLine("1");
                break;
            }
            else if (input3 == "2")
            {
                Console.WriteLine("2");
                break;
            }
            else if (input3 == "3")
            {
                Console.WriteLine("3");
                break;
            }
            else
            {
                Console.WriteLine("velg 1, 2 eller 3");
            }
        }

        // Console.WriteLine(calc.AddNumbers(input1, input2));
    }
}
