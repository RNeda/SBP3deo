using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjekatSBP;
using ProjekatSBP.DTOs;
using System;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PomocnikController : ControllerBase
    {
        #region Pomocnik
        [HttpGet]
        [Route("PreuzmiPomocnike")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPomocnike()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSvePomocnike());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiPomocnikaID/{pomocnikID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPomocnik(int pomocnikID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiPomocnika(pomocnikID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiPomocnikeKoordinatora/{koordinatorID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPomocnici(int koordinatorID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSvePomocKoordinatora(koordinatorID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        [Route("DodajPomocnika")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddPomocnik([FromBody] PomocnikView pomocnik)
        {
            try
            {
                DataProvider.DodajPomocnika(pomocnik);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPomocnikaKoordinatoru/{koordinatorID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddPomocnikToKoordinator([FromBody] PomocnikView pomocnik, int koordinatorID)
        {
            try
            {
                DataProvider.DodajPomocnikaKoordinatoru(pomocnik, koordinatorID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPut]
        [Route("PromeniPomocnika")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ChangePomocnik([FromBody] PomocnikView pomocnik)
        {
            try
            {
                DataProvider.AzurirajPomocnika(pomocnik);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiPomocnika/{pomocnikID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DeletePomocnik([FromRoute(Name = "pomocnikID")] int id)
        {
            try
            {
                DataProvider.ObrisiPomocnika(id);
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