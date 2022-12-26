abstract class Employee
{
    public ICalculateSalary salaryCalculator;
    public ICalculateTax taxCalculator;

    public Employee(ICalculateSalary salaryCalculator, ICalculateTax taxCalculator)
    {
        this.salaryCalculator = salaryCalculator;
        this.taxCalculator = taxCalculator;
    }
    public abstract double getSalaryAfterTax();

}