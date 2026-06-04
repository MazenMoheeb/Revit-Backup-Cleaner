using System;
using System.IO;
using System.Reflection;
using Microsoft.Toolkit.Uwp.Notifications;

namespace RevitBackupCleaner
{
    internal class Program
    {
        #region Helping Functions
        /// <summary>
        /// Get a valid path from the user to search for Revit backup files,
        /// if the provided path is not valid, it will keep asking the user until a valid path is provided.
        /// </summary>
        /// <returns>A valid directory path provided by the user.</returns>
        static string Pth()
        {
            Console.WriteLine("Please, Enter A Path");
            string path = Console.ReadLine();
            while (!Directory.Exists(path))
            {
                Console.WriteLine("Provided Path Does Not Exist, Please Enter A Valid Path");
                path = Console.ReadLine();
            }
            return path;
        }

        #endregion

        static void Main(string[] args)
        {

            string path = Pth();
            int FileCount = 0;
            double TotalBytes = 0;
            foreach (string file in Directory.EnumerateFiles(path, "*.00??.*", SearchOption.AllDirectories))
            {
                string ex = Path.GetExtension(file).ToLower();
                if (ex == ".rvt" || ex == ".rfa" || ex == ".rte")
                {
                    FileInfo fi = new FileInfo(file);
                    TotalBytes += fi.Length;
                    try
                    {
                        File.Delete(file);
                        FileCount++;
                    }
                    catch { }
                }
            }
            ToastContentBuilder Notfi = new ToastContentBuilder();
            Notfi.AddText("Revit Backup Cleaner");
            if (FileCount != 0)
            {
                if (TotalBytes >= 1073741824)
                {
                    Notfi.AddText($"Total Revit Backup Files Number Deleted: ({FileCount}) With Size = {TotalBytes / 1073741824:F3} GB");
                }
                else if (TotalBytes >= 1048576)
                {
                    Notfi.AddText($"Total Revit Backup Files Number Deleted: ({FileCount}) With Size = {TotalBytes / 1048576:F3} MB");
                }
                else if (TotalBytes >= 1024)
                {
                    Notfi.AddText($"Total Revit Backup Files Number Deleted: ({FileCount}) With Size = {TotalBytes / 1024:F3} KB");
                }
                else
                {
                    Notfi.AddText($"Total Revit Backup Files Number Deleted: ({FileCount}) With Size = {TotalBytes} Bytes");
                }
            }
            else
            {
                Notfi.AddText("There Is No Revit Backup File In The Provided Path");
            }
            string imageP = Path.GetFullPath(".\\Mazen Moheeb.png");
            if (File.Exists(imageP))
            {
                Notfi.AddInlineImage(new Uri(imageP));
            }

            Notfi.Show();
        }
    }
}
