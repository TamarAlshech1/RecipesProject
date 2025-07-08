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
    public class Recepi_DAL_Func : IRecepi_DAL
    {
        //משתנה מסוג המסד נתונים
        TamarTableContext _TamarTableContext;
        //בנאי
        public Recepi_DAL_Func(TamarTableContext i)
        {
            _TamarTableContext = i;
        }
        //פונקצית שליפה
       // List<RecepiTablebad> IRecepi_DAL.getAllRecepis()
        List<RecepiTablebad> IRecepi_DAL.getAllRecepis()
        {
            return _TamarTableContext.RecepiTablebads.Include(x=>x.IdUserNavigation).ToList();
        }
        //פונקצית הוספה
        public bool addRecepis(RecepiTablebad r)
        {
            try
            {
                _TamarTableContext.RecepiTablebads.Add(r);
                _TamarTableContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    
  
        //פונקצית מחיקה
        //public bool dellRecepis(int id)
        //{
        //    try
        //    {
        //        RecepiTablebad r = _TamarTableContext.RecepiTablebads.FirstOrDefault(g => g.Id==id);
        //        _TamarTableContext.RecepiTablebads.Remove(r);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

    }
}
