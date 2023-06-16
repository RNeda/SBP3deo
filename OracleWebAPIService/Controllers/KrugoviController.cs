using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjekatSBP;
using ProjekatSBP.DTOs;
using System;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KrugoviController : ControllerBase
    {
        #region Krugovi
        [HttpGet]
        [Route("PreuzmiKrugove")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetKrugove()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveKrugove());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiKrugID/{krugID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetKrug(int krugID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiKrug(krugID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajKrug")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddKrug([FromBody]KrugoviView krug)
        {
            try
            {
                DataProvider.DodajKrug(krug);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniKrug")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ChangeKrug([FromBody] KrugoviView krug)
        {
            try
            {
                DataProvider.AzurirajKrug(krug);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiKrug/{krugID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DeleteKrug([FromRoute(Name ="krugID")]int id)
        {
            try
            {
                DataProvider.ObrisiKrug(id);
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