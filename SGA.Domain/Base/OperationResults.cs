using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Domain.Base
{
    internal class OperationResults
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
