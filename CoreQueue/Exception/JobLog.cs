using System;
using System.Collections.Generic;
using System.Text;
using BL.Atlas.Infrastructure.CoreQueue.Exception;

namespace BL.Atlas.Logs
{
    public class JobLog
    {

        public DateTime CreateDate { get; private set; }

        public string JobName { get; private set; }

        public JobLog Name(string jobName)
        {
            this.JobName = jobName;
            return this;
        }
        public JobLog Date(DateTime createDate)
        {
            this.CreateDate = createDate;
            return this;
        }

        public MongoLogException Exception { get; private set; }

        public JobLog Ex(MongoLogException ex)
        {
            this.Exception = ex;
            return this;
        }

        

    }
}
