using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace theYesCoinClaim.Controls
{
    public class Bots
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetAccountInfo()
        {
            try
            {
                // Tạo yêu cầu GET
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.yescoin.gold/account/getAccountInfo");

                // Thêm các tiêu đề vào yêu cầu
                request.Headers.Add("Accept", "application/json, text/plain, */*");
                request.Headers.Add("Accept-Encoding", "gzip, deflate, br, zstd");
                request.Headers.Add("Accept-Language", "vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5");
                request.Headers.Add("Origin", "https://www.yescoin.gold");
                request.Headers.Add("Priority", "u=1, i");
                request.Headers.Add("Referer", "https://www.yescoin.gold/");
                request.Headers.Add("Sec-Ch-Ua", "\"Google Chrome\";v=\"125\", \"Chromium\";v=\"125\", \"Not.A/Brand\";v=\"24\"");
                request.Headers.Add("Sec-Ch-Ua-Mobile", "?0");
                request.Headers.Add("Sec-Ch-Ua-Platform", "\"Windows\"");
                request.Headers.Add("Sec-Fetch-Dest", "empty");
                request.Headers.Add("Sec-Fetch-Mode", "cors");
                request.Headers.Add("Sec-Fetch-Site", "same-site");
                request.Headers.Add("Token", "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiI4NzUyMjU1MjEiLCJjaGF0SWQiOiI4NzUyMjU1MjEiLCJpYXQiOjE3MTYzNjIzMjcsImV4cCI6MTcxODk1NDMyNywicm9sZUF1dGhvcml6ZXMiOltdLCJ1c2VySWQiOjE3OTMxNzA1NTU1MDc5OTQ2MjR9.tZQk-A2ElG1KBbqGQWarb6u7ygGImd8oDTu_5J94rWGRZCnkhGkACmg6yzOVY1pzy1XIuByka7R_mjWF_JfRKg");
                request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36");

                HttpResponseMessage response = await client.SendAsync(request);

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
