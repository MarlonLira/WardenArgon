using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadImgur
{
    class Helper
    {
        public static string Base64EncodeWithFile(string filePath)
        {
            Byte[] bytes = File.ReadAllBytes(filePath);
            String content = Convert.ToBase64String(bytes);
            return content;
        }

        public static bool CheckFileExist(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}
