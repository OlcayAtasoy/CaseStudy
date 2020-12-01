using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Atlas.Infrastructure.CoreQueue.Models
{
    public class CrmModel
    {
        public int AccountId { get; set; }

        public bool isSendToCrm  { get; set; } = false;

        public bool Button { get; set; }

}
}
