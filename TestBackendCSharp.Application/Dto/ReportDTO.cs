using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBackendCSharp.Application.Dto
{
    public class ReportDTO
    {
        public string Name { get; set; }
        public bool Status { get; set; }

        public Guid TestId { get; set; }
    }
}
