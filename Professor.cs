class Professor : Employee
{
    public Professor(ICalculateSalary salaryCalculator, ICalculateTax taxCalculator) : base(salaryCalculator, taxCalculator)
    {
        this.salaryCalculator = new SalaryCalculator();
        this.taxCalculator = new TaxCalculator();
    }

    public override double getSalaryAfterTax()
    {
        int salary = this.salaryCalculator.calculateSalary(this);
        return salary - this.taxCalculator.calculateTax(salary);
    }
}