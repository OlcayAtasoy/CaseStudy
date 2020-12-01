using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Atlas.Infrastructure.CoreQueue.Exception
{
    public class MongoLogException
    {
        public string Message { get; set; }

        public string StackTraceString { get; set; }

        public MongoLogException InnerException { get; set; }

        public string Source { get; set; }

        public string ClassName { get; set; }

        public List<string> MessageList { get; set; }
    }
}
