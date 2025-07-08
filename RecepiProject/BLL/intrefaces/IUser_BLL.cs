using DTO.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.intrefaces
{
    public interface IUser_BLL
    {
        List<UserTableDTO> getAllUser();
        UserTableDTO GetUserByMailAndPassword(string mail, int Password);
        bool addUser (UserTableDTO u);   
    }
}
