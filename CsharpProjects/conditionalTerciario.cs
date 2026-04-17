
/*
Random num = new Random();
int n1 = num.Next(0, 2);
Console.WriteLine($"you got: {(n1 > 0 ? "head" : "tails")}  \n and you number is: {n1}");
*/

string User = "Admin";
int level = 55;

string permission = "Admin|Manager";

if (User.Contains("Admin"))
{
    Console.WriteLine(level > 55 ? "Welcome, Super Admin Super" :
        "Welcome, Admin User");
}

else if (User.Contains("Manager"))
{
    Console.WriteLine(level > 20 ? "Contact an Andmin acces" :
        "You dont have sufficent privileges");
}
else
{
    Console.WriteLine("You dont have sufficent privileges");
}
