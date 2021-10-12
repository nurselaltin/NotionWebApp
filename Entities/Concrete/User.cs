using Entities.Abstract;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; } //Enum olabilir

        public List<Template> Templates { get; set; }
    }
}
