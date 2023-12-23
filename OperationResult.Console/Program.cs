// See https://aka.ms/new-console-template for more information
using OperationResult.Entities;
using OperationRresult.UserManager;

Console.WriteLine("Identificate");

Console.Write("Nombre de usuario: ");
string UserName = Console.ReadLine();

Console.Write("Contraseña: ");
string Password = Console.ReadLine();

LoginService loginService = new LoginService();

Result<Tokens, UserLoginError> result = loginService.Login(UserName, Password);

result.HandleError(
    token =>
    {
        Console.WriteLine($"Tu token es: {token.AccessToken}");
    }, 
    error =>
    {
        Console.WriteLine(error.ErrorMessage);
    });




