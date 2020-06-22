using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Domain
{
    public class Status
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
