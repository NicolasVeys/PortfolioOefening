using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Domain
{
    public class Project
    {
        public int Id { get; set; }
        public string title { get; set; }
        public int TagId { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public IList<ProjectTag> ProjectTags { get; set; }
    }
}
