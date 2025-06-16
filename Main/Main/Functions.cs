using System.Collections.Generic;
using System;

public class Functions
{
    public string schoolName;
    public string choose;
    public void Introduction()
    {
        Console.Write("Здравствуйте! Введите название вашей школы: ");
        schoolName = Console.ReadLine();
        School school = new School(schoolName);
        Console.Clear();
    }
    public void Menu()
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine($"Система управлением школой {schoolName}");
        Console.WriteLine();
        Console.WriteLine("Меню:");
        Console.WriteLine("1 - Добавить ученика в список");
        Console.WriteLine("2 - Удалить ученика из списка");
        Console.WriteLine("3 - Выход");
        Console.WriteLine();
        Console.WriteLine("Введите 1, 2 или 3:");
    }
    public void MenuChoosing()
    {
        Console.SetCursorPosition(20, 7);
        choose = Console.ReadLine();
    }
    public void Exit()
    {
        Console.WriteLine("Уверены? (да/нет): ");
        Console.SetCursorPosition(19, 8);
        string confirm = Console.ReadLine();
        confirm = confirm.ToLower();
        if (confirm == "да")
        {
            Console.Clear();
            Environment.Exit(0);
        }
    }
    public void AddStudent(List<Student> _students)
    {
        string[] Names = { "Иосиф", "Иван", "Пётр", "Сергей", "Андрей", "Николай", "Константин" };
        string[] Surnames = { "Дзеранов", "Лютый", "Пьяный", "Рукосуев", "Сухозад", "Сосиска", "Вырвихвост" };
        Random rnd = new Random();
        int rndName = rnd.Next(7);
        int rndSurname = rnd.Next(7);
        int age = rnd.Next(16, 25);
        Student student = new Student(Names[rndName], Surnames[rndSurname], age);
        _students.Add(student);
    }
    public void DelStudent(List<Student> _students)
    {
        if (_students.Count == 0)
        {
            Console.Write("Школа и так пуста! Задумайтесь о своей жизни и нажмите любую клавишу...");
            Console.ReadLine();
        }
        else
        {
            Console.Write("Введите №, который нужно удалить: ");
            string ts = Console.ReadLine();
            int ti;
            if (ts.Length == 1 && char.IsDigit(ts[0]))
            {
                ti = Convert.ToInt32(ts);
                if (ti < _students.Count)
                {
                    _students.Remove(_students[ti]);
                }
            }
            else
            {
                Console.Write("У Вас тремор, попробуйте нажать ладонью на Enter...");
                Console.ReadLine();
            }
        }
    }
    public void PrintStudents(List<Student> _students)
    {
        Console.WriteLine();
        Console.SetCursorPosition(0, 10);
        Console.WriteLine("{0, -3} | {1, -10} | {2, -10} | {3, -7}", "№", "Имя", "Фамилия", "Возраст");
        for (int i = 0; i < _students.Count; i++)
        {
            Console.WriteLine("{0, -3} | {1, -10} | {2, -10} | {3, -7}", "---", "----------", "----------", "-------");
            Console.WriteLine("{0, -3} | {1, -10} | {2, -10} | {3, -7}", i, _students[i].firstName, _students[i].lastName, _students[i].age);
        }
    }
}