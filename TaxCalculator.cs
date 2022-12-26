class TaxCalculator : ICalculateTax
{
    public double calculateTax(int salary)
    {
        if (salary > 5000) return 0.15 * salary;

        return salary * 0.1;
    }
}