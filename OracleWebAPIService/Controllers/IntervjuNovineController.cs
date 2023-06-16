using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjekatSBP;
using ProjekatSBP.DTOs;
using System;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IntervjuNovineController : ControllerBase
    {
        #region IntervjuNovine
        [HttpGet]
        [Route("PreuzmiIntervjuNovine")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetIntervjueNovine()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveIntervjue());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajIntervjuNovine")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult AddIntervjuNovine([FromBody] IntervjuNovineView intervju)
        {
            try
            {
                DataProvider.DodajIntervjuNovine(intervju);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajIntervjuNovine")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ChangeIntervjuNovine([FromBody] IntervjuNovineView intervju)
        {
            try
            {
                DataProvider.AzurirajIntervju(intervju);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiIntervjuNovine/{intervjuID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DeleteIntervjuNovine([FromRoute(Name = "intervjuID")] int id)
        {
            try
            {
                DataProvider.ObrisiIntervju(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
            #endregion
        
    }


