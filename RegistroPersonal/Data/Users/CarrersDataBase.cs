// List of objects implementation
using RegistroPersonal.Data.IData;
using RegistroPersonal.Data.Users.DefaultData;
using RegistroPersonal.Models;

namespace RegistroPersonal.Data.Users
{
  public class CarrersDataBase: IDataBase<Carrer>
  {
    public List<Carrer> Data
    {
      get {return new CarrersDefault().Carrers;}
    }
  }
}