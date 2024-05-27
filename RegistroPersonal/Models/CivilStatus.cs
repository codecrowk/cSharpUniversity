namespace RegistroPersonal.Models
{
  public class CivilStatus
  {
    public int Id {get; set;}
    public string Name {get; set;}

    public CivilStatus()
    { }

    public CivilStatus(int id, string name)
    {
      Id = id;
      Name = name;
    }
  }
}