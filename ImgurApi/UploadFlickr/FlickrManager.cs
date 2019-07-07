using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlickrNet;

namespace UploadFlickr
{
    public class FlickrManager
    {
        public const string ApiKey = "4c6cde1263f4ed841fa3d066e60711a3";
        public const string SharedSecret = "b9b3afa4ae91d46c";

        public static Flickr GetInstance()
        {
            return new Flickr(ApiKey, SharedSecret);
        }

        public static Flickr GetAuthInstance()
        {
            var f = new Flickr(ApiKey, SharedSecret);
            f.OAuthAccessToken = OAuthToken.Token;
            f.OAuthAccessTokenSecret = OAuthToken.TokenSecret;
            return f;
        }

        public static OAuthAccessToken OAuthToken = new OAuthAccessToken()
        {
            //Token = "72157704118884185-b49661def8ffeef3", FullName = "Goose Capital", TokenSecret = "3e7eda63e4f9f684",
            //UserId = "166348236@N06", Username = "goosecapital"
            Token = "72157677911711977-3e979721831c4ea5",
            TokenSecret = "0893ae08d67c16d5",
            UserId = "163456694@N06", FullName = "Oskar O. Jensen", Username = "goose-spotify"
        };

    }
}
