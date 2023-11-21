


/// Zadanie nr 4


string namesToCompare = "Ewa,Kobieta o imieniu Maria";
string gender = "Male";
int ageMale = 15;



if (namesToCompare.Split(',').Contains ("Kobieta o imieniu Maria") && ageMale < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (namesToCompare.Split(',').Contains("Ewa") && ageMale <= 33)
{ 
    Console.WriteLine("Ewa,lat 33");
}
else if (gender == "Male" && ageMale == 15)
{
    Console.WriteLine("Niepełnoletni Mezczyzna");
}
