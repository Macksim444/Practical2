using System;

class Worker
{
    private string name;
    private string surname;
    private double rate;
    private int days;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetSurname(string surname)
    {
        this.surname = surname;
    }

    public string GetSurname()
    {
        return surname;
    }

    public void SetRate(double rate)
    {
        this.rate = rate;
    }

    public double GetRate()
    {
        return rate;
    }

    public void SetDays(int days)
    {
        this.days = days;
    }

    public int GetDays()
    {
        return days;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Имя: " + GetName());
        Console.WriteLine("Фамилия: " + GetSurname());
        Console.WriteLine("Ставка: " + GetRate());
        Console.WriteLine("Отработанные дни: " + GetDays());
    }

    public void GetSalary()
    {
        double salary = rate * days;
        Console.WriteLine("Зарплата: " + salary);
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
}