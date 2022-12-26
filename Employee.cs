abstract class Employee
{
    public ICalculateSalary salaryCalculator;
    public ICalculateTax taxCalculator;

    public Employee(ICalculateSalary salaryCalculator, ICalculateTax taxCalculator)
    {
        this.salaryCalculator = new SalaryCalculator();
        this.taxCalculator = new TaxCalculator();
    }

    public abstract double getSalaryAfterTax();

}