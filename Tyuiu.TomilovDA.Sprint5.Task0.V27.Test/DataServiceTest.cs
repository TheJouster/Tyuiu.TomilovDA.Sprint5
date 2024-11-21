namespace Tyuiu.TomilovDA.Sprint5.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Jouster\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            Assert.IsTrue(exists);
        }
    }
}