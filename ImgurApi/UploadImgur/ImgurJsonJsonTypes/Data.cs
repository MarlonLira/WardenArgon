using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UploadImgur.ImgurJsonJsonTypes;

namespace UploadImgur.ImgurJsonJsonTypes
{

    public class Data
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public object Title { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("datetime")]
        public int Datetime { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("animated")]
        public bool Animated { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }

        [JsonProperty("bandwidth")]
        public int Bandwidth { get; set; }

        [JsonProperty("vote")]
        public object Vote { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("nsfw")]
        public object Nsfw { get; set; }

        [JsonProperty("section")]
        public object Section { get; set; }

        [JsonProperty("account_url")]
        public object AccountUrl { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("is_ad")]
        public bool IsAd { get; set; }

        [JsonProperty("in_most_viral")]
        public bool InMostViral { get; set; }

        [JsonProperty("has_sound")]
        public bool HasSound { get; set; }

        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        [JsonProperty("ad_type")]
        public int AdType { get; set; }

        [JsonProperty("ad_url")]
        public string AdUrl { get; set; }

        [JsonProperty("in_gallery")]
        public bool InGallery { get; set; }

        [JsonProperty("deletehash")]
        public string Deletehash { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("error")]
        public Error Error { get; set; }

        [JsonProperty("request")]
        public string Request { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }
    }

}
