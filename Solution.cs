namespace inf04_c;

public static class Solution
{
    public static void Fill(this int[] arr)
    {
        for (var i = 0; i < arr.Length; i++)
        {
            arr[i] = Random.Shared.Next(1, 100);
        }
    }

    public static int Search(int[] arr, int number)
    {
        Array.Sort(arr); // pierwsze trzeba posortowac
        
        foreach (var i in arr)
        {
            Console.Write(i + ", ");
        }

        Console.WriteLine();
        
        return Array.BinarySearch(arr, number); // XD implement own binary search
    }
}