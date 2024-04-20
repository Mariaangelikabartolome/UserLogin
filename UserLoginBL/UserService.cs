using UserDataService;
namespace UserLoginBL
{
    public class BusinessLogic
    {
            public bool VerifyUserLogin(string username, string password)
            {
                UserDataServices dataService = new UserDataServices();
                var result = dataService.GetUser(username, password);
                if (result.username == username && result.password == password)
                {
                    return true;
                }
                else
                {
                    return false;

                }
        }
    }
}