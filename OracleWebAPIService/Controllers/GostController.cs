using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjekatSBP;
using ProjekatSBP.DTOs;
using System;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GostController :ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiGosta")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGosti()
        {
            try
            {

                return new JsonResult(DataProvider.VratiSveGoste());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiMitingeGosta/{IDgosta}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetMitingeGosta([FromRoute(Name = "IDgosta")] int idg)
        {
            try
            {
                return new JsonResult(DataProvider.MitingGosti(idg));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajGosta/{akcijaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddGost([FromBody] ProjekatSBP.Entiteti.Gost gost, [FromRoute(Name ="akcijaID")] int id)
        {
            try
            {
                DataProvider.DodajGosta(gost, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        
        [HttpPut]
        [Route("PromeniGosta")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeGost([FromBody] GostView gost)
        {
            try
            {
                DataProvider.AzurirajGosta(gost);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiGosta/{gostID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DeleteGost([FromRoute(Name = "gostID")] int id)
        {
            try
            {
                DataProvider.ObrisiGosta(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
