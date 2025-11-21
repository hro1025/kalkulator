namespace kalkulator;

using Spectre.Console;

public class Cli
{
    private readonly Kalkulator calc = new Kalkulator();

    public bool UseInt { get; set; }

    public int FirstNumberInt { get; set; }
    public int SecondNumberInt { get; set; }

    public double FirstNumberDouble { get; set; }
    public double SecondNumberDouble { get; set; }

    public void RunCli()
    {
        while (true)
        {
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Velg formel du vil bruke")
                    .AddChoices(new[] { "+", "-", "*", "/", "Exit" })
            );

            switch (choice)
            {
                case "+":
                    if (UseInt)
                        Console.WriteLine(calc.AddNumbers(FirstNumberInt, SecondNumberInt));
                    else
                        Console.WriteLine(calc.AddNumbers(FirstNumberDouble, SecondNumberDouble));
                    Environment.Exit(0);
                    break;

                case "-":
                    if (UseInt)
                        Console.WriteLine(calc.SubtractNumbers(FirstNumberInt, SecondNumberInt));
                    else
                        Console.WriteLine(
                            calc.SubtractNumbers(FirstNumberDouble, SecondNumberDouble)
                        );
                    Environment.Exit(0);
                    break;

                case "*":
                    if (UseInt)
                        Console.WriteLine(calc.MultiplyNumber(FirstNumberInt, SecondNumberInt));
                    else
                        Console.WriteLine(
                            calc.MultiplyNumber(FirstNumberDouble, SecondNumberDouble)
                        );
                    Environment.Exit(0);
                    break;
                case "/":
                    if (UseInt)
                        Console.WriteLine(calc.DivisionNumber(FirstNumberInt, SecondNumberInt));
                    else
                        Console.WriteLine(
                            calc.DivisionNumber(FirstNumberDouble, SecondNumberDouble)
                        );
                    Environment.Exit(0);
                    break;

                case "Exit":
                    return;
            }
        }
    }
}
