using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.intrefaces
{
    public interface IEngrediensForRecepi_BLL
    {
           List<EngrediensTableForRecepiDTO> Get_by_idRecepi(int id);
           bool addEngrediensToRecepi(int idRecepi, List<EngrediensTableForRecepiDTO> list);
    }
}
