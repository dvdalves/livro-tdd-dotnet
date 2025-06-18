namespace Chapter_4;

public class Employee(string name, double salary, Position jobRole)
{
    public string Name { get; private set; } = name;
    public double Salary { get; private set; } = salary;
    public Position Role { get; private set; } = jobRole;
}

public enum Position
{
    SoftwareEngineer,
    DBA,
    QualityAnalyst
}
