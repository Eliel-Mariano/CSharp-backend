using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCSharp.Business.Models;

namespace TestBackendCSharp.Business.Models
{
    public class Report : Entity
    {
        public string Name { get; set; }
        public bool Status { get; set; }

        public Guid TestId { get; set; }
        public Guid TransformatorId { get; set; }

    }
}
