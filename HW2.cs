using System.Linq.Expressions;

namespace HW2_1;

public class test
{
    
    static void Main(string[] args)
    {
        GetMinNumInArray(CreateArr(GetlenArr()));
    }
    public static int GetlenArr()
    {
        Console.WriteLine("Введите длину массива");
        int len = Convert.ToInt32(Console.ReadLine());
        return len;
    }

    public static int[] CreateArr(int len)
    {
        
        Random rnd = new Random();
        int[] arr =  new int[len];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(2000);
    
        }
        return arr;
    }

  public static void GetMinNumInArray(int[] arr)
    {
        int minValue = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < minValue)
            {
                minValue = arr[i];
            }

            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Минимальное число в массиве: " + minValue);
    }
}
