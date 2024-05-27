namespace RegistroPersonal.Models
{
  public class Carrer
  {
    public int Id {get; set;}
    public string Name {get; set;}

    public Carrer()
    { }

    public Carrer(int id, string name)
    {
      Id = id;
      Name = name;
    }
  }
}