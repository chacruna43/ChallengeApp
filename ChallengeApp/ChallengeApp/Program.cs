string name = "Ewa";
string gender = "femaile";
var age = 33;

////

if (name == "Ewa" && age == 40)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (gender == "femaile" && age != 33)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
if(name == "Ewa" && age >=33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if(name == "Ewa" && age <20)
{
    Console.WriteLine("Zadanie z gwiazdką");
}