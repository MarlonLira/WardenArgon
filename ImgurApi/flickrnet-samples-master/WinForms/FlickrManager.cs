using System;
using System.Net;
using System.Windows;
using FlickrNet;

namespace WinForms
{
    public class FlickrManager
    {
        public const string ApiKey = "4c6cde1263f4ed841fa3d066e60711a3";
        public const string SharedSecret = "b9b3afa4ae91d46c";

        public static Flickr GetInstance()
        {
            System.IO.File.WriteAllText("token.txt", OAuthToken.Token + "\r\n" + OAuthToken.FullName + "\r\n" + OAuthToken.TokenSecret + "\r\n" + OAuthToken.UserId + "\r\n" + OAuthToken.Username);
            return new Flickr(ApiKey, SharedSecret);
        }

        public static Flickr GetAuthInstance()
        {
            var f = new Flickr(ApiKey, SharedSecret);
            f.OAuthAccessToken = OAuthToken.Token;
            f.OAuthAccessTokenSecret = OAuthToken.TokenSecret;
            return f;
        }

        public static OAuthAccessToken OAuthToken
        {
            get
            {
                return Properties.Settings.Default.OAuthToken;
            }
            set
            {
                Properties.Settings.Default.OAuthToken = value;
                Properties.Settings.Default.Save();
            }
        }

    }
}
