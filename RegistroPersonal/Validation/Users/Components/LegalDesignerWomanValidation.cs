using RegistroPersonal.Data;
using RegistroPersonal.Models;
using RegistroPersonal.Validation.IValidation;
using RegistroPersonal.Validation.Users.Gears;

namespace RegistroPersonal.Validation.Users.Components
{
  class LegalDesignerWomanValidation: IComponent<int>
  {
    private BaseContext _data = new BaseContext();
    public int Validate ()
    {
      List<User> listOfUsers = _data.Users.Data;
      List<User> listDesignerWoman = new List<User>();

      for (int i = 0; i < listOfUsers.Count; i++)
      {
        User user = listOfUsers[i];
        UsersValidation validateUser = new UsersValidation(user); 
        // First lets check if is a system enginer female
        if (validateUser.IsGenderEqualTo("Female")
          & validateUser.IsCarrerEqualTo("Ux and Ui designer")
        )
        {
          listDesignerWoman.Add(user);
        }
      }

      // 
      return listDesignerWoman.Count;
    }
  }
}