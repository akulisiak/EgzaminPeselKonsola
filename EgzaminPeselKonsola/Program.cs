// See https://aka.ms/new-console-template for more information
using EgzaminPeselKonsola;

Console.WriteLine("Podaj 11 znakowy numer PESEL:");
string numerPesel = Console.ReadLine();

Pesel pesel = new Pesel(numerPesel);

Console.WriteLine("Płeć zawarta w numerze PESEL:");
if (pesel.SprawdzPlec() == 'K')
{
    Console.WriteLine("Kobieta");
}
else
{
    Console.WriteLine("Mężczyzna");
}

Console.WriteLine("Sprawdzenie poprawności numeru PESEL:");
if (pesel.WalidacjaNumeruPesel())
{
    Console.WriteLine("Pesel prawidłowy");
}
else
{
    Console.WriteLine("Pesel nie prawidłowy");

}