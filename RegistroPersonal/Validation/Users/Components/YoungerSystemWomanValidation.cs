using RegistroPersonal.Data;
using RegistroPersonal.Models;
using RegistroPersonal.Validation.IValidation;
using RegistroPersonal.Validation.Users.Gears;

namespace RegistroPersonal.Validation.Users.Components
{
  class YoungerSystemWomanValidation: IComponent<User>
  {
    private BaseContext _data = new BaseContext();
    public User Validate ()
    {
      List<User> listOfUsers = _data.Users.Data;
      User user = null;

      for (int i = 0; i < listOfUsers.Count; i++)
      {
        User userCompare = listOfUsers[i];

        UsersValidation validateUser = new UsersValidation(userCompare); 
        // First lets check if is a system enginer female
        if (validateUser.IsGenderEqualTo("Female")
          & validateUser.IsCarrerEqualTo("System Engineer")
        ) { }

        else { continue; }

        // Now lets check if exist an current user
        if(user == null) 
        {
          user = userCompare;
          continue;
        }

        //----- Now compare ages -----//
        /*
          This looks like an error, because it is unecessary to create new instances
          of UserComparation and UserValidation if we are not going to storage that information,
          and just use the methods.
        */
        UserComparation comparationOfUsers = new UserComparation(user, userCompare);

        user = comparationOfUsers.IsYounger() 
          ? userCompare
          : user;
      }

      return user;
    }
  }
}