using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigicelApps.Models.DTOs.MapperProfiles
{
    public class ApplicationProfile: Profile
    {
        public ApplicationProfile()
        {
            this.CreateMap<Application, ApplicationCreationDto>().ReverseMap();
            this.CreateMap<Application, ApplicationDetailDto>().ReverseMap();
            this.CreateMap<Category, CategoryCreationDto>().ReverseMap();
        }
    }
}
