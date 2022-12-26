class HeadOfDepartment : Employee
{
    public HeadOfDepartment(ICalculateTax taxCalculator) : base(new HeadOfDepartmentSalary(), new TaxCalculator())
    { }

    public override double getSalaryAfterTax()
    {
        int salary = this.salaryCalculator.calculateSalary();
        return salary - this.taxCalculator.calculateTax(salary);
    }
}