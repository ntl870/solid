class Professor : Employee
{
    public Professor(ICalculateTax taxCalculator) : base(new ProfessorSalary(), new TaxCalculator()) { }


    public override double getSalaryAfterTax()
    {
        int salary = this.salaryCalculator.calculateSalary();
        return salary - this.taxCalculator.calculateTax(salary);
    }
}