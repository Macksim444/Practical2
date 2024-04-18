using System;

class MyClass
{
    public int Number { get; set; }
    public string Name { get; set; }
    
    public MyClass(int number, string name)
    {
        Number = number;
        Name = name;
    }

    public MyClass()
    {
        Number = 0;
        Name = "Default";
    }

    ~MyClass()
    {
        Console.WriteLine($"Объект с именем {Name} и числом {Number} удален.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}, Число: {Number}");
    }
}

class Program
{
    static void Main()
    {
        MyClass firstObject = new MyClass(10, "Object1");
        firstObject.DisplayInfo();
        
        MyClass secondObject = new MyClass();
        secondObject.DisplayInfo();
        
    }
}