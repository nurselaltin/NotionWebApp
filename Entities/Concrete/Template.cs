using Entities.Abstract;

namespace Entities.Concrete
{
    public class Template : IEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Type { get; set; } //Enum olabilir

        //User
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
