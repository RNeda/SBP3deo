using Microsoft.AspNetCore.Mvc;
using ProjekatSBP;
using ProjekatSBP.DTOs;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TVDueli:ControllerBase
    {
        #region TVDueli
        [HttpGet]
        [Route("PreuzmiTVDuele")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTVDuele()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveTVDuele());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajTVDuel")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddTVDuel([FromBody] TVDueliView duel)
        {
            try
            {
                DataProvider.DodajDuel(duel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniTVDuel")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ChangeTVDuel([FromBody] TVDueliView duel)
        {
            try
            {
                DataProvider.AzurirajDuel(duel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiTVDuel/{tvDuelID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DeleteTVDuel([FromRoute(Name = "tvDuelID")] int id)
        {
            try
            {
                DataProvider.ObrisiDuel(id);
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
    

