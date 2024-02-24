// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanuse
// kui kasutaja vanuson väiksem kui 13, siis konsoolis kuvatakse:
//" You are too young to use Instagram"
//muul juhul
// konsoolis kuvatakse " Welcome to Instagram"

Console.WriteLine("Enter your age:");
string userAge = Console.ReadLine();
int userAgeNum = 0;

//boolean - true/ false

bool isAgenumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgenumber}. User is {userAgeNum} years old.");

if( isAgenumber == true)
{
    if( userAgeNum >= 13 )
    {
        Console.WriteLine("Welcome to Instagram.");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram. ");
    }
    
}
else
{
    Console.WriteLine("Could not read you age.");
}


