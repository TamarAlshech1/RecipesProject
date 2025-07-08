using BLL.intrefaces;
using DTO.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecepiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecepiBLLController : ControllerBase
    {
        IRecepi_BLL _IRecepi_BLL;
        //בנאי
        public RecepiBLLController(IRecepi_BLL i)
        {
            _IRecepi_BLL = i;
        }
        //פונקצית שליפה
        [HttpGet("mygetallrecepi")]
        public ActionResult<List<RecepiTableDTO>> mygetallrecepi()
        {
            return Ok(_IRecepi_BLL.getAllRecepis());
        }

        [HttpPost("myaddRecepis/{myRecepi}")]
        public ActionResult<int> addRecepis(RecepiTableDTO r)
        {
            return Ok(_IRecepi_BLL.addRecepis(r));
        }

        // public List<RecepiTableDTO> userCode_by_Get(int id)
        [HttpGet("myaddRecepis/{myId}")]
        public ActionResult<List<RecepiTableDTO>> userCode_by_Get(int id)
        {
            return Ok(_IRecepi_BLL.userCode_by_Get(id));
        }

    }
}
