﻿
namespace TestBackendCSharp.Application.ViewModel
{
    public class TransformatorViewModel
    {
        public Guid Id { get; set; }
        public string transformatorName { get; set; }
        public int internalNumber { get; set; }
        public int tensionClass { get; set; }
        public int potency { get; set; }
        public int current { get; set; }
    }
}
