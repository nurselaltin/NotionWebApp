using Entities.Abstract;

namespace Entities.Concrete
{
    public class Tag : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
