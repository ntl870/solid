class SalaryCalculator : ICalculateSalary
{
    public virtual int calculateSalary(AssistantProfessor assistantProfessor)
    {
        return 0;
    }
    public int calculateSalary(Professor professor)
    {
        return 10000;
    }

    public int calculateSalary(HeadOfDepartment headOfDepartment)
    {
        return 20000;
    }
}