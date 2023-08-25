using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkWeb.Jwt
{
    public class Jwt
    { 
        public string Create(object model)
        {
            return "";
        }

        public bool IsValid(string token)
        {
            return false;
        }

        public object Payload(string token)
        {
            return null;
        }
    }
}
