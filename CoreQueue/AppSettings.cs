using BL.Atlas.Infrastructure.CoreQueue.Models;

namespace BL.Atlas.Infrastructure.CoreQueue
{
    public class AppSettings
    {
        //public const string HostName = "......"; 
        //public const string UserName = "rabbit";
        //public const string Password = "rabbit";

        // ö.a. aşağıdaki canlı makinasının bilgileri
#if DEBUG
        public const string HostName = ConnectKey.RabbitTest;
        public const string UserName = "rabbit";
        public const string Password = ConnectKey.RabbitDebugKey;
#else
        public const string HostName = ".......";
        public const string UserName = "admin";
        public const string Password = ConnectKey.RabbitReleaseKey;
#endif
    }
}
