/*Console.WriteLine("ingrese un numero entre 5 y 10 : ");

int number = 0;
do
{
    string? numberString = Console.ReadLine();
    bool flag = int.TryParse(numberString, out number);
    if (!flag) Console.WriteLine($"{numberString} es invalido \n ingres un numero entre 5 y 10 xxx: ");
    else if (!(5 < number && number < 10)) Console.WriteLine($"{numberString} esta fuera de rango \n ingres un numero entre 5 y 10 : ");
} while (!((5 < number) && (number < 10)));

Console.WriteLine($"{number} ha sido aceptado");*/



/*
string[] names = { "Admin", "Manager", "User" };
string rol;
bool flag = true;
Console.WriteLine("ingrese el rol: ");

do
{
    rol = Console.ReadLine() ?? "";
    foreach (var item in names)
    {

        if (item.Trim().ToLower() == rol.Trim().ToLower())
        {
            flag = false;
            break;
        }
        ;

    }
    if (flag == true) Console.WriteLine("rol no se encuentra\n ingrese el rol: ");

} while (flag);

Console.WriteLine($"el rol {rol}  es aceptado:");*/


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation;

foreach (String myString in myStrings)
{
    periodLocation = myString.IndexOf(".");
    string myStringLocal = myString;
    do
    {
        if (periodLocation == -1)
        {
            Console.WriteLine(myStringLocal);
            continue;
        }
        Console.WriteLine(myStringLocal.Remove(periodLocation));
        myStringLocal = myStringLocal.Substring(periodLocation).TrimStart('.').TrimStart();

        periodLocation = myStringLocal.IndexOf('.');
    } while (periodLocation != -1);

}
