Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

string[] roles = [ "administrator", "manager", "user" ];
bool isRole = false;
string? userInput = "";

do
{
    userInput = Console.ReadLine();
    if (userInput != null)
    {
        if (roles.Contains(userInput.ToLower().Trim()))
        {
            Console.WriteLine("Yes");
            isRole = true;
        }
        else
        {
            Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    }


} while (isRole == false);
