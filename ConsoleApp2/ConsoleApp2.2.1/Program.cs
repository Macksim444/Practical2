using System;

class Student {
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string GroupNumber { get; set; }
    public int[] Grades { get; set; }

    public void UpdateInfo(string lastName, DateTime dateOfBirth, string groupNumber) {
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        GroupNumber = groupNumber;
    }

    public void DisplayInfo() {
        Console.WriteLine($"Фамилия: {LastName}");
        Console.WriteLine($"Дата рождения: {DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Номер группы: {GroupNumber}");
    }
}

class Program {
    static void Main() {
        Student student = new Student();
        
        Console.Write("Введите фамилию студента: ");
        student.LastName = Console.ReadLine();
        
        Console.Write("Введите дату рождения студента (гггг-мм-дд): ");
        student.DateOfBirth = DateTime.Parse(Console.ReadLine());
        
        Console.Write("Введите номер группы студента: ");
        student.GroupNumber = Console.ReadLine();

        student.DisplayInfo();

        Console.WriteLine("Изменение информации:");
        Console.Write("Введите новую фамилию студента: ");
        string newLastName = Console.ReadLine();
        
        Console.Write("Введите новую дату рождения студента (гггг-мм-дд): ");
        DateTime newDateOfBirth = DateTime.Parse(Console.ReadLine());
        
        Console.Write("Введите новый номер группы студента: ");
        string newGroupNumber = Console.ReadLine();

        student.UpdateInfo(newLastName, newDateOfBirth, newGroupNumber);

        student.DisplayInfo();
    }
}