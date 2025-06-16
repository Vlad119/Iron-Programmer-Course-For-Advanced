using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    class Program
    {
        static void Main()
        {
            Functions func = new Functions();
            List<Student> students = new List<Student>();
            func.Introduction();
            while (true)
            {
                func.Menu();
                func.PrintStudents(students);
                func.MenuChoosing();
                if (func.choose == "1")
                {
                    func.AddStudent(students);
                }
                if (func.choose == "2")
                {
                    func.DelStudent(students);
                }
                if (func.choose == "3")
                {
                    func.Exit();
                }
                Console.Clear();
            }
        }
    }
}