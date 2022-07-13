// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

namespace DZ
{
    class Task38
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double[] array = new double[5];
            FillArray(array);

            Console.WriteLine($"Задан массив [{String.Join(",", array)}]");

            double minElement = array[0];
            double maxElement = array[0];
            double diff = 0;

            Console.WriteLine("--------------------------------");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                }
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }
            diff = maxElement - minElement;

            Console.WriteLine($"Разница между максимальным и минимальным элементами массива составляет: {diff}");
        }

        public static void FillArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().NextDouble() * 100 - 0;
                array[i] = Math.Round(array[i], 0);
            }
        }
    }
}
