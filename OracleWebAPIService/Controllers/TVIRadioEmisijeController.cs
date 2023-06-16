using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjekatSBP;
using ProjekatSBP.DTOs;
using System;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TVIRadioEmisijeController : ControllerBase
    {
        #region TVIRadioEmisije
        [HttpGet]
        [Route("PreuzmiTVIRadioEmisije")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTVIRadioEmisije()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveEmisije());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajTVIRadioEmisiju")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddTVIRadioEmisiju([FromBody] TVIRadioEmisijeView emisija)
        {
            try
            {
                DataProvider.DodajEmisiju(emisija);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniTVIRadioEmisiju")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ChangeTVIRadioEmisiju([FromBody] TVIRadioEmisijeView emisija)
        {
            try
            {
                DataProvider.AzurirajEmisiju(emisija);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiTVIRadioEmisiju/{emisijaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DeleteTVIRadioEmisiju([FromRoute(Name = "emisijaID")] int id)
        {
            try
            {
                DataProvider.ObrisiEmisiju(id);
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