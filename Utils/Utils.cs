using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SparkWeb.Utils
{
    public class Utils
    {
        public static string GetPath()
        {
            return Directory.GetParent(AppContext.BaseDirectory).FullName;
        }

        public static string GetShellName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "cmd.exe";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return "zsh";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return "bash";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
            {
                return "tcsh";
            }
            else
            {
                throw new PlatformNotSupportedException("Unsupported operating system.");
            }
        }
    }
}
