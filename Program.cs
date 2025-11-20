using System.Threading.Tasks.Dataflow;
using kalkulator;
using Spectre.Console;

Kalkulator calc = new Kalkulator();

int inputFirstNumberInt;
double inputFirstNumberDouble;

int inputSecondNumberInt;
double inputSecondNumberDouble;

bool firstIsInt;
bool secondIsInt;

while (true)
{
    Console.Write("Skriv første tall: ");
    string? inputFirstNumber = Console.ReadLine();

    if (int.TryParse(inputFirstNumber, out inputFirstNumberInt))
    {
        inputFirstNumberDouble = inputFirstNumberInt;
        firstIsInt = true;
        break;
    }
    else if (double.TryParse(inputFirstNumber, out inputFirstNumberDouble))
    {
        firstIsInt = false;
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
        inputSecondNumberDouble = inputSecondNumberInt;
        secondIsInt = true;
        break;
    }
    else if (double.TryParse(inputSecondNumber, out inputSecondNumberDouble))
    {
        secondIsInt = false;
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
        if (firstIsInt && secondIsInt)
        {
            Console.WriteLine(calc.AddNumbers(inputFirstNumberInt, inputSecondNumberInt));
        }
        else
        {
            Console.WriteLine(calc.AddNumbers(inputFirstNumberDouble, inputSecondNumberDouble));
        }
        break;
    }
    else if (inputChoose == "2")
    {
        if (firstIsInt && secondIsInt)
        {
            Console.WriteLine(calc.SubtractNumbers(inputFirstNumberInt, inputSecondNumberInt));
        }
        else
        {
            Console.WriteLine(
                calc.SubtractNumbers(inputFirstNumberDouble, inputSecondNumberDouble)
            );
        }
        break;
    }
    else if (inputChoose == "3")
    {
        if (firstIsInt && secondIsInt)
        {
            Console.WriteLine(calc.MultiplyNumber(inputFirstNumberInt, inputSecondNumberInt));
        }
        else
        {
            Console.WriteLine(calc.MultiplyNumber(inputFirstNumberDouble, inputSecondNumberDouble));
        }
        break;
    }
    else
    {
        Console.WriteLine("velg 1, 2 eller 3");
    }
}
