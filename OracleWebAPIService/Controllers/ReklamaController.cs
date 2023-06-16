using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjekatSBP;
using ProjekatSBP.DTOs;
using System;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReklamaController : ControllerBase
    {
        
        [HttpGet]
        [Route("PreuzmiReklame")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetReklame()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveReklame());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajReklamu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddReklama([FromBody] ReklamaView reklama)
        {
            try
            {
                DataProvider.DodajReklamu(reklama);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniReklamu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ChangeReklama([FromBody] ReklamaView reklama)
        {
            try
            {
                DataProvider.AzurirajReklamu(reklama);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiReklamuu/{reklamaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DeleteReklama([FromRoute(Name = "reklamaID")] int id)
        {
            try
            {
                DataProvider.ObrisiReklamu(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
