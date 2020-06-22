using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class ProjectCreateViewModel
    {
        public int Id { get; set; }
        public string title { get; set; }
        public int TagId { get; set; }
        public int StatusId { get; set; }
        public List<SelectListItem> Statuses { get; set; }
        public IEnumerable<int> ProjectTags { get; set; }
        public List<SelectListItem> Tags { get; set; }
    }
}
