using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commander.Utilities
{
    public class UtlFile
    {
        public bool CreateAndWrite(string path, string content)
        {
            //success flag
            bool isSuccess = false;

            //create directory if not exist
            if(!Directory.Exists(path)) Directory.CreateDirectory(Path.GetDirectoryName(path));

            //delete file if exist
            if (File.Exists(path)) File.Delete(path);

            using (FileStream fileStream = File.Create(path))
            {
                //convert string content to byte array
                byte[] tbiContent = new UTF8Encoding(true).GetBytes(content);

                //write to file
                fileStream.Write(tbiContent, 0, tbiContent.Length);
            }

            //set success flag
            isSuccess = true;

            return isSuccess;
        }

        public string Read(string path)
        {
            string fileContent = "";

            //make sure file is exist
            if (!File.Exists(path)) return fileContent;

            //read all file content in one string
            fileContent = File.ReadAllText(path);

            return fileContent;
        }
    }
}
