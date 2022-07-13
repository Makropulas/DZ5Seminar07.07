// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

namespace DZ
{
    class Task34
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Сейчас будет сгенерирован массив. Нажмите любую клавишу для продолжения");
            Console.ReadKey();

            int lengthArray = SetArayLenth();
            int[] array = new int[lengthArray];
            FillArray(array);

            Console.WriteLine($"[{String.Join(",", array)}]");

            int even = 0;

            Console.WriteLine("--------------------------------");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even++;
                }
            }
            Console.WriteLine($"Количество чётных чисел в массиве: {even}");
            Console.ReadKey();
        }

        public static int SetArayLenth()
        {
            int length = new Random().Next(4, 11);
            return length;
        }

        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100, 1000);
            }
        }
    }
}