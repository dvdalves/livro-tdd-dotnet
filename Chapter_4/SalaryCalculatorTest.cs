using NUnit.Framework;

namespace Chapter_4
{
    [TestFixture]
    public class SalaryCalculatorTest
    {
        [Test]
        public void ShouldCalculateSalaryForDevelopersWithSalaryBelowThreshold()
        {
            SalaryCalculator calculator = new();
            Employee developer = new("David", 1500.0, Position.SoftwareEngineer);

            double salary = SalaryCalculator.CalculateSalary(developer);
            Assert.That(salary, Is.EqualTo(1500.0 * 0.9).Within(0.00001));
        }

        [Test]
        public void ShouldCalculateSalaryForDevelopersWithSalaryAboveThreshold()
        {
            SalaryCalculator calculator = new();
            Employee developer = new("David", 4000.0, Position.SoftwareEngineer);

            double salary = SalaryCalculator.CalculateSalary(developer);
            Assert.That(salary, Is.EqualTo(4000.0 * 0.8).Within(0.00001));
        }
    }
}
