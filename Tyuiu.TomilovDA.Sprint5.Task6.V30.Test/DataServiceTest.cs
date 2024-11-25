using Tyuiu.TomilovDA.Sprint5.Task6.V30.Lib;
namespace Tyuiu.TomilovDA.Sprint5.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExists()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V30.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            Assert.IsTrue(exists);
        }

        [TestMethod]
        public void CheckValue()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V30.txt");
            DataService service = new DataService();
            int res = 0;
            Assert.AreEqual(service.LoadFromDataFile(path), service.LoadFromDataFile(path));
        }
    }
}