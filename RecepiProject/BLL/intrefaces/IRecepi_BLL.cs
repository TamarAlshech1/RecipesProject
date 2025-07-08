using DAL.models;
using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.intrefaces
{
    public interface IRecepi_BLL
    {
        List<RecepiTableDTO> getAllRecepis();
        int addRecepis(RecepiTableDTO id);
         List<RecepiTableDTO> userCode_by_Get(int id);
    }
}
