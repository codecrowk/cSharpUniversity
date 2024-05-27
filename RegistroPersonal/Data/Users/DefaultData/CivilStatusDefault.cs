using RegistroPersonal.Models;

namespace RegistroPersonal.Data.Users.DefaultData
{
  public class CivilStatusDefault 
  {
    public List<CivilStatus> CivilStatus 
    {
      get
      {
        return DefaultData();
      }
    }

    private List<CivilStatus> DefaultData()
    {
      List<CivilStatus> data = new List<CivilStatus>
      {
        new CivilStatus(1, "Single"),
        new CivilStatus(2, "Married"),
        new CivilStatus(3, "Widow"),
        new CivilStatus(4, "No married")
      };

      return data;
    }
  }
}