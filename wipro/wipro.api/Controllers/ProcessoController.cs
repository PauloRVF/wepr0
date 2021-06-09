using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wipro.core.DTO;
using wipro.core.Interface.Service;

namespace wipro.api.Controllers
{
    [Route("")]
    public class ProcessoController : Controller
    {
        private readonly IProcessoService _service;

        public ProcessoController(IProcessoService service)
        {
            _service = service;
        }

        [HttpGet("GetItemFila")]
        public ActionResult<ProcessoDTO> GetItemFila()
        {
            try
            {
                var proc = _service.GetLastProcesso();

                return Ok(proc);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddItemFila")]
        public IActionResult AddItemFila([FromBody] IEnumerable<ProcessoDTO> processos)
        {
            try
            {
                return Ok(_service.CreateAll(processos));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
