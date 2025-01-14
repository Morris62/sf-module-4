namespace Module_4;

class Program
{
    static void Main(string[] args)
    {
        var array = new int[] { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };

        var pos = 0;
        foreach (var item in array)
        {
            if (item > 0)
                pos++;
        }  
        Console.Write($"{pos}");    
    }
}