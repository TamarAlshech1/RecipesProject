using DAL.interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.fanctions
{
    public class Engrediens_DAL_Func: IEngrediens_DAL
    {
        //משתנה מסוג המסד נתונים
        TamarTableContext _TamarTableContext;
        //בנאי
        public Engrediens_DAL_Func(TamarTableContext i)
        {
            _TamarTableContext = i;
        } 
        //פונקצית שליפה
        List<EngrediensTable> IEngrediens_DAL.getAllIEngrediens()
        {
            return _TamarTableContext.EngrediensTables.ToList();
        }
        //פונקצית הוספה
        public int addEngrediens(EngrediensTable e)
        {
            try
            {
                _TamarTableContext.EngrediensTables.Add(e);
                _TamarTableContext.SaveChanges();
                return e.IdEngrediens;
            }
            catch
            {
                return -1;   
            }
        }
        //פונקצית מחיקה
        public bool dellEngrediens(int id)
        {
            try
            {
                EngrediensTable e = _TamarTableContext.EngrediensTables.FirstOrDefault(g => g.IdEngrediens == id);
                _TamarTableContext.EngrediensTables.Remove(e);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
