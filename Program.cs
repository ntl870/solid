class Program
{
    static void Main(string[] args)
    {
        TaxCalculator taxCalculator = new TaxCalculator();
        SalaryCalculator salaryCalculator = new SalaryCalculator();

        AssistantProfessor assistantProfessor = new AssistantProfessor(salaryCalculator, taxCalculator);
        Console.WriteLine(assistantProfessor.getSalaryAfterTax());

        Professor professor = new Professor(salaryCalculator, taxCalculator);
        Console.WriteLine(professor.getSalaryAfterTax());

        HeadOfDepartment headOfDepartment = new HeadOfDepartment(salaryCalculator, taxCalculator);
        Console.WriteLine(headOfDepartment.getSalaryAfterTax());

        LabAssistant labAssistant = new LabAssistant(salaryCalculator, taxCalculator);
        Console.WriteLine(labAssistant.getSalaryAfterTax());

    }
}
