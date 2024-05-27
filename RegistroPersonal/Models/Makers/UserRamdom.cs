using RegistroPersonal.Data;
using RegistroPersonal.Data.Users;

namespace RegistroPersonal.Models.Makers
{
  class UserRamdom : User
  {
    private BaseContext _context = new BaseContext();
    private Carrer[] Carrers;
    private Gender[] Genders; 
    private CivilStatus[] CivilStatusArray;
    private string[] Names = {"David", "Sara", "Manuel", "Carlos", "Laura"};
    public UserRamdom()
    {
      Carrers = _context.Carrers.Data.ToArray();
      Genders = _context.Genders.Data.ToArray();
      CivilStatusArray = _context.CivilStatus.Data.ToArray();
    }

    public User RamdomUser ()
    {
      Random random = new Random();
      User user = new User();

      user.Name = Names[random.Next(0, Names.Length)];
      // Legal age, and life expectacy
      user.Age = random.Next(18, 85);

      /*
        Select a ramdom gender in the list

        example:
          Genders = [{Id: 1, Name: male}, {Id: 2, Name: female}]
          Gender[0] = {Id: 1, Name: male}

        Then just get name value
          User.Name = Gender[0].Name
          User.Name = "male"
      */
      user.Gender = Genders[random.Next(0, Genders.Length)].Name;
      user.Carrer = Carrers[random.Next(0, Carrers.Length)].Name;
      user.CivilStatus = CivilStatusArray[random.Next(0, CivilStatusArray.Length)].Name;

      return user;
    }
  }
}