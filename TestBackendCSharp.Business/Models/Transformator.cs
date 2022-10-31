

namespace TestCSharp.Business.Models
{
    public class Transformator : Entity
    {
        public string Name { get; set; }
        public int InternalNumber { get; set; }
        public int TensionClass { get; set; }
        public int Potency { get; set; }
        public int Current { get; set; }

        public Guid UserId { get; set; }
    }
}
