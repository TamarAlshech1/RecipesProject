using AutoMapper;
using BLL.intrefaces;
using DAL.interfaces;
using DAL.models;
using DTO;
using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.functions
{
    public class Engrediens_BLL_Func: IEngrediens_BLL
    {
        static IMapper _Mapper;
        IEngrediens_DAL _IEngrediens_DAL;
        //בנאי
        public Engrediens_BLL_Func(IEngrediens_DAL i)
        {
            _IEngrediens_DAL = i;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfil>();
            });
            _Mapper = config.CreateMapper();
        }

        //פונקצית שליפה
        public List<EngrediensTableDTO> getAllIEngrediens()
        {
            List<EngrediensTable> ls = _IEngrediens_DAL.getAllIEngrediens();
            return _Mapper.Map<List<EngrediensTable>, List<EngrediensTableDTO>>(ls);
        }

        // פונקציה שמקבלת רכיב ומוסיפה אותו מחזירה את קוד הרכיב שנוסף
        public int addIEngrediens(EngrediensTableDTO e)
        {
            EngrediensTable newe = _Mapper.Map<EngrediensTableDTO, EngrediensTable>(e);
            _IEngrediens_DAL.addEngrediens(newe);
            return newe.IdEngrediens;
        }
    }
}
