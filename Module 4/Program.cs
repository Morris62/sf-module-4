namespace Module_4;

class Program
{
    static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    var k = arr[i];
                    arr[i] = arr[j];
                    arr[j] = k;
                }
            }
        }

        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        
    }
}