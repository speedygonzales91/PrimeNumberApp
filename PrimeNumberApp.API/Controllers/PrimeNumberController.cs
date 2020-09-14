using Microsoft.AspNetCore.Mvc;
using PrimeNumberApp.BLL.Interfaces.Managers;

namespace PrimeNumberApp.API.Controllers
{
    
    [Route("api/primeNumber")]
    [ApiController]
    public class PrimeNumberController : ControllerBase
    {
        private readonly IPrimeNumberMgr _primeNumberMgr;

        public PrimeNumberController(IPrimeNumberMgr primeNumberMgr)
        {
            _primeNumberMgr = primeNumberMgr;
        }

        [Route("isPrime/{number}")]
        [HttpGet]
        public ActionResult<bool> IsPrime(int number)
        { 
            return Ok(_primeNumberMgr.IsPrime(number));
        }

        [Route("nextPrime/{number}")]
        [HttpGet]
        public ActionResult<int> NextPrime(int number)
        {
            return Ok(_primeNumberMgr.NextPrimeAfterGivenNumber(number));
        }
    }
}
