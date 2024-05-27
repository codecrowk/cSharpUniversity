using RegistroPersonal.Models;

namespace RegistroPersonal.Repository.IRepository
{
  interface IUserRepository
  {
    public User YoungerSystemWoman(); 
    public User OlderSystemMan();
    public double MarriedProgrammerAvarage();
    public double ChildrenSupportPercentage();
    public int LegalDesignerWoman();
  }
}