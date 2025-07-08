using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IUser_DAL
    {
        List<UserTable> getAllUser();
        bool addUser(UserTable u);   
        bool dellUser(int id);
    }
}
