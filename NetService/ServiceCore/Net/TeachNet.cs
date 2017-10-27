using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;

namespace ServiceCore.Net
{
    public class TeachNet
    {
        private Uri BaseUri;
        private Uri ClassesUri;
        public string classinfo { get; set; }

        private string username;
        private string password;


        private string userstring;
        private HttpWebRequest webRequest;
        private HttpWebResponse webResponse;
        private Cookie JSESSIONID;
        private CookieCollection cookies;

        
        private Encoding gb2312;

        public TeachNet(string U, string P)
        {
            username = U;
            password = P;
        }

        public void Initialize()
        {
           // Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            gb2312 = Encoding.GetEncoding("gb2312");

            BaseUri = new Uri("http://zhjw.dlut.edu.cn/loginAction.do");
            ClassesUri = new Uri("http://zhjw.dlut.edu.cn/xkAction.do?actionType=6");
            userstring = "zjh=" + username + "&" + "mm=" + password;
            webRequest = (HttpWebRequest)WebRequest.Create(BaseUri);
            webRequest.CookieContainer = new CookieContainer();
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";

           
        }

        public async Task<string> ConnectAsync()
        {
            

                using (Stream RequsetStream = await webRequest.GetRequestStreamAsync())
                {
                    byte[] b = Encoding.UTF8.GetBytes(userstring);
                    RequsetStream.Write(b, 0, b.Length);

                }
                webResponse = (HttpWebResponse)await webRequest.GetResponseAsync();


                //Stream st = webResponse.GetResponseStream();
                // string str = new StreamReader(st, gb2312).ReadToEnd();

                foreach (Cookie ck in webResponse.Cookies)
                {
                    if (ck.Name == "JSESSIONID")
                        JSESSIONID = new Cookie("JSESSIONID", ck.Value);
                }
                cookies = new CookieCollection();
                cookies.Add(JSESSIONID);


                HttpWebRequest cl = (HttpWebRequest)WebRequest.Create(ClassesUri);
                cl.Method = "GET";
                cl.CookieContainer = new CookieContainer();
                cl.CookieContainer.Add(ClassesUri, JSESSIONID);

                cl.ContinueTimeout = 100;
                // cl.AllowReadStreamBuffering = true

                HttpWebResponse clr = (HttpWebResponse)await cl.GetResponseAsync();
                Stream ClassesStream = clr.GetResponseStream();
                classinfo = new StreamReader(ClassesStream, gb2312).ReadToEnd();
                return classinfo;
      

        }
    }
}
