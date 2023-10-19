using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HaSdkWrapper.Api
{
    public class Client : IDisposable
    {
        public string IP { get; private set; }
        public int Port { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        private HttpClient _client;
        private bool disposedValue;

        public Client(string ip, int port = 8000)
        {
            IP = ip;
            Port = port;
        }

        private void BuildClient()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(string.Format("http://{0}:{1}/", IP, Port));

            if (UserName != null && Password != null)
            {
                var auth = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", UserName, Password)));
                _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", auth);
            }
        }


        public async Task<UploadPersonResponse> AddFaceAsync(string personID, string personName, int personRole, string picPath, uint wgNo, uint effectTime, uint effectstarttime, byte ScheduleMode, String userParam)
        {
            if (_client == null)
            {
                BuildClient();
            }

            var req = new UploadPersonRequest
            {
                id = personID,
                name = personName,
                role = personRole,
                kind = ScheduleMode,
                reg_image = Convert.ToBase64String(File.ReadAllBytes(picPath)),
                wg_card_id = (int)wgNo,
                term_start = effectstarttime.ToDateTime().ToString("yyyy/MM/dd HH:mm:ss"),
                term = effectTime == uint.MaxValue ? "never" : effectTime.ToDateTime().ToString("yyyy/MM/dd HH:mm:ss"),
                customer_text = string.IsNullOrEmpty(userParam) ? null : userParam,
            };

            var json = JsonConvert.SerializeObject(req);

            var resp = await _client.PostAsJsonAsync("", req);
            resp.EnsureSuccessStatusCode();
            return await resp.Content.ReadAsAsync<UploadPersonResponse>();

        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    _client?.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _client = null;
                disposedValue = true;
            }
        }


        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
