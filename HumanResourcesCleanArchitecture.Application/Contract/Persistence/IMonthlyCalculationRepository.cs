namespace HumanResourcesCleanArchitecture.Application;

public interface ICalculatio<T> where T : class
{
   Task<List<T>> Calculation();
}

