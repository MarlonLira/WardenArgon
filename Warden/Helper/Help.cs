using System;
using System.Web;

namespace Warden.Helper {
    public static class Help {

        public static String FormatUrl(String Url) {
            String Result = (HttpContext.Current.Request.Url.Authority + @"/" + Url.Replace(@"~/", @"/"));
            while (Result.IndexOf(@"//") > -1) {
                Result = Result.Replace(@"//", @"/");
            }
            return HttpContext.Current.Request.Url.Scheme + @"://" + Result;
        }


        public static String WordCheck(String Word) {
            String WordType = "";

            foreach (Char Letter in Word.ToCharArray()) {

                if (Char.IsNumber(Letter)) {
                    if (WordType == "Number" || String.IsNullOrEmpty(WordType)) {
                        WordType = "Number";
                    } else {
                        WordType = "Erro";
                        break;
                    }
                }
                if (Char.IsLetter(Letter) && !Char.IsSymbol(Letter)) {
                    if (WordType == "Letter" || String.IsNullOrEmpty(WordType)) {
                        WordType = "Letter";
                    } else {
                        WordType = "Erro";
                        break;
                    }
                }
            }

            return WordType;
        }
    }
}