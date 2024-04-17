namespace ArchiveFolderTests
{
    [TestClass]
    public class ArchiveFolderTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Task.WhenAll(
            Task.Run(async () => { await Task.Yield(); ArchiveFolderLib.Util.BackupFolder("D:\\devx\\source\\repos\\BoxCode2.git"); }),
            Task.Run(async () => { await Task.Yield(); ArchiveFolderLib.Util.BackupFolder("D:\\devx\\source\\repos\\BoxCode2"); })
            ).Wait();
        }
    }
}