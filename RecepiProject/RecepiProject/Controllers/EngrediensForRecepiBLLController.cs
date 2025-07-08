using BLL.intrefaces;
using DTO.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecepiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EngrediensForRecepiBLLController : ControllerBase
    {
        IEngrediensForRecepi_BLL _IEngrediensForRecepi_BLL;
        //בנאי
        public EngrediensForRecepiBLLController(IEngrediensForRecepi_BLL i)
        {
            _IEngrediensForRecepi_BLL = i;
        }
        //פונקציה שמקבלת קוד מתכון ושולפת את כל הרכיבים שלו
        [HttpGet("getByIdRecepi/{id}")]
        public ActionResult<List<EngrediensTableForRecepiDTO>> Get_by_idRecly(int id)
        {
            return Ok(_IEngrediensForRecepi_BLL.Get_by_idRecepi(id));
        }

        [HttpPost("myAddEngrediens/{id}")]
         public ActionResult<bool> myAddEngrediens(int id)
         {
            return Ok(_IEngrediensForRecepi_BLL.Get_by_idRecepi(id));
         }

        //פונקצית שליפה
        //[HttpGet("myAllEngrediensForRecepi")]
        //public ActionResult<List<EngrediensTableForRecepiDTO>> mygetAllEngrediensForRecepi()
        //{
        //    return _IEngrediensForRecepi_BLL.getAllEngrediensForRecepi();
        //}

    }
}
