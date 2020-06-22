using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Portfolio.Domain
{
    public class Tag
    {
        public int Id { get; set; }
        public string title { get; set; }
        public IList<ProjectTag> ProjectTags { get; set; }

    }
}
