﻿using AutoMapper;
using DB;


namespace WPF_SUSUERTE_V1.Domain.Utils
{
    public class ObjMapper
    {
        // Patron de Diseño Singleton
        private static IMapper? _instance;

        private ObjMapper() { }

        public static IMapper Instance
        {
            get
            {
                if (_instance == null)
                {
                    var mapperConfig = new MapperConfiguration(mc => mc.AddProfile(new MappingProfile()));
                    _instance = mapperConfig.CreateMapper();
                }
                return _instance;
            }
        }

    }

    internal class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<DB_Transaction, TransactionDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdApi));

            CreateMap<TransactionDto, DB_Transaction>()
                .ForMember(dest => dest.IdApi, opt => opt.MapFrom(src => src.Id));

            CreateMap<DB_TransactionDetail, TransactionDetailDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdApi));
            CreateMap<TransactionDetailDto, DB_TransactionDetail>()
                .ForMember(dest => dest.IdApi, opt => opt.MapFrom(src => src.Id));
        }
    }
}
