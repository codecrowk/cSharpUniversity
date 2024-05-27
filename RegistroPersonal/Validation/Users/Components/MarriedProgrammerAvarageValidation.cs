using RegistroPersonal.Data;
using RegistroPersonal.Models;
using RegistroPersonal.Validation.IValidation;
using RegistroPersonal.Validation.Users.Gears;

namespace RegistroPersonal.Validation.Users.Components
{
  class MarriedProgrammerAvarageValidation: IComponent<double>
  {
    private BaseContext _data = new BaseContext();
    public double Validate ()
    {
      double ageAvarage = 0;
      try
      {
        List<User> marriedProgrammers = GetMarriedProgrammers();
        ageAvarage = GetAgeAvarage(marriedProgrammers);
      }
      catch (NullReferenceException e)
      {
        Console.WriteLine(e.Message);
      }

      return ageAvarage;
    }


    private List<User> GetMarriedProgrammers()
    {
      List<User> listOfUsers = _data.Users.Data;
      List<User> marriedProgrammers = new List<User>();

      for (int i = 0; i < listOfUsers.Count; i++)
      {
        User user = listOfUsers[i];
        UsersValidation validateUser = new UsersValidation(user); 

        if (validateUser.IsCarrerEqualTo("Programmer")
          & validateUser.IsCivilStatusEqualTo("Married")
        )
        {
          marriedProgrammers.Add(user);
        }
      }

      return marriedProgrammers;
    }
    private double GetAgeAvarage(List<User> usersList)
    {
      if (usersList.Count == 0)
        throw new NullReferenceException("List is empty");

      int ageAcoulation = 0;
      int totalUsers = usersList.Count;
      for (int i = 0; i < totalUsers; i++)
      {
        User user = usersList[i];

        ageAcoulation += user.Age;
      }

      int ageAvarage = ageAcoulation / totalUsers;
      return ageAvarage;
    }
  }
}