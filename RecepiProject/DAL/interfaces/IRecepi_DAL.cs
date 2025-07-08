
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IRecepi_DAL
    {
        List<RecepiTablebad> getAllRecepis();
        bool addRecepis(RecepiTablebad r);
       // bool dellRecepis(int id);   
    }
}
