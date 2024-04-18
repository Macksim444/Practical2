using System;

class MathNum {
    public int number { get; set; }
    public int newNumber { get; set; }

    public void ClassInfo(int number, int newNumber) {
        this.number = newNumber;
    }

    public void DisplayInfo() {
        Console.WriteLine($"Number for this moment: {number}");
    }

    public void UpdateInfo()
    {
        Console.WriteLine($"New number: {number}");
    }
}

class Program {
    static void Main()
    {
        MathNum mathNum = new MathNum();
        mathNum.number = 1;

        while (true)
        {
            int k = int.Parse(Console.ReadLine());
            if (k == 9)
            {
                break;
            }
            switch (k)
            {
                case 0:
                    mathNum.number++;
                    break;
                case 1:
                    mathNum.number--;
                    break;
                case 2:
                    mathNum.DisplayInfo();
                    break;
                case 3:
                    Console.WriteLine("Add new number: ");
                    mathNum.newNumber = int.Parse(Console.ReadLine());
                    mathNum.number = mathNum.newNumber;
                    mathNum.UpdateInfo();
                    break;
                default:
                    Console.WriteLine("Not a valid command");
                    break;
            }
        }
    }
}