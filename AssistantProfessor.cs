class AssistantProfessor : Employee
{
    public AssistantProfessor(ICalculateTax taxCalculator) : base(new AssistantProfessorSalary(), new TaxCalculator())
    { }

    public override double getSalaryAfterTax()
    {
        int salary = this.salaryCalculator.calculateSalary();
        return salary - this.taxCalculator.calculateTax(salary);
    }

}