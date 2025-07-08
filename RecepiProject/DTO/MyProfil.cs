using AutoMapper;
using DAL.models;
using DTO.repository;
//using RecepiProject.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MyProfil : Profile
    {
        public MyProfil()
        {
            //CreateMap<EngrediensTableForRecepi, EngrediensTableForRecepiDTO>().ForMember(x => x.EngrediensName, j => j.MapFrom(h => h.IdEngrediensNavigation.Name));

            CreateMap<EngrediensTableForRecepi, EngrediensTableForRecepiDTO>().ForMember(x => x.EngrediensName, j => j.MapFrom(h => h.IdEngrediensNavigation.NameEngrediens));

            CreateMap<EngrediensTableForRecepiDTO, EngrediensTableForRecepi>();

            CreateMap<EngrediensTable, EngrediensTableDTO>();
            CreateMap<EngrediensTableDTO, EngrediensTable>();

            CreateMap<RecepiTableDTO, RecepiTablebad>();
            CreateMap<RecepiTablebad, RecepiTableDTO>().ForMember(x => x.IdUser, j => j.MapFrom(h => h.IdUserNavigation.Id))
                .ForMember(x => x.Name, j => j.MapFrom(h => h.IdUserNavigation.Name))
                .ForMember(x => x.Fname, j => j.MapFrom(h => h.IdUserNavigation.Fname))
                .ForMember(x => x.Email, j => j.MapFrom(h => h.IdUserNavigation.Email))
                .ForMember(x => x.Password, j => j.MapFrom(h => h.IdUserNavigation.Password));

            CreateMap<UserTableDTO, UserTable>();
            CreateMap<UserTable, UserTableDTO>();
        }
    }
}
