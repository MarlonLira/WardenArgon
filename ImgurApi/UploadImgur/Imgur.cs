using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UploadImgur
{
    public class Imgur
    {
        public string ClientId = "6910e68a72b635a";
        public string error { get; private set; }
        public string link { get; private set; }
        private string urlPost = "https://api.imgur.com/3/image";
        public Imgur(string clientId)
        {
            this.ClientId = clientId;
        }

        public Imgur()
        {

        }

        public bool UploadImages(string filePath)
        {
            if (!Helper.CheckFileExist(filePath))
            {
                error = "Wrong Path";
                return false;
            }

            string base64Image = Helper.Base64EncodeWithFile(filePath);
            string serverString = Upload(base64Image);
            return HandleServerString(serverString);
        }

        private string Upload(string base64Image)
        {
            string output = "{\"success\": false}";
            try
            {
                using (var w = new WebClient())
                {
                    var values = new NameValueCollection
                    {
                        {"image", base64Image},
                    };

                    w.Headers.Add("Authorization", "Client-ID " + ClientId);
                    byte[] response = w.UploadValues(urlPost, "POST", values);
                    output = Encoding.UTF8.GetString(response);
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    using (StreamReader reader = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        output = reader.ReadToEnd();
                    }
                }
                else
                {
                    output =
                        "{\"success\":false,\"data\":{\"error\":\"Server error\"}}";
                }
            }

            return output;
        }

        private bool HandleServerString(string serverString)
        {
            ImgurJson json = JsonConvert.DeserializeObject<ImgurJson>(serverString);
            if (!json.Success)
            {
                error = json.Data.Error.Message;
                return false;
            }
            else
            {
                link = json.Data.Link;
                return true;
            }
        }
    }
}
