using System.Data.Common;
using Tyuiu.TomilovDA.Sprint5.Task2.V26.Lib;
namespace Tyuiu.TomilovDA.Sprint5.Task2.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись структурированных данных в текстовый файл            *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значения*");
            Console.WriteLine("*ями с клавиатуры. Заменить положительные элементы массива на 1, отрицател*");
            Console.WriteLine("*льные на 0. Результат сохранить в файл OutPutFileTask2.csv и вывести на к*");
            Console.WriteLine("*консоль.                                                                 *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите высоту матрицы:");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ширину матрицы:");
            int columns = Convert.ToInt32(Console.ReadLine());

            
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите {j + i * 3} элемент матрицы:");
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Полученная матрица:");
            for (int i1 = 0; i1 < rows; i1++)
            {
                for (int j1 = 0; j1 < columns; j1++)
                {
                    Console.Write($"{matrix[i1, j1]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.SaveToFileTextData(matrix);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}