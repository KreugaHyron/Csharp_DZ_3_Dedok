namespace Csharp_DZ_3_Dedok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1 - Пользователь вводит длину сторон пятиугольника, длина каждой стороны заносится в массив,
            //необходимо вычислить периметр пятиугольника (периметр – сумма всех сторон).
            //Решить задачу двумя способами – с помощью соответствующего метода класса System.Array и «вручную».
            double[] sides = new double[5];
            Console.WriteLine("Введите длины сторон пятиугольника:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Сторона {i + 1}: ");
                sides[i] = Convert.ToDouble(Console.ReadLine());
            }
            // Способ 1
            double perimeterUsingSum = sides.Sum();
            Console.WriteLine($"Периметр (метод Sum): {perimeterUsingSum}");
            // Способ 2
            double perimeterManual = 0;
            for (int i = 0; i < sides.Length; i++)
            {
                perimeterManual += sides[i];
            }
            Console.WriteLine($"Периметр (вручную): {perimeterManual}");

            //Task_2 - Пользователь вводит в массив прибыль фирмы за год (12 месяцев).
            //Необходимо определить месяц, в котором прибыль была максимальна, и месяц, в котором прибыль была минимальна.
            double[] profits = new double[12];
            Console.WriteLine("Введите прибыль за каждый месяц (12 значений):");
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Месяц {i + 1}: ");
                profits[i] = Convert.ToDouble(Console.ReadLine());
            }
            double maxProfit = profits[0];
            double minProfit = profits[0];
            int maxMonth = 0;
            int minMonth = 0;
            for (int i = 1; i < 12; i++)
            {
                if (profits[i] > maxProfit)
                {
                    maxProfit = profits[i];
                    maxMonth = i;
                }
                if (profits[i] < minProfit)
                {
                    minProfit = profits[i];
                    minMonth = i;
                }
            }
            Console.WriteLine($"Месяц с максимальной прибылью: {maxMonth + 1} (прибыль: {maxProfit})");
            Console.WriteLine($"Месяц с минимальной прибылью: {minMonth + 1} (прибыль: {minProfit})");

            //Task_3 - Создать массив целых чисел размером 10 элементов. Заполнить его случайными числами в диапазоне от -9 до 9 включительно.
            //Найти сумму нечетных элементов. Найти сумму элементов с нечетными индексами.
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-9, 10);
            }
            Console.WriteLine("Массив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            int sumOddElements = 0;
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    sumOddElements += num;
                }
            }
            int sumOddIndices = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sumOddIndices += array[i];
            }
            Console.WriteLine("Сумма нечетных элементов: " + sumOddElements);
            Console.WriteLine("Сумма элементов с нечетными индексами: " + sumOddIndices);
        }
    }
}
