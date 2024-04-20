using UserLogin;
using System.Collections.Generic;
namespace UserDataService
{
    public class UserDataServices
    {
        List<User> dummyUsers = new List<User>();
        public UserDataServices()
        {
            CreateDummyData();
        }
        private void CreateDummyData()
        {

            User user1 = new User()
            {
                username = "Maria",
                password = "Angelika",
            };
            dummyUsers.Add(user1);



            User user2 = new User()
            {
                username = "Nina",
                password = "Luisa",

            };

            dummyUsers.Add(user2);


            User user3 = new User()
            {
                username = "Liam",
                password = "Edwards",

            };

            dummyUsers.Add(user3);


        }
        public User GetUser(string username, string password)
        {
            User foundUser = new User();
            foreach (var user in dummyUsers)
            {
                if (user.username == username && password == user.password)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }
    }
}
