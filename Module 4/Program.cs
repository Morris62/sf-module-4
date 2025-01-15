namespace Module_4;

class Program
{
    static void Main(string[] args)
    {
        (string name, int age) anketa = new();
        
        Console.WriteLine("Введите Ваше имя: "); 
        anketa.name = Console.ReadLine();
        Console.WriteLine("Введите Ваш возраст: ");
        anketa.age = int.TryParse(Console.ReadLine(), out int age) ? age : 0;
        
        Console.WriteLine("Вас зовут {0}, Ваш возраст {1}", anketa.name, anketa.age.ToString());
        Console.ReadKey();
    }
}