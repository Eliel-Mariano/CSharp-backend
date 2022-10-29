namespace TestBackendCSharp.Application.ViewModel
{
    public class GetTestViewModel
    {
        public Guid Id { get; set; }
        public string testName { get; set; }
        public bool testStatus { get; set; }
        public int testDurationInSeconds { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
