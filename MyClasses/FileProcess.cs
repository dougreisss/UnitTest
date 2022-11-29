using System;
using System.IO;

namespace MyClasses.FileProcess
{
    public class FileProcess
    {
        public bool FileExists(string fileName)
        {
            if (String.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }

            return File.Exists(fileName);
        }
    }
}
