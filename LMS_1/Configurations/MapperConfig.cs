using AutoMapper;
using LMS_1.Models;
using LMS_1.Data;

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
