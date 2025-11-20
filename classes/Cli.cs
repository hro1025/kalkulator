namespace kalkulator;

using Microsoft.VisualBasic;
using Spectre.Console;

public class Cli
{
    Kalkulator calc = new Kalkulator();
    public int InputFirstNumberInt { get; set; }
    public int InputSecondNumberInt { get; set; }

    public double InputFirstNumberDouble { get; set; }
    public double InputSecondNumberDouble { get; set; }
    public bool FirstIsInt { get; set; }
    public bool SecondIsInt { get; set; }

    public async Task RunCli()
    {
        while (true)
        {
            var choise = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Velg fin formel som du vil bruke")
                    .AddChoices(new[] { "+", "-", "*", "Exit" })
            );

            switch (choise)
            {
                case "+":
                    if (FirstIsInt && SecondIsInt)
                    {
                        Console.WriteLine(
                            calc.AddNumbers(InputFirstNumberInt, InputSecondNumberInt)
                        );
                    }
                    else
                    {
                        Console.WriteLine(
                            calc.AddNumbers(InputFirstNumberDouble, InputSecondNumberDouble)
                        );
                    }
                    break;
                case "-":
                    if (FirstIsInt && SecondIsInt)
                    {
                        Console.WriteLine(
                            calc.SubtractNumbers(InputFirstNumberInt, InputSecondNumberInt)
                        );
                    }
                    else
                    {
                        Console.WriteLine(
                            calc.SubtractNumbers(InputFirstNumberDouble, InputSecondNumberDouble)
                        );
                    }
                    break;
                case "*":
                    if (FirstIsInt && SecondIsInt)
                    {
                        Console.WriteLine(
                            calc.MultiplyNumber(InputFirstNumberInt, InputSecondNumberInt)
                        );
                    }
                    else
                    {
                        Console.WriteLine(
                            calc.MultiplyNumber(InputFirstNumberDouble, InputSecondNumberDouble)
                        );
                    }
                    break;
                case "Exit":
                    return;
            }
        }
    }
}
