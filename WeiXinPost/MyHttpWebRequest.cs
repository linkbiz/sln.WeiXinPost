using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Web;
using System.Text;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace WeiXinPost
{
    /**//// <summary>
    /// HttpWeb请求管理。
    /// </summary>
    public class MyHttpWebRequest
    {
        /**//// <summary>
        /// 保存网站Cookie。
        /// </summary>
        private string m_cookieheader;

        /// <summary>
        /// 保存引用地址
        /// </summary>
        private string m_Referer = string.Empty;

        private HttpStatusCode m_Status = HttpStatusCode.OK;


        /**//// <summary>
        /// 页面请求超时限制。
        /// </summary>
        private int TIMEOUT = 60000;
        
        /// <summary>
        /// 设置引用URL
        /// </summary>
        /// <param name="url"></param>
        public void SetReferer(string url)
        {
            m_Referer = url;
        }

        /// <summary>
        /// 设置最长连接时间
        /// </summary>
        /// <param name="seconds">秒</param>
        public void SetTimeOut(int seconds)
        {
            TIMEOUT = seconds * 1000;
        }

        /// <summary>
        /// 设置引用URL
        /// </summary>
        /// <param name="url"></param>
        public HttpStatusCode GetStatusCode
        {
            get { return m_Status; }
        }

        public MyHttpWebRequest()
        {
            //
            // 构造函数逻辑
            //
            this.m_cookieheader = "";
        }

        /**//// <summary>
        /// 断开，清除Cookie。
        /// </summary>
        public void Disconnect()
        {
            this.m_cookieheader = "";
        }

        /**//// <summary>
        /// 登录，记录会话。
        /// </summary>
        public string Login(String url, NameValueCollection paramList, System.Text.Encoding wideCharEncoding)
        {
            return getPage(url, paramList, wideCharEncoding, "POST", true);
        }

        /**//// <summary>
        /// Form提交方式获取响应数据。
        /// </summary>
        public string post(String url, NameValueCollection paramList, System.Text.Encoding wideCharEncoding) 
        {
            return getPage(url, paramList, wideCharEncoding, "POST", false);
        }

   

        /**//// <summary>
        /// Get方式获取响应数据。
        /// </summary>
        public string getPage(String url) 
        {
            return getPage(url, null, null, "GET", false);
        }

        /**//// <summary>
        /// Get方式获取响应数据。
        /// </summary>
        public byte[] getPageData(String url, bool doSetCookie)
        {
            return getPageBytes(url, null, null, "GET", doSetCookie);
        }
        
        private string getPage(String url, NameValueCollection paramList, System.Text.Encoding wideCharEncoding, string method, bool doSetCookie) 
        {
            return System.Text.Encoding.UTF8.GetString(getPageBytes(url, paramList, wideCharEncoding, method, doSetCookie));
           // return System.Text.Encoding.Default.GetString( getPageBytes(url, paramList, wideCharEncoding, method, doSetCookie) );
        }

       
        private byte[] getPageBytes(String url, NameValueCollection paramList, System.Text.Encoding wideCharEncoding, string method, bool resetCookie) 
        {
            HttpWebResponse res = null;
            System.Collections.ArrayList result = new System.Collections.ArrayList(5000);

            try 
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
               // req.UserAgent = "Mozilla/5.0 (Windows NT 5.2; rv:10.0) Gecko/20100101 Firefox/10.0";
                req.AllowAutoRedirect = false;
                req.Method = method;
                //req.KeepAlive = true;
               // req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
               // req.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
                //req.Headers.Add(HttpRequestHeader.AcceptCharset, "GB2312,utf-8;q=0.7,*;q=0.7");
               // req.ContentType = "application/x-www-form-urlencoded";
              //  req.CookieContainer = new CookieContainer();
               // req.CookieContainer.SetCookies(new Uri(url), this.m_cookieheader);
                req.Timeout = TIMEOUT;
               // if (m_Referer != string.Empty)
               //     req.Referer = this.m_Referer;

                //上行方式时，设置参数
                if(method.ToUpper() != "GET")
                {
                    StringBuilder UrlEncoded = new StringBuilder();
                    Char[] reserved = {'?', '=', '&'};
                    byte[] SomeBytes = null;

                    if (paramList != null) 
                    {
                        System.Text.StringBuilder paramBuilder = new System.Text.StringBuilder();
                        String paramstr = null;
                        for(int li=0; li<paramList.Keys.Count; li++)
                        {
                            if(li > 0)
                            {
                                    paramBuilder.Append("&");
                            }
                            if (paramList.Keys[li] != "")
                            {
                                paramBuilder.Append(paramList.Keys[li]);
                                paramBuilder.Append("=");
                            }
                            paramBuilder.Append(paramList[paramList.Keys[li]]);
                        }

                        paramstr = paramBuilder.ToString();
                        
                        //int i=0, j;
                        //while(i<paramstr.Length)
                        //{
                        //    j=paramstr.IndexOfAny(reserved, i);
                        //    if (j==-1)
                        //    {
                        //        UrlEncoded.Append(HttpUtility.UrlEncode(paramstr.Substring(i, paramstr.Length-i), wideCharEncoding ));
                        //        break;
                        //    }
                        //    UrlEncoded.Append(HttpUtility.UrlEncode(paramstr.Substring(i, j-i), wideCharEncoding));
                        //    UrlEncoded.Append(paramstr.Substring(j,1));
                        //    i = j+1;
                        //}
                        SomeBytes = Encoding.UTF8.GetBytes(paramstr);

                        req.ContentLength = SomeBytes.Length;
                        Stream newStream = req.GetRequestStream();
                        newStream.Write(SomeBytes, 0, SomeBytes.Length);
                        newStream.Close();
                    } 
                    else 
                    {
                        req.ContentLength = 0;
                    }
                }


                //请求响应
                res = (HttpWebResponse)req.GetResponse();
                m_Status = res.StatusCode;
                if(resetCookie)
                {
                    this.m_cookieheader = req.CookieContainer.GetCookieHeader(new Uri(url));
                }

                Stream ReceiveStream = res.GetResponseStream();
                
                System.IO.BinaryReader sr = null;
                if(res.ContentEncoding == "gzip")
                {
                    GZipStream stream = new GZipStream(ReceiveStream, CompressionMode.Decompress);

                     sr =  new BinaryReader(stream);
                }
                else
                    sr = new BinaryReader(ReceiveStream);

                //读取数据
                
                
                byte[] read = new byte[256];
                int count = sr.Read( read, 0, 256 );
                while (count > 0) 
                {
                    result.AddRange( GetSubBytes(read, 0, count) );
                    count = sr.Read(read, 0, 256);
                }

              

            } 
            catch (Exception ex)
            {
                string tmp =  ex.Message;
                result.Clear();
            } 
            finally 
            {
                if ( res != null ) 
                {
                    res.Close();
                }
            }

            return (byte[])result.ToArray(typeof(byte));
        }

        private byte[] GetSubBytes(byte [] buffer, int index, int count)
        {
            if ( (count+index)>buffer.Length ) 
            {
                count = buffer.Length-index;
            }
            System.IO.MemoryStream s = new System.IO.MemoryStream(buffer, index, count);
            return s.ToArray();
        }
    }
}


