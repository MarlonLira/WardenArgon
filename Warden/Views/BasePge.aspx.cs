using System;
using System.Web.UI;

namespace Warden.Views {
    public partial class BasePge : Page {

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            if (Global.Funcionario == null & Global.Aluno == null) {
                Session["Error"] = "Sua Conexão Expirou!";
                Response.Redirect("~/Views/Login.aspx", false);
            }
            /*if (Global.Aluno == null) {
                Response.Redirect("~/Views/Default.aspx", false);
            }*/

            #region AutoCrypto

            if (Session["Key"] != null && Session["IV"] != null) {
                Key = (Byte[])Session["Key"];
                IV = (Byte[])Session["IV"];

            } else {
                Session.Add("Key", Helper.Help.Crypto.GenerateRandomNumber(8));
                Session.Add("IV", Helper.Help.Crypto.GenerateRandomNumber(8));
            }

            #endregion

        }

        #region CryptoKeys
        public Byte[] Key;
        public Byte[] IV;
        #endregion

        #region EncryptionMethods
        public String Encryt(String ToEncrypt) {
            String Encrypted = "";
            try {
                Encrypted = Helper.Help.Crypto.Encrypt(ToEncrypt, Key, IV);
            } catch (Exception Err) {
                throw new Exception(Err.Message +  " " + Err.InnerException);
            }
            return Encrypted;
        }

        public String Decryt(String ToDecrypt) {
            String Decrypted = "";
            try {
                Decrypted = Helper.Help.Crypto.Encrypt(ToDecrypt, Key, IV);
            } catch (Exception Err) {
                throw new Exception(Err.Message + " " + Err.InnerException);
            }
            return Decrypted;
        }
        #endregion
    }
}