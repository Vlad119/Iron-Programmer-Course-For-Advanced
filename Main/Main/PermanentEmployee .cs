public class PermanentEmployee : Employee
{
    public decimal HourlyRate { get; set; }
    public int WorkHoursPerMonth { get; set; }
    public override decimal Salary => HourlyRate * WorkHoursPerMonth;
}

