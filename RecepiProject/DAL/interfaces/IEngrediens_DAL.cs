using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IEngrediens_DAL
    {
        List<EngrediensTable> getAllIEngrediens();
        int addEngrediens(EngrediensTable e);
        bool dellEngrediens(int id);
    }
}
