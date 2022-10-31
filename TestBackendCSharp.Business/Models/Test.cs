using TestCSharp.Business.Models;

namespace TestCSharp.Models
{
    public class Test : Entity
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public int DurationInSeconds { get; set; }

        public Guid TransformatorId { get; set; }

    }
}
