using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Data.SqlClient;
using System.Web;

namespace ClinicSoft.Utilities
{
    public class AuthenticateUser
    {
        //static readonly HttpClient client = new HttpClient();




        public static async Task<string> AuthLogin(string username, string password)
        {
            string message = "";

            var client =  new RestClient("https://mail.waec.org.ng/owa/auth.owa");
            //client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            client.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko";
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Cookie", "X-BackEndCookie=S-1-5-21-2210914853-1348094456-3247505572-20284=u56Lnp2ejJqBnM6bzMvInMrSzZ6cxtLLnseZ0p3Kzc7Sm8ucmcvMxs7JmpnNgYHNz83N0s/M0s3Lq87KxczLxc/I; ClientId=CE83D590A3144A268D9C8C925B3B2188; UC=9f5fec4224da437fb34c51705580ccc5; X-OWA-CANARY=UDA7mdvfj0m1_C3KxrNuytDnRHoY9tkIhffVjodZ8NRKCrdQw50HVsH89eTAFXcNGfh9ESzVFN4.; cadata=1KoRP1YZQBSXxZI7sBsKecS+lLQWHZpCJFjk84te/J9laSnhsPlrlDI+29gziRj0kRr4QNYYfQpRZ/0GpxvyV77Ie+Z8AGalcUf4n+z0oZcJjjow5e2FZYCQYOx6bqodqccZ2GKB+ZYFPDaNs5BZ1Q==; cadataIV=Y5Y6OwZ4ENOT1/ahjXROe56gWIirvKPbsM1r8/Cv0Tstks9dDhwO1UlcsHgOxvHGOJnf1qjpAQpSqDsm5AZknttoD35SfVZW/5p98xwjXPStZhy0pNdqadz8/p0SxQVSagfSJ0CocOXr2FE+grRIKFZTb7syu1M/8ZEFRFOzCfh/dJL0z2TtOZ938QOF+Uu682cH9Tg4ZUDommdOZ6lyOWW1MLplaCiG/+EU4Rc0dKKIZh8ZHryOmX84KHCj7k4LweYo0Amgzxl0kVjkXRxnFlr18noukd81X5UDyYT84acWDTYPNQgKlPCD6saaLnhtu0AaWs39wSIxaNTni575Bw==; cadataKey=EDji9SmjpxKr5omoaSwKF6BTUSrxPihhUMNW8OIYClUnJdSgkT/3datzebdlMiScJGANsD/6zta/Ba0qsTfHzGqX2dbKKw6FOiINhkdH4w2IXnz09CDYf4dGTMxtNtp2kt4pwPYT9g7rRzty0SNqvzJXtP4V8W70VdMmP8nC1wIO3QSUR31++QjYgOk53hAQJ9wiVnc6jNOc8UthxaNkROVefgBIZasea83KgLzT61uO4GTZlHxsCVnMJYHHF0ne6DecSGYt95jsW8oA2SIzK1cCC51CmqQuJ/OKOl9hBHS3iGiJxLemx0zmY4raQMw4uHJs2qrM8tkDGj8b+Xpc1w==; cadataSig=i45Y+jI6UcJiXeFckKtFvsgKUvHtOugpF3mtHhCtQ84=; cadataTTL=hVqIFjoIQeTxD2gXXLf87g==");
            request.AddParameter("destination", "https://mail.waec.org.ng");
            request.AddParameter("flags", "4");
            request.AddParameter("username", username);
            request.AddParameter("password", password);
            IRestResponse response =  client.Execute(request);
            message = response.Content;


            //Console.WriteLine(response.Content);
            return message;
        }

    }
}