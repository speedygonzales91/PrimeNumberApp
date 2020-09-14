namespace PrimeNumberApp.BLL.Interfaces.Managers
{
    public interface IPrimeNumberManager
    {
        bool IsPrime(int number);
        int NextPrimeAfterGivenNumber(int number);
    }
}
