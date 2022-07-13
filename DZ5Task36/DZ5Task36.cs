// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

namespace DZ
{
    class Task36
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

            int sum = 0;

            Console.WriteLine("--------------------------------");

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum = sum + array[i];
                }
            }
            Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");
            Console.ReadKey();
        }

        public static int SetArayLenth()
        {
            int length = new Random().Next(4, 8);
            return length;
        }

        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-100, 101);
            }
        }
    }
}