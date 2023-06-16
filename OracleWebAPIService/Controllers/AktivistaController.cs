using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjekatSBP;
using ProjekatSBP.DTOs;
using System;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AktivistaController : ControllerBase
    {
        #region Aktivista
        [HttpGet]
        [Route("PreuzmiAktiviste")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAktiviste()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveAktiviste());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiAktivistuID/{aktivistaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAktivista(int aktivistaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiAktivistu(aktivistaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajAktivistu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddAktivista([FromBody]AktivistaView aktivista)
        {
            try
            {
                DataProvider.DodajAktivistu(aktivista);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniAktivistu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ChangeAktivista([FromBody] AktivistaView aktivista)
        {
            try
            {
                DataProvider.AzurirajAktivistu(aktivista);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PoveziAktivistuSaGlasackimMestom/{aktivistaID}/{glasackoMestoID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult PoveziAktivistuSaGM(int aktivistaID, int glasackoMestoID)
        {
            try
            {
                DataProvider.PoveziAktivistuSaGM(aktivistaID, glasackoMestoID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete]
        [Route("IzbrisiAktivistu/{aktivistaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DeleteAktivista([FromRoute(Name ="aktivistaID")]int id)
        {
            try
            {
                DataProvider.ObrisiAktivistu(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPrimedbu/{aktivistaID}/{primedba}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddPrimedba( int aktivistaID, [FromRoute(Name = "primedba")] string primedba)
        {
            try
            {
                DataProvider.DodajPrimedbu(aktivistaID, primedba);
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