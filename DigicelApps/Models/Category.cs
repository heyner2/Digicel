using System;
using System.Collections.Generic;

#nullable disable

namespace DigicelApps.Models
{
    public partial class Category
    {
        public Category()
        {
            Applications = new HashSet<Application>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
    }
}
