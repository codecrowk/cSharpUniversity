// List of objects implementation
using RegistroPersonal.Data.IData;
using RegistroPersonal.Data.Users.DefaultData;
using RegistroPersonal.Models;

namespace RegistroPersonal.Data.Users
{
  public class GendersDataBase: IDataBase<Gender>
  {
    public List<Gender> Data
    {
      get {return new GendersDefault().Genders;}
    }
  }
}