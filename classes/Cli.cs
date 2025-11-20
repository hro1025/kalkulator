namespace kalkulator;

using Microsoft.VisualBasic;
using Spectre.Console;

public class Cli
{
    Kalkulator calc = new Kalkulator();
    int InputFirstNumberInt { get; set; }
    int InputSecondNumberInt { get; set; }

    double InputFirstNumberDouble { get; set; }
    double InputSecondNumberDouble { get; set; }

    public Task RunCli()
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
                    break;
            }
        }
    }
}
