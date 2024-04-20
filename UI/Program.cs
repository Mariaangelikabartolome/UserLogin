using UserLoginBL;
namespace UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            BusinessLogic userService = new BusinessLogic();
            bool result = userService.VerifyUserLogin(username, password);

            if (result)
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Login Unsuccessful");
            }
        }
        }
    }