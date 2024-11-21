using Tyuiu.TomilovDA.Sprint5.Task1.V18.Lib;
namespace Tyuiu.TomilovDA.Sprint5.Task1.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись набора данных в текстовый файл                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дана функция, F(x) = 3x + 2 - 2x-x cos(x)+1 (произвести табулирование) f(*");
            Console.WriteLine("*(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления *");
            Console.WriteLine("* на ноль. При делении на ноль вернуть значение 0. результат сохранить тек*");
            Console.WriteLine("*кстовый файл OutPutFileTaskl.txt и вывести на консоль в таблицу. Значения*");
            Console.WriteLine("*я округлить до двух знаков после запятой.                                *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine($"Стартовое значение: {startValue}");
            Console.WriteLine($"Конечное значение: {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            

            DataService ds = new DataService();

            var result = ds.SaveToFileTextData(startValue,stopValue);
            int stValue = -5;
            Console.WriteLine($"Файл: {result}");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   F(x)   |");
            Console.WriteLine("+----------+----------+");
            foreach (string line in File.ReadLines(result))
            {
                Console.WriteLine("|{0, 5:d}     | {1, 6:f2}   |", stValue, line);
                stValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}