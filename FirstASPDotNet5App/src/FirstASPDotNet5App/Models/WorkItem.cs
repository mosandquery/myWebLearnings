using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPDotNet5App.Models
{
    public class WorkItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public WorkItemTypes WorkItemType { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public string UpdateddBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public string AssignedTo { get; set; }

        public Child[] LinkedWorkItems { get; set; }

    }
}
