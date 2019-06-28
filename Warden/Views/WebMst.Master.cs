using System;
using System.Web;
using System.Web.UI;

namespace Warden.Views {
    public partial class WebMst : MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
           /* if (Global.Funcionario == null & Global.Aluno == null) {
                Response.Redirect("~/Views/Login.aspx", false);
            }*/
        }

        public String Usuario() {
            return (Global.Funcionario != null ? Global.Funcionario.Nome : "");
        }

        public String FormatUrl(String Url) {
            String Result = (HttpContext.Current.Request.Url.Authority + @"" + Url.Replace(@"~/", @"/"));
            while (Result.IndexOf(@"//") > -1) {
                Result = Result.Replace(@"//", @"/");
                Result = Result.Replace(@"../", @"/");
                Result = Result.Replace(@"./", @"/");
            }
            return HttpContext.Current.Request.Url.Scheme + @"://" + Result;
        }
    }
}