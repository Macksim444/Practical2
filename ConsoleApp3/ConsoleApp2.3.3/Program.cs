using System;

class Calculation
{
    private string calculationLine {get; set;}

    public void SetCalculationLine(string newCalculationLine)
    {
        calculationLine = newCalculationLine;
    }

    public void SetLastSymbolCalculationLine(char lastSymbol)
    {
        calculationLine += lastSymbol;
    }

    public void GetCalculationLine()
    {
        Console.WriteLine(calculationLine);
    }

    public void GetLastSymbol()
    {
        Console.WriteLine(calculationLine[calculationLine.Length - 1]);
    }

    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
        }
    }

    class Program
    {
        public static void Main()
        {
            Calculation calc = new Calculation();
            string calculationLine = Console.ReadLine();
            calc.SetCalculationLine(calculationLine);
            calc.GetCalculationLine();

            char lastSymbol = 'A';
            calc.SetLastSymbolCalculationLine(lastSymbol);
            calc.GetCalculationLine();

            calc.GetLastSymbol();

            calc.DeleteLastSymbol();
            calc.GetCalculationLine();
        }
    }
}