using Microsoft.AspNetCore.Mvc;
using PrimeNumberApp.BLL.Interfaces.Managers;

namespace PrimeNumberApp.API.Controllers
{
    
    [Route("api/primeNumber")]
    [ApiController]
    public class PrimeNumberController : ControllerBase
    {
        private readonly IPrimeNumberManager _primeNumberManager;

        public PrimeNumberController(IPrimeNumberManager primeNumberManager)
        {
            _primeNumberManager = primeNumberManager;
        }

        [Route("isPrime/{number}")]
        [HttpGet]
        public ActionResult<bool> IsPrime(int number)
        { 
            return Ok(_primeNumberManager.IsPrime(number));
        }

        [Route("nextPrime/{number}")]
        [HttpGet]
        public ActionResult<int> NextPrime(int number)
        {
            return Ok(_primeNumberManager.NextPrimeAfterGivenNumber(number));
        }
    }
}
