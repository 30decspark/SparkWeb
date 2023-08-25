using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SparkWeb.DotEnv
{
    public class DotEnv
    {
        public static void Load()
        {
            string file = Directory.GetParent(AppContext.BaseDirectory).FullName + "\\.env";
            if (!File.Exists(file)) return;
            string[] lines = File.ReadAllLines(file);
            var env = new ExpandoObject() as IDictionary<string, object>;
            foreach (string s in lines)
            {
                if (s.Trim() == string.Empty) continue;
                if (s.Trim().StartsWith("#")) continue;
                string[] sp = s.Split('=');
                if (sp.Length < 2) return;
                string key = sp[0];
                if (!Regex.IsMatch(key, "^[A-Z]+(_[A-Z]+)*$")) continue;
                string value = sp[1];
                env[key] = value;
            }
            process.env = env;
        }
    }
}
