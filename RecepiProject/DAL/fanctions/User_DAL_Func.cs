
using DAL.interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.fanctions
{
    public class User_DAL_Func: IUser_DAL
    {
        //משתנה מסוג המסד נתונים
        TamarTableContext _TamarTableContext;
        //בנאי
        public User_DAL_Func(TamarTableContext i)
        {
            _TamarTableContext = i;
        }
        //פונקצית שליפה
        List<UserTable> IUser_DAL.getAllUser()
        {
            return _TamarTableContext.UserTables.ToList();
        }
        //פונקצית הוספה
        public bool addUser(UserTable u)
        {
            try
            {
                _TamarTableContext.Add(u);
                _TamarTableContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //פונקצית מחיקה
        public bool dellUser(int id)
        {
            try
            {
                UserTable r = _TamarTableContext.UserTables.FirstOrDefault(g => g.Id == id);
                _TamarTableContext.UserTables.Remove(r);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
