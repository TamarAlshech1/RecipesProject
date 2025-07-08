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
    public class EngrediensForRecepi_BLL_Func: IEngrediensForRecepi_BLL
    {
        static IMapper _Mapper;
        IEngrediensForRecepi_DAL _IEngrediensForRecepi_DAL;
        IEngrediens_DAL _IEngrediens_DAL;
        // EngrediensTable _EngrediensTable;

        // EngrediensTableForRecepi _EngrediensTableForRecepi;
        //בנאי
        public EngrediensForRecepi_BLL_Func(IEngrediensForRecepi_DAL i, IEngrediens_DAL j)
        {
            _IEngrediensForRecepi_DAL = i;
            _IEngrediens_DAL = j;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfil>();
            });
            _Mapper = config.CreateMapper();
        }


        //פונקציה שמקבלת קוד מתכון ושולפת את כל הרכיבים שלו
        public List<EngrediensTableForRecepiDTO> Get_by_idRecepi(int id)
        {
            //List<EngrediensTable> ls = new List<EngrediensTable>();
            List<EngrediensTableForRecepi> lt = _IEngrediensForRecepi_DAL.getAllEngrediensForRecepi().Where(k => k.IdRecepi == id).ToList();
            return _Mapper.Map<List<EngrediensTableForRecepi>, List<EngrediensTableForRecepiDTO>>(lt);
        }

        // פונקציה שמקבלת קוד מתכון ורשימת רכיבים
        //הוספת רכיבים
        public bool addEngrediensToRecepi(int idRecepi, List<EngrediensTableForRecepiDTO> list)
        {
            try
              {
                for (int i = 0; i < list.Count(); i++)
                {
                    if (list[i].IdEngrediens == 0)
                    {
                        EngrediensTable newEngrediens = new EngrediensTable() { NameEngrediens = list[i].EngrediensName };
                        int codei = _IEngrediens_DAL.addEngrediens(newEngrediens);
                        list[i].IdEngrediens = codei;
                    }
                    EngrediensTableForRecepi er = _Mapper.Map<EngrediensTableForRecepiDTO, EngrediensTableForRecepi>(list[i]);
                    _IEngrediensForRecepi_DAL.addIEngrediensForRecepi(er);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
