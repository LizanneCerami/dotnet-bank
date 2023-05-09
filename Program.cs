
// Console.WriteLine("Hello, World!");

/*
int age = 34;
string name = "Liz";
bool isHere = true;
float salary = 22000.01f;

Console.WriteLine($"Hi, {name}! Your age is {age} and is here? {isHere}");
Console.WriteLine($"And you make ${salary} a year");
*/

try
{
  savingsAccount myAccount = new savingsAccount(300);
  // myAccount.balance = 300;

  Console.WriteLine($"Your balance is ${myAccount.getBalance()}");
} catch (Exception ex) {
  Console.WriteLine($"We got an error: {ex.Message}");
}
