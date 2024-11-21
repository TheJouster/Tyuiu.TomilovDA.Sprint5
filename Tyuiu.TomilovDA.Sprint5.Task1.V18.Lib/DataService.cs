using System.Linq.Expressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TomilovDA.Sprint5.Task1.V18.Lib
{
    public class DataService : ISprint5Task1V18
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            for (int x = startValue; x < stopValue; x++)
            {
                if (Math.Cos(x) + 1 != 0)
                {
                    double y = Math.Round(3 * x + 2 - ((2 * x - x) / (Math.Cos(x) + 1)),2);
                    File.AppendAllText(path, Convert.ToString(y) + Environment.NewLine);
                }
                else
                {
                    double y = 0;
                    File.AppendAllText(path, Convert.ToString(y) + Environment.NewLine);
                }
                
            }
            return path;
        }
    }
}
