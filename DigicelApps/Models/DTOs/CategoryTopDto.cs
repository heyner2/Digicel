using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigicelApps.Models.DTOs
{
    public class CategoryTopDto
    {
        public CategoryTopDto()
        {

        }
        public CategoryTopDto(string name,int count)
        {
            this.name = name;
            this.count = count;
        }
        public string name { get; set; }

        public int count { get; set; }
    }
}
