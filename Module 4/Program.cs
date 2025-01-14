namespace Module_4;

class Program
{
    static void Main(string[] args)
    {
        var arr = new[] { 5, 6, 9, 1, 2, 3, 4 };

        int sum = 0;
        
        foreach (var item in arr)
        {
            sum += item;
        }
        Console.WriteLine("Сумма = " + sum);
    }
}