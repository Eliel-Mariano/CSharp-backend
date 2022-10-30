using TestCSharp.Business.Models;

namespace TestCSharp.Models
{
    public class Test : Entity
    {
        public string testName { get; set; }
        public bool testStatus { get; set; }
        public int testDurationInSeconds { get; set; }

        public Guid TransformatorId { get; set; }

    }
}
