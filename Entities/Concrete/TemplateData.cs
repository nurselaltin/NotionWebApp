using Entities.Abstract;
using System;

namespace Entities.Concrete
{
    public class TemplateData : IEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? EndedDate { get; set; }
        public string Comment { get; set; }
        public string Tags { get; set; }
        public int TemplateID { get; set; }
    }
}
