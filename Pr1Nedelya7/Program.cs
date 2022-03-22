using System;

namespace Pr1Nedelya7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lenght=0;
            int[] arr = new int[100];
            do {
                Console.Write("Введите размер массива: ");
                int.TryParse(Console.ReadLine(), out lenght); }
            while (lenght <= 0);
            for (int i = 0; i < lenght; i++)
                arr[i] = rnd.Next(101);
            Console.Write("Изначальный массив: ");
            for (int i = 0; i < lenght; i++)
                Console.Write(arr[i] + ";");
            Console.WriteLine("");
            shuffle(arr, lenght);
            Console.Write("Перемешанный массив: ");
            for (int i = 0; i < lenght; i++)
                Console.Write(arr[i] + ";");
            Console.ReadLine();
        }
        static void shuffle(int[] arr, int lenght)
        {
            Random rnd = new Random();
            for (int i = lenght-1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                int tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
        }
    }
}
