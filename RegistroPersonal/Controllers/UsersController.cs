using RegistroPersonal.Data;
using RegistroPersonal.Repository;
using RegistroPersonal.Views;

namespace RegistroPersonal.Controllers
{
  class UserController
  {
    private readonly BaseContext _dataBase = new BaseContext();
    private readonly UserRepository userRepository = new UserRepository();
    private PrintUserInfo printUserInfo = new PrintUserInfo();
    
    public void Init ()
    {
      // Print all users
      printUserInfo.PrintAllUsers(_dataBase.Users.Data);

      // Print requiriments information
      Console.WriteLine();
      VyougerSystemWoman();

      Console.WriteLine();
      VolderSystemMan();

      Console.WriteLine();
      VlegalDesignerWoman();

      Console.WriteLine();
      VchildrenSupportPercentage();

      Console.WriteLine();
      VmarriedProgrammerAvarage();
    }

    private void VyougerSystemWoman()
    {
      Console.WriteLine($"Younger system woman is ");
      printUserInfo.PrintUser(userRepository.YoungerSystemWoman());
    }

    private void VolderSystemMan()
    {
      Console.WriteLine($"Older system man is ");
      printUserInfo.PrintUser(userRepository.OlderSystemMan());
    }

    // We are going to send all designer woman, 
    // counter implementation should be implemented in views
    private void VlegalDesignerWoman()
    {
      Console.WriteLine($"How many designers are woman: {userRepository.LegalDesignerWoman()}");
    }

    private void VmarriedProgrammerAvarage()
    {
      Console.WriteLine($"Avarage age of married programmers: {userRepository.MarriedProgrammerAvarage()}");
    }

    private void VchildrenSupportPercentage()
    {
      Console.WriteLine($"Support children students percentage: {userRepository.ChildrenSupportPercentage()}");
    }
  }
}