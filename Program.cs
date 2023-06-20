internal class Program
{
    private static void MinMaxValue(int[] arr, out int max, out int min)
    {
        min = arr[0];
        max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
    }

    public static void Main()
    {
        var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        MinMaxValue(array, out int max, out int min);
        Console.WriteLine($"Minimum {min}, maximum {max}");
    }
}