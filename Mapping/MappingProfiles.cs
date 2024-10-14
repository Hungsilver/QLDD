using AutoMapper;
using QLDD.Dtos.Response;
using QLDD.Models;

namespace QLDD.Mapping
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles() {
            CreateMap<User, UserDTORes>();
        }
    }
}
