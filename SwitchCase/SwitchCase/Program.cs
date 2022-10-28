Console.WriteLine("car dealer exercise");
string renault = "Renault";
string chevrolet = "Chevrolet";
string fiat = "Fiat";
string toyota = "Toyota";

Console.WriteLine("Welcome to the \"COMBITAUTOS\" dealership");
Console.WriteLine("Have you paid 30% of the initial fee?");
string var30 = Console.ReadLine();

if (var30.ToLower() == "yes")
{
    Console.WriteLine("EXCELLENT, indicate what is the make of the vehicle you are buying?");
    Console.WriteLine("Renault\nChevrolet\nFiat\nToyota");
    string MARCA = Console.ReadLine();

    switch (MARCA.ToLower())
    {
        case "renault": Console.WriteLine("2% OF THE VALUE OF THE VEHICLE WILL BE DISCOUNTED");break;
        case "chevrolet": Console.WriteLine("3.3% OF THE VALUE OF THE VEHICLE WILL BE DISCOUNTED"); break;
        case "fiat": Console.WriteLine("4% OF THE VALUE OF THE VEHICLE WILL BE DISCOUNTED"); break;
        case "toyota": Console.WriteLine("4.1% OF THE VALUE OF THE VEHICLE WILL BE DISCOUNTED"); break;
        default: Console.WriteLine("Unrecognized vehicle make, enter the name without spaces"); break;
    }
}
else if (var30.ToLower() == "no")
{
    Console.WriteLine("sorry, you must first pay the initial vehicle fee");
}

Console.WriteLine("See you soon");
Console.WriteLine("bye");

Console.ReadKey();
