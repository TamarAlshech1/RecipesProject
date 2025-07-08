using BLL.intrefaces;
using DTO.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecepiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EngrediensBLLController : ControllerBase
    {
        IEngrediens_BLL _IEngrediens_BLL;
        //בנאי
        public EngrediensBLLController(IEngrediens_BLL i)
        {
            _IEngrediens_BLL = i;
        }
        //פונקצית שליפה
        [HttpGet("myGetAllEngrediens")]
        public ActionResult<List<EngrediensTableDTO>> getAllIEngrediens()
        {
            return Ok(_IEngrediens_BLL.getAllIEngrediens());
        }
        //פונקציה שמקבלת רכיב ומוסיפה אותו ומחזירה את קוד הרכיב שנוסף
        [HttpPost("myallEngrediens/{eDTO}")]
        public ActionResult<int> myallEngrediens(EngrediensTableDTO eDTO)
        {
            return Ok(_IEngrediens_BLL.addIEngrediens(eDTO));
        }
    }
}
