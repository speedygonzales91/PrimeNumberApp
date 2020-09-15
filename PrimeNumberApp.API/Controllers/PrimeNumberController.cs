using Microsoft.AspNetCore.Mvc;
using PrimeNumberApp.BLL.Interfaces.Managers;

namespace PrimeNumberApp.API.Controllers
{
    
    /// <summary>
    /// Controller for prime number calculations
    /// </summary>
    [Route("api/primeNumber")]
    [ApiController]
    public class PrimeNumberController : ControllerBase
    {
        private readonly IPrimeNumberManager _primeNumberManager;

        /// <summary>
        /// Creates a new PrimeNumberController instance
        /// </summary>
        /// <param name="primeNumberManager"></param>
        public PrimeNumberController(IPrimeNumberManager primeNumberManager)
        {
            _primeNumberManager = primeNumberManager;
        }

        /// <summary>
        /// Determines whether a number is prime or not
        /// </summary>
        /// <param name="number">Number to check</param>
        /// <returns>True if number is prime</returns>
        [Route("isPrime/{number}")]
        [HttpGet]
        public ActionResult<bool> IsPrime(int number)
        { 
            return Ok(_primeNumberManager.IsPrime(number));
        }

        /// <summary>
        /// Calculates the next prime after the given parameter
        /// </summary>
        /// <param name="number">Number to start from</param>
        /// <returns>The next prime after a given number</returns>
        [Route("nextPrime/{number}")]
        [HttpGet]
        public ActionResult<int> NextPrime(int number)
        {
            return Ok(_primeNumberManager.NextPrimeAfterGivenNumber(number));
        }


    }
}
