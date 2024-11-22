using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TomilovDA.Sprint5.Task2.V26.Lib
{
    public class DataService : ISprint5Task2V26
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }
            string str = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                    else if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    if (j < matrix.GetLength(1)-1)
                    {
                        str += Convert.ToString(matrix[i, j]) + ";";
                    }
                    else
                    {
                        str += Convert.ToString(matrix[i, j]);
                    }
                }
                if (i < matrix.GetLength(1) - 1)
                {
                    File.AppendAllText(path, str+Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }
            return path;
        }
    }
}
