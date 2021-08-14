using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigicelApps.Models.DTOs
{
    public class ApplicationDetailDto
    {
        public ApplicationDetailDto(int id, string name, String Description, String Deparment, String Category, String owner)
        {
            this.Id = id;
            this.Name = name;
            this.Description = Description;
            this.Deparment = Deparment;
            this.Category = Category;
            this.Owner = owner;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Deparment { get; set; }
        public string Category { get; set; }
        public string Owner { get; set; }
    }
}
