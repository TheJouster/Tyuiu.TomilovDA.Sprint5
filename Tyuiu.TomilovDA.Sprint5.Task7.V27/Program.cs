using Tyuiu.TomilovDA.Sprint5.Task7.V27.Lib;
namespace Tyuiu.TomilovDA.Sprint5.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine(@"*Дан файл С:\DataSprint5\InPutDataFileTask7V27.txt (файл взять из архива с*");
            Console.WriteLine(@"*согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопир*");
            Console.WriteLine("*ровать в неё файл) в котором есть набор символьных данных.Удалить все про*");
            Console.WriteLine("*обелы, идущие подряд больше одного.Полученный результат сохранить в файл *");
            Console.WriteLine("* OutPutDataFileTask7V27.txt.                                             *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string filePath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V27.txt");
            string saveFilePath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V27.txt");
            Console.WriteLine($"Входные данные: {filePath}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.LoadDataAndSave(filePath);
            Console.WriteLine($"Полученный файл: {result}");
            Console.ReadKey();
        }
    }
}