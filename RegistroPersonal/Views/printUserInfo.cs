using RegistroPersonal.Models;

namespace RegistroPersonal.Views
{
  class PrintUserInfo
  {
    public void PrintUser(User user, bool headers = true)
    {

      if (user == null)
      {
        Console.WriteLine("Not user");
        return;
      }
 
      if(headers) 
        PrintHeaders();

      Console.WriteLine($"{user.Name}   | {user.Age} | {user.Gender} | {user.Carrer}      | {user.CivilStatus}");
    }

    public void PrintAllUsers(List<User> userList)
    {
      PrintHeaders();
      for(int i = 0; i < userList.Count; i++)
      {
        User currentUser = userList[i];
        PrintUser(currentUser, false);
      }
    }

    private void PrintHeaders()
    {
      Console.WriteLine("Name    | Age   | Gender   | Carrer        | Civil status");
    }
  }
}