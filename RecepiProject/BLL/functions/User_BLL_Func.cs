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
    public class User_BLL_Func: IUser_BLL
    {
        static IMapper _Mapper;
        IUser_DAL _IUser_DAL;
        //בנאי
        public User_BLL_Func(IUser_DAL i)
        {
            _IUser_DAL = i;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfil>();
            });
            _Mapper = config.CreateMapper();
        }
        //פונקצית שמחזירה רשימה של כל המשתמשים
        public List<UserTableDTO> getAllUser()
        {
            List<UserTable> ls = _IUser_DAL.getAllUser();
            return _Mapper.Map<List<UserTable>, List<UserTableDTO>>(ls);
        }
        //null מקבלת מייל וסיסמא ומחזירה משתמש בודד אם לא מחזירה
        public UserTableDTO GetUserByMailAndPassword(string mail, int password)
        {
            List<UserTable> ls = _IUser_DAL.getAllUser();
            for(int i=0;i<ls.Count;i++)
            {
                if (ls[i].Email == mail && ls[i].Password == password)                
                   return _Mapper.Map<UserTable, UserTableDTO>(ls[i]);
            }
            return null;
        }
        //מקבלת עצם להוספה ומוסיפה אותו מחזירה true אם הוסיף או false אם לא
        public bool addUser(UserTableDTO u)
        {
            try
            {
                _IUser_DAL.addUser(_Mapper.Map<UserTableDTO,UserTable>(u));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
