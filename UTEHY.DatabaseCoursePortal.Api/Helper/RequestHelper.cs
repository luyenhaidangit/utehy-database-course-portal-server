using System.Net;
using System.Text;

namespace UTEHY.DatabaseCoursePortal.Api.Helper
{
    public class RequestHelper
    {
        public static String PerformRequest(String uri, String contentType = "", String method = "GET", String body = "", Dictionary<string, string> headers = null, int timeout = 30000)
        {
            if (String.IsNullOrEmpty(uri)) throw new ArgumentNullException("uri");

            var request = WebRequest.Create(uri);
            request.Method = method;
            request.Timeout = timeout;
            if (headers != null)
            {
                foreach (var key in headers.Keys)
                {
                    request.Headers.Add(key, headers[key]);
                }
            }


            if (!string.IsNullOrEmpty(contentType))
            {
                request.ContentType = contentType;
            }

            var bytes = Encoding.UTF8.GetBytes(body ?? "");
            if (request.Method != "GET" && bytes.Length > 0)
            {
                request.ContentLength = bytes.Length;
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
            }

            try
            {
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    if (stream == null) return null;
                    using (var readStream = new StreamReader(stream))
                    {
                        return readStream.ReadToEnd();
                    }
                }
            }
            catch (WebException)
            {
                request.Abort();
                throw;
            }
        }
    }
}
