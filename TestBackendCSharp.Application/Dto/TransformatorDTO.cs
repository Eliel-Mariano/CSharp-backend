namespace TestCSharp.ControllersDTO
{
    public class TransformatorDTO
    {
        public string transformatorName { get; set; }
        public int internalNumber { get; set; }
        public int tensionClass { get; set; }
        public int potency { get; set; }
        public int current { get; set; }

        public Guid UserId { get; set; }

    }
}
