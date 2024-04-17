using System.IO.Compression;
using System.Reflection.Metadata.Ecma335;

namespace ArchiveFolderLib
{
    public static class UtilExtensions
    {
        public static string FormatEnumerableToString(this IEnumerable<char> chars) =>
            chars.Aggregate("", (prev, ch) => $"{prev}{ch}");
        public static string PadNumber(this int number, int size) =>
            Enumerable.Repeat('0', size).Concat($"{number}").Reverse().Take(size).Reverse().FormatEnumerableToString();
        public static string FormatYear(this int year) =>
            year.PadNumber(4); 
        public static string FormatMillisMicros(this int millisOrMicros) =>
            millisOrMicros.PadNumber(3);
        public static string FormatOtherLargeDateUnit(this int unit) =>
           unit.PadNumber(2);
         public static string FormatDate(this DateTime datetime) =>
            $"{datetime.Year.FormatYear()}{datetime.Month.FormatOtherLargeDateUnit()}{datetime.Day.FormatOtherLargeDateUnit()}_{datetime.Hour.FormatOtherLargeDateUnit()}{datetime.Minute.FormatOtherLargeDateUnit()}{datetime.Second.FormatOtherLargeDateUnit()}.{datetime.Millisecond.FormatMillisMicros()}{datetime.Microsecond.FormatMillisMicros()}";
          public static string TimeStamp() => DateTime.Now.FormatDate();
         public static string NameWithTimeStamp(this string name,string? extension = null) => $"{name}_{TimeStamp()}" + (extension != null ? $".{extension}" : "");
    }
    public class Util
    {
        public static void ArchiveFolder(string dirPath,string zipPath)
        {
            if (new DirectoryInfo(dirPath) is DirectoryInfo dir &&  dir.Exists && ((dir.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                && new FileInfo(zipPath) is FileInfo file && file.Directory?.Exists is bool parent_exists && parent_exists & !file.Exists)
            { 
                ArchiveFolder(dir,file);
            }
        }
        public static void ArchiveFolder(DirectoryInfo dir,FileInfo zipFile)
        {
            using (var filestream = new FileStream(zipFile.FullName, FileMode.CreateNew, FileAccess.Write))
            {
                using (var zipArchive = new ZipArchive(filestream, ZipArchiveMode.Create))
                {
                    var zipEntry =zipArchive.CreateEntry(zipFile.Name + ".unsolid.zip");
                    using (var zipStream = zipEntry.Open())
                    {
                        ZipFile.CreateFromDirectory(dir.FullName, zipStream, CompressionLevel.NoCompression, true);
                    }
                }
            }                       
        }

        public static void BackupFolder(string dir)
        {

                ArchiveFolder(dir, dir.NameWithTimeStamp("zip"));
        }
        public static void BackupFolder(DirectoryInfo dir)
        {
            BackupFolder(dir.FullName);
        }

    }
}
