using AutoMapper;
using Cards.DataAccess;

namespace Cards.Front.Model
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Session, SessionModel>();
        }
    }
}
