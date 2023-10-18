
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace huaanClient.Api
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


        public async Task<T> Post<R, T>(R data)
        {

            if (_client == null)
            {
                BuildClient();
            }



            var resp = await _client.PostAsJsonAsync("", data);

            return default(T);
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
