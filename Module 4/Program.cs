namespace Module_4;

class Program
{
    static void Main(string[] args)
    {
        var (name, age) = ("Евгения", 27);
        
        Console.WriteLine("Вас зовут {0}, Ваш возраст {1}", name, age.ToString());

        Console.WriteLine("Введите Ваше имя: "); 
        name = Console.ReadLine();
        Console.WriteLine("Введите Ваш возраст: ");
        age = int.TryParse(Console.ReadLine(), out int _age) ? _age : 0;
        
        Console.WriteLine("Вас зовут {0}, Ваш возраст {1}", name, age.ToString());
        Console.ReadKey();
    }
}