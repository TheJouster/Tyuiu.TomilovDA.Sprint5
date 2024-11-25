using Tyuiu.TomilovDA.Sprint5.Task5.V10.Lib;
namespace Tyuiu.TomilovDA.Sprint5.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Чтение набора данных из текстового файла                                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine(@"*Дан файл С:\DataSprint5\InPutDataFileTask5V10.txt (файл взять из архива с*");
            Console.WriteLine(@"*согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопир*");
            Console.WriteLine("*ровать в неё файл) в котором есть набор значений. Найти сумму всех четных*");
            Console.WriteLine("*х целых чисел в файле.  Полученный результат вывести на консоль. У вещест*");
            Console.WriteLine("*твенных значений округлить до трёх знаков после запятой.                 *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V10.txt");
            Console.WriteLine(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            DataService ds = new DataService();

            var result = ds.LoadFromDataFile(path);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}