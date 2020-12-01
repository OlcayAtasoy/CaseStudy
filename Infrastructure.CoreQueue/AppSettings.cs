using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CoreQueue
{
    public class AppSettings
    {

#if DEBUG
        public const string HostName = "rabitservername";
        public const string UserName = "rabbit";
        public const string Password = "rabbit";
#else
        public const string HostName = "rabitservernameprod";
        public const string UserName = "admin";
        public const string Password = "admin";
#endif
    }
}
