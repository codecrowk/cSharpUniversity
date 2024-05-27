using RegistroPersonal.Models;
using RegistroPersonal.Models.Makers;

namespace RegistroPersonal.Data.Users.DefaultData
{
  public sealed class UserRamdomData 
  {
    private static List<User> users = null;
    private static readonly UserRamdom RamdomUser = new UserRamdom();
    public static List<User> Users
    {
      get
      {
        if (users == null)
        {
          users = new List<User>();
          GenerateData();
        }

        return users;
      }
    }

    private static void GenerateData ()
    {
      for(int i=0; i < 10; i++)
      {

        users.Add(RamdomUser.RamdomUser());
      }
    }
  }
}