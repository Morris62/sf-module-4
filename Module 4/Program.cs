namespace Module_4;

class Program
{
    static void Main(string[] args)
    {
        (string Name, string Type, double Age, int NameCount) Pet;
        
        Console.WriteLine("Введите имя питомца: "); 
        Pet.Name = Console.ReadLine();
        Pet.NameCount = Pet.Name.Length;
        Console.WriteLine("Введите тип питомца: ");
        Pet.Type = Console.ReadLine();
        Console.WriteLine("Введите возраст питомца: ");
        Pet.Age = double.TryParse(Console.ReadLine(), out var age) ? age : 0;
        
        Console.WriteLine("Имя питомца {0}, тип питомца {1}, возраст питомца {2}", Pet.Name, Pet.Type, Pet.Age.ToString("F1"));
        Console.ReadKey();
    }
}