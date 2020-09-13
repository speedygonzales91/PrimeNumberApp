using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberApp.BLL.Interfaces.Managers
{
    public interface IPrimeNumberMgr
    {
        bool IsPrime(int number);
        int NextPrimeAfterGivenNumber(int number);
    }
}
