class AssistantProfessor : Employee
{
    public AssistantProfessor(ICalculateSalary salaryCalculator, TaxCalculator taxCalculator) : base(salaryCalculator, taxCalculator)
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