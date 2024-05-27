// List of objects implementation
using RegistroPersonal.Data.IData;
using RegistroPersonal.Data.Users.DefaultData;
using RegistroPersonal.Models;

namespace RegistroPersonal.Data.Users
{
  public class CivilStatusDataBase: IDataBase<CivilStatus>
  {
    public List<CivilStatus> Data
    {
      get {return new CivilStatusDefault().CivilStatus;}
    }
  }
}