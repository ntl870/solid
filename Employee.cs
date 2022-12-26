abstract class Employee
{
    public ICalculateSalary? salaryCalculator;
    public ICalculateTax? taxCalculator;

    public abstract double getSalaryAfterTax();

}