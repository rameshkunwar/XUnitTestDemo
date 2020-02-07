using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestDemo
{
   public class SamlingMappingProfile : Profile
    {
        public SamlingMappingProfile()
        {
            CreateMap<SamlingReadOnlyModel, SamlingDto>()
                .ForMember(model => model.SearchResultDto, conf => conf.MapFrom(model => model.SearchResultReadOnly));

            CreateMap<SearchResultReadOnly, SearchResultDto>();
        }
    }
}
