using Entities.Abstract;

namespace DataAccess.Concrete
{
    public class DatabaseRepositoryBases<T> where T : class , IEntity ,new()
    {
    }
}
