namespace RegistroPersonal.Models
{
  public class Gender
  {
    public int Id {get; set;}
    public string Name {get; set;}
    public Gender()
    { }

    public Gender(int id, string name)
    {
      Id = id;
      Name = name;
    }
  }
}