using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IEngrediensForRecepi_DAL
    {
         List<EngrediensTableForRecepi> getAllEngrediensForRecepi();
          bool addIEngrediensForRecepi(EngrediensTableForRecepi e);
        // bool dellIEngrediensForRecepi(int id);
    }
}
