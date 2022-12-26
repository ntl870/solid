class AssistantProfessor : Employee
{
    public AssistantProfessor(ICalculateTax taxCalculator)
    {
        this.salaryCalculator = new AssistantProfessorSalary();
        this.taxCalculator = new TaxCalculator();
    }

    public override double getSalaryAfterTax()
    {
        int salary = this.salaryCalculator.calculateSalary();
        return salary - this.taxCalculator.calculateTax(salary);
    }

}