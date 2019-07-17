using AutoMapper;

namespace Brspontes.Application.AutoMapper
{
    public partial class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
           {
               ps.AddProfile(new MappingsProfiles());
           });
        }
    }
}
