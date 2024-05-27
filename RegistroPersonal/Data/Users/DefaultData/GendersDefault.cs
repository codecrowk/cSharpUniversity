using RegistroPersonal.Models;

namespace RegistroPersonal.Data.Users.DefaultData
{
  public class GendersDefault 
  {
    public List<Gender> Genders 
    {
      get
      {
        return DefaultData();
      }
    }

    private List<Gender> DefaultData()
    {
      List<Gender> data = new List<Gender>
      {
        new Gender(1, "Male"),
        new Gender(2, "Female")
      };

      return data;
    }
  }
}