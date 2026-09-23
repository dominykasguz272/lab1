using Lab1;

// Uzduotis #4
Group grupe = new() { Pavadinimas = "KT-5" };

Console.WriteLine("\n\nUZDUOTIS #4: Studentu radimas pagal ID ir PASTA");

while (true)
{
    Console.WriteLine("\nMeniu");
    Console.WriteLine("0 - Iseiti");
    Console.WriteLine("1 - Rasti studenta pagal ID");
    Console.WriteLine("2 - Rasti studenta pagal PASTA");
    Console.WriteLine("3 - Rodyti visus studentus");
    Console.WriteLine("\nPasirinkimas: ");

    string pasirinkimas = Console.ReadLine() ?? "";

    switch(pasirinkimas)
    {
        case "0":
            Console.WriteLine("\nPrograma baigta.\n");
            return;
        case "1":
            grupe.FindById();
            break;
        case "2":
            grupe.FindByEmail();
            break;
        case "3":
            grupe.RodytiVisus();
            break;
    }
}
