// List of objects implementation
using RegistroPersonal.Data.IData;
using RegistroPersonal.Data.Users.DefaultData;
using RegistroPersonal.Models;

namespace RegistroPersonal.Data.Users
{
  public class UserDataBase: IDataBase<User>
  {
    public List<User> Data
    {
      // get {return new UsersDefault().Users;}
      get {return UserRamdomData.Users;}
    }
  }
}