class HeadOfDepartment : Employee
{
    public HeadOfDepartment(ICalculateSalary salaryCalculator, TaxCalculator taxCalculator)
    {
        this.salaryCalculator = new SalaryCalculator();
        this.taxCalculator = new TaxCalculator();
    }

    public override double getSalaryAfterTax()
    {
        int salary = this.salaryCalculator.calculateSalary();
        return salary - this.taxCalculator.calculateTax(salary);
    }
}