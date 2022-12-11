using Challange.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Challange
{
   
    public partial class Websites : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strurltest = String.Format("https://jsonplaceholder.typicode.com/posts/1/comments");
            WebRequest requestObjGet = WebRequest.Create(strurltest);
            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();

            string strresulttest = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
                // txtValueA.Text = strresulttest;
            }

            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            List<Comment> objList = (List<Comment>)serializer.Deserialize(strresulttest, typeof(List<Comment>));


            foreach (Comment obj in objList)
            {

                int postId = obj.postId;
                int id = obj.id;
                string name = obj.name;
                string email = obj.email;
                string body = obj.body;



                txtValueB.Text = $"Post id is {postId}, the user id is {id}, the username is {name}, the email is {email} and the comment is {body}";

            }
        }
        }
    }
