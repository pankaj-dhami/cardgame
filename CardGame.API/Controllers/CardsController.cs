using CardGame.Service.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CardGame.API.Controllers
{
    public class SortedCardController : BaseApiController
    {
        private readonly ICardDeckService _cardDeckService;
        public SortedCardController(ICardDeckService cardDeckService)
        {
            _cardDeckService = cardDeckService;
        }
        // GET: api/<CardsController>
        [HttpGet]
        public IActionResult Get(string randomStrings = "3C,JS,2D,PT,10H,KH,8S,4T,AC,4H,RT")
        {
                if (!string.IsNullOrEmpty(randomStrings) && randomStrings.Length > 0)
                {
                    var inputArray = randomStrings.Split(',');
                    return Ok( _cardDeckService.GetSortedCardDeck(inputArray));
                }
                else
                {
                    return BadRequest(new ProblemDetails { Title = "Input string is not valid" });
                }
        }

    }
}
