using System;
using System.Collections.Generic;
using System.Text;

namespace _04._WorkForce.Models
{
    public class JobList : List<Job>
    {
        public void AddJob(Job job)
        {
            this.Add(job);
            job.JobCompleted += this.OnJobComplete;
        }
        public void OnJobComplete(Job job)
        {
            this.Remove(job);
        }
    }
}
