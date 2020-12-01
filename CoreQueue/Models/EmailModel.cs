using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BL.Atlas.Infrastructure.CoreQueue.Models
{
    public class EmailModel
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string ReplyTo { get; set; }
        public IList<string> Bcc { get; set; }
        public IEnumerable<string> Cc { get; set; }
        public string AttachmentFilePath { get; set; }
        public List<ReportStream> ReportStreamList { get; set; }
        public IDictionary<string, string> Headers { get; set; }
        public List<LinkedResourcesInBody> LinkedResourcesInBodyList { get; set; } = null;
    }


    public class ReportStream
    {
        public MemoryStream AttachmentFileStream { get; set; }
        public string FileName { get; set; } // AttachmentFileStream kullanıldığında kullanılmalıdır.
    }

    public class LinkedResourcesInBody
    {
        public string FileName { get; set; }
        public byte[] Data { get; set; }
        public MimeKit.ContentType ContentType { get; set; }
    }
}

