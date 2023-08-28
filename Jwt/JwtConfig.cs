using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkWeb.Jwt
{
    public class JwtConfig
    {
        public string Key { get; set; } = "your-256-bit-secret";
        public JwtAlgo Algo { get; set; } = JwtAlgo.HS256;
        public TimeSpan Expire { get; set; } = TimeSpan.FromDays(1);
    }
}
