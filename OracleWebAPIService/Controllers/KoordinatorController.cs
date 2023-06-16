using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjekatSBP;
using ProjekatSBP.DTOs;
using System;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KoordinatorController : ControllerBase
    {
        #region Koordinator
        [HttpGet]
        [Route("PreuzmiKoordinatore")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetKoordinatore()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveKoordinator());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiKoordinatoraID/{koordinatorID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetKoordinator(int koordinatorID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiKoordinatora(koordinatorID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajKoordinatora")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddKoordinator([FromBody]KoordinatorView koordinator)
        {
            try
            {
                DataProvider.DodajKoordinatora(koordinator);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniKoordinatora")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ChangeKoordinator([FromBody] KoordinatorView koordinator)
        {
            try
            {
                DataProvider.AzurirajKoordinator(koordinator);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiKoordinatora/{koordinatorID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DeleteKoordinator([FromRoute(Name ="koordinatorID")]int id)
        {
            try
            {
                DataProvider.ObrisiKoordinatora(id);
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