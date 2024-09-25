using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість елементів масива: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть елемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int? firstNegative = null;
        int? lastNegative = null;



        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                firstNegative = array[i];
                break;
            }
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                lastNegative = array[i];
                break;
            }
        }

        if (firstNegative.HasValue && lastNegative.HasValue)
        {
            int sum = firstNegative.Value + lastNegative.Value;
            Console.WriteLine($"Сума першого и останнього від’ємного елементів: {sum}");
        }
        else
        {
            Console.WriteLine("У масиві недостаточно від’ємних елементів.");
        }
    }
}
