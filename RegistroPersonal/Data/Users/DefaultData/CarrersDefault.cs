using RegistroPersonal.Models;

namespace RegistroPersonal.Data.Users.DefaultData
{
  public class CarrersDefault 
  {
    public List<Carrer> Carrers 
    {
      get
      {
        return DefaultData();
      }
    }

    private List<Carrer> DefaultData()
    {
      List<Carrer> data = new List<Carrer>
      {
        new Carrer(1, "System Engineer"),
        new Carrer(2, "Programmer"),
        new Carrer(3, "Support"),
        new Carrer(4, "Ux and Ui designer"),
      };
      return data;
    }
  }
}