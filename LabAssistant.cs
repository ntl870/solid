class LabAssistant : Employee
{
    public LabAssistant(ICalculateSalary salaryCalculator, ICalculateTax taxCalculator) : base(salaryCalculator, taxCalculator)
    {
        this.salaryCalculator = new SalaryCalculator();
        this.taxCalculator = new TaxCalculator();
    }

    public override double getSalaryAfterTax()
    {
        return 3500;
    }
}