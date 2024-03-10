namespace pattern_singleton.Data
{
    public class Config
    {
        private static Config _instance;
        private string _host;
        private string _port;

        private Config() { }
     
        public static Config GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Config();
            }
            return _instance;
        }

        public void SetHost(string host)
        {
            _host = host;
        }

        public void SetPort(string port)
        {
            _port = port;
        }
        public override string ToString()
        {
            return $"Server Address: {_host}, Port: {_port}";
        }
    }
}
