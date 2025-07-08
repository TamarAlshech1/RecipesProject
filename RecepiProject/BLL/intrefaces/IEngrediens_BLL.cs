using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.intrefaces
{
    public interface IEngrediens_BLL
    {
        List<EngrediensTableDTO> getAllIEngrediens();
        int addIEngrediens(EngrediensTableDTO e); 
    }
}
