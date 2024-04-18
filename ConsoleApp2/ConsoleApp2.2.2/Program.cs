using System;

class Trains {
    public string PlaceName { get; set; }
    public int Train { get; set; }
    public DateTime TimeOfStart { get; set; }

    public void DisplayTrainInfo() {
        Console.WriteLine($"Train {Train} to {PlaceName} starts at {TimeOfStart}");
    }
}

class Program {
    static void Main() {
        Trains train = new Trains {
            Train = int.Parse(Console.ReadLine())
        };

        switch (train.Train)
        {
            case 1:
                train.TimeOfStart = new DateTime(2024, 11, 13, 9, 3, 0);
                train.PlaceName = "Taganrog";
                break;
            case 2:
                train.TimeOfStart = new DateTime(2024, 9, 18, 6, 2, 2);
                train.PlaceName = "Karaganda";
                break;
            case 3:
                train.TimeOfStart = new DateTime(2024, 12, 11, 3, 2, 0);
                train.PlaceName = "Tomsk";
                break;
            case 4:
                train.TimeOfStart = new DateTime(2024, 5, 2, 15, 3, 0);
                train.PlaceName = "Dubai";
                break;
            default:
                Console.WriteLine("Invalid train number input");
                return;
        }

        train.DisplayTrainInfo();
    }
}