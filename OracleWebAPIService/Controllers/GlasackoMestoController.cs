using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjekatSBP;
using ProjekatSBP.DTOs;
using System;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GlasackoMestoController : ControllerBase
    {
        #region GlasackoMesto
        [HttpGet]
        [Route("PreuzmiGlasackaMesta")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGlasackaMesta()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSvaGlasackaMesta());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiGlasackoMestoID/{glasackoMestoID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGlasackoMesto(int glasackoMestoID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiGlasackoMesto(glasackoMestoID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajGlasackoMesto")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddGlasackoMesto([FromBody]GlasackoMestoView glasackoMesto)
        {
            try
            {
                DataProvider.DodajGlasackoMesto(glasackoMesto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniGlasackoMesto")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ChangeGlasackoMesto([FromBody] GlasackoMestoView glasackoMesto)
        {
            try
            {
                DataProvider.AzurirajGlasackoMesto(glasackoMesto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiGlasackoMesto/{glasackoMestoID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DeleteGlasackoMesto([FromRoute(Name ="glasackoMestoID")]int id)
        {
            try
            {
                DataProvider.ObrisiGlasackoMesto(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}