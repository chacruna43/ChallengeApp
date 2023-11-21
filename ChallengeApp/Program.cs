/// Zadanie nr 4

string name = "Ewa";
string gender = "Female";
int age = 33;
int agemale = age - 16;
bool ageEwaLat30 = false;


if (name == "Ewa" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (gender == "Female" && age > agemale)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (ageEwaLat30 == true)
{
    Console.WriteLine("Ewa,lat 33");
}
