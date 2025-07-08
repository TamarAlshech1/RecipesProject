
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
    public class Recepi_BLL_Func : IRecepi_BLL
    {
        static IMapper _Mapper;
        IRecepi_DAL _IRecepi_DAL;
        //בנאי
        public Recepi_BLL_Func(IRecepi_DAL i)
        {
           _IRecepi_DAL=i;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfil>();
            });
            _Mapper = config.CreateMapper();
        }
        //פונקצית שליפה של כל המתכונים
        public List<RecepiTableDTO> getAllRecepis()
        {
            List<RecepiTablebad> ls = _IRecepi_DAL.getAllRecepis();
            return _Mapper.Map<List<RecepiTablebad>, List<RecepiTableDTO>>(ls);
        }
        //פונקצית שמקבלת מתכון ומוסיפה אותו מחזירה את קוד המתכון שנוסף
        public int addRecepis(RecepiTableDTO r)
        {
            RecepiTablebad newr = _Mapper.Map<RecepiTableDTO, RecepiTablebad>(r);
            _IRecepi_DAL.addRecepis(newr);
            return newr.Id;
        }
        //פונקצית שמקבלת קוד משתמש ומחזירה את המתכונים שלו
        public List<RecepiTableDTO> userCode_by_Get(int id)
        {
            List<RecepiTablebad> ls = _IRecepi_DAL.getAllRecepis();
            List<RecepiTablebad> lt = new List<RecepiTablebad>();
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].IdUser == id)
                {
                    lt.Add(ls[i]);
                }
            }
            List<RecepiTableDTO> re = _Mapper.Map<List<RecepiTablebad>, List<RecepiTableDTO>>(lt);
            return re;
        }


    }
}
