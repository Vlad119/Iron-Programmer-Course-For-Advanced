using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        Employee permanentEmployee = new PermanentEmployee()
        {
            HourlyRate = 500,
            WorkHoursPerMonth = 180,
        };
        Console.WriteLine($"Зарплата постоянного сотрудника : {permanentEmployee.Salary} руб.");

        Employee employeeOnProjects = new EmployeeOnProjects()
        {
            CompletedProjects = new List<Project>()
        {
            new Project() { SalaryForEmployee = 10000 },
            new Project() { SalaryForEmployee = 5000 },
            new Project() { SalaryForEmployee = 20000 }
        }
        };
        Console.WriteLine($"Зарплата проектного сотрудника : {employeeOnProjects.Salary} руб.");
    }
}
