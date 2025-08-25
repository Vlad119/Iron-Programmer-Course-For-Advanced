using System.Collections.Generic;

public class EmployeeOnProjects : Employee
{
    public List<Project> CompletedProjects { get; set; } = new List<Project>();
    public override decimal Salary
    {
        get
        {
            decimal result = 0;
            foreach (var project in CompletedProjects)
            {
                result += project.SalaryForEmployee; 
            }
            return result;
        }
    }
}
