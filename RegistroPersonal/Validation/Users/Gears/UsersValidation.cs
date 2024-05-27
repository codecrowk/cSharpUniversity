using RegistroPersonal.Models;

namespace RegistroPersonal.Validation.Users.Gears
{
  class UsersValidation
  {
    private User CurrentUser;
    public int AdultAge = 18;

    public UsersValidation (User user)
    {
      CurrentUser = user;
    }

    public bool IsCarrerEqualTo(string carrer)
    {
      return CurrentUser.Carrer == carrer 
        ? true
        : false;
    }

    public bool IsGenderEqualTo(string gender)
    {
      return CurrentUser.Gender == gender 
        ? true
        : false;
    }
    
    public bool IsCivilStatusEqualTo(string civilStatus)
    {
      return CurrentUser.CivilStatus == civilStatus 
        ? true
        : false;
    }

    public bool IsAdult()
    {
      return CurrentUser.Age >= AdultAge 
        ? true
        : false;
    }
  }
}