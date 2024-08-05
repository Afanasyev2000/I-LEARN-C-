Console.WriteLine("Enter an integer value between 5 and 10");

string? readResult;
bool is_accepted = false;
int numericValue = 0;

do
{
readResult = Console.ReadLine();
if (readResult != null)
    {
        int.TryParse(readResult, out numericValue);
        if (numericValue >= 5 & numericValue <= 10)
            {
                is_accepted = true;
                Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
            }
        else 
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again");
            }
    }
} while (is_accepted == false);
