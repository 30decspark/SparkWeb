using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkWeb.Jwt
{
    public class Jwt
    {
        private static JwtConfig _config;
        public static void Config(Action<JwtConfig> configure)
        {
            _config = new JwtConfig();
            configure(_config);
        }
    }
}
