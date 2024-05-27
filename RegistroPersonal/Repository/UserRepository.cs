using RegistroPersonal.Data;
using RegistroPersonal.Models;
using RegistroPersonal.Repository.IRepository;
using RegistroPersonal.Validation.Users.Components;

namespace RegistroPersonal.Repository
{
  class UserRepository: IUserRepository
  {
    /* DataBase Injection error:
      * Making to many intances of BaseContext inside validation, that is the error: many instances
    */
    private BaseContext _data = new BaseContext();
    public User YoungerSystemWoman ()
    {
      return new YoungerSystemWomanValidation().Validate();
    }

    public User OlderSystemMan()
    {
      return new OlderSystemManValidation().Validate(); 
    }

    // We are going to send all designer woman, 
    // counter implementation should be implemented in views
    public int LegalDesignerWoman()
    {
      return new LegalDesignerWomanValidation().Validate();
    }

    public double MarriedProgrammerAvarage()
    {
      return new MarriedProgrammerAvarageValidation().Validate();
    }

    public double ChildrenSupportPercentage()
    {
      return new ChildrenSupportPercentageValidation().Validate();
    }
  }
}