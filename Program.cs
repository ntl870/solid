class Program
{
    static void Main(string[] args)
    {
        ICalculateTax taxCalculator = new TaxCalculator();

        AssistantProfessor assistantProfessor = new AssistantProfessor(taxCalculator);
        Console.WriteLine(assistantProfessor.getSalaryAfterTax());

        Professor professor = new Professor(taxCalculator);
        Console.WriteLine(professor.getSalaryAfterTax());

        HeadOfDepartment headOfDepartment = new HeadOfDepartment(taxCalculator);
        Console.WriteLine(headOfDepartment.getSalaryAfterTax());

        LabAssistant labAssistant = new LabAssistant(taxCalculator);
        Console.WriteLine(labAssistant.getSalaryAfterTax());

    }
}
