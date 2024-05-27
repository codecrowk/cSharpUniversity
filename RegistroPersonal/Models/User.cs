namespace RegistroPersonal.Models
{
  public class User
  {
    public int Id {get; set;}
    public string Name {get; set;}
    public int Age {get; set;}
    public string Gender {get; set;}
    public string CivilStatus {get; set;}
    public string Carrer {get; set;}

    public User ()
    { }
    public User 
    (
      int id,
      string name,
      int age,
      string gender,
      string civilStatus,
      string carrer
    )
    {
      Id = id;
      Name = name; 
      Age = age;
      Gender = gender;
      CivilStatus = civilStatus;
      Carrer = carrer;
    }
  }
}