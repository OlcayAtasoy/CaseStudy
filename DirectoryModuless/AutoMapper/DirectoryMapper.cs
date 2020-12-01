using AutoMapper;
using DirectoryModules.RequestModels;
using Infrastructure.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryModules.AutoMapper
{
    public class DirectoryMapper : Profile
    {
        public DirectoryMapper()
        {
            CreateMap<DirectionCreateRequestModel, Directory>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<CommunicationInformationRequestModel, CommunicationInformation>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ReverseMap();
        }

    }
}
