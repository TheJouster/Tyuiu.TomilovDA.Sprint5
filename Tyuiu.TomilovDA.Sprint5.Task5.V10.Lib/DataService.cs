using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TomilovDA.Sprint5.Task5.V10.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] nums = line.Split(' ');
                    foreach (string s in nums)
                    {
                        double x = double.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
                        if (x % 2 == 0)
                        {
                            res += x;
                        }
                    }
                }
            }
            return res;
        }
    }
}
