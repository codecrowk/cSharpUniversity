using RegistroPersonal.Models;

namespace RegistroPersonal.Validation.Users.Gears
{
  class UserComparation
  {
    private User CurrentUser;
    private User CompareUser;

    public UserComparation (User user, User compareUser)
    {
      CurrentUser = user;
      CompareUser = compareUser;
    }
    
    public bool IsYounger()
    {
      /*
        Compare user age = 12
        Current user age = 20

        if (12 < 18)
          true
        
        it means that if current user is older,
          so compare user is younger
      */
      return CompareUser.Age < CurrentUser.Age
        ? true
        : false;
    }
    public bool IsOlder()
    {
      return CompareUser.Age > CurrentUser.Age
        ? true
        : false;
    }

    public bool HaveSameAge()
    {
      return CurrentUser.Age == CompareUser.Age
        ? true
        : false;
    }
  }
}