using System;

class MathNum {
    public int firstNumber { get; set; }
    public int secondNumber { get; set; }
    public int sumOfNumbers { get; set; }
    public int maxNumber { get; set; }

    public void ClassInfo(int lastfirstnumber, int lastsecondnumber) {
        firstNumber = lastfirstnumber;
        secondNumber = lastsecondnumber;
        sumOfNumbers = lastfirstnumber + lastsecondnumber;
    }

    public void DisplayInfo() {
        Console.WriteLine($"Сумма чисел: {sumOfNumbers}");
        Console.WriteLine($"Максимальное число: {maxNumber}");
    }

    public void UpdateInfo(int lastfirstnumber, int lastsecondnumber) {
        ClassInfo(lastfirstnumber, lastsecondnumber);
    }
}

class Program {
    static void Main() {
        MathNum math = new MathNum();
       
        Console.WriteLine("Введите число 1: ");
        int lastfirstnumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число 2: ");
        int lastsecondnumber = int.Parse(Console.ReadLine());
       
        math.ClassInfo(lastfirstnumber, lastsecondnumber);

        if (math.firstNumber > math.secondNumber)
        {
            math.maxNumber = math.firstNumber;
        }
        else
        {
            math.maxNumber = math.secondNumber;
        }

        math.DisplayInfo();

        Console.WriteLine("Изменение информации:");
        Console.WriteLine("Введите новое число 1: ");
        lastfirstnumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите новое число 2: ");
        lastsecondnumber = int.Parse(Console.ReadLine());
       
        math.UpdateInfo(lastfirstnumber, lastsecondnumber);

        math.DisplayInfo();
    }
}