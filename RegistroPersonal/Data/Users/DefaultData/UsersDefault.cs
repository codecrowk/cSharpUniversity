using RegistroPersonal.Models;

namespace RegistroPersonal.Data.Users.DefaultData
{
  public class UsersDefault 
  {
    public List<User> Users {get;}
    // {
    //   get
    //   {
    //     return DefaultData();
    //   }
    // }

    public UsersDefault()
    {
      List<User> data = new List<User>
      {
        new User(1, "jose", 30, "Male", "Married", "Programmer"),
        new User(7, "Daniel", 32, "Male", "Widow", "Programmer"),
        new User(3, "Michael", 28, "Male", "Single", "Programmer"),
        new User(5, "David", 20, "Male", "Married", "Programmer"),
        new User(10, "Josefin", 11, "Female", "Single", "System Engineer"),
        new User(10, "Amanda", 26, "Female", "Single", "System Engineer"),
        new User(6, "Jessica", 27, "Female", "No married", "System Engineer"),
        new User(1, "John", 51, "Male", "Married", "System Engineer"),
        new User(1, "Maicol", 54, "Male", "Married", "System Engineer"),
        new User(10, "Sara", 17, "Female", "Married", "System Engineer"),
        new User(4, "Sarah", 35, "Female", "Married", "Support"),
        new User(11, "David", 17, "Male", "Single", "Support"),
        new User(11, "Homero", 11, "Female", "Married", "Support"),
        new User(8, "Rachel", 29, "Female", "Married", "Support"),
        new User(9, "Robert", 40, "Male", "Married", "Ux and Ui designer"),
        new User(2, "Emily", 30, "Female", "Married", "Ux and Ui designer"),
        new User(2, "Laura", 41, "Female", "No married", "Ux and Ui designer")
      };

      Users = data;

    }
  }
}