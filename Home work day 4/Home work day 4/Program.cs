string name = "Andrzej ";
string gender = "Mężczyzna ";
var age = 43;
string result = name + gender + age;
Console.WriteLine(result);





string name1 = "Ewa";
string gender1 = "Kobieta";
var age1 = 33;

if (name1 == "Ewa" && age1 < 35)
{
    Console.WriteLine("Ewa, lat 33");
}
else
{
    Console.WriteLine("Ewa, nie ma 33 lat");

}


string gender2 = "Kobieta";
var age2 = 30;

if (gender2 == "Kobieta" && age2 > 40)
{
    Console.WriteLine("Kobieta jest młodsza niz sie wydaje");
}
else
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

string gender3 = "Mężczyzna";
var age3 = 17;

if (gender3 == "Mężczyzna" && age3 == 17)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Dzieciak");

}