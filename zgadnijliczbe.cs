Random r = new Random();

int gowno = r.Next(1, 10);
int zgaduj = 0;
bool poprawny = false;

Console.WriteLine("mysle o cyfrze od 1 do 10");

while (!poprawny)
 {
    Console.Write("zgadnij numer: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out zgaduj))
    {
        Console.WriteLine("to nie cyfra glabie");
        continue;
    }

    if (zgaduj < gowno)
    {
        Console.WriteLine("wyzsza");
    }
    else if (zgaduj > gowno)
    {
        Console.WriteLine("nizsza");
    }
    else
    {
        poprawny = false;
        Console.WriteLine("udalo sie:D");
    }


 }