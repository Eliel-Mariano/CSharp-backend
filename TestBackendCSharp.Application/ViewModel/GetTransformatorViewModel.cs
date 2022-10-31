

namespace TestBackendCSharp.Application.ViewModel
{
    public class GetTransformatorViewModel
    {
        public Guid Id { get; set; }
        public string transformatorName { get; set; }
        public int internalNumber { get; set; }
        public int tensionClass { get; set; }
        public int potency { get; set; }
        public int current { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UserId { get; set; }
    }
}
