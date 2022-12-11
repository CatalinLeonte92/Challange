using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challange
{
    public partial class Scan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebRequest wReq = WebRequest.Create("https://www.listafirme.ro/contact.asp");
            WebResponse mRes = wReq.GetResponse(); 
            StreamReader sr = new StreamReader(mRes.GetResponseStream());   
            string sHTML = sr.ReadToEnd();
            sr.Close();

            if(sHTML != string.Empty && sHTML != null)
            {
                const string PATTERN = @"a href=""https://wa.me/[0-9]*""";
                Regex regex = new Regex(PATTERN, RegexOptions.IgnoreCase);
                
                MatchCollection MC = regex.Matches(sHTML);  

                foreach(Match m in MC) {
                    txtValueB.Text = m.Value;
                   
                }
               
            }
        }

       

    }
}