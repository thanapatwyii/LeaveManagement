using AutoMapper;
using LMS_1.Data;
using LMS_1.Models;

namespace LMS_1.Configurations
{
    public class MapperConfig : Profile

    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
