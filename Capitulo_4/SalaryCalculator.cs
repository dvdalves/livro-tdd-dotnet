namespace Chapter_4;

public class SalaryCalculator
{
    public static double CalculateSalary(Employee employee)
    {
        return employee.Salary > 3000 ? 3200.0 : 1350.0;
    }
}