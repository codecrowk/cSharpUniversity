namespace Salario.Models
{
  public interface ISalario
  {
    int MinimunWage {get; set;} //Salario minimo
    float CalculateSalaryReduction(int currentSalary);
    float CalulateTransportAllowance(); // Auxilio transporte
  }
}