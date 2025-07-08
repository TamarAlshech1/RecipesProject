using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.fanctions
{
    public class EngrediensForRecepi_DAL_Func: IEngrediensForRecepi_DAL
    {
        //משתנה מסוג המסד נתונים
        TamarTableContext _TamarTableContext;
        //בנאי
        public EngrediensForRecepi_DAL_Func(TamarTableContext i)
        {
            _TamarTableContext = i;
        }

        //פונקצית שליפה
        public List<EngrediensTableForRecepi> getAllEngrediensForRecepi()
        {
            return _TamarTableContext.EngrediensTableForRecepis.Include(k => k.IdEngrediensNavigation).ToList();
        }
        //פונקצית הוספה
        public bool addIEngrediensForRecepi(EngrediensTableForRecepi e)
        {
            try
            {
                _TamarTableContext.EngrediensTableForRecepis.Add(e);
                _TamarTableContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

       


        //פונקצית מחיקה
        //public bool dellIEngrediensForRecepi(int id)
        //{
        //    try
        //    {
        //        EngrediensTableForRecepi e = _TamarTableContext.EngrediensTableForRecepis.FirstOrDefault(g => g.IdEngrediens == id);
        //        _TamarTableContext.EngrediensTableForRecepis.Remove(e);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}


    }
}
