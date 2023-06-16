using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjekatSBP;
using ProjekatSBP.DTOs;
using System;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AkcijaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiAkcije")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAkcije()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveAkcije());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiGosteMitinga/{IDmitinga}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGosteMitinga([FromRoute( Name ="IDmitinga")] int idm)
        {
            try
            {
                return new JsonResult(DataProvider.GostiNaMitingu(idm));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        [Route("DodajAkciju/{koordinatorID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddAkcija([FromBody] AkcijaView akcija, [FromRoute(Name = "koordinatorID")] int idkoord)
        {
            try
            {
                DataProvider.DodajKoordinatoraAkciji(akcija, idkoord);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniAkciju")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ChangeAkcija([FromBody] AkcijaView akcija)
        {
            try
            {
                DataProvider.AzurirajAkciju(akcija);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiAkciju/{akcijaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DeleteAkcija([FromRoute(Name = "akcijaID")] int id)
        {
            try
            {
                DataProvider.ObrisiAkciju(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
