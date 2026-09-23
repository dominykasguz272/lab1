namespace Lab1;

public class Group
{
    public string Pavadinimas { get; set; } = "";

    // Studentu Sarasas (dinaminis masyvas)
    public List<Student> Studentai { get; set; } = [
        new Student { Id = 1, Vardas = "Jonas", ElPastas = "jonas@gmail.com", Vidurkis = 8.5 },
        new Student { Id = 2, Vardas = "Ona", ElPastas = "ona@go.kauko.lt", Vidurkis = 9.2 },
        new Student { Id = 3, Vardas = "Tomas", ElPastas = "tomas@gmail.com", Vidurkis = 7.8 },
        new Student { Id = 4, Vardas = "Ieva", ElPastas = "ieva@outlook.com", Vidurkis = 8.9 },
        new Student { Id = 5, Vardas = "Mantas", ElPastas = "mantas@gmail.com", Vidurkis = 6.9 }
    ];

    public void RodytiVisus()
    {
        Console.WriteLine("\nStudentai grupėje: " + Pavadinimas);

        foreach (Student s in Studentai)
        {
            Console.WriteLine($"ID: {s.Id}, Vardas: {s.Vardas}, El.paštas: {s.ElPastas}, Vidurkis: {s.Vidurkis}");
        }
    }

    public void FindByEmail()
    {
        string pastas;
        bool rastas = false;

        while (true)
        {
            Console.WriteLine("Ivesk pilna pasta: ");
            pastas = Console.ReadLine() ?? "";

            if (pastas != "")
            {
                break;
            } 
            else 
            {
                Console.WriteLine("KLAIDA: pastas turi buti pilnas");
            }
        
        }
        
        foreach (Student s in Studentai)
        {
            if (s.ElPastas == pastas) {
                Console.WriteLine($"ID: {s.Id}, Vardas: {s.Vardas}, El.paštas: {s.ElPastas}, Vidurkis: {s.Vidurkis}");
                rastas = true;
                break;
            }
        }

        if (!rastas)
        {
            Console.WriteLine($"Studento pagal si pasta ({pastas}) nerastas!");
        }
    }

    public void FindById()
    {
        int id;
        bool rastas = false;
        
        while (true)
        {
            Console.WriteLine("Ivesk ID: ");
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out id))
            {
                break;
            } 
            else 
            {
                Console.WriteLine("KLAIDA: ID turi buti skaicius");
            }
        }
        
        foreach (Student s in Studentai)
        {
            if (s.Id == id) 
            {
                Console.WriteLine($"ID: {s.Id}, Vardas: {s.Vardas}, El.paštas: {s.ElPastas}, Vidurkis: {s.Vidurkis}");
                rastas = true;
                break;
            }
        }

        if (!rastas)
        {
            Console.WriteLine($"Studento pagal ID: {id} nerastas!");
        }

    }
}