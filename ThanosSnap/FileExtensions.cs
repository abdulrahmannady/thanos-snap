using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

namespace ThanosSnap
{
    public static class FileExtentions
    {
        public static readonly string[] FILE_EXTENSIONS = FileManager.GetFileExtensions();

        public static bool BelongsTo(this FileInfo file)
        {
            return FILE_EXTENSIONS.Any(x => x == Path.GetExtension(file?.Name)) == true;
        }

        public static void SendToRecycleBin(this FileInfo file)
        {
            FileSystem.DeleteFile(file.FullName, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
        }

    }
}
