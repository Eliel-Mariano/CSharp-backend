

namespace TestBackendCSharp.Application.ViewModel
{
    public class ReportViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public Guid UserId { get; set; }

        public Guid TestId { get; set; }
        public string TestName { get; set; }
        public bool TestStatus { get; set; }
        public int TestDurationInSeconds { get; set; }
        public DateTime TestCreatedAt { get; set; }
        public DateTime TestUpdatedAt { get; set; }

        public Guid TransformatorId { get; set; }
        public string TransformatorName { get; set; }
        public int TransformatorInternalNumber { get; set; }
        public int TransformatorTensionClass { get; set; }
        public int TransformatorPotency { get; set; }
        public int TransformatorCurrent { get; set; }
        public DateTime TransformatorCreatedAt { get; set; }
        public DateTime TransformatorUpdatedAt { get; set; }
    }
}
