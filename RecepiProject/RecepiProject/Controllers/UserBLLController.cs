using BLL.intrefaces;
using DTO.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecepiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBLLController : ControllerBase
    {
        IUser_BLL _IUser_BLL;
        //בנאי
        public UserBLLController(IUser_BLL i)
        {
            _IUser_BLL = i;
        }
        //פונקצית שליפה
        [HttpGet("myGetAllUsers")]
        public ActionResult<List<UserTableDTO>> myGetAllUsers()
        {
            return _IUser_BLL.getAllUser();
        }

        [HttpGet("myGetUserByMailAndPassword/{mail,password}")]
        public ActionResult<UserTableDTO> myGetUserByMailAndPassword(string mail, int password)
        {
            return Ok(_IUser_BLL.GetUserByMailAndPassword( mail, password));
        }

        [HttpPost("myAddUser")]
         public ActionResult<bool> myAddUser(UserTableDTO u)
         {
            return Ok(_IUser_BLL.addUser(u));
         }
    }
}
