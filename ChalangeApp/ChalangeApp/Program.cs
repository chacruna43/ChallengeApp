

string name = "Ewa";
string gender = "femaile";
var age = 33;

if(name == "Ewa" && age > 40)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if(name == "Ewa" && age != 33)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if(gender == "femaile" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}