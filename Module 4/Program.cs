using System.Net;

namespace Module_4;

class Program
{
    static void Main(string[] args)
    {
        var arrays = new int[3][];
        arrays[0] = new[] {1,2};
        arrays[1] = new[] {3,4,5};
        arrays[2] = new[] {6,7,8,9};

        foreach (var array in arrays)
        {
            foreach (var item in array)
            Console.Write($"{item} ");       
        }
    }
}