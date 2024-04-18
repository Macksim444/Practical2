using System;

class Worker
{
    public string name { get; set; }
    public string surname { get; set; }
    public int rate { get; set; }
    public int days { get; set; }

    public void GetSalary()
    {
        int salary = rate * days;
        Console.WriteLine($"Зарплата работника: {salary} руб.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Фамилия: {surname}");
        Console.WriteLine($"Ставка в день: {rate}");
        Console.WriteLine($"Количество рабочих дней: {days}");
    }
}

class Program
{
    static void Main()
    {
        Worker worker = new Worker();
        
        while (true)
        {
            Console.WriteLine("Введите номер сотрудника (1-5) или введите '6' для выхода из программы: ");
            int k = int.Parse(Console.ReadLine());
            if (k == 6)
            {
                Console.WriteLine("Хорошего дня");
                break;
            }
            
            switch (k)
            {
                case 1:
                    worker.name = "Максим";
                    worker.surname = "Бичевин";
                    worker.rate = 100;
                    worker.days = 20;
                    worker.DisplayInfo();
                    worker.GetSalary();
                    break;
                case 2:
                    worker.name = "Денис";
                    worker.surname = "Бичевин";
                    worker.rate = 345;
                    worker.days = 12;
                    worker.DisplayInfo();
                    worker.GetSalary();
                    break;
                case 3:
                    worker.name = "Максим";
                    worker.surname = "Отец";
                    worker.rate = 112;
                    worker.days = 222;
                    worker.DisplayInfo();
                    worker.GetSalary();
                    break;
                case 4:
                    worker.name = "Наталья";
                    worker.surname = "Куертова";
                    worker.rate = 199999;
                    worker.days = 3;
                    worker.DisplayInfo();
                    worker.GetSalary();
                    break;
                case 5:
                    worker.name = "Татьяна";
                    worker.surname = "Прожилова";
                    worker.rate = 1700;
                    worker.days = 28;
                    worker.DisplayInfo();
                    worker.GetSalary();
                    break;
                default:
                    Console.WriteLine("Неверный номер сотрудника.");
                    break;
            }
        }
    }
}