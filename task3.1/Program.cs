using System.Text;

namespace task3._1
{
    internal class Program { }
    public static class ConsoleExtensions

    {
        public static int ReadInt()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine()!.Trim(), out int number))
                    return number;

                Console.WriteLine("Введите число");
            }
        }

        public static void Main()
        {

            Console.Write("Кол-во строк: ");
            int rows = ConsoleExtensions.ReadInt();

            Console.Write("Кол-во столбцов: ");
            int columns = ConsoleExtensions.ReadInt();

            var matrixRngNumbers = new int[rows, columns];

            var random = new Random();
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                    matrixRngNumbers[i, j] = random.Next(0, 100);
            }

            Console.WriteLine("Матрица:");
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                    Console.Write($"{matrixRngNumbers[i, j],4}");
                Console.WriteLine();
            }

            int sum = matrixRngNumbers.Cast<int>().Sum();
            Console.WriteLine($"Сумма всех элементов матрицы: {sum}");
        }
    }
}




