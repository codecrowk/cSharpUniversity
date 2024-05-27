using RegistroPersonal.Data.IData;
using RegistroPersonal.Data.Users;
using RegistroPersonal.Models;

namespace RegistroPersonal.Data
{
  class BaseContext 
  {
    public IDataBase<User> Users = new UserDataBase();
    public IDataBase<Gender> Genders = new GendersDataBase();
    public IDataBase<CivilStatus> CivilStatus = new CivilStatusDataBase();
    public IDataBase<Carrer> Carrers = new CarrersDataBase();
  }
}