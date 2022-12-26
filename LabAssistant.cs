class LabAssistant : Employee
{
    public LabAssistant(ICalculateTax taxCalculator) : base(new LabAssistantSalary(), new TaxCalculator())
    { }

    public override double getSalaryAfterTax()
    {
        return this.salaryCalculator.calculateSalary();
    }
}