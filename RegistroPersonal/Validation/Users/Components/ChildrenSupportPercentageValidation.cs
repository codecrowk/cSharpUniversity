using RegistroPersonal.Data;
using RegistroPersonal.Models;
using RegistroPersonal.Validation.IValidation;
using RegistroPersonal.Validation.Users.Gears;

namespace RegistroPersonal.Validation.Users.Components
{
  class ChildrenSupportPercentageValidation: IComponent<double>
  {
    private BaseContext _data = new BaseContext();
    public double Validate ()
    {
      List<User> listOfSupports = SupportPeople();
      double childrenSupportPercentage = ChildrenWorkersPercentage(listOfSupports);
      return childrenSupportPercentage;
    }

    public List<User> SupportPeople()
    {
      List<User> listOfUsers = _data.Users.Data;
      List<User> listSupportPeople = new List<User>();

      for (int i = 0; i < listOfUsers.Count; i++)
      {
        User user = listOfUsers[i];
        UsersValidation validateUser = new UsersValidation(user); 

        if (validateUser.IsCarrerEqualTo("Support"))
        {
          listSupportPeople.Add(user);
        }
      }

      return listSupportPeople;
    }

    public double ChildrenWorkersPercentage(List<User> usersList)
    {
      // Chech if list is empty
      if (usersList.Count == 0)
        return 0;

      List<User> childerList = new List<User>();

      for (int i = 0; i < usersList.Count; i++)
      {
        User user = usersList[i];
        UsersValidation validateUser = new UsersValidation(user); 

        if (!validateUser.IsAdult())
        {
          childerList.Add(user);
        }

      }

      double childrenPercentage = (childerList.Count * 100) / usersList.Count;
      return childrenPercentage;
    }
  }
}