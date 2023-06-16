using Microsoft.AspNetCore.Mvc;
using ProjekatSBP.DTOs;
using ProjekatSBP;
using System;
using ProjekatSBP.Entiteti;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpisakPitanjaController : ControllerBase
    {
        #region SpisakPitanja
        [HttpGet]
        [Route("PreuzmiPitanjaDuela")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPitanjaDuela()
        {
            try
            {
                return new JsonResult(DataProvider.VratiPitanjaDuela());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPitanjeDuelu/{pitanje}/{tvDuelID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddPitanjeDuelu([FromRoute(Name = "pitanje")] string pitanje, [FromRoute(Name = "tvDuelID")]int duel)
        {
            try
            {
                SpisakPitanja o = new SpisakPitanja();
                o.Id.Pitanje = pitanje;
                DataProvider.SacuvajPitanje(o,duel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiPitanjeDuela/{pitanje}/{tvDuelID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DeletePitanjeDuela([FromRoute(Name = "pitanje")] string pitanje, [FromRoute(Name = "tvDuelID")] int duel)
        {
           
            try
            {
                SpisakPitanja pit = new SpisakPitanja();
                pit.Id.Pitanje = pitanje;
                DataProvider.ObrisiPitanje(pit,duel);
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
