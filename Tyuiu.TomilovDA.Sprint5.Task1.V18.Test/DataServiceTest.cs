namespace Tyuiu.TomilovDA.Sprint5.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Jouster\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            Assert.IsTrue(exists);
        }
    }
}