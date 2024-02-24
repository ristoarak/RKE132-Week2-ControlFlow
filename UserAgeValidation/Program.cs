// See https://aka.ms/new-console-template for more information

//rakendus küsib kastajal valida tema sugu( m/f)
//Rakendus küsib kasutajal sisatada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / " Welcome, Ms. [ kasutaja perekonnanimi];

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());// loeb konsoolis maha andmeid  string ( sõne) formaadis
Console.WriteLine( "Please, enter your lastname:");

string userLastname = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastname}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastname}!");
    }

else
{
    Console.WriteLine($"Welcome! {userLastname}!");
}



