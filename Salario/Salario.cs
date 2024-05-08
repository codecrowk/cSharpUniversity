using Salario.Models;

namespace Salario
{
  public class Salario : ISalario
  {
    public int MinimunWage {get; set;}

    public float CalculateSalaryReduction (int currentSalary)
    {
      float salaryReduction;
      if (currentSalary <= (MinimunWage * 4))
      {
        salaryReduction = (MinimunWage * 8) / 100;
      }
      else 
      {
        salaryReduction = (MinimunWage * 9) / 100;
      }

      return salaryReduction;
    }
  }
}