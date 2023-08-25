using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkWeb.Jwt
{
    public class JwtConfig
    {
        private static string? _key;
        private static JwtAlgo? _algo;
        private static TimeSpan? _expire;

        public static string Key
        {
            get => _key ?? "your-256-bit-secret";
            set
            {
                if (_key == null) _key = value;
            }
        }

        public static JwtAlgo Algo
        {
            get => _algo ?? JwtAlgo.HS256;
            set
            {
                if (_algo == null) _algo = value;
            }
        }

        public static TimeSpan Expire
        {
            get => _expire ?? TimeSpan.FromDays(1);
            set
            {
                if (_expire == null) _expire = value;
            }
        }
    }
}
