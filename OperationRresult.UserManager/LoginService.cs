using OperationResult.Entities;

namespace OperationRresult.UserManager;
public class LoginService
{
    public Result<Tokens, UserLoginError> Login(string username, string password)
    {
        Result<Tokens, UserLoginError> result;
        if(username != "admin" || password != "admin")
        {
            result = new(new UserLoginError());
        }
        else
        {
            result = new(new Tokens());
        }
        return result;
    }
}
