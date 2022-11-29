using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern.Application.Wrappers
{
    public class BaseResponse
    {
        public Guid id { get; set; }
        public bool  Success { get; set; }
        public string message { get; set; }

    }
}
