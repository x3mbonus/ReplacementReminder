using AutoMapper;
using ReplacementReminder.Data;
using ReplacementReminder.Models;

namespace ReplacementReminder.Mapping
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Photo, PhotoModel>().ReverseMap();
            CreateMap<ReplacementHistoryEntry, ReplacementHistoryEntryModel>().ReverseMap();
            CreateMap<ReplacementItem, ReplacementItemModel>().ReverseMap();
        }
    }
}
