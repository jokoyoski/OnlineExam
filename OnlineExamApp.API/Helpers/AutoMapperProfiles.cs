using System.Collections.Generic;
using AutoMapper;
using OnlineExamApp.API.Dto;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles(){
            CreateMap<IQuestion, IQuestionForDisplay>();
            CreateMap<ICategory, ICategoryForDisplayDto>();
            CreateMap<IOption, IOptionsForDisplay>();
            CreateMap<UserForRegisterDto, User>();

            CreateMap<IEnumerable<IQuestion>, IEnumerable<IQuestionForDisplay>>();
            CreateMap<IEnumerable<IOption>, IEnumerable<IOptionsForDisplay>>();
            CreateMap<IEnumerable<ICategory>, IEnumerable<ICategoryForDisplayDto>>();

        }
    }
}