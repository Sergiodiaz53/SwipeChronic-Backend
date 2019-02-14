using System;
using AutoMapper;
using SwipeChronic.Models;
using SwipeChronic.ViewModel;

namespace SwipeChronic.Configuration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<QuestionViewModel, Question>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                .ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.Level));
        }
    }
}
