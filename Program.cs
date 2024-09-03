using System.Globalization;

Console.WriteLine("Enter your last name:");
string lastName = Console.ReadLine();

Console.WriteLine("Enter your gender (f/m/n):");
char userGender =Char.Parse(Console.ReadLine());

String greeting = "";

if (userGender =='f')
{
    greeting = "Ms.";
}
else if (userGender == 'm')
{
    greeting = "Mr.";
}
else
{
    greeting = "";
}
Console.WriteLine($"Hello, {greeting} {lastName}!");

Console.WriteLine("Enter your year of birht");
int userYB =Int32.Parse(Console.ReadLine());

int currentYear=DateTime.Now.Year;


int userAge = currentYear - userYB;




if (userGender>=13)
{
    Console.WriteLine("Your are {usersYB} old enough to have account");

}
else if (userAge<13)
{
    Console.WriteLine("You are {usersYB} to young to have an account");

}