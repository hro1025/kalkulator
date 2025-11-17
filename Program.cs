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

        bool useInt;

        while (true)
        {
            Console.Write("Skriv første tall: ");
            string? inputFirstNumber = Console.ReadLine();

            if (int.TryParse(inputFirstNumber, out inputFirstNumberInt))
            {
                useInt = true;
                break;
            }
            else if (double.TryParse(inputFirstNumber, out inputFirstNumberDouble))
            {
                useInt = false;
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
                useInt = true;
                break;
            }
            else if (double.TryParse(inputSecondNumber, out inputSecondNumberDouble))
            {
                useInt = false;
                break;
            }
            else
            {
                Console.WriteLine("Bare tall, prøv igjen.");
            }
        }

        Console.WriteLine("Hva slags formel vil du bruke?\n1:  +\n2:  -\n3:  *");
        Console.WriteLine();

        while (true)
        {
            Console.Write("------->  ");
            string? inputChoose = Console.ReadLine();
            if (inputChoose == "1")
            {
                if (useInt)
                {
                    Console.WriteLine(calc.AddNumbers(inputFirstNumberInt, inputSecondNumberInt));
                }
                else
                {
                    Console.WriteLine(
                        calc.AddNumbers(inputFirstNumberDouble, inputSecondNumberDouble)
                    );
                }
                break;
            }
            else if (inputChoose == "2")
            {
                Console.WriteLine("2");
                break;
            }
            else if (inputChoose == "3")
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
